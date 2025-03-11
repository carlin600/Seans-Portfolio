/**
 * Assignment Package
 */
package Assignment_Student_Management;

/**
 * Imported libraries for this class.
 */
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import javax.swing.*;

/**
 * This class represents editing a staff member.
 *
 * @author Sean Carlin
 *
 */
public class Edit_Staff extends JFrame implements ActionListener {
	
	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblStaffID, lblName, lblOfficeLocation, lblOfficeHours, lblPosition, lblEmploymentStatus,
			lblPersonalWebsite;
	private JButton btnExit, btnReset, btnSelect, btnUpdate;
	private JTextField txtStaffID, txtName, txtPersonalWebsite;
	private JComboBox cmbOfficeLocation, cmbOfficeHours, cmbPosition, cmbEmploymentStatus;
	private JPanel centre, pnlDisplay;
	private DefaultComboBoxModel[] options = new DefaultComboBoxModel[10];
	private boolean valid;
	private int staffID;
	private JScrollPane spDisplay;
	private JTextArea taDisplay;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Staff> staffs;

	/**
	 * Edit Staff default constructor.
	 * @param staffsIn the staff treemap.
	 */
	Edit_Staff(TreeMap<Integer, _Staff> staffsIn) {
		
		/**
		 * TreeMaps being initialised.
		 */
		staffs = staffsIn;

		
		/**
		 * JLabel initialisation and properties. 
		 * Any label used is created and values are set here.
		 */
		lblHeader = new JLabel("Edit Staff", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblStaffID = new JLabel("StaffID: ", JLabel.LEFT);
		lblStaffID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Name: ", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblOfficeLocation = new JLabel("Office Location: ", JLabel.LEFT);
		lblOfficeLocation.setFont(new Font("Calibri", Font.BOLD, 16));
		lblOfficeHours = new JLabel("Office Hours: ", JLabel.LEFT);
		lblOfficeHours.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Name: ", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblPosition = new JLabel("Position: ", JLabel.LEFT);
		lblPosition.setFont(new Font("Calibri", Font.BOLD, 16));
		lblEmploymentStatus = new JLabel("Employment Status: ", JLabel.LEFT);
		lblEmploymentStatus.setFont(new Font("Calibri", Font.BOLD, 16));
		lblPersonalWebsite = new JLabel("Personal Website: (Optional) ", JLabel.LEFT);
		lblPersonalWebsite.setFont(new Font("Calibri", Font.BOLD, 16));

		/**
		 * JTextField Properties and Values.
		 * Any text field used is created and values set here.
		 */
		txtStaffID = new JTextField(10);
		txtName = new JTextField(30);
		txtPersonalWebsite = new JTextField(30);

		/**
		 * JTextArea Properties and Values.
		 * Any text area used is created and values set here.
		 */
		taDisplay = new JTextArea(12, 30);
		taDisplay.setEditable(false);

		/**
		 * JScrollPane Properties and Values.
		 * Scroll Pane properties and values set here.
		 */
		spDisplay = new JScrollPane(taDisplay);
		spDisplay.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);

		/**
		 * JButton Initialisation and Properties. Any Button component is declared and
		 * built here. All Properties and values applied, text, text size, font etc.
		 */
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
		btnReset = new JButton("Reset");
		btnReset.setFont(new Font("Calibri", Font.BOLD, 16));
		btnReset.addActionListener(this);
		btnUpdate = new JButton("Update");
		btnUpdate.setFont(new Font("Calibri", Font.BOLD, 16));
		btnUpdate.addActionListener(this);
		btnSelect = new JButton("Select");
		btnSelect.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSelect.addActionListener(this);

		/**
		 * JComboBox models are created here. Java Swing allows JComboBoxes to have
		 * DefaultComboBoxModels implemented to allow for easier values added. Sometimes
		 * more than one.
		 */
		options[0] = new DefaultComboBoxModel(
				new String[] { "- Select Floor - ", "Ground Floor", "1st Floor", "2nd Floor", "3rd Floor" });
		options[1] = new DefaultComboBoxModel(
				new String[] { "- Select Hours - ", "Mon - Fri, 9 - 6", "Mon - Wed, 9 - 3", "Daily, 9 - 5" });
		options[2] = new DefaultComboBoxModel(new String[] { "- Select Position - ", "Social Officer ",
				"Student Services", "Instructor", "Cleaner", "Janitor", "Security" });
		options[3] = new DefaultComboBoxModel(
				new String[] { "- Select Status - ", "Full-Time", "Part-Time", "Temorary", "Placement/Internship" });
		options[4] = new DefaultComboBoxModel(new String[] { "" });

		
		/**
		 * JComboBox declarations and properties.
		 */
		cmbOfficeLocation = new JComboBox(options[0]);
		cmbOfficeLocation.addActionListener(this);
		cmbOfficeHours = new JComboBox(options[1]);
		cmbOfficeHours.addActionListener(this);
		cmbPosition = new JComboBox(options[2]);
		cmbPosition.addActionListener(this);
		cmbEmploymentStatus = new JComboBox(options[3]);
		cmbEmploymentStatus.addActionListener(this);

		
		
		/**
		 * JPanel Initialisation and Properties.
		 */
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		pnlDisplay = new JPanel();
		pnlDisplay.setLayout(new BorderLayout());
		pnlDisplay.setBackground(Color.cyan);
		pnlDisplay.add(spDisplay);

		
		/**
		 * <b>AddComp Method Values.<b> This section is where all Swing Components and
		 * Objects are passed into the AddComp Method and placed within the <i>GridBag
		 * Layout<i>
		 */
		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 1, 4, 1, 2, 2);
		addComp(pnlDisplay, centre, 3, 3, 5, 3, 3, 3);
		addComp(lblStaffID, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtStaffID, centre, 2, 2, 1, 1, 1, 1);
		addComp(btnSelect, centre, 3, 2, 1, 1, 1, 1);
		addComp(lblName, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtName, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblOfficeLocation, centre, 1, 4, 1, 1, 1, 1);
		addComp(cmbOfficeLocation, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblOfficeHours, centre, 1, 5, 1, 1, 1, 1);
		addComp(cmbOfficeHours, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblPosition, centre, 1, 7, 1, 1, 1, 1);
		addComp(cmbPosition, centre, 2, 7, 1, 1, 1, 1);
		addComp(lblEmploymentStatus, centre, 1, 8, 1, 1, 1, 1);
		addComp(cmbEmploymentStatus, centre, 2, 8, 1, 1, 1, 1);
		addComp(lblPersonalWebsite, centre, 1, 9, 1, 1, 1, 1);
		addComp(txtPersonalWebsite, centre, 2, 9, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 10, 1, 1, 1, 1);
		addComp(btnReset, centre, 2, 10, 1, 1, 1, 1);
		addComp(btnUpdate, centre, 3, 10, 2, 1, 1, 1);

