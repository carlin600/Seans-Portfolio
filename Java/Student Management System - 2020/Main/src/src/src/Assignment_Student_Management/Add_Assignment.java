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
 * This class represents adding an assignment to the system.
 *
 * @author Sean Carlin
 *
 */
public class Add_Assignment extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblAssignmentCourse, lblAssignmentModule, lblAssignmentName, lblAssignmentDesc,
			lblDateAssigned, lblAssignmentID;
	private JTextField txtAssignmentID, txtAssignmentName, txtAssignmentDesc, txtDate;
	private JComboBox cmbAssignmentCourse;
	private JButton btnExit, btnReset, btnSubmit;
	private JPanel centre;
	private int assignmentID;
	private boolean valid;
	private ArrayList<_Module> relatedmoduleDATA;
	private DefaultListModel lstDataArray;
	private JList lstModules;

	
	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Assignment> assignments;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	
	/**
	 * Add assignment constructor.
	 * @param assignmentsIn the assignment treemap.
	 * @param coursesIn the course treemap.
	 * @param modulesIn the modules map.
	 */
	Add_Assignment(TreeMap<Integer, _Assignment> assignmentsIn, TreeMap<Integer, _Course> coursesIn,
			TreeMap<Integer, _Module> modulesIn) {
		
		/**
		 * TreeMaps being initialised.
		 */
		assignments = assignmentsIn;
		modules = modulesIn;
		courses = coursesIn;

		/**
		 * JLabel initialisation and properties. 
		 * Any label used is created and values are set here.
		 */
		lblHeader = new JLabel("Add New Assignment", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblAssignmentID = new JLabel("Assignment ID: ", JLabel.LEFT);
		lblAssignmentID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignmentName = new JLabel("Assignment Name: ", JLabel.LEFT);
		lblAssignmentName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignmentCourse = new JLabel("Assignment Course: ", JLabel.LEFT);
		lblAssignmentCourse.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignmentModule = new JLabel("Assignment Module: ", JLabel.LEFT);
		lblAssignmentModule.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignmentDesc = new JLabel("Description: ", JLabel.LEFT);
		lblAssignmentDesc.setFont(new Font("Calibri", Font.BOLD, 16));
		lblDateAssigned = new JLabel("Date: ", JLabel.LEFT);
		lblDateAssigned.setFont(new Font("Calibri", Font.BOLD, 16));

		/**
		 * JTextField Properties and Values.
		 * Any text field used is created and values set here.
		 */
		txtAssignmentID = new JTextField(10);
		txtAssignmentID.setEditable(false);
		txtAssignmentName = new JTextField(30);
		txtAssignmentDesc = new JTextField(30);
		txtDate = new JTextField(10);

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
		btnSubmit = new JButton("Submit");
		btnSubmit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSubmit.addActionListener(this);

		
		/**
		 * Array List linked to the course treemap.
		 * The for loop will loop through the course treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Course> courseArray = new ArrayList<_Course>();
		Set<Map.Entry<Integer, _Course>> coursestored = courses.entrySet();
		for (Map.Entry<Integer, _Course> coursesStored : coursestored) {
			courseArray.add(coursesStored.getValue());
		}

		
		/**
		 * Array List linked to the module treemap.
		 * The for loop will loop through the module treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Module> moduleArray = new ArrayList<_Module>();
		Set<Map.Entry<Integer, _Module>> modulestored = modules.entrySet();

		for (Map.Entry<Integer, _Module> modulesStored : modulestored) {
			moduleArray.add(modulesStored.getValue());
		}

		relatedmoduleDATA = moduleArray;

		
		/**
		 * DefaultListModel declarations and properties.
		 */
		lstDataArray = new DefaultListModel();
		lstDataArray.addElement("  ");
		lstModules = new JList(lstDataArray);
		lstModules.setVisibleRowCount(6);
		lstModules.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

		cmbAssignmentCourse = new JComboBox(courseArray.toArray());
		cmbAssignmentCourse.addActionListener(this);

		/**
		 * Autogen Engines. This is where the ID is automatically incremented
		 * by 1. It pulls the last entry from the map and adds 1 on.
		 */	
		assignmentID = assignments.lastEntry().getValue().getAssignmentID() + 1;
		txtAssignmentID.setText(Integer.toString(assignmentID));

		
		/**
		 * JPanel Initialisation and Properties.
		 */
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		/**
		 * <b>AddComp Method Values.<b> This section is where all Swing Components and
		 * Objects are passed into the AddComp Method and placed within the <i>GridBag
		 * Layout<i>
		 */
		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 1, 4, 1, 2, 2);
		addComp(lblAssignmentID, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtAssignmentID, centre, 2, 2, 1, 1, 1, 1);
		addComp(lblAssignmentName, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtAssignmentName, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblAssignmentCourse, centre, 1, 4, 1, 1, 1, 1);
		addComp(cmbAssignmentCourse, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblAssignmentModule, centre, 1, 5, 1, 1, 1, 1);
		addComp(lstModules, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblAssignmentDesc, centre, 1, 6, 1, 1, 1, 1);
		addComp(txtAssignmentDesc, centre, 2, 6, 1, 1, 1, 1);
		addComp(lblDateAssigned, centre, 1, 7, 1, 1, 1, 1);
		addComp(txtDate, centre, 2, 7, 1, 1, 1, 1);
		addComp(btnReset, centre, 3, 8, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 8, 2, 1, 1, 1);
		addComp(btnSubmit, centre, 4, 8, 1, 1, 1, 1);

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
	 * ResetForm Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	public void resetForm() {
		valid = false;

		txtAssignmentID.setText("");
		txtAssignmentName.setText("");
		txtAssignmentDesc.setText("");
		txtDate.setText("");
		cmbAssignmentCourse.setSelectedIndex(0);
		lstDataArray.clear();
		// Autogen student ID
		assignmentID = assignments.lastEntry().getValue().getAssignmentID() + 1;
		txtAssignmentID.setText(Integer.toString(assignmentID));
		JOptionPane.showMessageDialog(null, "Form Reset!", "Confirmation!", JOptionPane.OK_OPTION);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		/**
		 * Exit button actionlistener. 
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
			resetForm();

		}

		/**
		 * assignmentcourse combobox actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == cmbAssignmentCourse) {

			lstDataArray.clear();

			for (int i = 0; i < relatedmoduleDATA.size(); i++) {

				String relatedCourse = relatedmoduleDATA.get(i).getRelatedCourse();
				String comboCourse = cmbAssignmentCourse.getSelectedItem().toString();
				String MATCHED;
				if (relatedCourse.toString().equals(comboCourse)) {

					MATCHED = relatedmoduleDATA.get(i).getModuleName();
					lstDataArray.addElement(MATCHED);
				}

			}
		}

		/**
		 * submit button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnSubmit) {
			valid = true;

			_Assignment newAssignment = new _Assignment();

			try {
				newAssignment.setAssignmentName(txtAssignmentName.getText());
			} catch (_ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}

			if (valid == true) {
				newAssignment.setAssignmentID(Integer.parseInt(txtAssignmentID.getText()));
				newAssignment.setAssignmentCourse(txtAssignmentName.getText());
				newAssignment.setAssignmentModule(lstModules.getSelectedValuesList().toString());
				newAssignment.setAssignmentDesc(txtAssignmentDesc.getText());
				newAssignment.setDateAssigned(txtDate.getText());
				assignments.put(newAssignment.getAssignmentID(), newAssignment);

				JOptionPane.showMessageDialog(null, "Assignment Submitted!", "Confirmation!",
						JOptionPane.PLAIN_MESSAGE);
				resetForm();

			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}

	}

}
