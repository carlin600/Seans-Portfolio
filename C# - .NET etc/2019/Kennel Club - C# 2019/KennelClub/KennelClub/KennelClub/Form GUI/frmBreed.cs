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

namespace KennelClub
{
     public partial class frmBreed : Form
    {
        SqlDataAdapter daBreed;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBBreed;
        DataRow drBreed;
        String connStr, sqlBreed;
        int selectedTab = 0;
        bool breedSelected = false;
        int breedNoSelected = 0;

        public frmBreed()
        {
            InitializeComponent();
        }

        private void frmBreed_Load(object sender, EventArgs e)
        {
            connStr = @"Data source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";

            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, connStr);
            cmdBBreed = new SqlCommandBuilder(daBreed);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");
            dgvBreed.DataSource = dsInTheDogHouse.Tables["Breed"];

            //resize the DataGridView columns to fit the newly loaded content. - Huh?

            dgvBreed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabbreed.SelectedIndex = 1;
            tabbreed.SelectedIndex = 0;
        }

        //display tab
        private void btndisplayadd_Click(object sender, EventArgs e)
        {
            tabbreed.SelectedIndex = 1;

        }

        private void btndisplayedit_Click(object sender, EventArgs e)
        {
            tabbreed.SelectedIndex = 2;
        }

        private void btndisplaydelete_Click(object sender, EventArgs e)
        {
            if (dgvBreed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drBreed = dsInTheDogHouse.Tables["Customer"].Rows.Find(dgvBreed.SelectedRows[0].Cells[0].Value);

                string tempName = drBreed["Breed"].ToString() + " " + drBreed["Size"].ToString() + "\' s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + "details?", "Add Breed", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drBreed.Delete();
                    daBreed.Update(dsInTheDogHouse, "Breed");
                }
            }
        }

        //add tab
        private void btnaddAdd_Click(object sender, EventArgs e)
        {
            MyBreed myBreed = new MyBreed();
            bool ok = true;
            errP.Clear();

            try
            {
                myBreed.BreedNo = Convert.ToInt32(lbladdBreedNo.Text.Trim());
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(lbladdBreedNo, MyEx.ToString());
            }

            try
            {
                myBreed.BreedName = txtaddBreed.Text.Trim();
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(txtaddBreed, MyEx.ToString());
            }

            try
            {
                myBreed.SizeB = txtaddSize.Text.Trim();
            }
            catch (Exception MyEx)
            {
                ok = false;
                errP.SetError(txtaddSize, MyEx.ToString());
            }

            try
            {
                if (ok)
                {
                    drBreed = dsInTheDogHouse.Tables["Breed"].NewRow();
                    drBreed["BreedNo"] = myBreed.BreedNo;
                    drBreed["Breed"] = myBreed.BreedName;
                    drBreed["Size"] = myBreed.SizeB;

                    dsInTheDogHouse.Tables["Breed"].Rows.Add(drBreed);
                    daBreed.Update(dsInTheDogHouse, "Breed");

                    MessageBox.Show("Breed Added");

                    if (MessageBox.Show("Do you wish to add another Breed?", "Add Breed", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsInTheDogHouse.Tables["Breed"].Rows.Count);
                    }
                    else
                    {
                        tabbreed.SelectedIndex = 0;
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
            if (MessageBox.Show("Cancel the addition of Breed No: " + lbladdBreedNo.Text + "?", "Add Breed", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabbreed.SelectedIndex = 0;
            }
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvBreed.SelectedRows.Count == 0)
            {
                breedSelected = false;
                breedNoSelected = 0;
            }
            else if (dgvBreed.SelectedRows.Count == 1)
            {
                breedSelected = true;
                breedNoSelected = Convert.ToInt32(dgvBreed.SelectedRows[0].Cells[0].Value);
            }
        }



        //edit tab
        private void btneditEdit_Click(object sender, EventArgs e)
        {
            if (lbleditedit.Text == "Edit")
            {
                txteditbreed.Enabled = true;
                txteditsize.Enabled = true;

                lbleditedit.Text = "Save";
            }
            else
            {
                MyBreed myBreed = new MyBreed();
                bool ok = true;
                errP.Clear();

                try
                {
                    myBreed.BreedNo = Convert.ToInt32(lbleditbreedno.Text.Trim()); //passed to customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lbleditbreedno, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drBreed.BeginEdit();
                        drBreed["BreedNo"] = myBreed.BreedNo;
                        drBreed["Breed"] = myBreed.BreedName;
                        drBreed["SizeB"] = myBreed.SizeB;

                        drBreed.EndEdit();
                        daBreed.Update(dsInTheDogHouse, "Breed");
                        MessageBox.Show("Breed Details Updated", "Breed");

                       
                        txteditbreed.Enabled = false;
                        txteditsize.Enabled = false;

                        lbldisplayedit.Text = "Edit";
                        tabbreed.SelectedIndex = 0;


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
            if (MessageBox.Show("Cancel the edit of Breed No: " + lbleditbreedno.Text + "?", "Edit Breed", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabbreed.SelectedIndex = 0;
            }
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (breedSelected == false && breedNoSelected == 0)
            {
                //have to do this bit here, reset tab to display and put out message to select a customer
                breedSelected = false;
                breedNoSelected = 0;
            }
            else if (dgvBreed.SelectedRows.Count == 1)
            {
                breedSelected = true;
                breedNoSelected = Convert.ToInt32(dgvBreed.SelectedRows[0].Cells[0].Value);

            }
        }



        //unsure about these

        //tried double clicking didnt work
        private void tabBreed_SelctectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabbreed.SelectedIndex;

            tabbreed.TabPages[tabbreed.SelectedIndex].Focus();

            tabbreed.TabPages[tabbreed.SelectedIndex].CausesValidation = true;

            //whats all this for?-----------------------------------
            //if (dgvCustomers.SelectedRows.Count == 0 && tabCustomers.SelectedIndex == 2)
            //tabCustomers.TabPages[tabCustomers.SelectedIndex].CausesValidation = true;
            //else
            //{

            switch (tabbreed.SelectedIndex)
            {
                case 0: // display tab selected
                    {
                        dsInTheDogHouse.Tables["Breed"].Clear();
                        daBreed.Fill(dsInTheDogHouse, "Breed");

                        break;
                    }

                case 1: //add tab selected
                    {
                        int noRows = dsInTheDogHouse.Tables["Breed"].Rows.Count;

                        if (noRows == 0)
                        {
                            lbladdBreedNo.Text = "200";

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
                        if (breedNoSelected == 0)
                        {
                            tabbreed.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lbleditbreedno.Text = breedNoSelected.ToString();
                            drBreed = dsInTheDogHouse.Tables["Breed"].Rows.Find(lbleditbreedno.Text);
                           

                            txteditbreed.Text = drBreed["Breed"].ToString();
                            txteditsize.Text = drBreed["Size"].ToString();

                            break;

                        }
                    }

            }
        }

        private void frmBreed_Shown(object sender, EventArgs e)
        {
            tabbreed.TabPages[0].CausesValidation = true;
            tabbreed.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabbreed.TabPages[2].CausesValidation = true;
            tabbreed.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);// where is this tab?

        }


        void clearAddForm()
        {
            txtaddBreed.Clear();
            txtaddSize.Clear();


        }

        private void getNumber(int noRows)
        {
            drBreed = dsInTheDogHouse.Tables["Breed"].Rows[noRows - 1];
            lbladdBreedNo.Text = (int.Parse(drBreed["Breed No"].ToString()) + 1).ToString();
        }
    }
}
