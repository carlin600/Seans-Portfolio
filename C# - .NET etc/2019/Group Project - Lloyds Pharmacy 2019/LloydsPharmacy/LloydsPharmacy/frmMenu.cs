using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsPharmacy
{
    public partial class frmMenu : Form
    {

        Color darkGreen = new Color();
        Color lightGreen = new Color();
        Color transparent = new Color();

        private int imageNumber = 1;


        //image slider
        private void NextImageLoad()
        {
            if(imageNumber == 3)
            {
                imageNumber = 1;
            }
            pbSlider.ImageLocation = string.Format(@"ImageSlider\{0}.jpg", imageNumber);
            imageNumber++;
        }

        //timer is enabled so it calls the method above.
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextImageLoad();
        }


        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            darkGreen = Color.FromArgb(32, 115, 60);
            lightGreen = Color.FromArgb(165, 203, 82);
            transparent = Color.FromArgb(255, 255, 255);

            pnlNavBar.BackColor = lightGreen;
            ilNavbar.TransparentColor = darkGreen;
        }

        private void lblPatients_MouseEnter(object sender, EventArgs e)
        {
            lblPatients.ForeColor = lightGreen;
            lblPatients.BackColor = darkGreen;
            lblPatients.Text = "";
            lblPatients.ImageIndex = 1 ;
        }

        private void lblPatients_MouseLeave(object sender, EventArgs e)
        {
            lblPatients.ForeColor = darkGreen;
            lblPatients.BackColor = lightGreen;
            lblPatients.Text = "Patients";
            lblPatients.ImageIndex = -1;
        }

        private void lblPrescriptions_MouseEnter(object sender, EventArgs e)
        {
            lblPrescriptions.ForeColor = lightGreen;
            lblPrescriptions.BackColor = darkGreen;
            lblPrescriptions.Text = "";
            lblPrescriptions.ImageIndex = 2;
        }

        private void lblPrescriptions_MouseLeave(object sender, EventArgs e)
        {
            lblPrescriptions.ForeColor = darkGreen;
            lblPrescriptions.BackColor = lightGreen;
            lblPrescriptions.Text = "Prescriptions";
            lblPrescriptions.ImageIndex = -1;
        }

        private void lblMAilment_MouseEnter(object sender, EventArgs e)
        {
            lblMAilment.ForeColor = lightGreen;
            lblMAilment.BackColor = darkGreen;
            lblMAilment.Text = "";
            lblMAilment.ImageIndex = 3;
        }

        private void lblMAilment_MouseLeave(object sender, EventArgs e)
        {
            lblMAilment.ForeColor = darkGreen;
            lblMAilment.BackColor = lightGreen;
            lblMAilment.Text = "Minor Ailments";
            lblMAilment.ImageIndex = -1;
        }

        private void lblStock_MouseEnter(object sender, EventArgs e)
        {
            lblStock.ForeColor = lightGreen;
            lblStock.BackColor = darkGreen;
            lblStock.Text = "";
            lblStock.ImageIndex = 4;
        }

        private void lblStock_MouseLeave(object sender, EventArgs e)
        {
            lblStock.ForeColor = darkGreen;
            lblStock.BackColor = lightGreen;
            lblStock.Text = "Stock";
            lblStock.ImageIndex = -1;
        }

        private void lblSupplier_MouseEnter(object sender, EventArgs e)
        {
            lblSuppliers.ForeColor = lightGreen;
            lblSuppliers.BackColor = darkGreen;
            lblSuppliers.Text = "";
            lblSuppliers.ImageIndex = 5;
        }

        private void lblSupplier_MouseLeave(object sender, EventArgs e)
        {
            lblSuppliers.ForeColor = darkGreen;
            lblSuppliers.BackColor = lightGreen;
            lblSuppliers.Text = "Supplier";
            lblSuppliers.ImageIndex = -1;
        }

        private void lblStaff_MouseEnter(object sender, EventArgs e)
        {
            lblStaff.ForeColor = lightGreen;
            lblStaff.BackColor = darkGreen;
            lblStaff.Text = "";
            lblStaff.ImageIndex = 6;
        }

        private void lblStaff_MouseLeave(object sender, EventArgs e)
        {
            lblStaff.ForeColor = darkGreen;
            lblStaff.BackColor = lightGreen;
            lblStaff.Text = "Staff";
            lblStaff.ImageIndex = -1;
        }

        private void lblCourse_MouseEnter(object sender, EventArgs e)
        {
            lblCourse.ForeColor = lightGreen;
            lblCourse.BackColor = darkGreen;
            lblCourse.Text = "";
            lblCourse.ImageIndex = 7;
        }

        private void lblCourse_MouseLeave(object sender, EventArgs e)
        {
            lblCourse.ForeColor = darkGreen;
            lblCourse.BackColor = lightGreen;
            lblCourse.Text = "Courses";
            lblCourse.ImageIndex = -1;
        }

        private void lblSales_MouseEnter(object sender, EventArgs e)
        {
            lblSales.ForeColor = lightGreen;
            lblSales.BackColor = darkGreen;
            lblSales.Text = "";
            lblSales.ImageIndex = 8;
        }

        private void lblSales_MouseLeave(object sender, EventArgs e)
        {
            lblSales.ForeColor = darkGreen;
            lblSales.BackColor = lightGreen;
            lblSales.Text = "Sales";
            lblSales.ImageIndex = -1;
        }

        private void lblTimetable_MouseEnter(object sender, EventArgs e)
        {
            lblTimetable.ForeColor = lightGreen;
            lblTimetable.BackColor = darkGreen;
            lblTimetable.Text = "";
            lblTimetable.ImageIndex = 9;
        }

        private void lblTimetable_MouseLeave(object sender, EventArgs e)
        {
            lblTimetable.ForeColor = darkGreen;
            lblTimetable.BackColor = lightGreen;
            lblTimetable.Text = "Timetable";
            lblTimetable.ImageIndex = -1;
        }

        //Navbar navigation applications are subsidised and not fully closed.
        private void lblPatients_Click(object sender, EventArgs e)
        {
            frmPatients frmpatients = new frmPatients();
            frmpatients.Show();
            this.Hide();
        }

        private void lblPrescriptions_Click(object sender, EventArgs e)
        {
            frmPrescriptions frmprescriptions = new frmPrescriptions();
            frmprescriptions.Show();
            this.Hide();
        }

        private void lblMAilment_Click(object sender, EventArgs e)
        {
            frmMinorAilments frmminorailments = new frmMinorAilments();
            frmminorailments.Show();
            this.Hide();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            frmStock frmstock = new frmStock();
            frmstock.Show();
            this.Hide();
        }

        private void lblSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers frmsuppliers = new frmSuppliers();
            frmsuppliers.Show();
            this.Hide();
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            frmStaff frmstaff = new frmStaff();
            frmstaff.Show();
            this.Hide();
        }

        private void lblCourse_Click(object sender, EventArgs e)
        {
            frmCourses frmcourses = new frmCourses();
            frmcourses.Show();
            this.Hide();
        }

        private void lblSales_Click(object sender, EventArgs e)
        {
            frmSales frmsales = new frmSales();
            frmsales.Show();
            this.Hide();
        }


        private void lblTimetable_Click(object sender, EventArgs e)
        {
            frmStaffCourse frmstaffcourse = new frmStaffCourse();
            frmstaffcourse.Show();
            this.Hide();
        }




        //System.Windows.Forms.Application.Exit( ) exits entire application
        //System.Windows.Forms.Application.ExitThread( )



    }
}
