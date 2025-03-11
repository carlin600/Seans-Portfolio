package assignmentTwo;

import java.awt.AWTEvent;
import java.awt.Color;
import java.awt.Component;
import java.awt.Container;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Map;

import javax.swing.*;

import bookings.RoomBooking;

public class MakeSale extends JFrame implements ActionListener {
	
	//declare variables
	private JLabel lblHeader, lblDetails, lblSaleid,lblProduct, lblPrice, lblName;
	private JButton btnExit, btnATB, btnNewSale, btnCheckout;
	private JComboBox cmbCategory;
	private JTextField txtSearch, txtSaleid, txtPrice, txtName;
	private JTextArea taDisplay, taItemDisplay, taBasket;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[8];
	private JPanel centre; 
	//declare hashmaps
	private	HashMap<Integer, Product> products;
	
	//create new linkedlists using two classes.
	LinkedList<Sale> sales = new LinkedList<Sale>();
	LinkedList<Basket> basket = new LinkedList<Basket>();

	//declaring list variables
	private Basket basketitem;
	private Sale checkout;
	
	private int saleID = 1000;
	private double price;
	private boolean valid;
	
	//MakeSale(LinkedList<Sale> local) {
	//	sales = local;

	MakeSale(HashMap<Integer, Product> local ) {
		
		
		products = local;
		basketitem = new Basket();
		checkout = new Sale();
		
		//Jlabels
		lblHeader = new JLabel("Make Sale", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.BOLD, 18));
		lblSaleid = new JLabel("Sale ID:", JLabel.RIGHT);
		lblSaleid.setFont(new Font("Calibri", Font.BOLD, 18));
		lblPrice = new JLabel("£", JLabel.RIGHT);
		lblPrice.setFont(new Font("Calibri", Font.BOLD, 18));
		lblName = new JLabel("Name:", JLabel.CENTER);
		lblName.setFont(new Font("Calibri", Font.BOLD, 18));
		lblProduct = new JLabel("Enter Product ID:", JLabel.RIGHT);
		lblProduct.setFont(new Font("Calibri", Font.BOLD, 18));
		
		//JTextField properties & Values
		txtSearch = new JTextField(4);
		txtSaleid = new JTextField(4);
		txtSaleid.setEditable(false);
		txtPrice = new JTextField(6);
		txtPrice.setEditable(false);
		txtName = new JTextField(4);


		//JTextArea properties & values
		taDisplay = new JTextArea(10,10);
		taDisplay.setEditable(false);
		taItemDisplay = new JTextArea(10,10);
		taItemDisplay.setEditable(false);
		taBasket = new JTextArea(10,10);
		taBasket.setEditable(false);
		
		//JButton properties & values
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
	
		btnATB = new JButton("Add To Basket");
		btnATB.setFont(new Font("Calibri", Font.BOLD, 16));
		btnATB.addActionListener(this);
	
		btnCheckout = new JButton("Checkout");
		btnCheckout.setFont(new Font("Calibri", Font.BOLD, 16));
		btnCheckout.addActionListener(this);
		
