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


    public partial class frmSuppliers : Form
    {
        private SqlDataAdapter daSupplier, daSuppOrders, daSuppName, daSuppOrderDetails, daStockAvailable, daSearch, daSuppPayments, daSuppPaymentDetails, daUnpaidOrders, daPaidOrders, daPaymentType, daUnpaidInvoices, daPaidInvoices;
        private SqlCommandBuilder cmdBSupplier, cmdBSearch, cmdBSuppOrder, cmdBSuppOrderDetails, cmdBSuppPayments, cmdBSuppPaymentDetails;
        private String connStr, sqlSupplier, sqlSuppOrders, sqlSuppOrderDetails, sqlSuppName, sqlStockAvailable, sqlSearch, sqlSuppPayments,sqlSuppPaymentDetails, sqlUnpaidOrders, sqlPaidOrders, sqlUnpaidInvoices, sqlPaidInvoices;
        private DataTable dtSuppName = new DataTable(), dtPaymentType = new DataTable();
        private DataSet dsLloydsPharmacy = new DataSet();
        private DataRow drSupplier, drStock, drSuppOrder, drSuppPayments, drSuppPaymentDetails;
        private SqlConnection conn;
        
        int selectedTab = 0;
        bool suppSelected = false, firstLoad = true;
        string suppIDSelected = "";
        string newLine = Environment.NewLine;

        //Delcaring reports here so they can be used in methods.
        //rptSupplier rptsup = new rptSupplier();

        public frmSuppliers()
        {
            InitializeComponent();
        }
        private void frmSuppliers_Load(object sender, EventArgs e)
        {
           //connStr = @"Data source = .; Initial Catalog = LloydsPharmacy; Integrated Security = true";
            connStr = @"Data Source = REDTOPS\SQLEXPRESS; Initial Catalog = LloydsPharmacy; Integrated Security = True";
            conn = new SqlConnection(connStr);
            sqlSearch = txtSearchSupplier.ToString();

            //Supplier Display Tab
            sqlSupplier = @"Select * FROM Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsLloydsPharmacy, "Supplier");
            dgvSuppliers.DataSource = dsLloydsPharmacy.Tables["Supplier"];


            //Order Display Tab
            //combo box -- null all of a sudden?
            daSuppName = new SqlDataAdapter("Select SupplierID, SupplierName FROM Supplier", connStr);
            daSuppName.Fill(dtSuppName);
            cmbDisBySupp.DataSource = dtSuppName;
            cmbDisBySupp.DisplayMember = "SupplierName";
            cmbDisBySupp.ValueMember = "SupplierID";
         

            //SuppOrders
            sqlSuppOrders = @"Select * FROM SupplierOrder ";
            daSuppOrders = new SqlDataAdapter(sqlSuppOrders, conn);
            cmdBSuppOrder = new SqlCommandBuilder(daSuppOrders);
            daSuppOrders.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SupplierOrder");
            daSuppOrders.Fill(dsLloydsPharmacy, "SupplierOrder");
            dgvSuppOrders.DataSource = dsLloydsPharmacy.Tables["SupplierOrder"];



            //supplierorderdetails
            sqlSuppOrderDetails = @"Select * FROM SupplierOrderDetails";
            daSuppOrderDetails = new SqlDataAdapter(sqlSuppOrderDetails, conn);
            cmdBSuppOrderDetails = new SqlCommandBuilder(daSuppOrderDetails);
            daSuppOrderDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SupplierOrderDetails");
            daSuppOrderDetails.Fill(dsLloydsPharmacy, "SupplierOrderDetails");

            //Add Order Tab
            //suppliers
            sqlSupplier = @"Select * FROM Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, conn);
            daSupplier.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsLloydsPharmacy, "Supplier");
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            lstSuppliers.DataSource = dsLloydsPharmacy.Tables["Supplier"];
            lstSuppliers.DisplayMember = "SupplierName";
            lstSuppliers.ValueMember = "SupplierID";

            //Stock available table.
            sqlStockAvailable = @"Select * FROM Stock WHERE SupplierID LIKE '" + lstSuppliers.SelectedValue + "'";
            daStockAvailable = new SqlDataAdapter(sqlStockAvailable, conn);
            daStockAvailable.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daStockAvailable.Fill(dsLloydsPharmacy, "Stock");

            //Payments tab
            sqlSuppPayments = @"Select * FROM SupplierPayments";
            daSuppPayments = new SqlDataAdapter(sqlSuppPayments, conn);
            daSuppPayments.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SupplierPayments");
            daSuppPayments.Fill(dsLloydsPharmacy, "SupplierPayments");
            cmdBSuppPayments = new SqlCommandBuilder(daSuppPayments);

            sqlSuppPaymentDetails = @"Select * FROM SupplierPaymentDetails";
            daSuppPaymentDetails = new SqlDataAdapter(sqlSuppPaymentDetails, conn);
            daSuppPaymentDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SupplierPaymentDetails");
            daSuppPaymentDetails.Fill(dsLloydsPharmacy, "SupplierPaymentDetails");
            cmdBSuppPaymentDetails = new SqlCommandBuilder(daSuppPaymentDetails);


            //combo boxes
            daPaymentType = new SqlDataAdapter("Select * FROM PaymentType", connStr);
            daPaymentType.Fill(dtPaymentType);
            cmbPaymentType.DataSource = dtPaymentType;
            cmbPaymentType.DisplayMember = "PaymentTypeDesc";
            cmbPaymentType.ValueMember = "PaymentTypeID";


            dgvSupplierHeadings();
            dgvOrderHeadings();
            firstLoad = false;

            //lstSuppliers.Click = 
        }
        private void frmSuppliers_Shown(object sender, EventArgs e)
        {
            tabSupplier.TabPages[0].CausesValidation = true;
            tabSupplier.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabSupplier.TabPages[2].CausesValidation = true;
            tabSupplier.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);

        }
        private void tabSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabSupplier.SelectedIndex;
            tabSupplier.TabPages[tabSupplier.SelectedIndex].Focus();
            tabSupplier.TabPages[tabSupplier.SelectedIndex].CausesValidation = true;

            switch (tabSupplier.SelectedIndex)
            {
                case 0://display
                    {
                        dsLloydsPharmacy.Tables["Supplier"].Clear();
                        txtSearchSupplier.Clear();
                        daSupplier.Fill(dsLloydsPharmacy, "Supplier");
                        SuppInfoClear();
                        break;

                    }

                case 1://add
                    {
                        int noRows = dsLloydsPharmacy.Tables["Supplier"].Rows.Count;
                        txtAddSuppID.Enabled = false;
                        if (noRows == 0)
                        {
                            txtAddSuppID.Text = "SUP0001";
                        }
                        else
                        {
                            getNumber(noRows);

                        }
                        errP.Clear();
                        ClearAddForm();
                        break;
                    }

                case 2://edit
                    {
                        disableEdit();
                        if (suppIDSelected == "")
                        {
                            MessageBox.Show("Please select an Order to Edit!", "Edit Order");
                            tabControlOrder.SelectedIndex = 0;
                            break;

                        }
                        else
                        {
                            drSupplier = dsLloydsPharmacy.Tables["Supplier"].Rows.Find(dgvSuppliers.SelectedRows[0].Cells[0].Value);
                            txtEditSuppID.Text = drSupplier["SupplierID"].ToString();
                            txtEditSuppName.Text = drSupplier["SupplierName"].ToString();
                            txtEditSuppStreet.Text = drSupplier["SupplierStreet"].ToString();
                            txtEditSuppTown.Text = drSupplier["SupplierTown"].ToString();
                            txtEditSuppCounty.Text = drSupplier["SupplierCounty"].ToString();
                            txtEditSuppPostcode.Text = drSupplier["SupplierPostcode"].ToString();
                            txtEditSuppTelno.Text = drSupplier["SupplierTelNo"].ToString();

                            break;
                        }

                    }

                case 3:
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

        ///// D I S P L A Y  T A B 
        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            //this searchs via the text changed in the text box, resets ther DGV and then applies the new data retrieved from the search.
            sqlSearch = @"Select * from Supplier WHERE SupplierName LIKE '" + txtSearchSupplier.Text + "%'";
            daSearch = new SqlDataAdapter(sqlSearch, connStr);
            cmdBSearch = new SqlCommandBuilder(daSearch);
            dsLloydsPharmacy.Tables["Supplier"].Clear();
            daSearch.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Supplier");
            daSearch.Fill(dsLloydsPharmacy, "Supplier");
            dgvSuppliers.DataSource = dsLloydsPharmacy.Tables["Supplier"];
            dgvSuppliers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvSuppliers.Refresh();


        }
        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            drSupplier = dsLloydsPharmacy.Tables["Supplier"].Rows.Find(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
            txtDisSuppIDData.Text = drSupplier["SupplierID"].ToString();
            txtDisSuppNameData.Text = drSupplier["SupplierName"].ToString();
            txtDisSuppStreetData.Text = drSupplier["SupplierStreet"].ToString();
            txtDisTownData.Text = drSupplier["SupplierTown"].ToString();
            txtDisCountyData.Text = drSupplier["SupplierCounty"].ToString();
            txtDisPostcodeData.Text = drSupplier["SupplierPostcode"].ToString();
            txtDisTelNoData.Text = drSupplier["SupplierTelNo"].ToString();

        }
        private void btnDisAdd_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 1;
        }
        private void btnDisEdit_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Supplier you wish to edit.", "Select Supplier!");
            }
            else
            {
                tabSupplier.SelectedIndex = 2;

                //might have a method that enables the edit form properties.
                drSupplier = dsLloydsPharmacy.Tables["Supplier"].Rows.Find(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
                txtEditSuppID.Text = drSupplier["SupplierID"].ToString();
                txtEditSuppName.Text = drSupplier["SupplierName"].ToString();
                txtEditSuppStreet.Text = drSupplier["SupplierStreet"].ToString();
                txtEditSuppTown.Text = drSupplier["SupplierTown"].ToString();
                txtEditSuppCounty.Text = drSupplier["SupplierCounty"].ToString();
                txtEditSuppPostcode.Text = drSupplier["SupplierPostcode"].ToString();
                txtEditSuppTelno.Text = drSupplier["SupplierTelNo"].ToString();

                disableEdit();
                //Will possibly have this within a method so it can be called via edit button on display tab and the tab selected index.


            }
        }
        private void btnDisDel_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Supplier you wish to delete.", "Select Supplier!");
            }
            else
            {
                drSupplier = dsLloydsPharmacy.Tables["Supplier"].Rows.Find(dgvSuppliers.SelectedRows[0].Cells[0].Value);

                string tempName = drSupplier["SupplierName"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Delete Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsLloydsPharmacy, "Supplier");
                }


            }
        }
        private void btnDisExit_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }

        // A D D  T A B 
        private void btnAddDis_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 0;

        }
        private void btnAddAddSupp_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupplier.SupplierID = txtAddSuppID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSuppID, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierName = txtAddSuppName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSuppName, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierStreet = txtAddSuppStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSuppStreet, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierTown = txtAddSuppTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSuppTown, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierCounty = txtAddSuppCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSuppID, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierPostcode = txtAddSuppPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSuppPostcode, MyEx.toString());
            }

            //try
            //{
            //    mySupplier.SupplierTelNo = txtAddSuppTelno.Text.Trim();
            //}
            //catch (MyException MyEx)
            //{
            //    ok = false;
            //    errP.SetError(txtAddSuppTelno, MyEx.toString());
            //}

            try
            {
                if (ok)
                {
                    drSupplier = dsLloydsPharmacy.Tables["Supplier"].NewRow();
                    drSupplier["SupplierID"] = mySupplier.SupplierID;
                    drSupplier["SupplierName"] = mySupplier.SupplierName;
                    drSupplier["SupplierStreet"] = mySupplier.SupplierStreet;
                    drSupplier["SupplierTown"] = mySupplier.SupplierTown;
                    drSupplier["SupplierCounty"] = mySupplier.SupplierCounty;
                    drSupplier["SupplierPostcode"] = mySupplier.SupplierPostcode;
                   // drSupplier["SupplierTelNo"] = mySupplier.SupplierTelNo;

                    dsLloydsPharmacy.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsLloydsPharmacy, "Supplier");

                    MessageBox.Show("Supplier Added");

                    if (MessageBox.Show("Do you wish to add another Supplier?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ClearAddForm();
                        getNumber(dsLloydsPharmacy.Tables["Supplier"].Rows.Count);
                    }
                    else
                    {
                        tabSupplier.SelectedIndex = 0;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }
        private void btnAddEditSupp_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 2;
        }
        private void btnAddDelSupp_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 0;
        }
        private void btnAddCancelSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Supplier No: " + txtAddSuppID.Text + "?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ClearAddForm();
                tabSupplier.SelectedIndex = 0;
            }
        }
        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                suppSelected = false;
                suppIDSelected = "";
            }
            else if (dgvSuppliers.SelectedRows.Count == 1)
            {
                suppSelected = true;
                suppIDSelected = dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString();


            }
        }

        // E D I T  T A B
        private void btnEditDis_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 0;
        }
        private void btnEditAddSupp_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 1;
        }
        private void btnEditEditSupp_Click(object sender, EventArgs e)
        {
            enableEdit();
        }
        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            MySupplier mySupplier = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupplier.SupplierID = txtEditSuppID.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSuppID, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierName = txtEditSuppName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSuppName, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierStreet = txtEditSuppStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSuppStreet, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierTown = txtEditSuppTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSuppTown, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierCounty = txtEditSuppCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSuppCounty, MyEx.toString());
            }

            try
            {
                mySupplier.SupplierPostcode = txtEditSuppPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtEditSuppPostcode, MyEx.toString());
            }

            //try
            //{
            //    mySupplier.SupplierTelNo = txtEditSuppTelno.Text.Trim();
            //}
            //catch (MyException MyEx)
            //{
            //    ok = false;
            //    errP.SetError(txtEditSuppTelno, MyEx.toString());
            //}

            try
            {
                if (ok)
                {
                    drSupplier.BeginEdit();
                    drSupplier["SupplierID"] = mySupplier.SupplierID;
                    drSupplier["SupplierName"] = mySupplier.SupplierName;
                    drSupplier["SupplierStreet"] = mySupplier.SupplierStreet;
                    drSupplier["SupplierTown"] = mySupplier.SupplierTown;
                    drSupplier["SupplierCounty"] = mySupplier.SupplierCounty;
                    drSupplier["SupplierPostcode"] = mySupplier.SupplierPostcode;
                    //drSupplier["SupplierTelNo"] = mySupplier.SupplierTelNo;

                    drSupplier.EndEdit();
                    daSupplier.Update(dsLloydsPharmacy, "Supplier");

                    MessageBox.Show(drSupplier["SupplierName"].ToString() + " has been Updated!", "Update");

                    disableEdit();


                    btnEditEditSupp.Text = "Edit";
                    tabSupplier.SelectedIndex = 0;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }
        private void btnEditDelSupp_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 0;

        }
        private void btnEditCancelEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Supplier No: " + txtAddSuppID.Text + "?", "Add Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ClearAddForm();
                tabSupplier.SelectedIndex = 0;
            }
        }
        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                suppSelected = false;
                suppIDSelected = "";
            }
            else if (dgvSuppliers.SelectedRows.Count == 1)
            {
                suppSelected = true;
                suppIDSelected = dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        //O R D E R  S E C T I O N 
        private void tabControlOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabControlOrder.SelectedIndex;

            switch (tabControlOrder.SelectedIndex)
            {
                case 0://Display Orders
                    {
                        //dsLloydsPharmacy.Tables["SupplierOrder"].Clear();
                        //dgvSuppOrders.Refresh();
                        SuppOrders();
                        dgvSuppOrders.ClearSelection();
                        break;
                    }

                case 1://Add Orders
                    {
                        clearAddOrder();
                        enableAddOrder();

                        int noRows = dsLloydsPharmacy.Tables["SupplierOrder"].Rows.Count;

                        if (noRows == 0)
                        {
                            txtAddSuppID.Text = "S0101";
                        }
                        else
                        {
                            getSuppOrderNum(noRows);

                        }
                        break;
                    }

                case 2://Edit Orders
                    {
                        clearEditOrder();

                        if (dgvSuppOrders.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Please select an Order to Edit!", "Edit Order");
                            tabControlOrder.SelectedIndex = 0;

                        }
                        else
                        {
                            
                            disableEditOrder();


                        }

                        break;

                    }
                case 3://Payments
                    {
                     

                        int noRows = dsLloydsPharmacy.Tables["SupplierPayments"].Rows.Count;
                        txtPaymentID.Enabled = false;
                        if (noRows == 0)
                        {
                            txtAddSuppID.Text = "SP101";
                        }
                        else
                        {
                            getSuppPaymentNum(noRows);

                        }
                        errP.Clear();


                        lvUnpaidOrders.Items.Clear();
                        lvPaidOrders.Items.Clear();
                        orderPayments();
                       
                        

                        break;
                    }
                case 4://Invoices
                    {
                       
                        orderInvoices();
                   
                        break;
                    }


            }
        }
        //DISPLAY ORDERS
        private void dgvOrders_Click(object sender, EventArgs e)
        {

            //SuppOrderDetails
            lvSuppOrderDetails.Items.Clear();


            sqlSuppOrderDetails = @"SELECT sod.SupplierOrderID, sod.StockID,sod.QTYOrdered, s.StockDesc
                                  FROM SupplierOrderDetails sod
                                  JOIN Stock s ON sod.StockID = s.StockID
                                  WHERE sod.SupplierOrderID LIKE '" + dgvSuppOrders.SelectedRows[0].Cells[0].Value.ToString() + "'" +
                                   "ORDER BY s.StockDesc ASC";
            daSuppOrderDetails = new SqlDataAdapter(sqlSuppOrderDetails, conn);
            daSuppOrderDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SuppOrderDetailInfo");
            daSuppOrderDetails.Fill(dsLloydsPharmacy, "SuppOrderDetailInfo");

            foreach (DataRow dr in dsLloydsPharmacy.Tables["SuppOrderDetailInfo"].Rows)
            {
                ListViewItem item = new ListViewItem(dr["SupplierOrderID"].ToString());
                item.SubItems.Add(dr["StockID"].ToString());
                item.SubItems.Add(dr["StockDesc"].ToString());
                item.SubItems.Add(dr["QTYOrdered"].ToString());
                lvSuppOrderDetails.Items.Add(item);
            }
            dsLloydsPharmacy.Tables["SuppOrderDetailInfo"].Clear();


        }
        private void cmbDisBySupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstLoad)
            {
                dsLloydsPharmacy.Tables["SupplierOrder"].Clear();

                String strType = cmbDisBySupp.SelectedValue.ToString();
                sqlSuppName = @"Select * from SupplierOrder where SupplierID like '%" + strType + "'";
                daSuppName = new SqlDataAdapter(sqlSuppName, connStr);
                cmdBSupplier = new SqlCommandBuilder(daSuppName);

                daSuppName.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SupplierOrder");
                daSuppName.Fill(dsLloydsPharmacy, "SupplierOrder");

                dgvSuppOrders.DataSource = dsLloydsPharmacy.Tables["SupplierOrder"];
                dgvSuppOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvSuppOrders.Refresh();




            }
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dsLloydsPharmacy.Tables["SupplierOrder"].Clear();
            SuppOrders();
        }
        //Navigational Buttons
        private void btnOrderDisAdd_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 1;
        }
        private void btnOrderDisEdit_Click(object sender, EventArgs e)
        {
            if (dgvSuppOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an Order to Edit!", "Edit Order");
                tabControlOrder.SelectedIndex = 0;

            }
            
          else  if (dgvSuppOrders.SelectedRows[0].Cells["Paid"].Value.ToString() == "False")
            {
                tabControlOrder.SelectedIndex = 2;

                //Supplier Order Details
                            drSuppOrder = dsLloydsPharmacy.Tables["SupplierOrder"].Rows.Find(dgvSuppOrders.SelectedRows[0].Cells[0].Value);
                            txtEditOrderInfo.Text = drSuppOrder["SupplierOrderID"].ToString();
                            txtEditSuppIDInfo.Text = drSuppOrder["SupplierID"].ToString();
                            txtEditOrderDate.Text = drSuppOrder["OrderDate"].ToString();
                            txtEditDespatchDate.Text = drSuppOrder["DispatchDate"].ToString();
                            txtEditDeliveredDate.Text = drSuppOrder["DeliveryDate"].ToString();

                            //Stock Details linked to the Supplier selected
                            sqlStockAvailable = @"Select * FROM Stock WHERE SupplierID  = '" + txtEditSuppIDInfo.Text + "'";
                            daStockAvailable = new SqlDataAdapter(sqlStockAvailable, conn);
                            daStockAvailable.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
                            daStockAvailable.Fill(dsLloydsPharmacy, "Stock");
                            lstEditStockAvailable.DataSource = dsLloydsPharmacy.Tables["Stock"];
                            lstEditStockAvailable.DisplayMember = "StockDesc";
                            lstEditStockAvailable.ValueMember = "StockID";

                            sqlSuppOrderDetails = @"SELECT sod.SupplierOrderID, sod.QTYOrdered, s.StockID, s.StockDesc
                                  FROM SupplierOrderDetails sod
                                  JOIN Stock s ON sod.StockID = s.StockID
                                  WHERE SupplierOrderID LIKE '" + txtEditOrderInfo.Text + "'" +
                                                                "ORDER BY StockID ASC";
                            daSuppOrderDetails = new SqlDataAdapter(sqlSuppOrderDetails, conn);
                            daSuppOrderDetails.FillSchema(dsLloydsPharmacy, SchemaType.Source, "StockOrdered");
                            daSuppOrderDetails.Fill(dsLloydsPharmacy, "StockOrdered");

                            foreach (DataRow dr in dsLloydsPharmacy.Tables["StockOrdered"].Rows)
                            {
                                ListViewItem item = new ListViewItem(dr["SupplierOrderID"].ToString());
                                item.SubItems.Add(dr["StockID"].ToString());
                                item.SubItems.Add(dr["StockDesc"].ToString());
                                item.SubItems.Add(dr["QTYOrdered"].ToString());
                                lvEditOrderItems.Items.Add(item);
                            }

                            dsLloydsPharmacy.Tables["StockOrdered"].Clear();
            }
            else
                MessageBox.Show("Can't Edit an Order thats been paid for!");

        }
        private void btnOrderDisDel_Click(object sender, EventArgs e)
        {
            //must delete the supplier order details alongside the order itself.

            if (dgvSuppOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an Order you wish to delete.", "Select Order!");
            }
            else
            {
               dsLloydsPharmacy.Tables["SupplierOrder"].Rows.Find(dgvSuppOrders.SelectedRows[0].Cells["Paid"].Value);
                //int paid = int.Parse(drSupplier["Paid"].ToString());
                //validates if its paid or not (cant delete and order thats not paid for)
                    
                    if (dgvSuppOrders.SelectedRows[0].Cells["Paid"].Value.ToString() == "False")
                    {
                    if (MessageBox.Show("Are you sure you want to delete Order No: " + "lvSuppOrderDetails.SelectedItems[0].ToString()" + "?", "Delete Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        object[] primaryKey = new object[2];
                        var orderItem = lvSuppOrderDetails.Items[0];

                        foreach (ListViewItem item in lvSuppOrderDetails.Items)
                        {

                            primaryKey[0] = item.SubItems[0].Text;
                            primaryKey[1] = item.SubItems[1].Text;
                            
                            SqlCommand cmdDelSuppOrderDetails = new SqlCommand();
                            SqlConnection con = new SqlConnection(connStr);
                            cmdDelSuppOrderDetails.CommandText = @"Delete FROM SupplierOrderDetails WHERE SupplierOrderID = @SuppID AND StockID = @StockID";
                            con.Open();
                            cmdDelSuppOrderDetails.Connection = con;
                            cmdDelSuppOrderDetails.Parameters.AddWithValue("@SuppID", primaryKey[0]);
                            cmdDelSuppOrderDetails.Parameters.AddWithValue("@StockID", primaryKey[1]);
                            cmdDelSuppOrderDetails.ExecuteNonQuery();
                            con.Close();
                            lvSuppOrderDetails.Items.Remove(orderItem);


                        }
                        if (lvSuppOrderDetails.SelectedItems.Count == 0)
                        {
                            primaryKey[0] = orderItem.SubItems[0].Text;

                            SqlCommand cmdDelSuppPaymentDetails = new SqlCommand();
                            SqlConnection con = new SqlConnection(connStr);
                            cmdDelSuppPaymentDetails.CommandText = @"Delete FROM SupplierPaymentDetails WHERE SupplierOrderID = @SuppOrderID ";
                            con.Open();
                            cmdDelSuppPaymentDetails.Connection = con;
                            cmdDelSuppPaymentDetails.Parameters.AddWithValue("@SuppOrderID", primaryKey[0]);
                            cmdDelSuppPaymentDetails.ExecuteNonQuery();
                            con.Close();

                            SqlCommand cmdDelSuppOrder = new SqlCommand();
                            SqlConnection con2 = new SqlConnection(connStr);
                            cmdDelSuppOrder.CommandText = @"Delete FROM SupplierOrder WHERE SupplierOrderID = @SuppID ";
                            con2.Open();
                            cmdDelSuppOrder.Connection = con2;
                            cmdDelSuppOrder.Parameters.AddWithValue("@SuppID", primaryKey[0]);
                            cmdDelSuppOrder.ExecuteNonQuery();
                            con2.Close();
                            dsLloydsPharmacy.Tables["SupplierOrder"].Clear();
                            dgvSuppOrders.Refresh();
                            SuppOrders();
                            MessageBox.Show("Order Deleted!", "Success!");
                        }

                    }
                    }
                    else
                        MessageBox.Show("You can't Delete an Orders thats already been Paid for!", "Error! Paid Order!");


            }
        }
        private void btnOrderDisPayment_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 3;

        }
        private void btnOrderDisInvoice_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 4;

        }
        private void btnOrderDisExit_Click(object sender, EventArgs e)
        {

        }

        //ADD ORDER 
        private void lstSuppliers_Click(object sender, EventArgs e)
        {
          
            dsLloydsPharmacy.Tables["Stock"].Clear();
            sqlStockAvailable = @"Select * FROM Stock WHERE SupplierID LIKE '" + lstSuppliers.SelectedValue + "'";
            daStockAvailable = new SqlDataAdapter(sqlStockAvailable, conn);
            daStockAvailable.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Stock");
            daStockAvailable.Fill(dsLloydsPharmacy, "Stock");
            lstStockAvailable.DataSource = dsLloydsPharmacy.Tables["Stock"];
            lstStockAvailable.DisplayMember = "StockDesc";
            lstStockAvailable.ValueMember = "StockID";

            drSupplier = dsLloydsPharmacy.Tables["Supplier"].Rows.Find(lstSuppliers.SelectedValue.ToString());
            txtInfoSuppID.Text = drSupplier["SupplierID"].ToString();
            txtInfoSuppName.Text = drSupplier["SupplierName"].ToString();
            txtInfoSuppStreet.Text = drSupplier["SupplierStreet"].ToString();
            txtInfoSuppTown.Text = drSupplier["SupplierTown"].ToString();
            txtInfoSuppCounty.Text = drSupplier["SupplierCounty"].ToString();
            txtInfoSuppPostcode.Text = drSupplier["SupplierPostcode"].ToString();
            txtInfoSuppTelNo.Text = drSupplier["SupplierTelNo"].ToString();

            clearStockInfo();

        }
        private void lstStockAvailable_Click(object sender, EventArgs e)
        {
            drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(lstStockAvailable.SelectedValue.ToString());
            txtInfoStockID.Text = drStock["StockID"].ToString();
            txtInfoStockDesc.Text = drStock["StockDesc"].ToString();
            txtInfoStockTypeID.Text = drStock["StockTypeID"].ToString();
            txtInfoQTYInStock.Text = drStock["QTYInStock"].ToString();
            txtInfoStockPrice.Text = drStock["StockPrice"].ToString();
            lstSuppliers.Enabled = false;
        }
     
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exits = false;

            if (lstSuppliers.SelectedIndex == -1)
                MessageBox.Show("Please Select a Supplier!", "Supplier");
            else if (lstStockAvailable.SelectedIndex == -1)
                MessageBox.Show("Please Select a Stock Item!", "Stock");
            else if (cmbAddItemQTY.Text == "")
                MessageBox.Show("Please Enter Quantity!", "Quantity");
            else
            {
                foreach(ListViewItem item in lvBasket.Items)
                {
                    if(item.SubItems[0].Text == lstSuppliers.Text || item.SubItems[1].Text == lstStockAvailable.Text)
                    {
                        MessageBox.Show("You have already added this to your basket!", "Basket");
                        exits = true;

                        break;
                    }
                }

                if(!exits)
                {
                   
                    if(ok)
                    {
                   
                                ListViewItem item = new ListViewItem(lstStockAvailable.SelectedValue.ToString());
                                item.SubItems.Add(lstStockAvailable.Text);
                                item.SubItems.Add(cmbAddItemQTY.Text);
                                lvBasket.Items.Add(item);
                      
                    }

                }
            }
        }
        private void btnRemoveFromBasket_Click(object sender, EventArgs e)
        {
            if(lvBasket.SelectedItems.Count != 0)
            {
                var item = lvBasket.SelectedItems[0];
                lvBasket.Items.Remove(item);
            }
        }
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {

            DataRow drSuppOrders;
            string SuppOrderNo;

            int noRows = dsLloydsPharmacy.Tables["SupplierOrder"].Rows.Count;
            //not sure if this is correct -- mainly the suppordernum to string
            drSuppOrders = dsLloydsPharmacy.Tables["SupplierOrder"].Rows[noRows - 1];
            SuppOrderNo = txtSuppOrderNo.Text.ToString();

            if (lstSuppliers.SelectedIndex == -1)
                MessageBox.Show("Please Select a Supplier!", "Supplier");
            else if (lstStockAvailable.SelectedIndex == -1)
                MessageBox.Show("Please Select a Stock Item!", "Stock");
            else if (cmbAddItemQTY.Text == "")
                MessageBox.Show("Please Enter Quantity!", "Quantity");
            else if(lvBasket.Items.Count == 0)
                MessageBox.Show("Please Add an Item to your Basket!", "Basket");
            else
            {
                DateTime delivery = DateTime.Today;
                delivery = delivery.AddDays(5);

                drSuppOrders = dsLloydsPharmacy.Tables["SupplierOrder"].NewRow();
                drSuppOrders["SupplierOrderID"] = SuppOrderNo;
                drSuppOrders["SupplierID"] = txtInfoSuppID.Text;
                drSuppOrders["OrderDate"] = DateTime.Today;
                drSuppOrders["DispatchDate"] = DateTime.Today; 
                drSuppOrders["DeliveryDate"] = delivery;
                drSuppOrders["Paid"] = 0;// 0 means not paid


                //adds to the database
                dsLloydsPharmacy.Tables["SupplierOrder"].Rows.Add(drSuppOrders);
                cmdBSuppOrder.GetInsertCommand();
                daSuppOrders.Update(dsLloydsPharmacy, "SupplierOrder");
                
                foreach(ListViewItem item in lvBasket.Items)
                {

                  SqlCommand cmdNewSuppOrder = new SqlCommand();
                    SqlConnection con = new SqlConnection(connStr);
                    cmdNewSuppOrder.CommandText = @" INSERT INTO SupplierOrderDetails(SupplierOrderID, StockID, QTYOrdered)
                                                    VALUES (@SupplierOrderID, @StockID, @QTYOrdered)";
                    cmdNewSuppOrder.Connection = con;
                    con.Open();
                    cmdNewSuppOrder.Parameters.AddWithValue("@SupplierOrderID", txtSuppOrderNo.Text);
                    cmdNewSuppOrder.Parameters.AddWithValue("@StockID", item.SubItems[0].Text);
                    cmdNewSuppOrder.Parameters.AddWithValue("@QTYOrdered", int.Parse(item.SubItems[2].Text));
                    cmdNewSuppOrder.ExecuteNonQuery();
                    con.Close();

                }

                MessageBox.Show("Order Submitted!");
               
                disableAddOrder();
                tabControlOrder.SelectedIndex = 0;
            }

        }
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Order No: " + txtSuppOrderNo.Text + "?", "Cancel Order", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                clearAddOrder();
                tabControlOrder.SelectedIndex = 0;
            }
        }

        //Navigational buttons
        private void btnOrdAddDis_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;

        }
        private void btnOrdAddEdit_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 2;
        }
        private void btnOrdAddDel_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;
            MessageBox.Show("Select an Order you wish to Delete.", "Delete Order");
        }
        private void btnOrdAddPayment_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 3;
        }
        private void btnOrdAddInvoice_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 4;
        }
        private void btnOrdAddExit_Click(object sender, EventArgs e)
        {

        }


        //E D I T  S E C T I O N 
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            enableEditOrder();


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
                foreach (ListViewItem item in lvEditOrderItems.Items)
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

                        SqlCommand cmdNewSuppOrder = new SqlCommand();
                        SqlConnection con = new SqlConnection(connStr);
                        cmdNewSuppOrder.CommandText = @"INSERT INTO SupplierOrderDetails(SupplierOrderID, StockID, QTYOrdered) VALUES (@SupplierOrderID, @StockID, @QTYOrdered)";
                        cmdNewSuppOrder.Connection = con;
                        con.Open();
                        cmdNewSuppOrder.Parameters.AddWithValue("@SupplierOrderID", txtEditOrderInfo.Text);
                        cmdNewSuppOrder.Parameters.AddWithValue("@StockID", lstEditStockAvailable.SelectedValue.ToString());
                        cmdNewSuppOrder.Parameters.AddWithValue("@QTYOrdered", int.Parse(cmbEditItemQTY.Text));
                        cmdNewSuppOrder.ExecuteNonQuery();
                        con.Close();


                        ListViewItem newitem = new ListViewItem(txtEditOrderInfo.Text);
                        newitem.SubItems.Add(lstEditStockAvailable.SelectedValue.ToString());
                        newitem.SubItems.Add(lstEditStockAvailable.Text);
                        newitem.SubItems.Add(cmbEditItemQTY.Text);
                        lvEditOrderItems.Items.Add(newitem);
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
                var orderItem = lvEditOrderItems.SelectedItems[0];

                //removed foreach as it removed all the items instead of the selected one - will finish tomorrow.
                primaryKey[0] = orderItem.SubItems[0].Text;
                primaryKey[1] = orderItem.SubItems[1].Text;
                SqlCommand cmdDelSuppOrderDetails = new SqlCommand();
                SqlConnection con = new SqlConnection(connStr);
                cmdDelSuppOrderDetails.CommandText = @"DELETE FROM SupplierOrderDetails WHERE SupplierOrderID = @SupplierOrderID AND StockID = @StockID";
                con.Open();
                cmdDelSuppOrderDetails.Connection = con;
                cmdDelSuppOrderDetails.Parameters.AddWithValue("@SupplierOrderID", primaryKey[0]);
                cmdDelSuppOrderDetails.Parameters.AddWithValue("@StockID", primaryKey[1]);
                cmdDelSuppOrderDetails.ExecuteNonQuery();
                con.Close();
                lvEditOrderItems.Items.Remove(orderItem);
                lvEditOrderItems.Refresh();
            }
            MessageBox.Show("Item Removed!");

        }
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            disableEditOrder();
            MessageBox.Show("Order Updated!", "Updated");

        }
        private void lstEditStockAvailable_Click(object sender, EventArgs e)
        {
            drStock = dsLloydsPharmacy.Tables["Stock"].Rows.Find(lstEditStockAvailable.SelectedValue.ToString());
            txtEditItemStockID.Text = drStock["StockID"].ToString();
            txtEditItemSuppID.Text = drStock["StockDesc"].ToString();
            txtEditItemOrdDate.Text = drStock["StockTypeID"].ToString();
            txtEditItemDesDate.Text = drStock["QTYInStock"].ToString();
            txtEditItemDelDate.Text = drStock["StockPrice"].ToString();
        }

        //navigation buttons
        private void btnOrdEditDis_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;

        }
        private void btnOrdEditAdd_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 1;

        }
        private void btnOrdEditDel_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;
            MessageBox.Show("Select an Order you wish to Delete.", "Delete Order");
        }
        private void btnOrdEditPayment_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 3;

        }
        private void btnOrdEditInvoice_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 4;

        }
        private void btnOrdEditExit_Click(object sender, EventArgs e)
        {

        }


       
        // P A Y M E N T S  S E C T I O N
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            //how would i update the paid option in the supplierorder? IT doesnt have a foreign key to the supplierpayments section.
            string findSuppID = lvUnpaidOrders.SelectedItems[0].SubItems[1].Text;
            string findSuppOrderID = lvUnpaidOrders.SelectedItems[0].SubItems[3].Text;
            var orderItem = lvUnpaidOrders.SelectedItems[0];

            if (cmbPaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Order!", "Order Payment");

            }
            else
            {
                ////Updates the SupplierOrder 'Paid' To true(1)
                SqlCommand cmdUpdatePayment = new SqlCommand();
                SqlConnection con = new SqlConnection(connStr);
                cmdUpdatePayment.CommandText = @"UPDATE SupplierOrder
                                                 SET Paid = 'true'
                                                 WHERE SupplierOrderID ='" + orderItem.SubItems[3].Text + "'";
                cmdUpdatePayment.Connection = con;
                con.Open();
                cmdUpdatePayment.ExecuteNonQuery();
                con.Close();
                daSuppOrders.Update(dsLloydsPharmacy, "SupplierOrder");


                //Supplier Payments inputted values
                drSuppPayments = dsLloydsPharmacy.Tables["SupplierPayments"].NewRow();
                drSuppPayments["SupplierPaymentID"] = txtPaymentID.Text;
                drSuppPayments["SupplierID"] = findSuppID;
                drSuppPayments["PaymentDate"] = DateTime.Today;
                dsLloydsPharmacy.Tables["SupplierPayments"].Rows.Add(drSuppPayments);
                daSuppPayments.Update(dsLloydsPharmacy, "SupplierPayments");

                //Supplier Payment details inputted values - Both tables are linked.
                drSuppPaymentDetails = dsLloydsPharmacy.Tables["SupplierPaymentDetails"].NewRow();
                drSuppPaymentDetails["SupplierPaymentID"] = txtPaymentID.Text;
                drSuppPaymentDetails["SupplierOrderID"] = findSuppOrderID;
                drSuppPaymentDetails["PaymentTypeID"] = cmbPaymentType.SelectedValue.ToString();
                dsLloydsPharmacy.Tables["SupplierPaymentDetails"].Rows.Add(drSuppPaymentDetails);
                daSuppPaymentDetails.Update(dsLloydsPharmacy, "SupplierPaymentDetails");

                ListViewItem newitem = new ListViewItem(lvUnpaidOrders.SelectedItems[0].SubItems[0].Text);
                newitem.SubItems.Add(findSuppID);
                newitem.SubItems.Add(drSuppPayments["PaymentDate"].ToString());
                newitem.SubItems.Add(txtPaymentID.Text);
                newitem.SubItems.Add(cmbPaymentType.SelectedValue.ToString());
                newitem.SubItems.Add(cmbPaymentType.Text);
                lvPaidOrders.Items.Add(newitem);
                lvUnpaidOrders.Items.Remove(orderItem);
                MessageBox.Show("Item Added!", "Success!");
                lvUnpaidOrders.Refresh();
                lvPaidOrders.Refresh();

                

            }


        }
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel Payment " + txtPaymentID + "?", "Cancel Payment", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                clearPayments();
                tabControlOrder.SelectedIndex = 0;
            }
        }
        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 4;

        }
        //navigation
        private void btnOrdPayDis_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;

        }
        private void btnOrdPayAdd_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 1;

        }
        private void btnOrdPayEdit_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 2;

        }
        private void btnOrdPayDel_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;
            MessageBox.Show("Select an Order you wish to Delete.", "Delete Order");


        }
        private void btnOrdPayInvoice_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 4;

        }
        private void btnOrdPayExit_Click(object sender, EventArgs e)
        {

        }


        //I N V O I C E  S E C T I O N
        private void btnMakeInvoicePayment_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 3;

        }
        //navigation
        private void btnOrdInvDis_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;

        }
        private void btnOrdInvAdd_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 1;

        }
        private void btnOrdInvEdit_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 2;

        }
        private void btnOrdInvDel_Click(object sender, EventArgs e)
        {
            tabControlOrder.SelectedIndex = 0;
            MessageBox.Show("Select an Order you wish to Delete.", "Delete Order");


        }
        private void btnOrdInvPayment_Click(object sender, EventArgs e)
        {

        }
        private void btnOrdInvExit_Click(object sender, EventArgs e)
        {

        }


        //R E P O R T S
        //will do in class. - made codde in class - will also do viewer in class.
        private void crvReports_Load(object sender, EventArgs e)
        {







         



        }

       



        //O T H E R  F U N C T I O N S
        private void getNumber(int noRows)
        {
            //incrementing a string for the ID's VV
            drSupplier = dsLloydsPharmacy.Tables["Supplier"].Rows[noRows - 1];
            txtAddSuppID.Text = "SUP" + ((Convert.ToInt32(drSupplier["SupplierID"].ToString().Substring(3, 3))) + 1).ToString();
        }
        private void getSuppOrderNum(int noRows)
        {
            drSuppOrder = dsLloydsPharmacy.Tables["SupplierOrder"].Rows[noRows - 1];
            txtSuppOrderNo.Text = "SO" + ((Convert.ToInt32(drSuppOrder["SupplierOrderID"].ToString().Substring(2, 3))) + 1).ToString();
        }
        private void getSuppPaymentNum(int noRows)
        {
            drSuppPayments = dsLloydsPharmacy.Tables["SupplierPayments"].Rows[noRows - 1];
            txtPaymentID.Text = "SP" + ((Convert.ToInt32(drSuppPayments["SupplierPaymentID"].ToString().Substring(2, 3))) + 1).ToString();
        }

        //Tab controls and clear methods
        void ClearAddForm()
        {
            txtEditSuppID.Clear();
            txtEditSuppName.Clear();
            txtEditSuppStreet.Clear();
            txtEditSuppTown.Clear();
            txtEditSuppCounty.Clear();
            txtEditSuppPostcode.Clear();
            txtEditSuppTelno.Clear();
        }
        void enableEdit()
        {
            txtEditSuppID.Enabled = false;
            txtEditSuppName.Enabled = true;
            txtEditSuppStreet.Enabled = true;
            txtEditSuppTown.Enabled = true;
            txtEditSuppCounty.Enabled = true;
            txtEditSuppPostcode.Enabled = true;
            txtEditSuppTelno.Enabled = true;
        }
        void disableEdit()
        {
            txtEditSuppID.Enabled = false;
            txtEditSuppName.Enabled = false;
            txtEditSuppStreet.Enabled = false;
            txtEditSuppTown.Enabled = false;
            txtEditSuppCounty.Enabled = false;
            txtEditSuppPostcode.Enabled = false;
            txtEditSuppTelno.Enabled = false;
        }
        void SuppInfoClear()
        {
            txtDisSuppIDData.Text = "";
            txtDisSuppNameData.Text = "";
            txtDisSuppStreetData.Text = "";
            txtDisTownData.Text = "";
            txtDisCountyData.Text = "";
            txtDisPostcodeData.Text = "";
            txtDisTelNoData.Text = "";
        }

        //Order form
        //add
        void clearAddOrder()
        {
            lstSuppliers.Enabled = true;
            lstSuppliers.SelectedIndex = -1;
            dsLloydsPharmacy.Tables["Stock"].Clear();
            cmbAddItemQTY.SelectedIndex = -1;
            lvBasket.Items.Clear();

            clearStockInfo();
            clearSuppInfo();

        }
        void clearStockInfo()
        {
            txtInfoStockID.Clear();
            txtInfoStockDesc.Clear();
            txtInfoStockTypeID.Clear();
            txtInfoQTYInStock.Clear();
            txtInfoStockPrice.Clear();
        }
        void clearSuppInfo()
        {

            txtInfoSuppID.Clear();
            txtInfoSuppName.Clear();
            txtInfoSuppStreet.Clear();
            txtInfoSuppTown.Clear();
            txtInfoSuppCounty.Clear();
            txtInfoSuppPostcode.Clear();
            txtInfoSuppTelNo.Clear();
        }
        void disableAddOrder()
        {
            lstStockAvailable.Enabled = false;
            cmbAddItemQTY.Enabled = false;
            btnAddToBasket.Enabled = false;
            btnRemoveFromBasket.Enabled = false;
            lvBasket.Enabled = false;
            btnSubmitOrder.Enabled = false;
        }
        void enableAddOrder()
        {
            lstSuppliers.Enabled = true;
            lstStockAvailable.Enabled = true;
            cmbAddItemQTY.Enabled = true;
            btnAddToBasket.Enabled = true;
            btnRemoveFromBasket.Enabled = true;
            lvBasket.Enabled = true;
            btnSubmitOrder.Enabled = true;
        }

        //edit
        void clearEditOrder()
        {
            txtEditOrderInfo.Clear();
            txtEditSuppIDInfo.Clear();
            txtEditOrderDate.Clear();
            txtEditDespatchDate.Clear();
            txtEditDeliveredDate.Clear();
            cmbEditItemQTY.SelectedIndex = -1;
            lvEditOrderItems.Items.Clear();
            txtEditItemStockID.Clear();
            txtEditItemSuppID.Clear();
            txtEditItemOrdDate.Clear();
            txtEditItemDesDate.Clear();
            txtEditItemDelDate.Clear();

            dsLloydsPharmacy.Tables["Stock"].Clear();

        }
        void disableEditOrder()
        {
            pnlEditOrderInfo.Enabled = false;
            pnlItemDetails.Enabled = false;
            lvEditOrderItems.Enabled = false;
            pnlItemQTY.Enabled = false;
            lstEditStockAvailable.Enabled = false;
            btnUpdateOrder.Enabled = false;
            btnRemoveFromOrder.Enabled = false;
         

        }
        void enableEditOrder()
        {
            pnlEditOrderInfo.Enabled = true;
            pnlItemDetails.Enabled = true;
            lvEditOrderItems.Enabled = true;
            pnlItemQTY.Enabled = true;
            lstEditStockAvailable.Enabled = true;
            btnUpdateOrder.Enabled = true;
            btnRemoveFromOrder.Enabled = true;

        }

        private void btnDisOrders_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedIndex = 3;

        }

        //payments
        void clearPayments()
        {
            cmbPaymentType.SelectedIndex = -1;
        }

        void SuppOrders()
        {
            
                sqlSuppOrders = @"Select * FROM SupplierOrder ORDER BY SupplierOrderID ASC";
                daSuppOrders.FillSchema(dsLloydsPharmacy, SchemaType.Source, "SupplierOrder");
                daSuppOrders.Fill(dsLloydsPharmacy, "SupplierOrder");
            
         

        }

        void orderInvoices()
        {
            sqlUnpaidInvoices = @"SELECT s.SupplierID,s.SupplierName, so.Paid,so.SupplierOrderID, so.OrderDate 
                                            FROM Supplier s 
                                            JOIN SupplierOrder so ON s.SupplierID = so.SupplierID 
                                            WHERE so.Paid = 'false'  
                                            ORDER BY so.OrderDate ASC";
            daPaidInvoices = new SqlDataAdapter(sqlUnpaidInvoices, conn);
            daPaidInvoices.FillSchema(dsLloydsPharmacy, SchemaType.Source, "UnpaidInvoice");
            daPaidInvoices.Fill(dsLloydsPharmacy, "UnpaidInvoice");

            foreach (DataRow dr in dsLloydsPharmacy.Tables["UnPaidInvoice"].Rows)
            {
                ListViewItem item = new ListViewItem(dr["SupplierName"].ToString());
                item.SubItems.Add(dr["SupplierID"].ToString());//hidden in the program - ~love sean xx
                item.SubItems.Add(dr["Paid"].ToString());
                item.SubItems.Add(dr["SupplierOrderID"].ToString());
                item.SubItems.Add(dr["OrderDate"].ToString());
                lvUnpaidInvoices.Items.Add(item);

            }


            sqlPaidInvoices = @"SELECT s.SupplierID, s.SupplierName, sp.PaymentDate, sp.SupplierPaymentID, spd.SupplierOrderID,pt.PaymentTypeID, pt.PaymentTypeDesc, so.Paid
	                                        FROM Supplier s
                                            JOIN SupplierOrder so ON s.SupplierID = so.SupplierID 
	                                        JOIN SupplierPayments sp ON s.SupplierID = sp.SupplierID
	                                        JOIN SupplierPaymentDetails spd ON sp.SupplierPaymentID = spd.SupplierPaymentID
	                                        JOIN PaymentType pt ON spd.PaymentTypeID = pt.PaymentTypeID
                                            WHERE so.Paid = 'true'
	                                        ORDER BY sp.PaymentDate ASC";
            daUnpaidInvoices = new SqlDataAdapter(sqlPaidInvoices, conn);
            daUnpaidInvoices.FillSchema(dsLloydsPharmacy, SchemaType.Source, "PaidInvoice");
            daUnpaidInvoices.Fill(dsLloydsPharmacy, "PaidInvoice");

            foreach (DataRow dr in dsLloydsPharmacy.Tables["PaidInvoice"].Rows)
            {
                ListViewItem item = new ListViewItem(dr["SupplierName"].ToString());
                item.SubItems.Add(dr["SupplierID"].ToString());//hidden in the program - ~love sean xx
                item.SubItems.Add(dr["PaymentDate"].ToString());
                item.SubItems.Add(dr["SupplierPaymentID"].ToString());
                item.SubItems.Add(dr["PaymentTypeID"].ToString());
                item.SubItems.Add(dr["PaymentTypeDesc"].ToString());
                lvPaidInvoices.Items.Add(item);
            }
        }

        void orderPayments()
        {
            sqlUnpaidOrders = @"SELECT s.SupplierID,s.SupplierName, so.Paid,so.SupplierOrderID, so.OrderDate 
                                            FROM Supplier s 
                                            JOIN SupplierOrder so ON s.SupplierID = so.SupplierID 
                                            WHERE so.Paid = 0  
                                            ORDER BY so.OrderDate ASC";
            daUnpaidOrders = new SqlDataAdapter(sqlUnpaidOrders, conn);
            daUnpaidOrders.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Unpaid");
            daUnpaidOrders.Fill(dsLloydsPharmacy, "Unpaid");

            foreach (DataRow dr in dsLloydsPharmacy.Tables["Unpaid"].Rows)
            {
                ListViewItem item = new ListViewItem(dr["SupplierName"].ToString());
                item.SubItems.Add(dr["SupplierID"].ToString());//hidden in the program - ~love sean xx
                item.SubItems.Add(dr["Paid"].ToString());
                item.SubItems.Add(dr["SupplierOrderID"].ToString());
                item.SubItems.Add(dr["OrderDate"].ToString());
                lvUnpaidOrders.Items.Add(item);

            }


            sqlPaidOrders = @"	SELECT s.SupplierID, s.SupplierName, sp.PaymentDate, sp.SupplierPaymentID, spd.SupplierOrderID, pt.PaymentTypeID, pt.PaymentTypeDesc, so.Paid
	                                        FROM Supplier s
                                            JOIN SupplierOrder so ON s.SupplierID = so.SupplierID 
	                                        JOIN SupplierPayments sp ON s.SupplierID = sp.SupplierID
	                                        JOIN SupplierPaymentDetails spd ON sp.SupplierPaymentID = spd.SupplierPaymentID
	                                        JOIN PaymentType pt ON spd.PaymentTypeID = pt.PaymentTypeID
                                            WHERE so.Paid = 1
	                                        ORDER BY sp.PaymentDate ASC";
            daPaidOrders = new SqlDataAdapter(sqlPaidOrders, conn);
            daPaidOrders.FillSchema(dsLloydsPharmacy, SchemaType.Source, "Paid");
            daPaidOrders.Fill(dsLloydsPharmacy, "Paid");

            foreach (DataRow dr in dsLloydsPharmacy.Tables["Paid"].Rows)
            {
                ListViewItem item = new ListViewItem(dr["SupplierName"].ToString());
                item.SubItems.Add(dr["SupplierID"].ToString());//hidden in the program - ~love sean xx
                item.SubItems.Add(dr["PaymentDate"].ToString());
                item.SubItems.Add(dr["SupplierPaymentID"].ToString());
                item.SubItems.Add(dr["PaymentTypeID"].ToString());
                item.SubItems.Add(dr["PaymentTypeDesc"].ToString());
                lvPaidOrders.Items.Add(item);

            }
            txtPaymentDate.Text = DateTime.Now.ToString();

            dsLloydsPharmacy.Tables["Paid"].Clear();
            dsLloydsPharmacy.Tables["Unpaid"].Clear();


        }
        //Headings for DGV
        void dgvSupplierHeadings()
        {
            dgvSuppliers.Columns[0].HeaderText = "Supplier ID";
            dgvSuppliers.Columns[1].HeaderText = "Supplier Name";
            dgvSuppliers.Columns[2].HeaderText = "Street";
            dgvSuppliers.Columns[3].HeaderText = "Town";
            dgvSuppliers.Columns[4].HeaderText = "County";
            dgvSuppliers.Columns[5].HeaderText = "Postcode";
            dgvSuppliers.Columns[6].HeaderText = "Telephone #";

        }
        void dgvOrderHeadings()
        {
            dgvSuppOrders.Columns[0].HeaderText = "Supplier Order ID";
            dgvSuppOrders.Columns[1].HeaderText = "Supplier ID";
            dgvSuppOrders.Columns[2].HeaderText = "Order Date";
            dgvSuppOrders.Columns[3].HeaderText = "Dispatch Date";
            dgvSuppOrders.Columns[4].HeaderText = "Delivery Date";
        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
        }



        



        ///////////////////MOUSE HOVER ICONS AND PROPERTIES\\\\\\\\\\\\\\\\\\\\\\\\\\
        // D I S P L A Y  T A B 
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
            btnDisExit.ImageIndex = 6;
        }

     

        private void btnDisExit_MouseLeave(object sender, EventArgs e)
        {
            btnDisExit.Text = "Exit";
            btnDisExit.ImageIndex = -1;
        }

      

        //A D D  T A B
        private void btnAddDis_MouseEnter(object sender, EventArgs e)
        {
            btnAddDis.Text = "";
            btnAddDis.ImageIndex = 7;
        }

       
        private void btnAddDis_MouseLeave(object sender, EventArgs e)
        {
            btnAddDis.Text = "Display";
            btnAddDis.ImageIndex = -1;
        }

        private void btnAddAddSupp_MouseEnter(object sender, EventArgs e)
        {
            btnAddAddSupp.Text = "";
            btnAddAddSupp.ImageIndex = 1;
        }

        private void btnAddAddSupp_MouseLeave(object sender, EventArgs e)
        {
            btnAddAddSupp.Text = "Add";
            btnAddAddSupp.ImageIndex = -1;
        }

        private void btnAddEditSupp_MouseEnter(object sender, EventArgs e)
        {
            btnAddEditSupp.Text = "";
            btnAddEditSupp.ImageIndex = 2;
        }

        private void btnAddEditSupp_MouseLeave(object sender, EventArgs e)
        {
            btnAddEditSupp.Text = "Edit";
            btnAddEditSupp.ImageIndex = -1;
        }

        private void btnAddDelSupp_MouseEnter(object sender, EventArgs e)
        {
            btnAddDelSupp.Text = "";
            btnAddDelSupp.ImageIndex = 4;
        }

        private void btnAddDelSupp_MouseLeave(object sender, EventArgs e)
        {

            btnAddDelSupp.Text = "Delete";
            btnAddDelSupp.ImageIndex = -1;
        }

        private void btnAddCancelSupp_MouseEnter(object sender, EventArgs e)
        {
            btnAddCancelSupp.Text = "";
            btnAddCancelSupp.ImageIndex = 5;
        }

        private void btnAddCancelSupp_MouseLeave(object sender, EventArgs e)
        {

            btnAddCancelSupp.Text = "Cancel";
            btnAddCancelSupp.ImageIndex = -1;
        }

        // E D I T  T A B
        private void btnEditDis_MouseEnter(object sender, EventArgs e)
        {
            btnEditDis.Text = "";
            btnEditDis.ImageIndex = 7;
        }

        private void btnEditDis_MouseLeave(object sender, EventArgs e)
        {

            btnEditDis.Text = "Display";
            btnEditDis.ImageIndex = -1;
        }

        private void btnEditAddSupp_MouseEnter(object sender, EventArgs e)
        {
            btnEditAddSupp.Text = "";
            btnEditAddSupp.ImageIndex = 1;
        }

        private void btnEditAddSupp_MouseLeave(object sender, EventArgs e)
        {

            btnEditAddSupp.Text = "Add";
            btnEditAddSupp.ImageIndex = -1;
        }

        private void btnEditEditSupp_MouseEnter(object sender, EventArgs e)
        {
            btnEditEditSupp.Text = "";
            btnEditEditSupp.ImageIndex = 2;
        }

        private void btnEditEditSupp_MouseLeave(object sender, EventArgs e)
        {

            btnEditEditSupp.Text = "Edit";
            btnEditEditSupp.ImageIndex = -1;
        }

      

        private void btnEditDelSupp_MouseEnter(object sender, EventArgs e)
        {
            btnEditDelSupp.Text = "";
            btnEditDelSupp.ImageIndex = 4;
        }

        private void btnEditDelSupp_MouseLeave(object sender, EventArgs e)
        {

            btnEditDelSupp.Text = "Delete";
            btnEditDelSupp.ImageIndex = -1;
        }

        private void btnEditCancelEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEditCancelEdit.Text = "";
            btnEditCancelEdit.ImageIndex = 5;
        }

        private void btnEditCancelEdit_MouseLeave(object sender, EventArgs e)
        {

            btnEditCancelEdit.Text = "Cancel";
            btnEditCancelEdit.ImageIndex = -1;
        }

    
        
}

    
}
