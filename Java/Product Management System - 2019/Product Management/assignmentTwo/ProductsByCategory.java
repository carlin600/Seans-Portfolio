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

public class ProductsByCategory extends JFrame implements ActionListener {

	//Navigation & Design properties and values
	private JLabel lblHeader, lblDetails, lblCategory;
	private JTextArea taCategories;
	private JComboBox cmbCategory;
	private JButton btnExit, btnGenFile;
	private JPanel centre;

	//declare hashmap
	private HashMap<Integer,Product> products;
	
	
	ProductsByCategory(HashMap<Integer,Product> local)
	{
		products = local;
		
		//Jlabels
		lblHeader = new JLabel("Products By Category", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.BOLD, 18));
		lblCategory = new JLabel("Select Category", JLabel.RIGHT);
		lblCategory.setFont(new Font("Calibri", Font.BOLD, 18));
	
		//JTextarea
		taCategories = new JTextArea(10,10);
		taCategories.setEditable(false);
		
		//array for the combo box
		String[] categories = {"- Select Option -", "Beauty", "Food", "Sports Nutrition", "Vitamins", "Weight Loss"};
		cmbCategory = new JComboBox(categories);
		cmbCategory.addActionListener(this);
	
		//Jbutton properties and values
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
				addComp(cmbCategory, centre,2,3,1,1,2,2);
				addComp(taCategories, centre,1,4,4,4,4,4);
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
	
	//various methods that help functionality in the program
	private void reset()
	{
		taCategories.setText("");
	}
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
		if(e.getSource() == btnExit)
		{
			this.setVisible(false);
		}
	
		//combo box
		//whatever combo index is chosen, the category is then set and display via iterator
		if(e.getSource() == cmbCategory)
		{
			int number;
			String Category = "";
			number = cmbCategory.getSelectedIndex();
			
			switch(number) {
			case 0:
			
				break;
				
			case 1:
			Category = "Beauty";
			reset();
				break;
				
			case 2:
				Category = "Food";
				reset();

					break;
					
			case 3:
				Category = "Sports Nutrition";
				reset();

					break;
					
			case 4:
				Category = "Vitamins";
				reset();

				break;
					
			case 5:
				Category = "Weight Loss";
				reset();

					break;
					
					
			
			}
			
			Iterator i = products.entrySet().iterator(); 
			taCategories.append("You have Chosen " + cmbCategory.getSelectedItem() + " Products! \n");
			taCategories.append("Date: " + LocalDate.now().toString() + "\n");
			taCategories.append("Product ID               Name            Category             Size            Price (£)       Stock Level       Amount Sold \n");
				while(i.hasNext())
				{								Map.Entry me = (Map.Entry) i.next();

				if( products.get(me.getKey()).getCategory().equals(Category))
				{
					taCategories.append(me.getValue().toString());
				}
				}
			}
		
		
		//Generates a report inputting the given information
		if(e.getSource() == btnGenFile)
		{
			lblDetails.setText("Report Generated!");
			//Product print;
			String report;
			//open the text file to add the all sales report
			File inFile = new File("ProductByCategory_Report.txt");
			PrintWriter in = null;
			try {
				in = new PrintWriter(inFile);
			} catch (FileNotFoundException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			//set the header for the report
			in.println(" - - - - - - - - - - - - - - - - - - - - P R O D U C T S  B Y  C A T E G O R Y  R E P O R T - - - - - - - - - - - - - - - - - - - - - ");
			in.println("- - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
			in.println("");
			in.println("Product ID        Product Name        Category             Size           Unit Price £    Stock Level         # Sold");
			in.println(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");			
			in.print(taCategories.getText());
			
			in.close();
		}
		
		}
	}


