using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennelClub
{
    public partial class frmDog : Form
    {

        SqlDataAdapter daDog, daBreed, daCustomer;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBDog, cmdBCustomer, cmdBBreed;
        DataRow drDog;
        String connStr, sqlDog, sqlBreed, sqlCustomer;
        
        int selectedTab = 0;
        bool DogSelected = false;
        int DogNoSelected = 0;


        public frmDog()
        {
            InitializeComponent();
        }

        private void frmDog_Load(object sender, EventArgs e)
        {
            //If youre having trouble connecting to the database, and you have made sure you're connected via server explorer,
            //Alter this connection string to the SQL Server name on your computer that has the SQL code executed.
            connStr = @"Data source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            //connStr = @"Data Source = (server name here); Initial Catalog = InTheDogHouse; Integrated Security = True";


            sqlDog = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, connStr);
            cmdBDog = new SqlCommandBuilder(daDog);
            daDog.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daDog.Fill(dsInTheDogHouse, "Dog");

            sqlBreed = @"select * from Breed";
            daBreed = new SqlDataAdapter(sqlBreed, connStr);
            cmdBBreed = new SqlCommandBuilder(daBreed);
            daBreed.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daBreed.Fill(dsInTheDogHouse, "Breed");

            connStr = @"Data source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            dgvDog.DataSource = dsInTheDogHouse.Tables["Dog"];

            //resize the DataGridView columns to fit the newly loaded content. - Huh?
            dgvDog.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cmbAddBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbAddBreedNo.ValueMember = "BreedNo";
            cmbAddBreedNo.DisplayMember = "BreedName";

            cmbAddCustomerNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbAddCustomerNo.ValueMember = "CustomerNo";
            cmbAddCustomerNo.DisplayMember = "CustomerNo";

            cmbEditBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbEditBreedNo.ValueMember = "BreedNo";
            cmbEditBreedNo.DisplayMember = "BreedName";

            cmbEditCustomerNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbEditCustomerNo.ValueMember = "CustomerNo";
            cmbEditCustomerNo.DisplayMember = "CustomerNo";

            tabDog.SelectedIndex = 1;
            tabDog.SelectedIndex = 0;
        }

        private void getNumber(int noRows)
        {
            drDog = dsInTheDogHouse.Tables["Dog"].Rows[noRows - 1];
            lbladdDogNo.Text = (int.Parse(drDog["DogNo"].ToString()) + 1).ToString();
        }
        
        private void tabDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabDog.SelectedIndex;

            tabDog.TabPages[tabDog.SelectedIndex].Focus();
            tabDog.TabPages[tabDog.SelectedIndex].CausesValidation = true;

           if (dgvDog.SelectedRows.Count == 0 && tabDog.SelectedIndex == 2)
            {
                tabDog.TabPages[tabDog.SelectedIndex].CausesValidation = true;
            }
            else
            {
                
            }
            


            switch (tabDog.SelectedIndex)
            {
                case 0: //display tab selected
                {
                    dsInTheDogHouse.Tables["Dog"].Clear();
                    daDog.Fill(dsInTheDogHouse, "Dog");

                    break;

                }

                case 1: // add tab selected
                {
                   int noRows = dsInTheDogHouse.Tables["Dog"].Rows.Count;

                    if (noRows == 0)
                    {
                        lbladdDogNo.Text = "1000";
                    }
                    else
                    {
                        getNumber(noRows);
                    }

                    errP.Clear();
                    clearAddForm();
                    break;
                }

                case 2: //edit tab selected
                {
                    if (DogNoSelected == 0)
                    {
                        tabDog.SelectedIndex = 0;
                        break;
                    }
                    else
                    {
                        lblEditDogNo.Text = DogNoSelected.ToString();

                        drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lblEditDogNo.Text);

                        lblEditDogNo.Text = drDog["DogNo"].ToString();
                        txtEditName.Text = drDog["Name"].ToString();

                        DataRow drBreed = dsInTheDogHouse.Tables["Breed"].Rows.Find(drDog["BreedNo"].ToString());
                        cmbEditBreedNo.Text = drBreed["BreedName"].ToString();
                        txtEditColour.Text = drDog["Colour"].ToString();
                        dtpEditDOB.Text = drDog["DOB"].ToString();
                        cmbEditGender.Text = drDog["Gender"].ToString();
                        cmbEditCustomerNo.Text = drDog["CustomerNo"].ToString();

                        break;
                    }
                }
            }
        }

        //display tab
        private void btndisplaydelete_Click(object sender, EventArgs e)
        {
            //if (lstDogs.SelectedIndices.Count == 0) -- what is this?

            if (dgvDog.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Dog from the list", "Select Dog");
            }
            else
            {
                drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(dgvDog.SelectedRows[0].Cells[0].Value);

                string tempName = drDog["Name"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "Add Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drDog.Delete();
                    daDog.Update(dsInTheDogHouse, "Dog");
                }
            }
        }

        private void btndisplayadd_Click(object sender, EventArgs e)
        {
            tabDog.SelectedIndex = 1;
        }

        private void btndisplayedit_Click(object sender, EventArgs e)
        {
            tabDog.SelectedIndex = 2;
        }


        //add tab
        private void btnaddAdd_Click(object sender, EventArgs e)
        {
            MyDog myDog = new MyDog();
            bool ok = true;
            errP.Clear();

            try
            {
                myDog.dogNo = Convert.ToInt32(lbladdDogNo.Text.Trim()); // passed to Dog class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lbladdDogNo, MyEx.toString());
            }

            try
            {
                myDog.Name = txtAddName.Text.Trim(); //passed to dog class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddName, MyEx.toString());
            }

            try
            {
                myDog.breedNo = Convert.ToInt32(cmbAddBreedNo.SelectedValue); // passed to dog class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddBreedNo, MyEx.toString());//it says in the sheet that its dogno???? - DOUBLE CHECK--------------------------------
            }

            try
            {
                myDog.Colour = txtAddColour.Text.Trim(); //passed to dog class to check
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddColour, MyEx.toString());
            }

            try
            {
                myDog.DogDOB = DateTime.Parse(dtpAddDOB.Text.Trim()); //passed to dog class---------------- finish off
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpAddDOB, MyEx.toString());
            }

            try //----------------------------------------------------------------
            {
                myDog.Gender = Convert.ToChar(cmbAddGender.Text);
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddGender, MyEx.toString());
            }

            try
            {
                myDog.customerNo = Convert.ToInt32(cmbAddCustomerNo.SelectedValue);
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbAddCustomerNo, MyEx.toString());
            }

            try
            {
                if (ok)
                {
                    drDog = dsInTheDogHouse.Tables["Dog"].NewRow();

                    drDog["DogNo"] = myDog.dogNo;
                    drDog["Name"] = myDog.Name;
                    drDog["BreedNo"] = myDog.breedNo;
                    drDog["Colour"] = myDog.Colour;
                    drDog["DOB"] = myDog.DogDOB;
                    drDog["Gender"] = myDog.Gender;
                    drDog["CustomerNo"] = myDog.customerNo;

                    dsInTheDogHouse.Tables["Dog"].Rows.Add(drDog);
                    daDog.Update(dsInTheDogHouse, "Dog");

                    MessageBox.Show("Dog Added");

                    if (MessageBox.Show("Do you wish to add another Dog?", "Add Dog", MessageBoxButtons.YesNo) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(dsInTheDogHouse.Tables["Dog"].Rows.Count);
                    }
                    else
                        tabDog.SelectedIndex = 0;

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
            if (MessageBox.Show("Cancel the addition of Dog No: " + lbladdDogNo.Text + "?", "Add Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabDog.SelectedIndex = 0;
            }
        }

        private void cmbAddCustomerNo_Click(object sender, EventArgs e)
        {
            DataRow drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(cmbAddCustomerNo.Text);
            lbladdname.Text = drCustomer["Surname"].ToString() + "," + drCustomer["Forename"].ToString();
        }

        private void cmbAddCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void tabCustAdd_Click(object sender, EventArgs e)
        {
            //how do i find this on the form?
        }


        //edit tab
        private void btneditEdit_Click(object sender, EventArgs e)
        {
            if (lbleditedit.Text == "Edit")
            {
                txtEditName.Enabled = true;
                cmbEditBreedNo.Enabled = true;
                txtEditColour.Enabled = true;
                dtpEditDOB.Enabled = true;
                cmbEditGender.Enabled = true;
                cmbEditCustomerNo.Enabled = true;
                txtEditColour.Enabled = true;

                lbleditedit.Text = "Save";
            }
            else
            {
                MyDog myDog = new MyDog();
                bool ok = true;
                errP.Clear();

                try
                {
                    myDog.dogNo = Convert.ToInt32(lblEditDogNo.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditDogNo, MyEx.toString());

                }

                try
                {
                    myDog.Name = txtEditName.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditName, MyEx.toString());
                }

                try
                {
                    myDog.breedNo = Convert.ToInt32(cmbEditBreedNo.SelectedValue);
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditBreedNo, MyEx.toString());
                }

                try
                {
                    myDog.Colour = txtEditColour.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditColour, MyEx.toString());
                }

                try
                {
                    myDog.DogDOB = DateTime.Parse(dtpEditDOB.Text.Trim());
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dtpEditDOB, MyEx.toString());
                }

                try
                {
                    myDog.Gender = Convert.ToChar(cmbEditGender.Text);
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditGender, MyEx.toString());
                }

                try
                {
                    myDog.customerNo = Convert.ToInt32(cmbEditCustomerNo.SelectedValue);
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cmbEditCustomerNo, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drDog.BeginEdit();

                        drDog["DogNo"] = myDog.dogNo;
                        drDog["Name"] = myDog.Name;
                        drDog["BreedNo"] = myDog.breedNo;
                        drDog["Colour"] = myDog.Colour;
                        drDog["DOB"] = myDog.DogDOB;
                        drDog["Gender"] = myDog.Gender;
                        drDog["CustomerNo"] = myDog.customerNo;

                        drDog.EndEdit();
                        daDog.Update(dsInTheDogHouse, "Dog");

                        MessageBox.Show("Dog Details Updated", "Dog");

                        txtEditName.Enabled = false;
                        cmbEditBreedNo.Enabled = false;
                        txtEditColour.Enabled = false;
                        dtpEditDOB.Enabled = false;
                        cmbEditGender.Enabled = false;
                        cmbEditCustomerNo.Enabled = false;
                        txtEditColour.Enabled = false;

                        lbleditedit.Text = "Edit";
                        tabDog.SelectedIndex = 0;
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
            if (MessageBox.Show("Cancel the edit of Dog No: " + lblEditDogNo.Text + "?", "Edit Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tabDog.SelectedIndex = 0;
            }
        }
        
        private void cmbEditCustomerNo_Click(object sender, EventArgs e)
        {
            lblEditName.Text = "Hello";
        }
        
        private void cmbEditCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        


        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvDog.SelectedRows.Count == 0)
            {
                DogSelected = false; 
                DogNoSelected = 0;
            }
            else if(dgvDog.SelectedRows.Count == 1)
            {
                DogSelected = true;
                DogNoSelected = Convert.ToInt32(dgvDog.SelectedRows[0].Cells[0].Value);
            }
        }

        void EditTabValidate(object sender, CancelEventArgs e)
        {
            if (DogSelected == false && DogNoSelected == 0)
            {
                DogSelected = false;
                DogNoSelected = 0;

                MessageBox.Show("Please select a Dog from the list", "Select Dog", MessageBoxButtons.OK); // is this right?
                
            }
            else if (dgvDog.SelectedRows.Count == 1)
            {
                DogSelected = true;
                DogNoSelected = Convert.ToInt32(dgvDog.SelectedRows[0].Cells[0].Value);

            }
        }
        
        void clearAddForm()
        {
            txtAddName.Clear();
            cmbAddBreedNo.SelectedIndex = -1;
            txtAddColour.Clear();
            dtpAddDOB.Value = DateTime.Now;
            cmbAddGender.SelectedIndex = -1;
            cmbAddCustomerNo.SelectedIndex = -1;
            txtAddColour.Clear();
        }

    }
}
