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
import java.time.LocalDate;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

import javax.swing.*;


public class DeleteProduct extends JFrame implements ActionListener {

	private JLabel lblHeader,lblSearch, lblBLANK,lblDetails;
	private JTextField txtSearch;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[8];
	private JTextArea taDelDis;
	private JButton btnSearch, btnDelete, btnCancel, btnExit;
	private JPanel centre;
	
	private HashMap<Integer, Product> products;

	
	DeleteProduct(HashMap<Integer, Product> local)
	{
		products = local;
		
		//JLabels - setting properties & values
				lblHeader = new JLabel("Delete Products", JLabel.CENTER);
				lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
				lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
				lblDetails.setFont(new Font("Calibri", Font.ITALIC, 18));
				lblSearch = new JLabel("Search by Product ID:", JLabel.RIGHT);
				lblSearch.setFont(new Font("Calibri", Font.BOLD, 16));
				
				//JTextField properties & values
				txtSearch = new JTextField(10);
				
				
				//JTextArea properties & values
				taDelDis = new JTextArea(10,10);
				taDelDis.setEditable(false);
	

				//JButton properties & values
				btnDelete = new JButton("Delete");
				btnDelete.setFont(new Font("Calibri", Font.BOLD, 16));
				btnDelete.addActionListener(this);
				btnSearch = new JButton("Search");
				btnSearch.setFont(new Font("Calibri", Font.BOLD, 16));
				btnSearch.addActionListener(this);
				btnCancel = new JButton("Cancel");
				btnCancel.setFont(new Font("Calibri", Font.BOLD, 16));
				btnCancel.addActionListener(this);
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
				addComp(lblSearch, centre,1,3,1,1,2,2);
				addComp(txtSearch, centre,2,3,1,1,2,2);
				addComp(btnSearch, centre,3,3,1,1,2,2);
				addComp(btnDelete, centre,3,3,1,1,2,2);
				addComp(taDelDis, centre,1,4,4,4,4,4);
				addComp(btnCancel,centre,3,10,1,1,2,2);
				addComp(btnExit,centre,4,10,1,1,2,2);
				
				display();

				
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
			
			
			
			private void display()
			{
				taDelDis.setText("");	
				taDelDis.append("Displaying All Products \n");
				taDelDis.append("Date: " + LocalDate.now().toString() + "\n");
				taDelDis.append("Product ID               Name            Category             Size            Price (£)       Stock Level       Amount Sold \n");
				Iterator i = products.entrySet().iterator(); 
				while(i.hasNext())
				{
					Map.Entry me = (Map.Entry) i.next();
					taDelDis.append(me.getValue().toString());

				}

			}
			
			private void reset()
			{				txtSearch.setText("");

				btnDelete.setVisible(false);
				btnSearch.setVisible(true);
				display();
			}
			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				
			if(e.getSource() == btnExit)
			{
				this.setVisible(false);
			}
			
		
			

			if(e.getSource() == btnSearch)
			{
				Product delProduct = new Product();
				delProduct = products.get(Integer.parseInt(txtSearch.getText()));
				
				if(delProduct == null)
				{
					JOptionPane.showMessageDialog(null, "NONE FOUND, \nProduct ID not found. Please try again.", "ERROR",
							JOptionPane.ERROR_MESSAGE);
					txtSearch.setText("");			
					lblDetails.setText("Re-Enter an ID!");
				}
				else if (delProduct != null)
				{
					lblDetails.setText("Product ID:" + delProduct.getProductID() + " Has Been Found!");
					taDelDis.setText("Is this the correct Product? \n " + delProduct.toDisplay());
					btnDelete.setVisible(true);
					btnSearch.setVisible(false);
				}
		
			}
			

			if(e.getSource() == btnDelete)
			{
				lblDetails.setText("Product Deleted!");
				products.remove(Integer.parseInt(txtSearch.getText()));
				reset();

			}
			
			if(e.getSource() == btnCancel)
			{
				lblDetails.setText("Deletion Cancelled!");
				reset();

					
			}
			
		
}}
