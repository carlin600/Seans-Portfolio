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
import java.util.HashMap;
import java.util.Iterator;
import java.util.ListIterator;
import java.util.*;

import javax.swing.*;

public class AddProduct extends JFrame implements ActionListener {

	
	//declare variables
	private JLabel lblHeader, lblBLANK, lblDetails, lblID, lblName, lblSize, lblCategory, lblUnitprice, lblStocklevel;
	private JTextField txtID, txtName, txtUnitprice, txtStocklevel;
	private JComboBox cmbSize, cmbCategory;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[8];
	private JTextArea taAddDis, taAddDis2;
	private JButton btnReset, btnCancel, btnAdd, btnAddNew, btnExit;
	private JPanel centre;
	//sets the product ID's
	private int 
	beauty = 1000, 
	food = 2000, 
	sportsnutrition = 3000,
	vitamins = 4000,
	weightloss = 5000;
	
	//for validation purposes.
	private boolean valid;

	//declare hashmap
	private HashMap<Integer, Product> products;
	//gets rid of the warning lines under my combo model box
	@SuppressWarnings({ "unchecked", "rawtypes" })

	AddProduct(HashMap<Integer, Product> local) {
		products = local;

		// JLabels - setting properties & values
		lblHeader = new JLabel("Add New Products", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.ITALIC, 17));
		lblID = new JLabel("Product ID", JLabel.LEFT);
		lblID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Product Name", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblSize = new JLabel("Product Size", JLabel.LEFT);
		lblSize.setFont(new Font("Calibri", Font.BOLD, 16));
		lblCategory = new JLabel("Product Category", JLabel.LEFT);
		lblCategory.setFont(new Font("Calibri", Font.BOLD, 16));
		lblUnitprice = new JLabel("Unit Price (£)", JLabel.LEFT);
		lblUnitprice.setFont(new Font("Calibri", Font.BOLD, 16));
		lblStocklevel = new JLabel("Stock Level", JLabel.LEFT);
		lblStocklevel.setFont(new Font("Calibri", Font.BOLD, 16));

		// JTextField properties & values
		txtID = new JTextField(10);
		txtID.setText("Chose Category");
		txtID.setEditable(false);
		txtName = new JTextField(10);
		txtUnitprice = new JTextField(10);
		txtStocklevel = new JTextField(10);

		// JTextArea properties & values
		taAddDis = new JTextArea(15, 15);
		taAddDis.setEditable(false);
		taAddDis2 = new JTextArea(15, 15);
		taAddDis2.setEditable(false);

