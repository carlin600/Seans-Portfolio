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

import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class EditProduct extends JFrame implements ActionListener {

	
	//declare variables
	private JLabel lblHeader, lblSearch, lblBLANK, lblDetails, lblID, lblName, lblSize, lblCategory, lblUnitprice,
			lblStocklevel;
	private JTextField txtSearch, txtID, txtName, txtUnitprice, txtStocklevel;
	private JComboBox cmbSize, cmbCategory;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[8];
	private JTextArea taEditDis, taEditDis2, taEditDis3;
	private JButton btnEdit, btnEditAnother, btnUpdate, btnExit;
	private JPanel centre;
	private int beauty = 1000, food = 2000, sportsnutrition = 3000, vitamins = 4000, weightloss = 5000;
	private boolean valid;

	//declare hashmap
	private HashMap<Integer, Product> products;

	EditProduct(HashMap<Integer, Product> local) {
		products = local;

		// JLabels - setting properties & values
		lblHeader = new JLabel("Edit Products", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDetails = new JLabel("Awaiting Details", JLabel.CENTER);
		lblDetails.setFont(new Font("Calibri", Font.ITALIC, 17));
		lblSearch = new JLabel("Search by Product ID:", JLabel.RIGHT);
		lblSearch.setFont(new Font("Calibri", Font.BOLD, 16));
		lblID = new JLabel("Product ID", JLabel.LEFT);
		lblID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Product Name", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblSize = new JLabel("Product Size", JLabel.LEFT);
		lblSize.setFont(new Font("Calibri", Font.BOLD, 16));
		lblCategory = new JLabel("Product Category", JLabel.LEFT);
		lblCategory.setFont(new Font("Calibri", Font.BOLD, 16));
		lblUnitprice = new JLabel("Unit Price", JLabel.LEFT);
		lblUnitprice.setFont(new Font("Calibri", Font.BOLD, 16));
		lblStocklevel = new JLabel("Stock Level", JLabel.LEFT);
		lblStocklevel.setFont(new Font("Calibri", Font.BOLD, 16));

		// JTextField properties & values
		txtSearch = new JTextField(10);
		txtID = new JTextField(10);
		txtID.setEditable(false);
		txtName = new JTextField(10);
		txtUnitprice = new JTextField(10);
		txtStocklevel = new JTextField(10);

		// JTextArea properties & values
		taEditDis = new JTextArea(10, 10);
		taEditDis.setEditable(false);
		taEditDis2 = new JTextArea(10, 10);
		taEditDis2.setEditable(false);
		taEditDis3 = new JTextArea(10, 10);
		taEditDis3.setEditable(false);

		// JButton properties & values
		btnEdit = new JButton("Edit");
		btnEdit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnEdit.addActionListener(this);
		btnEditAnother = new JButton("Edit Another");
		btnEditAnother.setFont(new Font("Calibri", Font.BOLD, 16));
		btnEditAnother.addActionListener(this);
		btnEditAnother.setVisible(false);
		
		btnUpdate = new JButton("Update");
		btnUpdate.setFont(new Font("Calibri", Font.BOLD, 16));
		btnUpdate.addActionListener(this);
	
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);

		// JComboBox properties & values
		models[0] = new DefaultComboBoxModel(new String[] { "- Select Category -", "Beauty", "Food", "Sports Nutrition",
				"Vitamins", "Weight Loss" });
		models[1] = new DefaultComboBoxModel(new String[] { "- Select Product Category -" });
		models[2] = new DefaultComboBoxModel(
				new String[] { "- Select ML -", "25ml", "50ml", "75ml", "100ml", "125ml", "150ml", "200ml", "300ml" });
		models[3] = new DefaultComboBoxModel(
				new String[] { "- Select G -", "25g", "50g", "75g", "100g", "125g", "150g", "200g", "300g" });
		models[4] = new DefaultComboBoxModel(
				new String[] { "- Select MG -", "25mg", "50mg", "75mg", "100mg", "125mg", "150mg", "200mg", "300mg" });
		models[5] = new DefaultComboBoxModel(
				new String[] { "- Select Capsules -", "10 Capsules", "25 Capsules", "50 Capsules", "100 Capsules" });
		models[6] = new DefaultComboBoxModel(
				new String[] { "- Select Tablets -", "10 Tablets", "25 Tablets", "50 Tablets", "100 Capsules" });

		cmbCategory = new JComboBox(models[0]);
		cmbCategory.addActionListener(this);
		cmbCategory.setEditable(false);
		cmbSize = new JComboBox(models[1]);
		cmbSize.addActionListener(this);
		cmbSize.setEditable(false);

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
		addComp(taEditDis, centre, 3, 3, 2, 3, 4, 4);
		addComp(taEditDis2, centre, 3, 6, 2, 3, 4, 4);
		addComp(lblSearch, centre, 1, 3, 1, 1, 2, 2);
		addComp(txtSearch, centre, 2, 3, 1, 1, 2, 2);
		addComp(taEditDis3, centre, 1, 4, 4, 4, 4, 4);
		addComp(btnEdit, centre, 3, 3, 1, 1, 2, 2);
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
		addComp(btnUpdate, centre, 3, 10, 1, 1, 2, 2);
		addComp(btnEditAnother, centre, 3, 10, 1, 1, 2, 2);
		addComp(btnExit, centre, 4, 10, 1, 1, 2, 2);

		display();
		disableEdit();

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
		taEditDis3.setText("");
		
		taEditDis3.append("Displaying All Products \n");
		taEditDis3.append("Date: " + LocalDate.now().toString() + "\n");
		taEditDis3.append("Product ID               Name                       Category             Size            Price (£)       Stock Level       Amount Sold \n");
		txtSearch.setText("");
		Iterator i = products.entrySet().iterator();
		while (i.hasNext()) {
			Map.Entry me = (Map.Entry) i.next();
			taEditDis3.append(me.getValue().toString());

		}
	}
	
	private void display2() {
		taEditDis2.setText("");
		
		taEditDis2.append("Displaying All Products \n");
		taEditDis2.append("Date: " + LocalDate.now().toString() + "\n");
		taEditDis2.append("Product ID               Name                       Category             Size            Price (£)       Stock Level       Amount Sold \n");
		txtSearch.setText("");
		Iterator i = products.entrySet().iterator();
		while (i.hasNext()) {
			Map.Entry me = (Map.Entry) i.next();
			taEditDis2.append(me.getValue().toString());

		}
	}
	

	private void disableCombo() {
		cmbCategory.setEnabled(false);
		cmbSize.setSelectedIndex(0);

	}

	private void enableEdit() {
		lblSearch.setVisible(false);
		txtSearch.setVisible(false);
		lblID.setVisible(true);
		lblName.setVisible(true);
		lblSize.setVisible(true);
		lblCategory.setVisible(true);
		lblUnitprice.setVisible(true);
		lblStocklevel.setVisible(true);
		txtID.setVisible(true);
		txtName.setVisible(true);
		txtUnitprice.setVisible(true);
		txtStocklevel.setVisible(true);
		cmbSize.setVisible(true);
		cmbCategory.setVisible(true);
		taEditDis.setVisible(true);
		taEditDis2.setVisible(true);
		taEditDis3.setVisible(false);
		btnEdit.setVisible(false);
		btnUpdate.setVisible(true);
		btnEditAnother.setVisible(true);
	}

	private void disableEdit() {
		lblSearch.setVisible(true);
		txtSearch.setVisible(true);
		btnEdit.setVisible(true);
		lblID.setVisible(false);
		lblName.setVisible(false);
		lblSize.setVisible(false);
		lblCategory.setVisible(false);
		lblUnitprice.setVisible(false);
		lblStocklevel.setVisible(false);
		txtID.setVisible(false);
		txtName.setVisible(false);
		txtUnitprice.setVisible(false);
		txtStocklevel.setVisible(false);
		cmbSize.setVisible(false);
		cmbCategory.setVisible(false);
		btnUpdate.setVisible(false);
		btnEditAnother.setVisible(false);
		taEditDis.setVisible(false);
		taEditDis2.setVisible(false);
		taEditDis3.setVisible(true);
	}

	private void resetEdit() {
		txtID.setText("");
		txtName.setText("");
		cmbCategory.setEnabled(true);
		cmbCategory.setSelectedIndex(0);
		cmbSize.setModel(models[1]);
		editableTrue();
		display();
		txtUnitprice.setText("");
		txtStocklevel.setText("");
	}

	private void editableFalse() {
		txtID.setEditable(false);
		txtName.setEditable(false);
		cmbSize.setEditable(false);
		cmbCategory.setEditable(false);
		txtUnitprice.setEditable(false);
		txtStocklevel.setEditable(false);
		btnUpdate.setEnabled(false);
		btnEditAnother.setVisible(true);
		btnUpdate.setVisible(false);
	}

	private void editableTrue() {
		txtName.setEditable(true);
		cmbCategory.setEnabled(true);
		txtUnitprice.setEditable(true);
		txtStocklevel.setEditable(true);
		btnUpdate.setEnabled(true);
		taEditDis.setText("");

	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		if (e.getSource() == btnExit) {
			this.setVisible(false);
		}


		//this enables the user to edit the chosen product after making sure it was correct.
		if (e.getSource() == btnEdit) {
			Product editProduct = new Product();
			editProduct = products.get(Integer.parseInt(txtSearch.getText()));
			
			if(editProduct == null)
			{
				JOptionPane.showMessageDialog(null, "NONE FOUND, \nProduct ID not found. Please try again.", "ERROR",
						JOptionPane.ERROR_MESSAGE);
				txtSearch.setText("");			
				lblDetails.setText("Re-Enter an ID!");
			}
			else if(editProduct != null)
			{
				lblDetails.setText("You may Edit the Product!");

				txtID.setText(Integer.toString(editProduct.getProductID()));
				txtName.setText(editProduct.getName());
				cmbCategory.setSelectedItem(editProduct.getCategory());
				cmbSize.setSelectedItem(editProduct.getSize());
				txtUnitprice.setText(Double.toString(editProduct.getUnitPrice()));
				txtStocklevel.setText(Integer.toString(editProduct.getStockLevel()));
				editableTrue();
				enableEdit();
				display2();

			}

			
		}

		//combo box where they can chose product category followed by size.
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
			lblDetails.setText( cmbCategory.getSelectedItem() + " Selected!");
		}

	

		//This is where the edited product gets updated and re-added to the hashmap
		if (e.getSource() == btnUpdate) {
			valid = true;
			products.remove(Integer.parseInt(txtID.getText()));
			Product editProduct = new Product();
			
			if(cmbCategory.getSelectedIndex() == 0) {
				JOptionPane.showMessageDialog(null, "Error!",  "Category!", JOptionPane.ERROR_MESSAGE);
				valid = false;}
			else if (cmbSize.getSelectedIndex() == 0) {
				JOptionPane.showMessageDialog(null, "Error!", "Select a Size!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}
			
			try {
				editProduct.setName(txtName.getText());
				editProduct.setStockLevel(Integer.parseInt(txtStocklevel.getText()));
				editProduct.setUnitPrice(Double.parseDouble(txtUnitprice.getText()));

			} catch (NumberFormatException e1) {
				
				JOptionPane.showMessageDialog(null, "" + e1 + "***", "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			} catch (ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1 + "***", "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}
			
			if(valid == true)
			{	

				editProduct.setProductID(Integer.parseInt(txtID.getText()));
				editProduct.setSize(cmbSize.getSelectedItem().toString());
				editProduct.setCategory(cmbCategory.getSelectedItem().toString());
				editProduct.setNoSold(editProduct.getNoSold());

				products.put(editProduct.getProductID(), editProduct);
				taEditDis.append(editProduct.toDisplay());
				lblDetails.setText("Product Updated!");

				editableFalse();
				display2();

			}
			else if(valid == false)
				lblDetails.setText("Fill in required fields!");

			

		}

		if (e.getSource() == btnEditAnother) {
			taEditDis.setText("");
			resetEdit();
			disableEdit();
			display();
			lblDetails.setText("Edit Another Product!");

		}

	}
}