		displayStaff();
	}

	/**
	 * AddComp Constructor and setter method.
	 * 
	 * @param c       the component.
	 * @param main    the container.
	 * @param gridX   the X axis.
	 * @param gridY   the Y axis.
	 * @param width   the component width.
	 * @param height  the component height.
	 * @param weightX the X axis weight.
	 * @param weightY the Y axis height.
	 */
	private void addComp(Component c, Container main, int gridX, int gridY, int width, int height, int weightX,
			int weightY) {
		GridBagConstraints gc = new GridBagConstraints(); // creates constraints object gc
		gc.fill = GridBagConstraints.BOTH;
		gc.insets = new Insets(8, 8, 8, 8);
		gc.gridx = gridX;
		gc.gridy = gridY;
		gc.gridwidth = width;
		gc.gridheight = height;
		gc.weightx = weightX;
		gc.weighty = weightY;

		getContentPane().add(c, gc); // adds components to the gridbag
	}

	
	/**
	 * displayStudents Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	private void displayStaff() {
		taDisplay.append("");
		taDisplay.append(
				"Staff ID   Name                 Office Location        Office Hours         Position        Status    Website\n");

		ArrayList<_Staff> staffArray = new ArrayList<_Staff>();
		Set<Map.Entry<Integer, _Staff>> staffstored = staffs.entrySet();
		for (Map.Entry<Integer, _Staff> staffsStored : staffstored) {
			staffArray.add(staffsStored.getValue());
			taDisplay.append("" + staffsStored.getValue().toString());
		}
	}

	/**
	 * ResetForm Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	private void formReset() {
		valid = false;

		txtStaffID.setText("");
		txtName.setText("");
		cmbOfficeLocation.setSelectedIndex(0);
		cmbOfficeHours.setSelectedIndex(0);
		cmbPosition.setSelectedIndex(0);
		cmbEmploymentStatus.setSelectedIndex(0);
		txtPersonalWebsite.setText("");
		btnSelect.setEnabled(true);
		txtStaffID.setEnabled(true);
		displayStaff();

		JOptionPane.showMessageDialog(null, "Form Reset!", "Confirmation!", JOptionPane.OK_OPTION);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
		/**
		 * exit button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnExit) {
			int option = JOptionPane.showConfirmDialog(null, "Are you sure you wish to Exit?", "Warning",
					JOptionPane.YES_NO_OPTION);

			if (option == JOptionPane.YES_OPTION) {
				this.setVisible(false);
			}

		}

		/**
		 * reset button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnReset) {
			formReset();

		}

		/**
		 * select button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnSelect) {

			_Staff editStaff = new _Staff();
			editStaff = staffs.get(Integer.parseInt(txtStaffID.getText()));
			txtStaffID.setText(editStaff.getName());
			txtName.setText(editStaff.getName().toString());
			cmbOfficeLocation.setSelectedItem(editStaff.getOfficeLocation());
			cmbOfficeHours.setSelectedItem(editStaff.getOfficeHours());
			cmbPosition.setSelectedItem(editStaff.getPosition());
			cmbEmploymentStatus.setSelectedItem(editStaff.getEmploymentStatus());
			txtPersonalWebsite.setText(editStaff.getPersonalWebsite());
			btnSelect.setEnabled(false);
			txtStaffID.setEnabled(false);
		}

		
		/**
		 * update button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnUpdate) {
			valid = true;
			staffs.remove(Integer.parseInt(txtStaffID.toString()));
			_Staff updateStaff = new _Staff();

			try {
				updateStaff.setName(txtName.getText());
			} catch (_ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}

			if (valid == true) {
				updateStaff.setStaffID(Integer.parseInt(txtStaffID.getText()));
				updateStaff.setOfficeLocation(cmbOfficeLocation.getSelectedItem().toString());
				updateStaff.setOfficeHours(cmbOfficeHours.getSelectedItem().toString());
				updateStaff.setPosition(cmbPosition.getSelectedItem().toString());
				updateStaff.setEmploymentStatus(cmbEmploymentStatus.getSelectedItem().toString());
				updateStaff.setPersonalWebsite(txtPersonalWebsite.getText());
				staffs.put(updateStaff.getStaffID(), updateStaff);

				JOptionPane.showMessageDialog(null, "Staff Member Updated!", "Confirmation!",
						JOptionPane.PLAIN_MESSAGE);
				formReset();
			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}
	}

}
