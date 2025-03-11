using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine_Demo
{
    public partial class RootsKitchen : Form
    {

        List<Drink> drinks = new List<Drink>();
        List<StockSlot> slots = new List<StockSlot>();
        List<Pre_Pay_Customer> customers = new List<Pre_Pay_Customer>();
        List<BankAccount> banks = new List<BankAccount>();
        StockSlot slotChosen = new StockSlot();
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public RootsKitchen()
        {
            //Loads stock and slots
            InitializeComponent();
            loadDrinks();
            loadSlots();
            loadCustomers();
            loadBanks();
            loadCustomersIntoCmb();
            myTimer.Tick += new System.EventHandler(myTimer_Tick);
            
        }

        //Creates the bank information for the vending machine
        public void loadBanks()
        {
            banks.Add(new BankAccount { loyaltyCardNo = "LC1001", amountInAccount = 100 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1002", amountInAccount = 2 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1003", amountInAccount = 30 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1004", amountInAccount = 15 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1005", amountInAccount = .5 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1006", amountInAccount = 22 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1007", amountInAccount = 10 });
            banks.Add(new BankAccount { loyaltyCardNo = "LC1008", amountInAccount = 8 });
        }

        //Creates the customer information for the vending machine
        public void loadCustomers()
        {
            customers.Add(new Pre_Pay_Customer { customerNo = 1001, name = "Alex Jones", loyaltyCardNo = "LC1001", pinNumber = 1234 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1002, name = "Lesley Mack", loyaltyCardNo = "LC1002", pinNumber = 5678 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1003, name = "Stephen Payne", loyaltyCardNo = "LC1003", pinNumber = 9915 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1004, name = "Sarah Duffy", loyaltyCardNo = "LC1004", pinNumber = 2253 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1005, name = "Helen Brown", loyaltyCardNo = "LC1005", pinNumber = 7661 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1006, name = "Aaron Gallick", loyaltyCardNo = "LC1006", pinNumber = 1824 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1007, name = "Samantha Johns", loyaltyCardNo = "LC1007", pinNumber = 9241 });
            customers.Add(new Pre_Pay_Customer { customerNo = 1008, name = "Jeremy Elbertson", loyaltyCardNo = "LC1008", pinNumber = 3521 });
        }

        //Creates the drinks in the vending machine
        public void loadDrinks()
        {
            drinks.Add(new Drink() { itemCode = 1001, name = "Fanta", price = 1.5});
            drinks.Add(new Drink() { itemCode = 1002, name = "Coke", price = 1.5 });
            drinks.Add(new Drink() { itemCode = 1003, name = "Diet Coke", price = 1.2 });
            drinks.Add(new Drink() { itemCode = 1004, name = "Coke Zero", price = 1 });
            drinks.Add(new Drink() { itemCode = 1005, name = "Pepsi", price = 1.3 });
            drinks.Add(new Drink() { itemCode = 1006, name = "Diet Pepsi", price = 1.1 });
            drinks.Add(new Drink() { itemCode = 1007, name = "Pepsi Max", price = 1});
            drinks.Add(new Drink() { itemCode = 1008, name = "Vimto", price = 1 });
            drinks.Add(new Drink() { itemCode = 1009, name = "Water", price = .8});
            drinks.Add(new Drink() { itemCode = 1010, name = "Sparkling Water", price = 1});
        }

        //Creates the slots and adds drinks and stock in the vending machine
        public void loadSlots()
        {
            slots.Add(new StockSlot() { slotName = "A1", itemCode = 1002, stockInSlot = 5 });
            slots.Add(new StockSlot() { slotName = "A2", itemCode = 1002, stockInSlot = 8 });
            slots.Add(new StockSlot() { slotName = "A3", itemCode = 1003, stockInSlot = 2 });
            slots.Add(new StockSlot() { slotName = "A4", itemCode = 1003, stockInSlot = 0 });
            slots.Add(new StockSlot() { slotName = "A5", itemCode = 1004, stockInSlot = 3 });

            slots.Add(new StockSlot() { slotName = "B1", itemCode = 1005, stockInSlot = 0 });
            slots.Add(new StockSlot() { slotName = "B2", itemCode = 1005, stockInSlot = 8 });
            slots.Add(new StockSlot() { slotName = "B3", itemCode = 1006, stockInSlot = 6 });
            slots.Add(new StockSlot() { slotName = "B4", itemCode = 1006, stockInSlot = 4 });
            slots.Add(new StockSlot() { slotName = "B5", itemCode = 1007, stockInSlot = 5 });

            slots.Add(new StockSlot() { slotName = "C1", itemCode = 1001, stockInSlot = 1 });
            slots.Add(new StockSlot() { slotName = "C2", itemCode = 1001, stockInSlot = 3 });
            slots.Add(new StockSlot() { slotName = "C3", itemCode = 1001, stockInSlot = 4 });
            slots.Add(new StockSlot() { slotName = "C4", itemCode = 1008, stockInSlot = 6 });
            slots.Add(new StockSlot() { slotName = "C5", itemCode = 1008, stockInSlot = 2 });

            slots.Add(new StockSlot() { slotName = "D1", itemCode = 1009, stockInSlot = 8 });
            slots.Add(new StockSlot() { slotName = "D2", itemCode = 1009, stockInSlot = 4 });
            slots.Add(new StockSlot() { slotName = "D3", itemCode = 1009, stockInSlot = 2 });
            slots.Add(new StockSlot() { slotName = "D4", itemCode = 1009, stockInSlot = 2 });
            slots.Add(new StockSlot() { slotName = "D5", itemCode = 1009, stockInSlot = 4 });

            slots.Add(new StockSlot() { slotName = "E1", itemCode = 1010, stockInSlot = 8 });
            slots.Add(new StockSlot() { slotName = "E2", itemCode = 1010, stockInSlot = 5 });
            slots.Add(new StockSlot() { slotName = "E3", itemCode = 1010, stockInSlot = 6 });
            slots.Add(new StockSlot() { slotName = "E4", itemCode = 1010, stockInSlot = 7 });
            slots.Add(new StockSlot() { slotName = "E5", itemCode = 1010, stockInSlot = 7 });


        }

        //Resets form to default
        public void resetForm()
        {
            pnlCard.Enabled = false;
            txtPin.Text = "";
            pnlCash.Enabled = false;
            txtCash.Text = "";
            btnLoyaltyCard.Enabled = false;
            btnCash.Enabled = false;
            btnConfirm.Enabled = false;
            pnlKeyPad.Enabled = true;
            lblMessage.Text = "Please choose an Item.";
            loadCustomersIntoCmb();
        }
        
        //Calls the reset form method to cancel whatever the customer has done
        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        //Loads the item for 'X1'
        private void btn1_Click(object sender, EventArgs e)
        {
            if(letterPressed())
            {
                loadItem(1);
            }
        }

        //Changes the text to 'A'
        private void buttonA_Click(object sender, EventArgs e)
        {
          lblMessage.Text = "A";
        }

        //Checks if a letter is pressed, to add the number. (E.g. if it says 'A', a number can be added)
        private Boolean letterPressed()
        {
            bool pressed = false;
            
            if(lblMessage.Text.Length == 1)
            {
                pressed = true;
            }

            return pressed;
        }

        //Changes the text to 'B'
        private void btnB_Click(object sender, EventArgs e)
        {
                lblMessage.Text = "B";            
        }

        //Changes the text to 'C'
        private void btnC_Click(object sender, EventArgs e)
        {
                lblMessage.Text = "C";      
        }

        //Changes the text to 'D'
        private void btnD_Click(object sender, EventArgs e)
        {

                lblMessage.Text = "D";           
        }

        //Changes the text to 'E'
        private void btnE_Click(object sender, EventArgs e)
        {
                lblMessage.Text = "E";        
        }

        //Confirms the item selected, making sure one is selected and its not out of stock
        private void button1_Click(object sender, EventArgs e)
        {
            if(lblMessage.Text.Length > 1 && lblMessage.Text != "Item is out of stock!" && lblMessage.Text != "Please choose an Item.")
            {
                pnlKeyPad.Enabled = false;
                btnCash.Enabled = true;
                btnLoyaltyCard.Enabled = true;
                lblMessage.Text = "Please choose a payment method";
                btnConfirm.Enabled = true;
            }
        }

        //Gets the details for the item they chose
        public void loadItem(int num)
        {
            slotChosen = slots.Find(x => x.slotName == lblMessage.Text + num);
            Drink drinkChosen = drinks.Find(x => x.itemCode == slotChosen.itemCode);
            if (slotChosen.stockInSlot > 0)
            {
                lblMessage.Text = slotChosen.slotName + " - " + 
                    drinkChosen.name + ": £" + 
                    string.Format("{0:0.00}", drinkChosen.price) + "\n # In Stock - " + slotChosen.stockInSlot;               
            }
            else
            {
                lblMessage.Text = "Item is out of stock!";
            }
        }

        //Loads the item for 'X2'
        private void btn2_Click(object sender, EventArgs e)
        {
            if (letterPressed())
            {
                loadItem(2);
            }
        }

        //Loads the item for 'X3'
        private void btn3_Click(object sender, EventArgs e)
        {
            if (letterPressed())
            {
                loadItem(3);
            }
        }

        //Loads the item for 'X4'
        private void btn4_Click(object sender, EventArgs e)
        {
            if (letterPressed())
            {
                loadItem(4);
            }
        }

        //Loads the item for 'X5'
        private void btn5_Click(object sender, EventArgs e)
        {
            if (letterPressed())
            {
                loadItem(5);
            }
        }

        

        //Loads the panel for them to enter their loyalty card
        private void btnLoyaltyCard_Click(object sender, EventArgs e)
        {
            txtCash.Text = "";
            pnlCash.Enabled = false;
            pnlCard.Enabled = true;
            lblMessage.Text = "Please choose your account\nand enter your loyalty pin.";
        }

        //Loads the panel for them to enter their cash
        private void btnCash_Click(object sender, EventArgs e)
        {
            txtPin.Text = "";
            pnlCard.Enabled = false;
            pnlCash.Enabled = true;
            lblMessage.Text = "Please enter your cash";
        }

        //Confirms they have chosen an item, and entered a card/cash. Then either deposits or refuses.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Drink drinkChosen = drinks.Find(x => x.itemCode == slotChosen.itemCode);
            

            if (!pnlCard.Enabled && !pnlCash.Enabled)
            {
                lblMessage.Text = "Please enter your card or cash";
            }
            else if(pnlCash.Enabled)
            {
                if(verifyCash())
                {
                    double cash = double.Parse(txtCash.Text);
                    if(cash < drinkChosen.price)
                    {
                        lblMessage.Text = "Insufficient Funds!";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Confirm Purchase", "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {

                            double change = (cash - drinkChosen.price);
                            lblMessage.Text = "Drink Dispensed\nChange: £" + string.Format("{0:0.00}", change);
                            btnConfirm.Enabled = false;
                            slotChosen.stockInSlot = slotChosen.stockInSlot - 1;
                            myTimer.Interval = 2000;
                            myTimer.Start();
                        }
                    }
                }
            }
            else if(pnlCard.Enabled)
            {
                
                if (verifyCard())
                {
                    int custNo = int.Parse(cmbCustomers.SelectedValue.ToString());
                    Pre_Pay_Customer customerChosen = customers.Find(x => x.customerNo == custNo);

                    BankAccount customerBank = banks.Find(x => x.loyaltyCardNo == customerChosen.loyaltyCardNo);

                    if(customerBank.amountInAccount < drinkChosen.price)
                    {
                        lblMessage.Text = "Insufficient Funds in\nbank connected to card!";
                    }
                    else
                    {

                        DialogResult dialogResult = MessageBox.Show("Confirm Purchase", "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {

                            lblMessage.Text = "Drink Deposited!";
                            btnConfirm.Enabled = false;
                            slotChosen.stockInSlot = slotChosen.stockInSlot - 1;
                            customerBank.amountInAccount = (customerBank.amountInAccount - drinkChosen.price);
                            myTimer.Interval = 2000;
                            myTimer.Start();

                        }
                    }
                }
            }
            
        }

        //Timer to reset the form after the time is up.
        private void myTimer_Tick(object sender, System.EventArgs e)
        {
            resetForm();
            myTimer.Stop();
        }

        public void loadCustomersIntoCmb()
        {
            cmbCustomers.ValueMember = "customerNo";
            cmbCustomers.DisplayMember = "name";
            cmbCustomers.DataSource = customers;
            cmbCustomers.SelectedIndex = -1;   
        }

        public bool verifyCard()
        {
            bool cardValid = true;
            bool pinOk = false;
            int pin;
            if (cmbCustomers.SelectedIndex < 0)
            {
                lblMessage.Text = "Please choose an account!";
                cardValid = false;
            }

            if (cardValid)
            {
                int custNo = int.Parse(cmbCustomers.SelectedValue.ToString());
                Pre_Pay_Customer customerChosen = customers.Find(x => x.customerNo == custNo);

                try
                {
                    pin = int.Parse(txtPin.Text);
                    if(customerChosen.pinNumber == pin)
                        pinOk = true;
                    else
                        lblMessage.Text = "Invalid Pin.";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Invalid Pin.";
                    pinOk = false;
                }
            }
            return pinOk;
        }

        public bool verifyCash()
        {
            bool ok = true;
            double cash;
            try
            {
                cash = double.Parse(txtCash.Text);
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Invalid Amount!\nPlease try again.";
                ok = false;
            }

            bool isValid = double.TryParse(txtCash.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out cash);
            if (!isValid)
                ok = false;

            return ok;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        /* sean */

        private void btnAdminUpdateStock_Click(object sender, EventArgs e)
        {
            pnlChangePrice.Enabled = false;
            pnlChangeStock.Enabled = true;
            btnAdminUpdatePrice.Enabled = false;
            txtAdminCash.Text = "";
            pnlAdminKeypad.Enabled = true;
            btnAdminConfirm.Enabled = true;
        }

        private void btnAdminUpdatePrice_Click(object sender, EventArgs e)
        {
            pnlChangeStock.Enabled = false;
            pnlChangePrice.Enabled = true;
            btnAdminUpdateStock.Enabled = false;
            txtAdminQuantity.Text = "";
            pnlAdminKeypad.Enabled = true;
            btnAdminConfirm.Enabled = true;

        }

        private void btnAdminCancel_Click(object sender, EventArgs e)
        {
            pnlChangePrice.Enabled = false;
            pnlChangeStock.Enabled = false;
            btnAdminUpdatePrice.Enabled = true;
            txtAdminCash.Text = "";
            btnAdminUpdateStock.Enabled = true;
            txtAdminQuantity.Text = "";
            pnlAdminKeypad.Enabled = false;
            btnAdminConfirm.Enabled = false;


            lblMessage.Text = "Please choose an Item to Update.";

        }

      

        private void btnAdminA_Click(object sender, EventArgs e)
        {
            lblAdminText.Text = "A";
        }

        private void btnAdminB_Click(object sender, EventArgs e)
        {
            lblAdminText.Text = "B";

        }

        private void btnAdminC_Click(object sender, EventArgs e)
        {
            lblAdminText.Text = "C";

        }

        private void btnAdminD_Click(object sender, EventArgs e)
        {
            lblAdminText.Text = "D";

        }

        private void btnAdminE_Click(object sender, EventArgs e)
        {
            lblAdminText.Text = "E";
        }

        private void btnAdmin1_Click(object sender, EventArgs e)
        {
            if (adminLetterPressed())
            {
                loadAdminItem(1);
            }
        }

        private void btnAdmin2_Click(object sender, EventArgs e)
        {
            if (adminLetterPressed())
            {
                loadAdminItem(2);
            }
        }

        private void btnAdmin3_Click(object sender, EventArgs e)
        {
            if (adminLetterPressed())
            {
                loadAdminItem(3);
            }
        }

        private void btnAdmin4_Click(object sender, EventArgs e)
        {
            if (adminLetterPressed())
            {
                loadAdminItem(4);
            }
        }

        private void btnAdmin5_Click(object sender, EventArgs e)
        {
            if (adminLetterPressed())
            {
                loadAdminItem(5);
            }
        }

        private void btnAdminConfirmUpdate_Click(object sender, EventArgs e)
        {
            Drink drinkChosen = drinks.Find(x => x.itemCode == slotChosen.itemCode);


            if (!pnlChangeStock.Enabled && !pnlChangePrice.Enabled)
            {
                lblAdminText.Text = "Please Select an option.";
            }
            else if (pnlChangePrice.Enabled)
            {
                if (verifyCashChange())
                {
                    double cashChange = double.Parse(txtAdminCash.Text);
                    if (drinkChosen.price < 0)
                    {
                        lblMessage.Text = "Invalid Price Change! \nTry Again.";
                    }
                    else
                    {
                        double change = (drinkChosen.price = cashChange);
                        lblAdminText.Text = "Price Change to: " + cashChange;
                     
                    }
                }
            }
            else if (pnlChangeStock.Enabled)
            {

                if (verifyStockChange())
                {
                    int quantity = int.Parse(txtAdminQuantity.Text);

                    if (quantity < 0)
                    {
                        lblAdminText.Text = "Invalid Adjustment! Try Again.";
                    }
                    else if (quantity > 8)
                    {
                        lblAdminText.Text = "Max 8 only! Try Again.";
                    }
                    else
                    {
                        lblAdminText.Text = "Stock Adjusted!";
                        slotChosen.stockInSlot = quantity;
                       
                    }
                }
            }
        }

        public bool verifyCashChange()
        {
            bool ok = true;
            double cash;
 
            try
            {
                cash = double.Parse(txtAdminCash.Text);

                bool isValid = double.TryParse(txtAdminCash.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out cash);
                if (!isValid)
                    ok = false;

                if (cash < 0)
                {
                    lblAdminText.Text = "Invalid Amount!\nPlease try again.";
                    ok = false;
                }

            }
            catch (Exception ex)
            {
                lblAdminText.Text = "Invalid Amount!\nPlease try again.";
                ok = false;
            }

          

            return ok;
        }

        public bool verifyStockChange()
        {

            bool ok = true;
            int quantity;
            try
            {
                quantity = int.Parse(txtAdminQuantity.Text);

            }
            catch(Exception ex)
            {
                lblAdminText.Text = "Invalid Quantity! \nPlease try again.";
                ok = false;
            }

            bool isValid = int.TryParse(txtAdminQuantity.Text, NumberStyles.Integer, CultureInfo.GetCultureInfo(""), out quantity);
            if (!isValid)
                ok = false;

            return ok;
        }


        public void loadAdminItem(int num)
        {
            slotChosen = slots.Find(x => x.slotName == lblAdminText.Text + num);
            Drink drinkChosen = drinks.Find(x => x.itemCode == slotChosen.itemCode);
            if (slotChosen.stockInSlot > 0)
            {
                lblAdminText.Text = slotChosen.slotName + " - " +
                    drinkChosen.name + ": £" +
                    string.Format("{0:0.00}", drinkChosen.price) + "\n # In Stock - " + slotChosen.stockInSlot;
            }
            else
            {
                lblAdminText.Text = "Item is out of stock!";
            }
        }

        private Boolean adminLetterPressed()
        {
            bool pressed = false;

            if (lblAdminText.Text.Length == 1)
            {
                pressed = true;
            }

            return pressed;
        }

        private void btnAdminConfirm_Click(object sender, EventArgs e)
        {
            pnlAdminKeypad.Enabled = false;
            btnAdminConfirmUpdate.Enabled = true;
        }


    }
}
