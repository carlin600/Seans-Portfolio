using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsPharmacy
{
    public partial class frmSales : Form
    {

        private SqlDataAdapter daSupplier, daSales, daSaleDetails, daSaleItemDetails,daSalesByType, daPaymentType,daStock, daStockType;
        private SqlCommandBuilder cmdBSupplier, cmdBSales, cmdBSaleDetails, cmdBNewSale, cmbPaymentType, cmdBDisByPaymentType;
        private SqlCommand cmdEditSaleItems;
        private String connStr, sqlSales, sqlSalesByType, sqlStock, sqlSaleDetails, sqlSaleItemDetails;
        private DataTable dtSuppName = new DataTable(), dtPaymentType = new DataTable(), dtStockType = new DataTable();
        private DataSet dsLloydsPharmacy = new DataSet();
        private DataRow drSupplier, drSales, drStock;
        private SqlConnection conn;

        int selectedTab = 0;
        bool saleSelected = false, firstLoad = true;
        string saleIDSelected = "";
        string newLine = Environment.NewLine;

        private void frmSales_Load(object sender, EventArgs e)
        {
           // connStr = @"Data source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = True";
            conn = new SqlConnection(connStr);

            //All Sales for DGV
            sqlSales = @"Select * FROM Sales";
            daSales = new SqlDataAdapter(sqlSales, conn);
            cmdBSales = new SqlCommandBuilder(daSales);
            daSales.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Sales");
            daSales.Fill(dsLloydsPharmacy, "Sales");
            dgvSales.DataSource = dsLloydsPharmacy.Tables["Sales"];

            //Details for the selected Sale
            sqlSaleDetails = @"Select * FROM SaleDetails";
            daSaleDetails = new SqlDataAdapter(sqlSaleDetails, conn);
            cmdBSaleDetails = new SqlCommandBuilder(daSales);
            daSaleDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SaleDetails");
            daSaleDetails.Fill(dsLloydsPharmacy, "SaleDetails");


            sqlStock = @"Select * FROM Stock";
            daStock = new SqlDataAdapter(sqlStock, conn);
            daStock.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daStock.Fill(dsLloydsPharmacy, "Stock");
            lstSaleStock.DataSource = dsLloydsPharmacy.Tables["Stock"];
            lstSaleStock.DisplayMember = "StockDesc";
            lstSaleStock.ValueMember = "StockID";
            lstEditStockAvailable.DataSource = dsLloydsPharmacy.Tables["Stock"];
            lstEditStockAvailable.DisplayMember = "StockDesc";
            lstEditStockAvailable.ValueMember = "StockID";
            


            //Combo Boxes
            daPaymentType = new SqlDataAdapter("Select * FROM PaymentType", connStr);
            daPaymentType.Fill(dtPaymentType);
            cmbPaymentMethod.DataSource = dtPaymentType;
            cmbPaymentMethod.DisplayMember = "PaymentTypeDesc";
            cmbPaymentMethod.ValueMember = "PaymentTypeId";

            daStockType = new SqlDataAdapter("Select StockTypeID, StockTypeDesc FROM StockType", connStr);
            daStockType.Fill(dtStockType);
            cmbDisStockType.DataSource = dtStockType;
            cmbDisStockType.DisplayMember = "StockTypeDesc";
            cmbDisStockType.ValueMember = "StockTypeID";

            firstLoad = false;
        }
        public frmSales()
        {
            InitializeComponent();
        }
        private void frmSales_Shown(object sender, EventArgs e)
        {
            tabSales.TabPages[0].CausesValidation = true;
            tabSales.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabSales.TabPages[2].CausesValidation = true;
            tabSales.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

        }
        private void tabSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabSales.SelectedIndex;

            tabSales.TabPages[tabSales.SelectedIndex].Focus();

            tabSales.TabPages[tabSales.SelectedIndex].CausesValidation = true;

            switch (tabSales.SelectedIndex)
            {
                case 0://display
                    {
                        dsLloydsPharmacy.Tables["Sales"].Clear();
                        daSales.Fill(dsLloydsPharmacy, "Sales");
                        break;

                    }

                case 1://add
                    {
                        int noRows = dsLloydsPharmacy.Tables["Sales"].Rows.Count;
                        if (noRows == 0)
                        {
                            txtInfoSaleID.Text = "S101";
                        }
                        else
                        {
                            getSaleNum(noRows);
                            txtPaymentDate.Text = DateTime.Today.ToString();
                            txtInfoSaleDate.Text = DateTime.Today.ToString();
                            txtInfoSalePaymentType.Text = cmbPaymentMethod.Text.ToString();


                        }
                         clearAddSale();
                        break;
                    }

                case 2://edit
                    {
                        //disableEdit();
                        if (saleIDSelected == "")
                        {
                            MessageBox.Show("Please select a Sale to Edit!", "Edit Sale");
                            tabSales.SelectedIndex = 0;
                            break;

                        }
                        else
                        {
                            drSales = dsLloydsPharmacy.Tables["Sales"].Rows.Find(dgvSales.SelectedRows[0].Cells[0].Value);
                            txtInfoSaleID.Text = drSales["SaleID"].ToString();
                            txtInfoSaleDate.Text = drSales["SaleDate"].ToString();
                            txtInfoSalePaymentType.Text = drSales["PaymentTypeID"].ToString();
                    
                            break;
                        }

                    }

                case 3://Delete
                    {

                        break;
                    }

                case 4://reports
                    {
                        //crystal etc
                        break;
                    }

            }
        }




        //Display
        private void dgvSales_Click(object sender, EventArgs e)
        {
            lvSaleDetails.Items.Clear();


            sqlSaleItemDetails = @"SELECT sd.SaleID, sd.StockID, sd.QTYSold, s.StockDesc
                                FROM SaleDetails sd
                                JOIN Stock s ON sd.StockID = s.StockID
                                WHERE sd.SaleID = '" + dgvSales.SelectedRows[0].Cells[0].Value.ToString() + "'" +
                                   "ORDER BY s.StockDesc ASC";

            daSaleItemDetails = new SqlDataAdapter(sqlSaleItemDetails, conn);
            daSaleItemDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SaleItemDetails");
            daSaleItemDetails.Fill(dsLloydsPharmacy, "SaleItemDetails");

            foreach (DataRow dr in dsLloydsPharmacy.Tables["SaleItemDetails"].Rows)
            {
                ListViewItem item = new ListViewItem(dr["SaleID"].ToString());
                item.SubItems.Add(dr["StockID"].ToString());
                item.SubItems.Add(dr["StockDesc"].ToString());
                item.SubItems.Add(dr["QTYSold"].ToString());
                lvSaleDetails.Items.Add(item);
            }
            dsLloydsPharmacy.Tables["SaleItemDetails"].Clear();
        }
        //Buttons
        private void btnDisAddSale_Click(object sender, EventArgs e)
        {
            tabSales.SelectedIndex = 1;
        }
        private void btnDisEditSale_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an Order to Edit!", "Edit Order");
                tabSales.SelectedIndex = 0;

            }

            else 
            {
                tabSales.SelectedIndex = 2;

                //Supplier Order Details
                drSales = dsLloydsPharmacy.Tables["Sales"].Rows.Find(dgvSales.SelectedRows[0].Cells[0].Value);
                txtEditInfoSaleID.Text = drSales["SaleID"].ToString();
                txtEditInfoSaleDate.Text = drSales["SaleDate"].ToString();
                txtEditInfoSalePaymentType.Text = drSales["PaymentTypeID"].ToString();
                
;

                sqlSaleDetails = @"SELECT sal.SaleID, sal.StockID, sal.QTYSold, s.StockDesc
                                  FROM SaleDetails sal
                                  JOIN Stock s ON sal.StockID = s.StockID
                                  WHERE SaleID LIKE '" + txtEditInfoSaleID.Text + "'" +
                                                    "ORDER BY StockID ASC";
                daSaleDetails = new SqlDataAdapter(sqlSaleDetails, conn);
                daSaleDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SaleItems");
                daSaleDetails.Fill(dsLloydsPharmacy, "SaleItems");

                foreach (DataRow dr in dsLloydsPharmacy.Tables["SaleItems"].Rows)
                {
                    ListViewItem item = new ListViewItem(dr["StockID"].ToString());
                    item.SubItems.Add(dr["StockDesc"].ToString());
                    item.SubItems.Add(dr["QTYSold"].ToString());
                    lvEditSaleItems.Items.Add(item);
                }

                dsLloydsPharmacy.Tables["SaleItems"].Clear();
            }
        }
        private void btnDisDelSale_Click(object sender, EventArgs e)
        {
            tabSales.SelectedIndex = 0;

        }
        private void btnOrderDisExit_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }


        //Add
        private void cmbDisStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                dsLloydsPharmacy.Tables["Stock"].Clear();
                sqlStock = @"Select * FROM Stock WHERE StockTypeID = '" + cmbDisStockType.SelectedValue.ToString() + "'";
                daStock = new SqlDataAdapter(sqlStock, conn);
                daStock.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
                daStock.Fill(dsLloydsPharmacy, "Stock");
            }

        }
        private void lstSaleStock_Click(object sender, EventArgs e)
        {
            drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(lstSaleStock.SelectedValue.ToString());
            txtInfoStockID.Text = drStock["StockID"].ToString();
            txtInfoStockDesc.Text = drStock["StockDesc"].ToString();
            txtInfoStockTypeID.Text = drStock["StockTypeID"].ToString();
            txtInfoQTYInStock.Text = drStock["QTYInStock"].ToString();
            txtInfoStockPrice.Text = drStock["StockPrice"].ToString();

        }
        private void btnViewAllStockType_Click(object sender, EventArgs e)
        {
            sqlStock = @"Select * FROM Stock";
            daStock.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daStock.Fill(dsLloydsPharmacy, "Stock");
        }
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exits = false;

            if (lstSaleStock.SelectedIndex == -1)
                MessageBox.Show("Please Select an Item!", "Stock");
            else if (cmbAddItemQTY.Text == "")
                MessageBox.Show("Please Enter Quantity!", "Quantity");
            else
            {
                foreach (ListViewItem item in lvSaleBasket.Items)
                {
                    if (item.SubItems[0].Text == lstSaleStock.SelectedValue.ToString())
                    {
                        MessageBox.Show("You have already added this to your basket!", "Basket");
                        exits = true;

                        break;
                    }
                }

                if (!exits)
                {

                    if (ok)
                    {

                        ListViewItem item = new ListViewItem(lstSaleStock.SelectedValue.ToString());
                        item.SubItems.Add(lstSaleStock.Text);
                        item.SubItems.Add(cmbAddItemQTY.Text);
                        lvSaleBasket.Items.Add(item);

                    }
                    
                }
            }
        }
        private void btnRemoveFromBasket_Click(object sender, EventArgs e)
        {
            if (lvSaleBasket.SelectedItems.Count != 0)
            {
                var item = lvSaleBasket.SelectedItems[0];
                lvSaleBasket.Items.Remove(item);
            }
        }
        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Sale No: " + txtEditInfoSaleID + "?", "Cancel Order", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                clearAddSale();
                tabSales.SelectedIndex = 0;
            }
        }
        private void btnSubmitSale_Click(object sender, EventArgs e)
        {

            DataRow drSales;
            string SaleID;

            int noRows = dsLloydsPharmacy.Tables["SaleDetails"].Rows.Count;
            //not sure if this is correct -- mainly the suppordernum to string
            drSales = dsLloydsPharmacy.Tables["SaleDetails"].Rows[noRows - 1];
            SaleID = txtInfoSaleID.Text.ToString();

            if (lstSaleStock.SelectedIndex == -1)
                MessageBox.Show("Please Select a Supplier!", "Supplier");
            else if (lstSaleStock.SelectedIndex == -1)
                MessageBox.Show("Please Select a Stock Item!", "Stock");
            else if (cmbAddItemQTY.Text == "")
                MessageBox.Show("Please Enter Quantity!", "Quantity");
            else if (lvSaleBasket.Items.Count == 0)
                MessageBox.Show("Please Add an Item to your Basket!", "Basket");
            else if (cmbPaymentMethod.SelectedIndex == -1)
                MessageBox.Show("Please Selct Payment Method!", "Payment!");
            else
            {
                DateTime delivery = DateTime.Today;
                delivery = delivery.AddDays(5);

                drSales = dsLloydsPharmacy.Tables["Sales"].NewRow();
                drSales["SaleID"] = SaleID;
                drSales["SaleDate"] = DateTime.Today;
                drSales["PaymentTypeID"] = cmbPaymentMethod.SelectedValue.ToString();
            


                //adds to the database
                dsLloydsPharmacy.Tables["Sales"].Rows.Add(drSales);
                cmdBSales.GetInsertCommand();
                daSales.Update(dsLloydsPharmacy, "Sales");

                foreach (ListViewItem item in lvSaleBasket.Items)
                {

                    SqlCommand cmdNewSaleDetails = new SqlCommand();
                    SqlConnection con = new SqlConnection(connStr);
                    cmdNewSaleDetails.CommandText = @" INSERT INTO SaleDetails(SaleID, StockID, QTYSold)
                                                    VALUES (@SupplierOrderID, @StockID, @QTYOrdered)";
                    cmdNewSaleDetails.Connection = con;
                    con.Open();
                    cmdNewSaleDetails.Parameters.AddWithValue("@SupplierOrderID", txtInfoSaleID.Text);
                    cmdNewSaleDetails.Parameters.AddWithValue("@StockID", item.SubItems[0].Text);
                    cmdNewSaleDetails.Parameters.AddWithValue("@QTYOrdered", int.Parse(item.SubItems[2].Text));
                    cmdNewSaleDetails.ExecuteNonQuery();
                    con.Close();

                }

                MessageBox.Show("Order Submitted!");

                //disableAddOrder();
                tabSales.SelectedIndex = 0;
            }
        }

        //Buttons
        private void btnAddDis_Click(object sender, EventArgs e)
        {
            tabSales.SelectedIndex = 0;

        }
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            tabSales.SelectedIndex = 2;

        }
        private void btnAddDel_Click(object sender, EventArgs e)
        {
            tabSales.SelectedIndex = 0;

        }
        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvSales.SelectedRows.Count == 0)
            {
                 saleSelected= false;
                saleIDSelected = "";
            }
            else if (dgvSales.SelectedRows.Count == 1)
            {
                saleSelected = true;
                saleIDSelected = dgvSales.SelectedRows[0].Cells[0].Value.ToString();


            }
        }


        //Edit

        private void lstEditStockAvailable_Click(object sender, EventArgs e)
        {
            drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(lstEditStockAvailable.SelectedValue.ToString());
            txtEditItemStockID.Text = drStock["StockID"].ToString();
            txtEditItemSuppID.Text = drStock["StockDesc"].ToString();
            txtEditItemOrdDate.Text = drStock["StockTypeID"].ToString();
            txtEditItemDesDate.Text = drStock["QTYInStock"].ToString();
            txtEditItemDelDate.Text = drStock["StockPrice"].ToString();

        }
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            enableEditSale();
        }
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            var orderItem = lstEditStockAvailable.SelectedValue.ToString();
            bool exits = false;
            bool ok = true;


            if (lstEditStockAvailable.SelectedIndex == -1)
                MessageBox.Show("Please Select a Stock Item!", "Stock");
            else if (cmbEditItemQTY.Text == "")
                MessageBox.Show("Please Enter Quantity!", "Quantity");
            else
            {
                foreach (ListViewItem item in lvEditSaleItems.Items)
                {
                    if (item.SubItems[1].Text == lstEditStockAvailable.SelectedValue.ToString())
                    {
                        MessageBox.Show("You have already added this to your basket!", "Basket");
                        exits = true;

                        break;
                    }
                }

                if (!exits)
                {
                    if (ok)
                    {

                        SqlCommand cmdEditSaleItems = new SqlCommand();
                        SqlConnection con = new SqlConnection(connStr);
                        cmdEditSaleItems.CommandText = @"INSERT INTO SaleDetails(SaleID, StockID, QTYSold) VALUES (@SaleID, @StockID, @QTYSold)";
                        cmdEditSaleItems.Connection = con;
                        con.Open();
                        cmdEditSaleItems.Parameters.AddWithValue("@SaleID", txtEditInfoSaleID.Text);
                        cmdEditSaleItems.Parameters.AddWithValue("@StockID", lstEditStockAvailable.SelectedValue.ToString());
                        cmdEditSaleItems.Parameters.AddWithValue("@QTYSold", int.Parse(cmbEditItemQTY.Text));
                        cmdEditSaleItems.ExecuteNonQuery();
                        con.Close();


                        ListViewItem newitem = new ListViewItem(txtEditInfoSaleID.Text);
                        newitem.SubItems.Add(lstEditStockAvailable.Text);
                        newitem.SubItems.Add(cmbEditItemQTY.Text);
                        lvEditSaleItems.Items.Add(newitem);
                        MessageBox.Show("Item Added!", "Success!");
                    }
                }

            }
        }
        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Once Deleted it can't be undone! Are you sure?", "WARNING", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                object[] primaryKey = new object[2];
                var orderItem = lvEditSaleItems.SelectedItems[0];

                //removed foreach as it removed all the items instead of the selected one - will finish tomorrow.
                primaryKey[0] = orderItem.SubItems[0].Text;
                primaryKey[1] = orderItem.SubItems[1].Text;
                SqlCommand cmdDelSaleItemDetails = new SqlCommand();
                SqlConnection con = new SqlConnection(connStr);
                cmdDelSaleItemDetails.CommandText = @"DELETE FROM SaleDetails WHERE SaleID = @SaleID AND StockID = @StockID";
                con.Open();
                cmdDelSaleItemDetails.Connection = con;
                cmdDelSaleItemDetails.Parameters.AddWithValue("@SaleID", primaryKey[0]);
                cmdDelSaleItemDetails.Parameters.AddWithValue("@StockID", primaryKey[1]);
                cmdDelSaleItemDetails.ExecuteNonQuery();
                con.Close();
                lvEditSaleItems.Items.Remove(orderItem);
                lvEditSaleItems.Refresh();
            }
            MessageBox.Show("Item Removed!");
        }
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            disableEditSale();
            MessageBox.Show("Order Updated!", "Updated");
        }
        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvSales.SelectedRows.Count == 0)
            {
                saleSelected = false;
                saleIDSelected = "";
            }
            else if (dgvSales.SelectedRows.Count == 1)
            {
                saleSelected = true;
                saleIDSelected = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        //Other
        private void btnEditDis_Click(object sender, EventArgs e)
        {

        }
        private void btnEditAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnEditDel_Click(object sender, EventArgs e)
        {

        }
        private void getSaleNum(int noRows)
        {
            drSales = dsLloydsPharmacy.Tables["Sales"].Rows[noRows - 1];
            txtInfoSaleID.Text = "S" + ((Convert.ToInt32(drSales["SaleID"].ToString().Substring(1, 3))) + 1).ToString();
        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }

        void enableEditSale()
        {

        }
        void disableEditSale()
        {

        }
        void clearAddSale()
        {

        }


       
    }
}
