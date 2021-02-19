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
    public partial class frmKennel : Form
    {
        SqlDataAdapter daKennel;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBKennel;
        DataRow drKennel;
        String connStr, sqlKennel;
        int selectedTab = 0;
        bool kennelSelected = false;
        int KennelNoSelect = 0;

        public frmKennel()
        {
            InitializeComponent();
        }


        private void frmKennel_Load(object sender, EventArgs e)
        {
            connStr = @"Data source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlKennel = @"select * from Kennel";
            daKennel = new SqlDataAdapter(sqlKennel, connStr);
            cmdBKennel = new SqlCommandBuilder(daKennel);
            daKennel.FillSchema(dsInTheDogHouse, SchemaType.Source, "Kennel");
            daKennel.Fill(dsInTheDogHouse, "Kennel");
            dgvKennel.DataSource = dsInTheDogHouse.Tables["Kennel"];

            //resize the DataGridView columns to fit the newly loaded content. - Huh?

            dgvKennel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabkennel.SelectedIndex = 1;
            tabkennel.SelectedIndex = 0;
        }


        //display tab
        private void btndisplayadd_Click(object sender, EventArgs e)
        {
            tabkennel.SelectedIndex = 1;

        }

        private void btndisplayedit_Click(object sender, EventArgs e)
        {
            tabkennel.SelectedIndex = 2;
        }

        private void btndisplaydelete_Click(object sender, EventArgs e)
        {
            if (dgvKennel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drKennel = dsInTheDogHouse.Tables["Customer"].Rows.Find(dgvKennel.SelectedRows[0].Cells[0].Value);

                string tempName = drKennel["Kennel"].ToString() + " " + drKennel["Size"].ToString() + "\' s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Kennel", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drKennel.Delete();
                    daKennel.Update(dsInTheDogHouse, "Kennel");
                }
            }
        }

        //add tab
        private void btnaddAdd_Click(object sender, EventArgs e)
        {
            MyKennel myKennel = new MyKennel();
            bool ok = true;
            errP.Clear();

            try
            {
                myKennel.KennelNo = Convert.ToInt32(lbladdKennelNo.Text.Trim());
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(lbladdKennelNo, MyEx.ToString());
            }


            try
            {
                myKennel.SizeK = txtaddSizeK.Text.Trim();
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(txtaddSizeK, MyEx.ToString());
            }

            try
            {
                if (ok)
                {
                    drKennel = dsInTheDogHouse.Tables["Kennel"].NewRow();
                    drKennel["KennelNo"] = myKennel.KennelNo;
                    drKennel["Size"] = myKennel.SizeK;

                    dsInTheDogHouse.Tables["Kennel"].Rows.Add(drKennel);
                    daKennel.Update(dsInTheDogHouse, "Kennel");

                    MessageBox.Show("Kennel Added");

                    if (MessageBox.Show("Do you wish to add another Kennel?", "Add Kennel", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsInTheDogHouse.Tables["Kennel"].Rows.Count);
                    }
                    else
                    {
                        tabkennel.SelectedIndex = 0;
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
            if (MessageBox.Show("Cancel the addition of Kennel No: " + lbladdKennelNo.Text + "?", "Add Kennel", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabkennel.SelectedIndex = 0;
            }
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvKennel.SelectedRows.Count == 0)
            {
                kennelSelected = false;
                KennelNoSelect = 0;
            }
            else if (dgvKennel.SelectedRows.Count == 1)
            {
                kennelSelected = true;
                KennelNoSelect = Convert.ToInt32(dgvKennel.SelectedRows[0].Cells[0].Value);
            }
        }


        //edit tab
        private void btneditEdit_Click(object sender, EventArgs e)
        {
            if (lbleditedit.Text == "Edit")
            {
                txteditSizeK.Enabled = true;

                lbleditedit.Text = "Save";
            }
            else
            {
                MyKennel myKennel = new MyKennel();
                bool ok = true;
                errP.Clear();

                try
                {
                    myKennel.KennelNo = Convert.ToInt32(lbleditKennelNo.Text.Trim()); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lbleditKennelNo, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drKennel.BeginEdit();
                        drKennel["KennelNo"] = myKennel.KennelNo;
                        drKennel["SizeK"] = myKennel.SizeK;

                        drKennel.EndEdit();
                        daKennel.Update(dsInTheDogHouse, "Kennel");
                        MessageBox.Show("Kennel Details Updated", "Kennel");


                        txteditSizeK.Enabled = false;

                        lbldisplayedit.Text = "Edit";
                        tabkennel.SelectedIndex = 0;


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
            if (MessageBox.Show("Cancel the edit of Kennel No: " + lbleditKennelNo.Text + "?", "Edit Kennel", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabkennel.SelectedIndex = 0;
            }
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (kennelSelected == false && KennelNoSelect == 0)
            {
                //have to do this bit here, reset tab to display and put out message to select a customer
                kennelSelected = false;
                KennelNoSelect = 0;
            }
            else if (dgvKennel.SelectedRows.Count == 1)
            {
                kennelSelected = true;
                KennelNoSelect = Convert.ToInt32(dgvKennel.SelectedRows[0].Cells[0].Value);

            }
        }



        //unsure about these

        //tried double clicking didnt work
        private void tabkennel_SelctectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabkennel.SelectedIndex;

            tabkennel.TabPages[tabkennel.SelectedIndex].Focus();

            tabkennel.TabPages[tabkennel.SelectedIndex].CausesValidation = true;

            //whats all this for?-----------------------------------
            //if (dgvCustomers.SelectedRows.Count == 0 && tabCustomers.SelectedIndex == 2)
            //tabCustomers.TabPages[tabCustomers.SelectedIndex].CausesValidation = true;
            //else
            //{

            switch (tabkennel.SelectedIndex)
            {
                case 0: // display tab selected
                    {
                        dsInTheDogHouse.Tables["Kennel"].Clear();
                        daKennel.Fill(dsInTheDogHouse, "Kennel");

                        break;
                    }

                case 1: //add tab selected
                    {
                        int noRows = dsInTheDogHouse.Tables["Kennel"].Rows.Count;

                        if (noRows == 0)
                        {
                            lbladdKennelNo.Text = "0";

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
                        if (KennelNoSelect == 0)
                        {
                            tabkennel.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lbleditKennelNo.Text = KennelNoSelect.ToString();
                            drKennel = dsInTheDogHouse.Tables["Kennel"].Rows.Find(lbleditKennelNo.Text);


                            txteditSizeK.Text = drKennel["SizeL"].ToString();

                            break;

                        }
                    }

            }
        }

        private void frmKennel_Shown(object sender, EventArgs e)
        {
            tabkennel.TabPages[0].CausesValidation = true;
            tabkennel.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabkennel.TabPages[2].CausesValidation = true;
            tabkennel.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);// where is this tab?

        }


        void clearAddForm()
        {
            txtaddSizeK.Clear();
        }

        private void getNumber(int noRows)
        {
            drKennel = dsInTheDogHouse.Tables["Kennel"].Rows[noRows - 1];
            lbladdKennelNo.Text = (int.Parse(drKennel["Kennel No"].ToString()) + 1).ToString();
        }

















        



    }
}
