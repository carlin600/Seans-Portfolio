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

public class DisplayStock extends JFrame implements ActionListener {

	//decalre variables
	private JLabel lblHeader, lblDetails;
	private JTextArea taDisplay;
	private JButton btnExit;
	private JPanel centre;
	
	
	//declare hashmap
	private HashMap<Integer, Product> products;
	
	DisplayStock(HashMap<Integer, Product> local)
	{
		products = local;
		
		//Jlabels
		lblHeader = new JLabel("Displaying Products", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 18));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.ITALIC, 17));
		
		//Jtextarea
		taDisplay = new JTextArea(20,20);
		taDisplay.setEditable(false);
		
		//Jbuttons
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
		addComp(taDisplay, centre,1,4,2,2,2,2);
		addComp(btnExit, centre,1,6,4,2,2,2);
		
		
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
	
	//displays the products via an iterator
	private void display()
	{
		taDisplay.append("Displaying all Products \n");
		taDisplay.append("Date: " + LocalDate.now().toString() + "\n");
		taDisplay.append("Product ID               Name            Category             Size            Price (£)       Stock Level       Amount Sold \n");
		Iterator i = products.entrySet().iterator(); 
		while(i.hasNext())
		{
			Map.Entry me = (Map.Entry) i.next();
			taDisplay.append(me.getValue().toString());

		}
	}
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
		if(e.getSource() == btnExit)
		{
			this.setVisible(false);
		}
		
	}
	
	

}
