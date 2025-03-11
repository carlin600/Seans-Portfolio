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
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Map;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;

public class AllSales extends JFrame implements ActionListener {

	//declare variavles
	private JLabel lblHeader, lblDetails, lblCategory;
	private JTextArea taDisplay;
	private JButton btnGenFile,btnExit;
	private JPanel centre;
	
	private LinkedList<Sale> sales;

	AllSales(LinkedList<Sale> local) {

		sales = local;
		//Jlabels
		lblHeader = new JLabel("All Sales", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.BOLD, 18));
		
		//JButtons
		btnGenFile = new JButton("Generate Report");
		btnGenFile.setFont(new Font("Calibri", Font.BOLD, 16));
		btnGenFile.addActionListener(this);
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);

		//JTextAreas
		taDisplay = new JTextArea(10,10);
		taDisplay.setEditable(false);
				
		// JPanel properties & settings
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 1, 4, 1, 2, 2);
		addComp(lblDetails, centre, 1, 2, 4, 1, 2, 2);
		addComp(taDisplay, centre,1,4,4,4,4,4);
		addComp(btnGenFile, centre, 1, 10, 2, 1, 2, 2);
		addComp(btnExit, centre, 4, 10, 1, 1, 2, 2);

		display();
	}
	
	private void display()
	{	taDisplay.append("Sale ID        Customer Name            Product Codes                                  Date Sold         Total Price £ \n");
		taDisplay.append(sales.toString());
	}

//AddComp controls the overall layout of the components and panels through X,Y grid positioning
	private void addComp(Component c, Container main, int gridX, int gridY, int width, int height, int weightX,
			int weightY) { // here is GC V
		GridBagConstraints gc = new GridBagConstraints(); // creates constraints object gc
		gc.fill = GridBagConstraints.BOTH; // two constraints that are the same for all components
		gc.insets = new Insets(5, 5, 5, 5); // adds constraints to constraints object gc
		gc.gridx = gridX; //
		gc.gridy = gridY; //
		gc.gridwidth = width; //
		gc.gridheight = height; //
		gc.weightx = weightX; //
		gc.weighty = weightY; //

		getContentPane().add(c, gc); // adds components to the GridBag

	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		if (e.getSource() == btnExit) {
			this.setVisible(false);
		}
		
		//Generates report and inputs given info to a text file
		if(e.getSource() == btnGenFile)
		{
			lblDetails.setText("Report Generated!");
			Sale print;
			String report;
			//open the text file to add the all sales report
			File inFile = new File("All_Sales_Report.txt");
			PrintWriter in = null;
			try {
				in = new PrintWriter(inFile);
			} catch (FileNotFoundException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			//set the header for the report
			in.println(" - - - - - - - - - - - - - - - - - - - - A L L  S A L E S  R E P O R T - - - - - - - - - - - - - - - - - - - - - ");
			in.println("- - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
			in.println("");
			in.println("Sale ID        Customer Name        Product Codes                                  Date Sold         Total Price £");
			in.println(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");
			
			//loop through requests in queue to allocate tickets
			while(sales.isEmpty() == false)
			{
				print = sales.peek();
				
				//generate string for report and send it to the text file
				report = String.format(" %-8d %-10s %-15s  %10s %6f \n", print.getSaleID(), print.getCustomerName(), print.getProductCodes(),
						print.getDateSold(), print.getTotalPrice());
						
					in.println(report);
				//remove (pop) request from the queue
				sales.remove(report);
				
			}
			in.close();
		}

	}

}
