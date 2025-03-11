package assignmentTwo;


import java.awt.Color;
import java.awt.Component;
import java.awt.Container;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.time.LocalDate;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

import javax.swing.*;


public class LowStockItems extends JFrame implements ActionListener {
	
	//navigation & design properties and values
	private JLabel lblHeader, lblDetails, lblCategory;
	private JTextArea taDisplay;
	private JComboBox cmbQuantity;
	private JButton btnExit, btnGenFile;
	private JPanel centre;
	
	//declare hashmap
	private HashMap<Integer, Product> products;
	
	LowStockItems(HashMap <Integer, Product> local)
	{
		products = local;
		
		//Jlabels
		lblHeader = new JLabel("Low Stock Items", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.BOLD, 18));
		lblCategory = new JLabel("Select Category", JLabel.RIGHT);
		lblCategory.setFont(new Font("Calibri", Font.BOLD, 18));
		
		//Jtextarea
		taDisplay = new JTextArea(10,10);
		taDisplay.setEditable(false);
		
		//array for the combo box
		String[] categories = {"- Select Option -", "5", "10", "25", "50", "75", "100"};
		cmbQuantity = new JComboBox(categories);
		cmbQuantity.addActionListener(this);
		
		//JButton properties and values
		btnGenFile = new JButton("Generate Report");
		btnGenFile.setFont(new Font("Calibri", Font.BOLD, 16));
		btnGenFile.addActionListener(this);
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
		
		//JPanel properties & settings
				Container main = getContentPane();
				main.setLayout(new GridBagLayout());
				main.setBackground(Color.CYAN);
				
				centre = new JPanel();
				centre.setLayout(new GridBagLayout());
				centre.setBackground(Color.CYAN);
				
				addComp(centre,main,1,1,1,1,1,1);
				addComp(lblHeader,centre,1,1,4,1,2,2);
				addComp(lblDetails,centre,1,2,4,1,2,2);
				addComp(lblCategory, centre,1,3,1,1,2,2);
				addComp(cmbQuantity, centre,2,3,1,1,2,2);
				addComp(taDisplay, centre,1,4,4,4,4,4);
				addComp(btnGenFile, centre, 1, 10, 2, 1, 2, 2);
				addComp(btnExit,centre,4,10,1,1,2,2);
				
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
	
	//resets text area display
	private void reset()
	{
		taDisplay.setText("");
	}
	
		
	
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
		//exits program/window
		if(e.getSource() == btnExit)
		{
			this.setVisible(false);
		}
		
		
		//the user selects the quantity of the products with less of the chosen option
		//it is then displayed via iterator
		if(e.getSource() == cmbQuantity)
		{
			int number;
			String Quantity = "";
			number = cmbQuantity.getSelectedIndex();
			
			switch(number) {
			
			case 6:
				Quantity = "100";
				reset();
					break;
					
			case 5:
				Quantity = "75";
				reset();
					break;
					
			case 4:
				Quantity = "50";
				reset();
				break;
				
			case 3:
				Quantity = "25";
				reset();
					break;
					
			case 2:
				Quantity = "10";
				reset();
					break;
					
			case 1:
				Quantity = "5";
			reset();
				break;
				
			case 0:
			
				break;

					
			
			}
			
			Iterator i = products.entrySet().iterator(); 
			taDisplay.append("Stock Levels Below " + cmbQuantity.getSelectedItem() + " Selected! \n");
			taDisplay.append("Date: " + LocalDate.now().toString() + "\n");
			taDisplay.append("Product ID               Name            Category             Size            Price (£)       Stock Level       Amount Sold \n");

				while(i.hasNext())
				{								Map.Entry me = (Map.Entry) i.next();

				if( products.get(me.getKey()).getStockLevel() <= Integer.parseInt(Quantity))
				{
					taDisplay.append(me.getValue().toString());
				}
				}
			}
		
		if(e.getSource() == btnGenFile)
		{
			lblDetails.setText("Report Generated!");
			//Product print;
			String report;
			//open the text file to add the all sales report
			File inFile = new File("LowStockItems_Report.txt");
			PrintWriter in = null;
			try {
				in = new PrintWriter(inFile);
			} catch (FileNotFoundException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			//set the header for the report
			in.println(" - - - - - - - - - - - - - - - - - - - - L O W  S T O C K  I T E M S  R E P O R T - - - - - - - - - - - - - - - - - - - - - ");
			in.println("- - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
			in.println("");
			in.println("Sale ID        Customer Name        Product Codes                                  Date Sold         Total Price £");
			in.println(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");			
			in.print(taDisplay.getText());

			
			in.close();
		}
		
		}
	
	}


