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
    public partial class frmStock : Form
    {
        SqlDataAdapter daStock, daSearch;
        DataSet dsLloydsPharmacy = new DataSet();
        DataTable dtTypes = new DataTable(), dtSuppliers = new DataTable(), dtStockType = new DataTable();
        SqlDataAdapter daTypes, daSupplier, daStockType;
        SqlCommandBuilder cmdbStock, cmdBSearch, cmdBStockType;
        DataRow drStock, drSupplier;
        String connStr, sqlStock, sqlSearch,sqlSupplier, sqlStockType;
        int selectedTab = 0;
        bool stockSelected = false;
        string StockIDSelected = "";
        string newLine = Environment.NewLine;
        bool firstLoad = true;
        //rptStockSupplier rptStockSupplier = new rptStockSupplier();
        //rptStockType rptStockType = new rptStockType();
        //rptAllStock rptAllStock = new rptAllStock();


        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
           //connStr = @"Data Source=.; Initial Catalog = LloydsPharmacy; Integrated Security = true";
           connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = True";

            sqlStockType = @"Select * from StockType";
            daTypes = new SqlDataAdapter(sqlStockType, connStr);
            daTypes.Fill(dtTypes);
            cmbStockType.DataSource = dtTypes;
            cmbStockType.DisplayMember = "StockTypeDesc";
            cmbStockType.ValueMember = "StockTypeID";

            sqlSupplier = @"Select * FROM Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            daSupplier.Fill(dtSuppliers);
            cmbAddSuppID.DataSource = dtSuppliers;
            cmbAddSuppID.DisplayMember = "SupplierName";
            cmbAddSuppID.ValueMember = "SupplierID";
            cmbReportSupplier.DataSource = dtSuppliers;
            cmbReportSupplier.DisplayMember = "SupplierName";
            cmbReportSupplier.ValueMember = "SupplierID";
            cmbEditSuppID.DataSource = dtSuppliers;
            cmbEditSuppID.DisplayMember = "SupplierName";
            cmbEditSuppID.ValueMember = "SupplierID";

            sqlStockType = @"Select * FROM StockType";
            daStockType = new SqlDataAdapter(sqlStockType, connStr);
            daStockType.Fill(dtStockType);
            cmbAddStockTypeID.DataSource = dtStockType;
            cmbAddStockTypeID.DisplayMember = "StockTypeDesc";
            cmbAddStockTypeID.ValueMember = "StockTypeID";
            cmbEditStockTypeID.DataSource = dtStockType;
            cmbEditStockTypeID.DisplayMember = "StockTypeDesc";
            cmbEditStockTypeID.ValueMember = "StockTypeID";

            cmbDisByStockType.DataSource = dtStockType;
            cmbDisByStockType.DisplayMember = "StockTypeDesc";
            cmbDisByStockType.ValueMember = "StockTypeID";
            


            sqlStock = @"Select * from Stock";
            daStock = new SqlDataAdapter(sqlStock, connStr);
            cmdbStock = new SqlCommandBuilder(daStock);
            daStock.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daStock.Fill(dsLloydsPharmacy, "Stock");
            dgvStock.DataSource = dsLloydsPharmacy.Tables["Stock"];

            disableEdit();
            dgvHeadings();
            firstLoad = false;
        }
        private void tabStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabStock.SelectedIndex;

            tabStock.TabPages[tabStock.SelectedIndex].Focus();

            tabStock.TabPages[tabStock.SelectedIndex].CausesValidation = true;

            switch (tabStock.SelectedIndex)
            {
                case 0:
                    {
                        dsLloydsPharmacy.Tables["Stock"].Clear();
                        daStock.Fill(dsLloydsPharmacy, "Stock");
                        StockInfoClear();
                        break;

                    }

                case 1:
                    {
                        ClearAddForm();

                        int noRows = dsLloydsPharmacy.Tables["Stock"].Rows.Count;

                        if (noRows == 0)
                        {
                            txtAddStockID.Text = "ST001";
                        }
                        else
                        {
                            getNumber(noRows);
                        }
                        errP.Clear();
                        break;
                    }

                case 2:
                    {
                        if (StockIDSelected == "")
                        {
                            MessageBox.Show("Please select a Stock Item to Edit!");
                             tabStock.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
                            txtEditStockID.Text = drStock["StockID"].ToString();
                            cmbEditSuppID.SelectedValue = drStock["SupplierID"].ToString();
                            txtEditStockDesc.Text = drStock["StockDesc"].ToString();
                            cmbEditStockTypeID.SelectedValue = drStock["StockTypeID"].ToString();
                            txtEditQTY.Text = drStock["QTYInStock"].ToString();
                            txtEditStockPrice.Text = drStock["StockPrice"].ToString();

                            disableEdit();

                            break;
                        }

                    }


            }
        }
        private void frmStock_Shown(object sender, EventArgs e)
        {
            tabStock.TabPages[0].CausesValidation = true;
            tabStock.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabStock.TabPages[2].CausesValidation = true;
            tabStock.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

        }


        ///////D I S P L A Y  T A B\\\\\\\\
        //

        private void txtSearchStockName_TextChanged(object sender, EventArgs e)
        {
            //this searchs via the text changed in the text box, resets ther DGV and then applies the new data retrieved from the search.
            sqlSearch = @"Select * from Stock WHERE StockDesc LIKE '" + txtSearchStockName.Text + "%'";
            daSearch = new SqlDataAdapter(sqlSearch, connStr);
            cmdBSearch = new SqlCommandBuilder(daSearch);
            dsLloydsPharmacy.Tables["Stock"].Clear();
            daSearch.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daSearch.Fill(dsLloydsPharmacy, "Stock");
            dgvStock.DataSource = dsLloydsPharmacy.Tables["Stock"];
            dgvStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvStock.Refresh();
        }
        private void cmbStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                dsLloydsPharmacy.Tables["Stock"].Clear();

                String strType = cmbStockType.SelectedValue.ToString();
                sqlStockType = @"Select * from Stock where stocktypeID like '%" + strType + "'";
                daTypes = new SqlDataAdapter(sqlStockType, connStr);
                cmdBStockType = new SqlCommandBuilder(daTypes);

                daTypes.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
                daTypes.Fill(dsLloydsPharmacy, "Stock");

               

                dgvStock.DataSource = dsLloydsPharmacy.Tables["Stock"];
                dgvStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvStock.Refresh();
            }
            

        }
        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
            lblDisStockIDData.Text = drStock["StockID"].ToString();
            txtDisStockDescData.Text = drStock["StockDesc"].ToString();
            lblSDistockTypeIDData.Text = drStock["StockTypeID"].ToString();
            lblDisQTYInStockData.Text = drStock["QTYInStock"].ToString();
            lblDisStockPriceData.Text = drStock["StockPrice"].ToString();
        }
        private void btnDisAdd_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 1;
        }
        private void btnDisEdit_Click(object sender, EventArgs e)
        {
            if(dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the Stock item you wish to edit.", "Select Stock Item!");
            }
            else
            {
                tabStock.SelectedIndex = 2;
                drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(dgvStock.SelectedRows[0].Cells[0].Value.ToString());
                txtEditStockID.Text = drStock["StockID"].ToString();
                cmbEditSuppID.Text = drStock["SupplierID"].ToString();
                txtEditStockDesc.Text = drStock["StockDesc"].ToString();
                cmbEditStockTypeID.Text = drStock["StockTypeID"].ToString();
                txtEditQTY.Text = drStock["QTYInStock"].ToString();
                txtEditStockPrice.Text = drStock["StockPrice"].ToString();

                disableEdit();
            }
        }
        private void btnDisDel_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Stock you wish to delete.", "Select Stock!");
            }
            else
            {
                drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(dgvStock.SelectedRows[0].Cells[0].Value);

                string tempName = drStock["StockID"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete Stock Item - " + tempName, "Delete Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drStock.Delete();
                    daStock.Update(dsLloydsPharmacy, "Stock");
                }
                
            }

        }
        private void btnDisExit_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }




        /////A D D  T A B \\\\\\
        private void btnAddDis_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 0;

        }
        private void btnAddAddStock_Click(object sender, EventArgs e)
        {
            MyStock myStock = new MyStock();
            bool ok = true;
            errP.Clear();

            try
            {
                myStock.StockID = txtAddStockID.Text.Trim();
            }
            catch(MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStockID, MyEx.toString());
            }

            try
            {
                myStock.SupplierID = cmbAddSuppID.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddSuppID, MyEx.toString());

            }

            try
            {
                myStock.StockDesc = txtAddStockDesc.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStockDesc, MyEx.toString());
            }

            try
            {
                myStock.StockTypeID = cmbAddStockTypeID.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddStockTypeID, MyEx.toString());
            }

            try
            {
                myStock.QTYInStock = Convert.ToInt32(txtAddQTY.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddQTY, MyEx.toString());
            }
            catch(System.FormatException )
            {
                errP.SetError(txtAddQTY, "Invalid Quantity!");
            }

            try
            {
                myStock.StockPrice = Convert.ToInt32(txtAddStockPrice.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStockPrice, MyEx.toString());
            }
            catch (System.FormatException )
            {
                errP.SetError(txtAddStockPrice, "Invalid Price!");
            }

            try
            {
                if(ok)
                {
                    drStock = dsLloydsPharmacy.Tables["Stock"].NewRow();

                    drStock["StockID"] = myStock.StockID;
                    drStock["SupplierID"] = myStock.SupplierID;
                    drStock["StockDesc"] = myStock.StockDesc;
                    drStock["StockTypeID"] = myStock.StockTypeID;
                    drStock["QTYInStock"] = myStock.QTYInStock;
                    drStock["StockPrice"] = myStock.StockPrice;

                    dsLloydsPharmacy.Tables["Stock"].Rows.Add(drStock);
                    daStock.Update(dsLloydsPharmacy, "Stock");

                    MessageBox.Show("New Stock Item Added!");

                    if (MessageBox.Show("Do you wish to add another Stock Item?", "Add Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClearAddForm();
                        getNumber(dsLloydsPharmacy.Tables["Stock"].Rows.Count);
                    }
                    else
                    {
                        tabStock.SelectedIndex = 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }
        private void btnAddEditStock_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 2;

        }
        private void btnAddDelSupp_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 0;
        }
        private void btnAddCancelSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Stock Item: " + txtAddStockID.Text + "?", "Add Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ClearAddForm();
                tabStock.SelectedIndex = 0;
            }
        }
        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                stockSelected = false;
                StockIDSelected = "";
            }
            else if (dgvStock.SelectedRows.Count == 1)
            {
                stockSelected = true;
                StockIDSelected = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
            }
        }



        /////// E D I T  T A B \\\\\\\\
        private void btnEditDisplay_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 0;
        }
        private void btnEditAddStock_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 1;

        }
        private void btnEditEditStock_Click(object sender, EventArgs e)
        {
            
                enableEdit();

        }
        private void btnEditUpdateStock_Click(object sender, EventArgs e)
        {
            MyStock myStock = new MyStock();
            bool ok = true;
            errP.Clear();

            try
            {
                myStock.StockID = txtEditStockID.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditStockID, MyEx.toString());
            }

            try
            {
                myStock.SupplierID = cmbEditSuppID.SelectedValue.ToString();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditSuppID, MyEx.toString());
            }


            try
            {
                myStock.StockDesc = txtEditStockDesc.Text.Trim();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditStockDesc, MyEx.toString());
            }

            try
            {
                myStock.StockTypeID = cmbEditStockTypeID.SelectedValue.ToString();

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbEditStockTypeID, MyEx.toString());
            }

            try
            {
                myStock.QTYInStock = Convert.ToInt32(txtEditQTY.Text.Trim());

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditQTY, MyEx.toString());
            }

            try
            {
                myStock.StockPrice = Convert.ToDouble(txtEditStockPrice.Text.Trim());

            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditStockPrice, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drStock.BeginEdit();
                    drStock["StockID"] = myStock.StockID;
                    drStock["SupplierID"] = myStock.SupplierID;
                    drStock["StockDesc"] = myStock.StockDesc;
                    drStock["StockTypeID"] = myStock.StockTypeID;
                    drStock["QTYInStock"] = myStock.QTYInStock;
                    drStock["StockPrice"] = myStock.StockPrice;

                    drStock.EndEdit();
                    daStock.Update(dsLloydsPharmacy, "Stock");

                    MessageBox.Show(drStock["StockID"].ToString() + "Has been updated!", "Update");

                    disableEdit();

                    btnEditEditStock.Text = "Edit";
                    tabStock.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        private void btnEditDelStock_Click(object sender, EventArgs e)
        {
            tabStock.SelectedIndex = 0;

        }
        private void btnEditCancelStock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Stock Item No: " + txtEditStockID.Text + "?", "Add Stock", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ClearAddForm();
                tabStock.SelectedIndex = 0;
            }
        }
        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                //select a customer, reset tab to display etc
                stockSelected = false;
                StockIDSelected = "";
            }
            else if (dgvStock.SelectedRows.Count == 1)
            {
                stockSelected = true;
                StockIDSelected = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
            }
        }



        //private void crvReports_Load(object sender, EventArgs e)
        //{
        //    crvReports.ReportSource = rptAllStock;

        //}
        //private void cmbReportSupplier_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    rptStockSupplier.SetParameterValue("cSupplierID", cmbReportSupplier.SelectedValue.ToString());
        //    crvReports.ReportSource = rptStockSupplier;


        //}
        //private void cmbDisByStockType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    rptStockType.SetParameterValue("cStockTypeID", cmbDisByStockType.SelectedValue.ToString());
        //    crvReports.ReportSource = rptStockType;

        //}
        //private void btnViewAllData_Click(object sender, EventArgs e)
        //{
        //    crvReports.ReportSource = rptAllStock;
        //}





        /// ///////// OTHER METHODS
        private void getNumber(int noRows)
            {
                drStock = dsLloydsPharmacy.Tables["Stock"].Rows[noRows - 1];
                txtAddStockID.Text = "ST" + ((Convert.ToInt32(drStock["StockID"].ToString().Substring(2, 3))) + 1).ToString();
                txtAddStockID.Enabled = false;

            } 
            void ClearAddForm()
            {
                txtAddStockID.Clear();
                cmbAddSuppID.SelectedIndex = -1;
                txtAddStockDesc.Clear();
                cmbAddStockTypeID.SelectedIndex = -1;
                txtAddQTY.Clear();
                txtAddStockPrice.Clear();
            }
            void ClearEditForm()
            {
                txtEditStockID.Clear();
                cmbEditSuppID.SelectedIndex = -1;
                txtEditStockDesc.Clear();
                cmbEditStockTypeID.SelectedIndex = -1;
                txtEditQTY.Clear();
                txtEditStockPrice.Clear();
            }
            void enableEdit()
            {
                txtEditStockID.Enabled = true;
                cmbEditSuppID.Enabled = true;
                txtEditStockDesc.Enabled = true;
                cmbEditStockTypeID.Enabled = true;
                txtEditQTY.Enabled = true;
                txtEditStockPrice.Enabled = true;
            }
            void disableEdit()
            {
                txtEditStockID.Enabled = false;
                cmbEditSuppID.Enabled = false;
                txtEditStockDesc.Enabled = false;
                cmbEditStockTypeID.Enabled = false;
                txtEditQTY.Enabled = false;
                txtEditStockPrice.Enabled = false;
            }
            void dgvHeadings()
            {

                dgvStock.Columns[0].HeaderText = "Stock ID";
                dgvStock.Columns[1].HeaderText = "Supplier ID";
                dgvStock.Columns[2].HeaderText = "Stock Description";
                dgvStock.Columns[3].HeaderText = "Stock Type ID";
                dgvStock.Columns[4].HeaderText = "Quantity In Stock";
                dgvStock.Columns[5].HeaderText = "Stock Price";
            }
            void StockInfoClear()
            {
                lblDisStockIDData.Text = "";
                txtDisStockDescData.Text = "";
                lblSDistockTypeIDData.Text = "";
                lblDisQTYInStockData.Text = "";
                lblDisStockPriceData.Text = "";
            }
            private void pbLogo_Click(object sender, EventArgs e)
            {
                frmMenu frmmenu = new frmMenu();
                frmmenu.Show();
                this.Hide();
            }


        


        //////H O V E R  P R O P E R T I E S \\\\\\\
        /////display section
        private void btnDisAdd_MouseEnter(object sender, EventArgs e)
        {
            btnDisAdd.Text = "";
            btnDisAdd.ImageIndex = 1;
        }
        private void btnDisAdd_MouseLeave(object sender, EventArgs e)
        {
            btnDisAdd.Text = "Add";
            btnDisAdd.ImageIndex = -1;
        }
        private void btnDisEdit_MouseEnter(object sender, EventArgs e)
        {
            btnDisEdit.Text = "";
            btnDisEdit.ImageIndex = 2;
        }
        private void btnDisEdit_MouseLeave(object sender, EventArgs e)
        {
            btnDisEdit.Text = "Edit";
            btnDisEdit.ImageIndex = -1;
        }
        private void btnDisDel_MouseEnter(object sender, EventArgs e)
        {
            btnDisDel.Text = "";
            btnDisDel.ImageIndex = 4;
        }
        private void btnDisDel_MouseLeave(object sender, EventArgs e)
        {
            btnDisDel.Text = "Delete";
            btnDisDel.ImageIndex = -1;
        }
        private void btnDisExit_MouseEnter(object sender, EventArgs e)
        {
            btnDisExit.Text = "";
            btnDisExit.ImageIndex = 7;
        }
        private void btnDisExit_MouseLeave(object sender, EventArgs e)
        {
            btnDisExit.Text = "Exit";
            btnDisExit.ImageIndex = -1;
        }

        //add section
        private void btnAddDis_MouseEnter(object sender, EventArgs e)
        {
            btnAddDis.Text = "";
            btnAddDis.ImageIndex = 8;
        }
        private void btnAddDis_MouseLeave(object sender, EventArgs e)
        {
            btnAddDis.Text = "Add";
            btnAddDis.ImageIndex = -1;
        }
        private void btnAddAddStock_MouseEnter(object sender, EventArgs e)
        {
            btnAddAddStock.Text = "";
            btnAddAddStock.ImageIndex = 1;
        }
        private void btnAddAddStock_MouseLeave(object sender, EventArgs e)
        {
            btnAddAddStock.Text = "Add";
            btnAddAddStock.ImageIndex = -1;
        }
        private void btnAddEditStock_MouseEnter(object sender, EventArgs e)
        {
            btnAddEditStock.Text = "";
            btnAddEditStock.ImageIndex = 2;
           
        }
        private void btnAddEditStock_MouseLeave(object sender, EventArgs e)
        {
            btnAddEditStock.Text = "Edit";
            btnAddEditStock.ImageIndex = -1;
        }
        private void btnAddDelStock_MouseEnter(object sender, EventArgs e)
        {
            btnAddDelStock.Text = "";
            btnAddDelStock.ImageIndex = 4;
        }
        private void btnAddDelStock_MouseLeave(object sender, EventArgs e)
        {
            btnAddDelStock.Text = "Delete";
            btnAddDelStock.ImageIndex = -1;
        }
        private void btnAddCancelStock_MouseEnter(object sender, EventArgs e)
        {
            btnAddCancelStock.Text = "";
            btnAddCancelStock.ImageIndex = 5;
        }

       

        private void btnAddCancelStock_MouseLeave(object sender, EventArgs e)
        {
            btnAddCancelStock.Text = "Cancel";
            btnAddCancelStock.ImageIndex = -1;
        }

       

        //edit section
        private void btnEditDisplay_MouseEnter(object sender, EventArgs e)
        {
            btnEditDisplay.Text = "";
            btnEditDisplay.ImageIndex = 8;
        }
        private void btnEditDisplay_MouseLeave(object sender, EventArgs e)
        {
            btnEditDisplay.Text = "Display";
            btnEditDisplay.ImageIndex = -1;
        }
        private void btnEditAddStock_MouseEnter(object sender, EventArgs e)
        {
            btnEditAddStock.Text = "";
            btnEditAddStock.ImageIndex = 1;
        }
        private void btnEditAddStock_MouseLeave(object sender, EventArgs e)
        {
            btnEditAddStock.Text = "Add";
            btnEditAddStock.ImageIndex = -1;
        }
        private void lblDisStockByType_Click(object sender, EventArgs e)
        {

        }
        private void btnEditEditStock_MouseEnter(object sender, EventArgs e)
        { // ignore this for now
            if (btnEditEditStock.Text == "Edit")
            {
                btnEditEditStock.Text = "";
                btnEditEditStock.ImageIndex = 2;
            }
            else //if (btnEditEditStock.Text == "Update")
            {
                btnEditEditStock.Text = "";
                btnEditEditStock.ImageIndex = 3;
            }
        }
        private void btnEditEditStock_MouseLeave(object sender, EventArgs e)
        {
            if (btnEditEditStock.ImageIndex == 2)
            {
                btnEditEditStock.Text = "Edit";
                btnEditEditStock.ImageIndex = -1;
            }
            else //if (btnEditEditStock.ImageIndex == 3)
            {
                btnEditEditStock.Text = "Update";
                btnEditEditStock.ImageIndex = -1;
            }
        }     
        private void btnEditDelStock_MouseEnter(object sender, EventArgs e)
        {
            btnEditDelStock.Text = "";
            btnEditDelStock.ImageIndex = 4;
        }
        private void btnEditDelStock_MouseLeave(object sender, EventArgs e)
        {
            btnEditDelStock.Text = "Delete";
            btnEditDelStock.ImageIndex = -1;
        }
        private void btnEditCancelStock_MouseEnter(object sender, EventArgs e)
        {
            btnEditCancelStock.Text = "";
            btnEditCancelStock.ImageIndex = 5;
        }
        private void btnEditCancelStock_MouseLeave(object sender, EventArgs e)
        {
            btnEditCancelStock.Text = "Cancel";
            btnEditCancelStock.ImageIndex = -1;
        }

       



        


    }
}
