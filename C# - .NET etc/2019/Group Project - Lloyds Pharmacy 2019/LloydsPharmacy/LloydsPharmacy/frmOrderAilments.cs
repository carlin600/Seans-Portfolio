using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LloydsPharmacy
{
    public partial class frmOrderAilments : Form
    {
        SqlDataAdapter daPatients, daMinorAilments, daStock, daNames;
        SqlConnection conn;
        DataSet dsLloydsPharmacy = new DataSet();
        SqlCommand cmdPatients, cmdMinorAilments, cmdStock;
        DataRow drPatients;
        String connStr, sqlPatients, sqlMinorAilments, sqlStock, sqlNames;

        Button[] btns = new Button[26];

        Color darkGreen = new Color();
        Color lightGreen = new Color();

        public frmOrderAilments()
        {
            InitializeComponent();
        }

        private void frmCustMinAilments_Load(object sender, EventArgs e)
        {

        }
        //Takes user back to Minor ailments form
        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMinorAilments frmminorailments = new frmMinorAilments();
            frmminorailments.Show();
            this.Hide();
        }
        //Shows Patients in patient listbox based on letter clicked
        private void buttonLetters_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // get  customer details for listbox - use selected button letter for parameter 
            String str = b.Text;

            //empty dataset table Patients
            dsLloydsPharmacy.Tables["Patients"].Clear();

            fillListboxPatients(str);

            //clear any previously selected Minor Ailments/Stock by emptying the dataset tables
            dsLloydsPharmacy.Tables["MinorAilments"].Clear();
            dsLloydsPharmacy.Tables["Stock"].Clear();

            ClearPatients();
            pnlDates.Enabled = false;
            cmbQty.Enabled = false;
            cmbQty.SelectedIndex = -1;
        }

        private void fillListboxPatients(String str)
        {
            // get all patients details for listbox - use wildcard for parameter 
            cmdPatients.Parameters["@Letter"].Value = str + "%";
            daPatients.Fill(dsLloydsPharmacy, "Patients");

            // fill listbox
            lstPatients.DataSource = dsLloydsPharmacy.Tables["Patients"];
            lstPatients.DisplayMember = "PatientName";
            lstPatients.ValueMember = "PatientID";
        }
        //Clears Patient Panel details
        private void ClearPatients()
        {
            lstPatients.SelectedIndex = -1;

            lblCurrentPatID.Text = "";
            lblName.Text = "";
            lblTelNo.Text = "";
            lblEmail.Text = "";
            lblAddress.Text = "";
            lblPostcode.Text = "";
        }

        //Shows Minor Ailment IDs in Minor Ailments listbox
        private void lstPatients_Click(object sender, EventArgs e)
        {
            dsLloydsPharmacy.Tables["MinorAilments"].Clear();
            dsLloydsPharmacy.Tables["Stock"].Clear();

            cmdMinorAilments.Parameters["@PatID"].Value = lstPatients.SelectedValue;

            daMinorAilments.Fill(dsLloydsPharmacy, "MinorAilments");

            lstMinAilments.DataSource = dsLloydsPharmacy.Tables["MinorAilments"];
            lstMinAilments.DisplayMember = "MinorAilmentDesc";
            lstMinAilments.ValueMember = "MinorAilmentID";

            lstMinAilments.SelectedIndex = -1;

            drPatients = dsLloydsPharmacy.Tables["Patients"].Rows.Find(lstPatients.SelectedValue);

            lblCurrentPatID.Text = drPatients["PatientID"].ToString();
            lblName.Text = drPatients["PatientForename"].ToString() + " " + drPatients["PatientSurname"].ToString();
            lblTelNo.Text = drPatients["PatientTelNo"].ToString();
            lblEmail.Text = drPatients["PatientEmail"].ToString();
            lblAddress.Text = drPatients["PatientStreet"].ToString() + ",  " + drPatients["PatientTown"].ToString() + ",  " + drPatients["PatientCounty"].ToString();
            lblPostcode.Text = drPatients["PatientPostcode"].ToString();

            cmbQty.Enabled = false;
            cmbQty.SelectedIndex = -1;
        }

        //Shows Stock IDs in Stock listbox
        private void lstMinAilments_Click(object sender, EventArgs e)
        {
            if (lstMinAilments.Items.Count != 0)
            {
                //empty dataset table Stock
                dsLloydsPharmacy.Tables["Stock"].Clear();

                // get all stock details for listbox
                cmdStock.Parameters["@AilmentID"].Value = lstMinAilments.SelectedValue.ToString();

                daStock.Fill(dsLloydsPharmacy, "Stock");

                // fill listbox
                lstStock.DataSource = dsLloydsPharmacy.Tables["Stock"];
                lstStock.DisplayMember = "StockID";
                lstStock.ValueMember = "StockID";

                lstStock.SelectedIndex = -1;
                cmbQty.Enabled = false;
            }
        }
        //Enables Qty combo box & Dates panel
        private void lstStock_Click(object sender, EventArgs e)
        {
            if (lstStock.Items.Count != 0)
            {
                cmbQty.Enabled = true;
                pnlDates.Enabled = true;
            }
        }
        //Adds Qty and Stock ID to listview box
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exits = false;

            if (lstPatients.SelectedIndex == -1)
                MessageBox.Show("Please select a Patient", "Patient");
            else if (lstMinAilments.SelectedIndex == -1)
                MessageBox.Show("Please select a Minor Ailment", "Minor Ailment");
            else if (lstStock.SelectedIndex == -1)
                MessageBox.Show("Please select a Stock ID", "Stock");
            else if (cmbQty.SelectedIndex == -1)
            {
                MessageBox.Show("Please input Quantity", "Quantity");
                cmbQty.Focus();
            }
            else
            {
                foreach (ListViewItem item in lvwStockQty.Items)
                {
                    if (item.SubItems[2].Text == lstStock.Text)
                    {
                        MessageBox.Show("Stock ID already selected for this listview.", "Add Item");
                        exits = true;
                        break;
                    }
                }

                if (!exits)
                {
                    if (ok)
                    {
                        foreach (DataRow dr in dsLloydsPharmacy.Tables["Stock"].Rows)
                        {
                            if (dr["StockID"].ToString() == lstStock.Text)
                            {
                                ListViewItem item = new ListViewItem(dr["StockID"].ToString());
                                item.SubItems.Add(cmbQty.Text);
                                item.SubItems.Add(lstStock.Text);
                                lvwStockQty.Items.Add(item);
                                MessageBox.Show("Item has been inserted.", "Add Item");
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void btnAddItem_MouseEnter(object sender, EventArgs e)
        {
            btnAddItem.ForeColor = lightGreen;
            btnAddItem.BackColor = darkGreen;
            btnAddItem.Text = "";
            btnAddItem.ImageIndex = 0;
        }
        private void btnAddItem_MouseLeave(object sender, EventArgs e)
        {
            btnAddItem.ForeColor = darkGreen;
            btnAddItem.BackColor = lightGreen;
            btnAddItem.Text = "Add Item";
            btnAddItem.ImageIndex = -1;
        }

        //Edits clicked Stock ID and Qty in Listview with new choices
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (lvwStockQty.SelectedItems.Count != 0)
            {
                var item = lvwStockQty.SelectedItems[0];
                item.SubItems[0].Text = lstStock.Text;
                item.SubItems[1].Text = cmbQty.SelectedItem.ToString();
                MessageBox.Show("Item has been Updated", "Update Item");
            }
            else
            {
                MessageBox.Show("Select a Stock from the listview", "Update Item");
            }
        }
        private void btnUpdateItem_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateItem.ForeColor = lightGreen;
            btnUpdateItem.BackColor = darkGreen;
            btnUpdateItem.Text = "";
            btnUpdateItem.ImageIndex = 1;
        }
        private void btnUpdateItem_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateItem.ForeColor = darkGreen;
            btnUpdateItem.BackColor = lightGreen;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.ImageIndex = -1;
        }

        //Deletes clicked stock id and qty from listview
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lvwStockQty.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (lvwStockQty.SelectedItems.Count != 0)
                    {
                        var item = lvwStockQty.SelectedItems[0];
                        lvwStockQty.Items.Remove(item);
                        MessageBox.Show("Item has been Deleted", "Delete Item");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Stock from the listview", "Delete Item");
            }
        }
        private void btnDeleteItem_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteItem.ForeColor = lightGreen;
            btnDeleteItem.BackColor = darkGreen;
            btnDeleteItem.Text = "";
            btnDeleteItem.ImageIndex = 2;
        }
        private void btnDeleteItem_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteItem.ForeColor = darkGreen;
            btnDeleteItem.BackColor = lightGreen;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.ImageIndex = -1;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exits = false;

            if (lstPatients.SelectedIndex == -1)
                MessageBox.Show("Please select a Patient", "Patient");
            else if (lstMinAilments.SelectedIndex == -1)
                MessageBox.Show("Please select a Minor Ailment", "Minor Ailment");
            else if (lstStock.SelectedIndex == -1)
                MessageBox.Show("Please select a Stock ID", "Stock");
            else if (cmbQty.SelectedIndex == -1)
            {
                MessageBox.Show("Please input Quantity", "Quantity");
                cmbQty.Focus();
            }
            else
            {
                if (!exits)
                {
                    if (ok)
                    {
                        foreach (DataRow dr in dsLloydsPharmacy.Tables["Stock"].Rows)
                        {
                            if (dr["StockID"].ToString() == lstStock.Text)
                            {
                                ListViewItem item = new ListViewItem(dr["StockID"].ToString());
                                item.SubItems.Add(lstMinAilments.Text);
                                item.SubItems.Add(lstPatients.Text);
                                item.SubItems.Add(cmbQty.Text);
                                item.SubItems.Add(dtpOrderDate.Text);
                                lvwOrders.Items.Add(item);
                                MessageBox.Show("Order has been Added", "Add Order");
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void btnAddOrder_MouseEnter(object sender, EventArgs e)
        {
            btnAddOrder.ForeColor = lightGreen;
            btnAddOrder.BackColor = darkGreen;
            btnAddOrder.Text = "";
            btnAddOrder.ImageIndex = 0;
        }
        private void btnAddOrder_MouseLeave(object sender, EventArgs e)
        {
            btnAddOrder.ForeColor = darkGreen;
            btnAddOrder.BackColor = lightGreen;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.ImageIndex = -1;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lvwOrders.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this order?", "Delete Order", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (lvwOrders.SelectedItems.Count != 0)
                    {
                        var item = lvwOrders.SelectedItems[0];
                        lvwOrders.Items.Remove(item);
                        MessageBox.Show("Order has been Deleted", "Delete Order");
                    }
                }    
            }
            else
            {
                MessageBox.Show("Select a Stock from the listview", "Delete Order");
            }
        }
        private void btnDeleteOrder_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteOrder.ForeColor = lightGreen;
            btnDeleteOrder.BackColor = darkGreen;
            btnDeleteOrder.Text = "";
            btnDeleteOrder.ImageIndex = 2;
        }
        private void btnDeleteOrder_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteOrder.ForeColor = darkGreen;
            btnDeleteOrder.BackColor = lightGreen;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.ImageIndex = -1;
        }
    }
}