		btnNewSale = new JButton("New Sale");
		btnNewSale.setFont(new Font("Calibri", Font.BOLD, 16));
		btnNewSale.addActionListener(this);
		
		
		// JComboBox properties & values
		String[] categories = {"- Select Category -", "Beauty", "Food", "Sports Nutrition", "Vitamins", "Weight Loss"};
		cmbCategory = new JComboBox(categories);
		cmbCategory.addActionListener(this);
		cmbCategory.setEditable(false);
		
		
		//JPanel properties & settings
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);
		
		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);
		
		addComp(centre,main,1,1,1,1,1,1);
		addComp(lblHeader,centre,1,1,5,1,2,2);
		addComp(lblDetails,centre,2,2,3,1,2,2);
		addComp(lblName, centre,1,2,1,1,2,2);
		addComp(txtName,centre,1,3,1,1,2,2);
		addComp(cmbCategory,centre,1,4,1,1,2,2);
		addComp(lblProduct,centre,2,3,1,1,2,2);
		addComp(txtSearch, centre,3,3,1,1,2,2);
		addComp(btnATB,centre,2,4,2,1,2,2);
		addComp(taDisplay,centre,1,5,3,5,2,2);
		addComp(taItemDisplay, centre,4,5,2,2,2,2);
		addComp(taBasket, centre,4,7,2,2,2,2);
		addComp(lblPrice,centre,4,9,1,1,2,2);
		addComp(txtPrice,centre,5,9,1,1,2,2);
		addComp(lblSaleid,centre,4,3,1,1,2,2);
		addComp(txtSaleid,centre,5,3,1,1,2,2);
		addComp(btnCheckout,centre,4,11,2,1,2,2);
		addComp(btnNewSale,centre,4,11,2,1,2,2);
		addComp(btnExit, centre,1,11,1,1,2,2);

		saleID();
	}
	
	//AddComp controls the overall layout of the components and panels through X,Y grid positioning
	private void addComp(Component c, Container main, int gridX, int gridY, int width, int height, int weightX, int weightY)
	{		  //here is GC V
		GridBagConstraints gc = new GridBagConstraints(); //creates constraints object gc
		gc.fill = GridBagConstraints.BOTH; // two constraints that are the same for all components
		gc.insets = new Insets(5,5,5,5); //adds constraints to constraints object gc
		gc.gridx = gridX; //
		gc.gridy = gridY; //
		gc.gridwidth = width; //
		gc.gridheight = height; //
		gc.weightx = weightX; //
		gc.weighty = weightY; //
		
		getContentPane().add(c, gc); //adds components to the GridBag
		
	}
	
	
	//methods to help with functionality, setting displays and also resetting/disabling components.
	private void saleID()
	{
		saleID += 1;
		txtSaleid.setText(Integer.toString(saleID));
	}
	
	private void display()
	{
		Iterator i = products.entrySet().iterator(); 
		while(i.hasNext())
		{
			Map.Entry me = (Map.Entry) i.next();
			taDisplay.append(me.getValue().toString());

		}
	}
	

	private void resetSearch() {
		txtSearch.setText("");
	}
	
	private void resetDisplay() {
		taDisplay.setText("");
	}
	
	private void resetItemDisplay() {
		taItemDisplay.setText("");
	}
	
	private void reset()
	{
		btnCheckout.setVisible(true);
		btnNewSale.setVisible(false);		
		cmbCategory.setSelectedIndex(0);
		txtName.setText("");
		taBasket.setText("");
		resetItemDisplay();
		resetDisplay();
		resetSearch();
		lblDetails.setText("Application Reset!");
	}

	
	private void price()
	{
		txtPrice.setText(Double.toString(price));
	}

	private void displayCategory()
	{
		int number;
		String Category = "";
		number = cmbCategory.getSelectedIndex();

		switch (number) {
		case 0:
			taDisplay.setText("Select a Category of the product you wish to find and enter the Product ID into the text field "+ "\n to either Add Or Remove the item from your basket");
			break;

		case 1:
			resetDisplay();
			Category = "Beauty";
			break;

		case 2:
			resetDisplay();
			Category = "Food";
			break;

		case 3:
			resetDisplay();
			Category = "Sports Nutrition";
			break;

		case 4:
			resetDisplay();
			Category = "Vitamins";
			break;

		case 5:
			resetDisplay();
			Category = "Weight Loss";
			break;
		}

		Iterator i = products.entrySet().iterator();

		while (i.hasNext()) {
			Map.Entry me = (Map.Entry) i.next();

			if (products.get(me.getKey()).getCategory() == Category) {
				lblDetails.setText(Category + " Selected!");
				taDisplay.append("You have Chosen " + cmbCategory.getSelectedItem() + " Products! \n");
				taDisplay.append(me.getValue().toString());
			}
		}
	}
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		if (e.getSource() == btnExit) {
			this.setVisible(false);
		}

		if (e.getSource() == cmbCategory) {
			displayCategory();
		}
		
		if (e.getSource() == btnATB) {
			resetItemDisplay();

			valid = true;
			Product item = new Product();
			item = products.get(Integer.parseInt(txtSearch.getText()));

			if(txtSearch.getText() == "")
			{				
				JOptionPane.showMessageDialog(null, "Enter a valid ID!","Error!",  JOptionPane.ERROR_MESSAGE);
				valid = false;
				
			}
			
			try {
				item.setStockLevel(item.getStockLevel() - 1);
			} catch (ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "None in stock!","Error!",  JOptionPane.ERROR_MESSAGE);
				valid = false;
			}
			
			
			if(valid == true)
			{
				item.setNoSold(item.getNoSold() + 1);
				
				price += item.getUnitPrice();
				basketitem.setID(item.getProductID());
				basketitem.setQuantity(item.getNoSold());
				basketitem.setPrice(price);
				basket.add(basketitem);
				
				lblDetails.setText("Product ID:" + item.getProductID() + " Has Been Added To Your Basket!");
				taItemDisplay.append(item.toDisplay());
				taBasket.append(item.toString());
				price();
				resetDisplay();
				resetSearch();
				displayCategory();
			}
			else if (valid == false)
			{
				lblDetails.setText("Fill in required fields!");

			}
			
			
			


		}
	
		//processes all the items that are from the basket linkedlist and stores them in to the sale linkedlist.
		//They are then printed out to the screen
		if (e.getSource() == btnCheckout) {
			resetDisplay();
			String codes = "";
			valid = true;

			checkout.setSaleID(Integer.parseInt(txtSaleid.getText()));
			try {
				checkout.setCustomerName(txtName.getText());
			} catch (ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1 + "***", "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
				

			}
	
			if(valid == true)
			{
				checkout.setDateSold(LocalDate.now());
				checkout.setTotalPrice(price);
				
				Iterator it = basket.iterator();
				while(it.hasNext())
				{
					codes += ((Basket) it.next()).getID() + ",";
				}
		
				checkout.setProductCodes(codes);
				
				lblDetails.setText("Check-Out Complete!");
				taDisplay.setText("Sale ID    Customer Name        Product Codes                     Date Sold         Total Price £ \n");
				sales.add(checkout);
				taDisplay.append(sales.toString());
				btnCheckout.setVisible(false);
				btnNewSale.setVisible(true);
			}

	}
		
		if(e.getSource() == btnNewSale)
		{
			reset();
			lblDetails.setText("New Sale!");
			saleID++;
		}
		
		
	}
}