		// JButton properties & values
		btnReset = new JButton("Reset");
		btnReset.setFont(new Font("Calibri", Font.BOLD, 16));
		btnReset.addActionListener(this);
		btnCancel = new JButton("Cancel");
		btnCancel.setFont(new Font("Calibri", Font.BOLD, 16));
		btnCancel.addActionListener(this);
		btnAdd = new JButton("Add");
		btnAdd.setFont(new Font("Calibri", Font.BOLD, 16));
		btnAdd.addActionListener(this);
		btnAddNew = new JButton("Add Another");
		btnAddNew.setFont(new Font("Calibri", Font.BOLD, 16));
		btnAddNew.addActionListener(this);
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);

		// JComboBox properties & values
		models[0] = new DefaultComboBoxModel(new String[] { "- Select Category -", "Beauty", "Food", "Sports Nutrition", "Vitamins", "Weight Loss" });
		models[1] = new DefaultComboBoxModel(new String[] { "- Select Product Category -"});
		models[2] = new DefaultComboBoxModel(new String[] { "- Select ML -", "25ml", "50ml", "75ml", "100ml", "125ml", "150ml", "200ml", "300ml" });
		models[3] = new DefaultComboBoxModel(new String[] { "- Select G -", "25g", "50g", "75g", "100g", "125g", "150g", "200g", "300g" });
		models[4] = new DefaultComboBoxModel(new String[] { "- Select MG -", "25mg", "50mg", "75mg", "100mg", "125mg", "150mg", "200mg", "300mg" });
		models[5] = new DefaultComboBoxModel(new String[] { "- Select Capsules -", "10 Capsules", "25 Capsules", "50 Capsules", "100 Capsules" });
		models[6] = new DefaultComboBoxModel(new String[] { "- Select Tablets -", "10 Tablets", "25 Tablets", "50 Tablets", "100 Capsules" });

		cmbCategory = new JComboBox(models[0]);
		cmbCategory.addActionListener(this);
		cmbSize = new JComboBox(models[1]);
		cmbSize.addActionListener(this);

		// JPanel properties & settings
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		addComp(centre,main,1,1,1,1,1,1);
		addComp(lblHeader,centre,1,1,4,1,2,2);
		addComp(lblDetails,centre,1,2,4,1,2,2);
		addComp(taAddDis, centre, 3, 3, 2, 3, 4, 4);
		addComp(taAddDis2, centre, 3, 6, 2, 3, 4, 4);
		addComp(lblID, centre, 1, 3, 1, 1, 2, 2);
		addComp(txtID, centre, 2, 3, 1, 1, 2, 2);
		addComp(lblName, centre, 1, 4, 1, 1, 2, 2);
		addComp(txtName, centre, 2, 4, 1, 1, 2, 2);
		addComp(lblCategory, centre, 1, 5, 1, 1, 2, 2);
		addComp(cmbCategory, centre, 2, 5, 1, 1, 2, 2);
		addComp(lblSize, centre, 1, 6, 1, 1, 2, 2);
		addComp(cmbSize, centre, 2, 6, 1, 1, 2, 2);
		addComp(lblUnitprice, centre, 1, 7, 1, 1, 2, 2);
		addComp(txtUnitprice, centre, 2, 7, 1, 1, 2, 2);
		addComp(lblStocklevel, centre, 1, 8, 1, 1, 2, 2);
		addComp(txtStocklevel, centre, 2, 8, 1, 1, 2, 2);
		addComp(btnReset, centre, 1, 10, 1, 1, 2, 2);
		addComp(btnCancel, centre, 2, 10, 1, 1, 2, 2);
		addComp(btnAdd, centre, 3, 10, 1, 1, 2, 2);
		addComp(btnAddNew, centre, 3, 10, 1, 1, 2, 2);
		addComp(btnExit, centre, 4, 10, 1, 1, 2, 2);

		display();

	}

	// AddComp controls the overall layout of the components and panels through X,Y
	// grid positioning
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

	//various methods that reset/disable/enable/display value on the JTextAreas
	private void display() {
		taAddDis2.setText("");
		taAddDis2.setText("Product ID        Product Name        Category             Size           Unit Price £    Stock Level         # Sold \n");
		Iterator i = products.entrySet().iterator();
		while (i.hasNext()) {
			Map.Entry me = (Map.Entry) i.next();
			taAddDis2.append(me.getValue().toString());

		}

	}


	private void disableCombo()
	{
		cmbCategory.setEnabled(false);;
	}

	private void editFalse()
	{	

		txtName.setEditable(false);
		cmbSize.setEnabled(false);
		cmbCategory.setEnabled(false);
		txtUnitprice.setEditable(false);
		txtStocklevel.setEditable(false);
		btnReset.setEnabled(false);
		btnAdd.setVisible(false);
		btnAddNew.setVisible(true);
		btnReset.setEnabled(false);
		btnCancel.setEnabled(false);

	}

	private void editTrue()
	{	

		txtName.setEditable(true);
		cmbSize.setEnabled(true);
		cmbCategory.setEnabled(true);
		txtUnitprice.setEditable(true);
		txtStocklevel.setEditable(true);
		btnReset.setEnabled(true);
		btnAdd.setVisible(true);
		btnAddNew.setVisible(false);
		btnReset.setEnabled(true);
		btnCancel.setEnabled(true);		

	}

	private void resetAdd() {
		
		txtID.setText("Chose Category");
		txtName.setText("");
		cmbSize.setSelectedItem(1);
		cmbCategory.setSelectedItem(1);
		txtUnitprice.setText("");
		txtStocklevel.setText("");
		cmbCategory.setEnabled(true);
		cmbCategory.setSelectedIndex(0);
		cmbSize.setModel(models[1]);
		editTrue();
		display();
	}


	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		if (e.getSource() == btnExit) {
			this.setVisible(false);
		}

		if (e.getSource() == btnCancel) {
			resetAdd();
			lblDetails.setText("Product Cancelled!");

		}

		if (e.getSource() == btnReset) {
			resetAdd();
			lblDetails.setText("Product Reset!");

		}
		
		
		//adds a product if all fields have been entered correctly
		if (e.getSource() == btnAdd) {
			valid = true;
			Product newProduct = new Product();

			if(cmbCategory.getSelectedIndex() == 0) {
				JOptionPane.showMessageDialog(null, "Select a Category!","Error!",  JOptionPane.ERROR_MESSAGE);
				valid = false;}
			else if (cmbSize.getSelectedIndex() == 0) {
				JOptionPane.showMessageDialog(null,  "Select a Size!", "Error!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}
			
		
			try {
				newProduct.setName(txtName.getText());
				newProduct.setUnitPrice(Double.parseDouble(txtUnitprice.getText()));
				newProduct.setStockLevel(Integer.parseInt(txtStocklevel.getText()));
			} catch (NumberFormatException e1) {
				JOptionPane.showMessageDialog(null, "" + e1 , "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			} catch (ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1 , "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}
			
			if(valid == true)
			{
				newProduct.setProductID(Integer.parseInt(txtID.getText()));
				newProduct.setSize(cmbSize.getSelectedItem().toString());
				newProduct.setCategory(cmbCategory.getSelectedItem().toString());
				newProduct.setNoSold(0);

				products.put(newProduct.getProductID(), newProduct);
				taAddDis.append(newProduct.toDisplay());
				lblDetails.setText("Product Added!");
				editFalse();

			}
			else if (valid == false)
			{
				lblDetails.setText("Fill in required fields!");

			}
			

		}

		//enables the user to add another product
		if(e.getSource() == btnAddNew){
			lblDetails.setText("Add New Product!");
			taAddDis.setText("");
			lblDetails.setText("Edit Another Product!");
			resetAdd();
		}

		//combo box where the user can select the category of the product they wish to add
		//the size for each category is also set here.
		if (e.getSource() == cmbCategory) {
			int number;
			number = cmbCategory.getSelectedIndex();

			switch (number) {
			case 0:
				break;

			case 1:
				beauty++;
				txtID.setText(Integer.toString(beauty));
				cmbSize.setModel(models[2]);
				disableCombo();
				break;

			case 2:
				food++;
				txtID.setText(Integer.toString(food));
				cmbSize.setModel(models[3]);
				disableCombo();
				break;

			case 3:
				sportsnutrition++;
				txtID.setText(Integer.toString(sportsnutrition));
				cmbSize.setModel(models[4]);
				disableCombo();
				break;

			case 4:
				vitamins++;
				txtID.setText(Integer.toString(vitamins));
				cmbSize.setModel(models[5]);
				disableCombo();
				break;

			case 5:
				weightloss++;
				txtID.setText(Integer.toString(weightloss));
				cmbSize.setModel(models[6]);
				disableCombo();
				break;

				
			}
			lblDetails.setText("Product ID Issued!");
		}
	}
}
