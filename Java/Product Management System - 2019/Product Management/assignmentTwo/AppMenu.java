package assignmentTwo;

import javax.swing.*;

import hashMap.Student;

import java.awt.Color;
import java.awt.Component;
import java.awt.Container;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Image;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.HashMap;
import java.util.LinkedList;



public class AppMenu extends JFrame implements ActionListener {

	//Navigation & Design properties and values
	private JMenuBar jmb;
	private JMenu Products, Stock, Reports, Application;
	private JMenuItem miAddProduct, miEditProduct, miDeleteProduct, miDisplayStock, miMakeSale, miLSI, miPBC, miAllSales,miInfo,miHelp, miExit;
	private ImageIcon product, stock, reports, system,add,edit,delete,display,sale,low,category,allsales,info,pdf, help,exit, shop1, shop2;
	private JLabel lbldisImage, lbldisImage2, lblHeader;
	private JButton btnExit;
	private JPanel centre;
	
	//Hashmap & LinkedList Declarations/Created
	private HashMap <Integer, Product> products = new HashMap <Integer, Product>(50);	
	private LinkedList<Sale> sales = new LinkedList<Sale>();
	

	File productsFile = new File("stock.dat");
	File salesFile = new File("sales.dat");
	//Main
	public AppMenu()
	{
		productsIN();
		salesIN();		
		//get the rest of the icons ---------------------------------------------------------------
		//icon code followed by their properties for images, icons and graphics
		product = (new ImageIcon(new ImageIcon(getClass().getResource("products.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		stock =    (new ImageIcon(new ImageIcon(getClass().getResource("stock.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		reports =  (new ImageIcon(new ImageIcon(getClass().getResource("reports.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		system =   (new ImageIcon(new ImageIcon(getClass().getResource("system.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		add =      (new ImageIcon(new ImageIcon(getClass().getResource("add.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		edit =     (new ImageIcon(new ImageIcon(getClass().getResource("edit.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		delete =   (new ImageIcon(new ImageIcon(getClass().getResource("delete.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		display =  (new ImageIcon(new ImageIcon(getClass().getResource("display.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		sale =     (new ImageIcon(new ImageIcon(getClass().getResource("sale.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		low =      (new ImageIcon(new ImageIcon(getClass().getResource("low.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		category = (new ImageIcon(new ImageIcon(getClass().getResource("category.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		allsales = (new ImageIcon(new ImageIcon(getClass().getResource("allsales.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		info =     (new ImageIcon(new ImageIcon(getClass().getResource("info.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		pdf =      (new ImageIcon(new ImageIcon(getClass().getResource("pdf.png")).getImage().getScaledInstance(45, 45,Image.SCALE_SMOOTH)));
		help =     (new ImageIcon(new ImageIcon(getClass().getResource("help.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		exit =     (new ImageIcon(new ImageIcon(getClass().getResource("exit.png")).getImage().getScaledInstance(25, 25,Image.SCALE_SMOOTH)));
		shop1 =     (new ImageIcon(new ImageIcon(getClass().getResource("shopping 2.jpg")).getImage().getScaledInstance(450, 400,Image.SCALE_SMOOTH)));
		shop2 =     (new ImageIcon(new ImageIcon(getClass().getResource("shopping.jpg")).getImage().getScaledInstance(450, 400,Image.SCALE_SMOOTH)));

		
		//Menu bar properties
		jmb = new JMenuBar();
		Products = new JMenu("Products");
		Products.setIcon(product);
		Stock = new JMenu("Stock");
		Stock.setIcon(stock);
		Reports = new JMenu("Reports");
		Reports.setIcon(reports);
		Application = new JMenu("System");
		Application.setIcon(system);
		
		//Menu Item properties
		//Within the () you can see the description followed by the icon code
		miAddProduct = new JMenuItem("Add Product", add);
		miEditProduct = new JMenuItem("Edit Product", edit);
		miDeleteProduct = new JMenuItem("Delete Product", delete);
		miDisplayStock = new JMenuItem("Display Stock", display);
		miMakeSale = new JMenuItem("Make Sale", sale);
		miLSI = new JMenuItem("Low Stock Items", low);
		miPBC = new JMenuItem("Products By Category", category);
		miAllSales = new JMenuItem("All Sales", allsales);
		miInfo = new JMenuItem("Information", info);
		miHelp = new JMenuItem("Help", help);
		miExit = new JMenuItem("Exit", exit);
		
		//Adding the Menus to the Menu bar
		jmb.add(Products);
		jmb.add(Stock);
		jmb.add(Reports);
		jmb.add(Application);
		setJMenuBar(jmb);
		
		//All menu items are added to the specific menus on the JMenu
		Products.add(miAddProduct);
		Products.add(miEditProduct);
		Products.add(miDeleteProduct);
		Stock.add(miDisplayStock);
		Stock.add(miMakeSale);
		Reports.add(miLSI);
		Reports.add(miPBC);
		Reports.add(miAllSales);
		Application.add(miInfo);
		Application.add(miHelp);
		Application.add(miExit);
		
	
		//JButton properties
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
		
		//Jlabels
		lblHeader = new JLabel("Please Select an option from the Menu Bar", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 24));
		lbldisImage = new JLabel("", JLabel.CENTER);
		lbldisImage.setIcon(shop1);
		lbldisImage2 = new JLabel("", JLabel.CENTER);
		lbldisImage2.setIcon(shop2);

		//Declaring actionlisteners/actions when specific menu items are selected
		
		miAddProduct.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				AddProduct ap = new AddProduct(products);
				ap.setTitle("Add Product - © Sean Carlin");
				ap.setSize(1200,650);
				ap.setVisible(true);
				
			}
		});
		
		miEditProduct.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				EditProduct ep = new EditProduct(products);
				ep.setTitle("Edit/Update Product - © Sean Carlin");
				ep.setSize(1200,650);
				ep.setVisible(true);
			}
		});
		
		miDeleteProduct.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				DeleteProduct dp = new DeleteProduct(products);
				dp.setTitle("Delete Product - © Sean Carlin");
				dp.setSize(1200,650);
				dp.setVisible(true);
			}
		});
		
		miDisplayStock.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				DisplayStock ds = new DisplayStock(products);
				ds.setTitle("Display Stock - © Sean Carlin");
				ds.setSize(1200,650);
				ds.setVisible(true);
			}
		});
		
		miMakeSale.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				MakeSale ms = new MakeSale(products);
				ms.setTitle("Make Sale - © Sean Carlin");
				ms.setSize(1200,650);
				ms.setVisible(true);
			}
		});
		
		miLSI.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				LowStockItems lsi = new LowStockItems(products);
				lsi.setTitle("Low Stock Items - © Sean Carlin");
				lsi.setSize(1200,650);
				lsi.setVisible(true);
			}
		});
		
		miPBC.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				ProductsByCategory pbc = new ProductsByCategory(products);
				pbc.setTitle("Products By Category - © Sean Carlin");
				pbc.setSize(1200,650);
				pbc.setVisible(true);
			}
		});
		
		miAllSales.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				AllSales as = new AllSales(sales);
				as.setTitle("All Sales - © Sean Carlin");
				as.setSize(1200,650);
				as.setVisible(true);
			}
		});
		
		miInfo.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
					Info in = new Info();
					in.setTitle("Information - © Sean Carlin");
					in.setSize(1200,650);
					in.setVisible(true);
			}
		});
		
		miHelp.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null,
						"Here is a table showing you what the Grades are equivalent to from the chosen Exam Board.",
						"Help", JOptionPane.INFORMATION_MESSAGE, pdf);
			}
		});
		
		miExit.addActionListener(new ActionListener () {
			public void actionPerformed(ActionEvent e) {
				
				productsOUT();
				salesOUT();
				System.exit(0);
				
			}
		});
		
		
		//Layout Properties
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);
		
		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);
		
		
		//Adding components to their grid value.
		addComp(centre,main,1,1,1,1,1,1);
		addComp(lblHeader, centre, 1,2,2,1,2,2);
		addComp(lbldisImage, centre,1,3,1,1,2,2);
		addComp(lbldisImage2, centre,2,3,1,1,2,2);
		addComp(btnExit, centre,1,6,4,2,2,2);
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
		
		
		private void productsIN()
		{

			try
			{
				FileInputStream fis = new FileInputStream(productsFile);
				ObjectInputStream ois = new ObjectInputStream(fis);
				products = (HashMap<Integer, Product>) ois.readObject();
				ois.close();
				fis.close();
			}
			catch(ClassNotFoundException cEx)
			{
				JOptionPane.showMessageDialog(null, "Failed To Read Data!","Error!",  JOptionPane.ERROR_MESSAGE);

			}
			catch(FileNotFoundException fEx)
			{
				JOptionPane.showMessageDialog(null, "No File Found!","Error!",  JOptionPane.ERROR_MESSAGE);

			}
			catch(IOException ioEx)
			{
				JOptionPane.showMessageDialog(null, "Could Not Read From File!","Error!",  JOptionPane.ERROR_MESSAGE);

			}
			
			
		}
		private void salesIN()
		{
			try
			{
				FileInputStream fis = new FileInputStream(salesFile);
				ObjectInputStream ois = new ObjectInputStream(fis);
				products = (HashMap<Integer, Product>) ois.readObject();
				ois.close();
				fis.close();
			}
			catch(ClassNotFoundException cEx)
			{
				JOptionPane.showMessageDialog(null, "Failed To Read Data!","Error!",  JOptionPane.ERROR_MESSAGE);

			}
			catch(FileNotFoundException fEx)
			{
				JOptionPane.showMessageDialog(null, "No File Found!","Error!",  JOptionPane.ERROR_MESSAGE);

			}
			catch(IOException ioEx)
			{
				JOptionPane.showMessageDialog(null, "Could Not Read From File!","Error!",  JOptionPane.ERROR_MESSAGE);

			}
		}
		
		
		private void productsOUT()
		{
			try
			{
				FileOutputStream fos = new FileOutputStream(productsFile);
				ObjectOutputStream oos = new ObjectOutputStream(fos);
				oos.writeObject(products);
				oos.close();
				fos.close();
			}
			catch(FileNotFoundException fEx)
			{
				JOptionPane.showMessageDialog(null, "File Not Found!","Error!",  JOptionPane.ERROR_MESSAGE);
			}
			catch(IOException ioEX)
			{
				JOptionPane.showMessageDialog(null, "Failed to Output Data!","Error!",  JOptionPane.ERROR_MESSAGE);
			}
		}
		
		
		private void salesOUT()
		{
			try
			{
				FileOutputStream fos = new FileOutputStream(salesFile);
				ObjectOutputStream oos = new ObjectOutputStream(fos);
				oos.writeObject(products);
				oos.close();
				fos.close();
			}
			catch(FileNotFoundException fEx)
			{
				JOptionPane.showMessageDialog(null, "File Not Found!","Error!",  JOptionPane.ERROR_MESSAGE);
			}
			catch(IOException ioEX)
			{
				JOptionPane.showMessageDialog(null, "Failed to Output Data!","Error!",  JOptionPane.ERROR_MESSAGE);
			}
		}

	@Override
	public void actionPerformed(ActionEvent e) {		
		if(e.getSource() == btnExit)
		{
			productsOUT();
			salesOUT();
			
			
			System.exit(0);
		}
	}

}
