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

namespace KennelClub
{
    public partial class frmSize : Form
    {
        SqlDataAdapter daSize;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBSize;
        DataRow drSize;
        String connStr, sqlSize;
        int selectedTab = 0;
        bool sizeSelected = false;
        int sizeNoSelected = 0;

        public frmSize()
        {
            InitializeComponent();
        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            connStr = @"Data source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlSize = @"select * from Size";
            daSize = new SqlDataAdapter(sqlSize, connStr);
            cmdBSize = new SqlCommandBuilder(daSize);
            daSize.FillSchema(dsInTheDogHouse, SchemaType.Source, "Size");
            daSize.Fill(dsInTheDogHouse, "Size");
            dgvSize.DataSource = dsInTheDogHouse.Tables["Size"];

            //resize the DataGridView columns to fit the newly loaded content. - Huh?

            dgvSize.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabsize.SelectedIndex = 1;
            tabsize.SelectedIndex = 0;
        }



        //display tab
        private void btndisplayadd_Click(object sender, EventArgs e)
        {
            tabsize.SelectedIndex = 1;

        }

        private void btndisplayedit_Click(object sender, EventArgs e)
        {
            tabsize.SelectedIndex = 2;
        }

        private void btndisplaydelete_Click(object sender, EventArgs e)
        {
            if (dgvSize.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drSize = dsInTheDogHouse.Tables["Customer"].Rows.Find(dgvSize.SelectedRows[0].Cells[0].Value);

                string tempName = drSize["Kennel"].ToString() + " " + drSize["Size"].ToString() + "\' s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Kennel", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSize.Delete();
                    daSize.Update(dsInTheDogHouse, "Kennel");
                }
            }
        }

        //add tab
        private void btnaddAdd_Click(object sender, EventArgs e)
        {
            MySize mySize = new MySize();
            bool ok = true;
            errP.Clear();

            try
            {
                mySize.SizeNo = Convert.ToInt32(lbladdSizeNo.Text.Trim());
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(lbladdSizeNo, MyEx.ToString());
            }


            try
            {
                 mySize.chargePerDay = Convert.ToDouble(txtaddChargePD.Text.Trim()); // help me
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(txtaddChargePD, MyEx.ToString());
            }

            try
            {
                if (ok)
                {
                    drSize = dsInTheDogHouse.Tables["Size"].NewRow();
                    drSize["SizeNo"] = mySize.SizeNo;
                    drSize["ChargePerDay"] = mySize.chargePerDay;

                    dsInTheDogHouse.Tables["Size"].Rows.Add(drSize);
                    daSize.Update(dsInTheDogHouse, "Size");

                    MessageBox.Show("Size Added");

                    if (MessageBox.Show("Do you wish to add another Size?", "Add Size", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsInTheDogHouse.Tables["Size"].Rows.Count);
                    }
                    else
                    {
                        tabsize.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Error);
            }
        }

        private void btnaddCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Size No: " + lbladdSizeNo.Text + "?", "Add Size", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabsize.SelectedIndex = 0;
            }
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvSize.SelectedRows.Count == 0)
            {
                sizeSelected = false;
                sizeNoSelected = 0;
            }
            else if (dgvSize.SelectedRows.Count == 1)
            {
                sizeSelected = true;
                sizeNoSelected = Convert.ToInt32(dgvSize.SelectedRows[0].Cells[0].Value);
            }
        }


        //edit tab
        private void btneditEdit_Click(object sender, EventArgs e)
        {
            if (lbleditedit.Text == "Edit")
            {
                txteditChargePD.Enabled = true;

                lbleditedit.Text = "Save";
            }
            else
            {
                MySize mySize = new MySize();
                bool ok = true;
                errP.Clear();

                try
                {
                    mySize.SizeNo = Convert.ToInt32(lbleditSizeNo.Text.Trim()); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lbleditSizeNo, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drSize.BeginEdit();
                        drSize["SizeNo"] = mySize.SizeNo;
                        drSize["ChargePerDay"] = mySize.chargePerDay;

                        drSize.EndEdit();
                        daSize.Update(dsInTheDogHouse, "Size");
                        MessageBox.Show("Size Details Updated", "Size");


                        txteditChargePD.Enabled = false;

                        lbldisplayedit.Text = "Edit";
                        tabsize.SelectedIndex = 0;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error);
                }



            }
        }

        private void btneditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Size No: " + lbleditSizeNo.Text + "?", "Edit Size", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabsize.SelectedIndex = 0;
            }
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (sizeSelected == false && sizeNoSelected == 0)
            {
                //have to do this bit here, reset tab to display and put out message to select a customer
                sizeSelected = false;
                sizeNoSelected = 0;
            }
            else if (dgvSize.SelectedRows.Count == 1)
            {
                sizeSelected = true;
                sizeNoSelected = Convert.ToInt32(dgvSize.SelectedRows[0].Cells[0].Value);

            }
        }



        //unsure about these

        //tried double clicking didnt work
        private void tabSize_SelctectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabsize.SelectedIndex;

            tabsize.TabPages[tabsize.SelectedIndex].Focus();

            tabsize.TabPages[tabsize.SelectedIndex].CausesValidation = true;

            //whats all this for?-----------------------------------
            //if (dgvCustomers.SelectedRows.Count == 0 && tabCustomers.SelectedIndex == 2)
            //tabCustomers.TabPages[tabCustomers.SelectedIndex].CausesValidation = true;
            //else
            //{

            switch (tabsize.SelectedIndex)
            {
                case 0: // display tab selected
                    {
                        dsInTheDogHouse.Tables["Size"].Clear();
                        daSize.Fill(dsInTheDogHouse, "Size");

                        break;
                    }

                case 1: //add tab selected
                    {
                        int noRows = dsInTheDogHouse.Tables["Size"].Rows.Count;

                        if (noRows == 0)
                        {
                            lbladdSizeNo.Text = "0";

                        }
                        else
                        {
                            getNumber(noRows);
                        }
                        errP.Clear();
                        clearAddForm();
                        break;
                    }

                case 2: // edit tab selected
                    {
                        if (sizeNoSelected == 0)
                        {
                            tabsize.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lbleditSizeNo.Text = sizeNoSelected.ToString();
                            drSize = dsInTheDogHouse.Tables["Size"].Rows.Find(lbleditSizeNo.Text);


                            txteditChargePD.Text = drSize["ChargePerDay"].ToString();

                            break;

                        }
                    }

            }
        }

        private void frmKennel_Shown(object sender, EventArgs e)
        {
            tabsize.TabPages[0].CausesValidation = true;
            tabsize.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabsize.TabPages[2].CausesValidation = true;
            tabsize.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);// where is this tab?

        }


        void clearAddForm()
        {
            txtaddChargePD.Clear();
        }

        private void getNumber(int noRows)
        {
            drSize = dsInTheDogHouse.Tables["Size"].Rows[noRows - 1];
            lbladdSizeNo.Text = (int.Parse(drSize["SizeNo"].ToString()) + 1).ToString();
        }





















    }
}
