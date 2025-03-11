using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Artefact
{
    public partial class frmMain : Form
    {
        private int buttonClickCount = 0;
        private string uniqueCode = "";
        private List<Button> clickedButtons = new List<Button>();

        public frmMain()
        {
            InitializeComponent();
            cmbSelectTheme.SelectedIndex = 0;
        }

        private void cmbSelectTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = cmbSelectTheme.SelectedIndex;
            switch (num)
            {
                case 0:
                    btn1.ImageList = ilSports;
                    btn2.ImageList = ilSports;
                    btn3.ImageList = ilSports;
                    btn4.ImageList = ilSports;
                    btn5.ImageList = ilSports;
                    btn6.ImageList = ilSports;
                    btn7.ImageList = ilSports;
                    btn8.ImageList = ilSports;
                    btn9.ImageList = ilSports;
                break;

                case 1:
                    btn1.ImageList = ilNature;
                    btn2.ImageList = ilNature;
                    btn3.ImageList = ilNature;
                    btn4.ImageList = ilNature;
                    btn5.ImageList = ilNature;
                    btn6.ImageList = ilNature;
                    btn7.ImageList = ilNature;
                    btn8.ImageList = ilNature;
                    btn9.ImageList = ilNature;
                break;

                case 2:
                    btn1.ImageList = ilNumbers;
                    btn2.ImageList = ilNumbers;
                    btn3.ImageList = ilNumbers;
                    btn4.ImageList = ilNumbers;
                    btn5.ImageList = ilNumbers;
                    btn6.ImageList = ilNumbers;
                    btn7.ImageList = ilNumbers;
                    btn8.ImageList = ilNumbers;
                    btn9.ImageList = ilNumbers;
                break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbPanel.SelectedIndex = 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            tbPanel.SelectedIndex = 1;
        }

        private void btnRegBack_Click(object sender, EventArgs e)
        {
            tbPanel.SelectedIndex = 0;
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            tbPanel.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Exit Cancelled!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            txtAmountSelected.Text = buttonClickCount.ToString();
            Button clickedButton = sender as Button;

            clickedButtons.Add(clickedButton);

            if(clickedButtons.Count == 4)
            {
                foreach( Button button in clickedButtons)
                {
                    uniqueCode += button.Name.Substring(3);
                }
                Console.WriteLine(uniqueCode);
                MessageBox.Show("Max Limit Reached!", "Combination Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //store password here
                buttonClickCount = 0;
                clickedButtons.Clear();
                uniqueCode = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
        }
    }
}
