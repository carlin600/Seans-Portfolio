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
 * This class represents editing a tutor.
 *
 * @author Sean Carlin
 *
 */
public class Edit_Tutor extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblStaffID, lblName, lblOfficeLocation, lblOfficeHours, lblPosition, lblEmploymentStatus,
			lblPersonalWebsite, lblTutorCode, lblModulesTaught, lblCourseTaught;
	private JButton btnExit, btnReset, btnSelect, btnUpdate;
	private JTextField txtStaffID, txtName, txtPersonalWebsite, txtTutorCode;
	private JComboBox cmbOfficeLocation, cmbOfficeHours, cmbCourse, cmbPosition, cmbEmploymentStatus;
	private JPanel centre, pnlDisplay;
	private DefaultComboBoxModel[] options = new DefaultComboBoxModel[10];
	private boolean valid;
	private int staffID, tutorCode;
	private JList lstModules;
	private JScrollPane spDisplay;
	private JTextArea taDisplay;
	private ArrayList<_Module> relatedmoduleDATA;
	private DefaultListModel lstDataArray;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Tutor> tutors;
	private TreeMap<Integer, _Staff> staffs;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	/**
	 * Edit Tutor constructor.
	 * @param tutorsIn the tutor treemap.
	 * @param staffsIn the staff treemap.
	 * @param coursesIn the course treemap.
	 * @param modulesIn the module treemap.
	 */
	Edit_Tutor(TreeMap<Integer, _Tutor> tutorsIn, TreeMap<Integer, _Staff> staffsIn,
			TreeMap<Integer, _Course> coursesIn, TreeMap<Integer, _Module> modulesIn) {
		
		/**
		 * TreeMaps being initialised.
		 */
		tutors = tutorsIn;
		staffs = staffsIn;
		courses = coursesIn;
		modules = modulesIn;

		/**
		 * JLabel initialisation and properties. 
		 * Any label used is created and values are set here.
		 */
		lblHeader = new JLabel("Edit Tutor", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblStaffID = new JLabel("Select via StaffID: ", JLabel.LEFT);
		lblStaffID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblTutorCode = new JLabel("Tutor Code: ", JLabel.LEFT);
		lblTutorCode.setFont(new Font("Calibri", Font.BOLD, 16));
		lblCourseTaught = new JLabel("Course Taught: ", JLabel.LEFT);
		lblCourseTaught.setFont(new Font("Calibri", Font.BOLD, 16));
		lblModulesTaught = new JLabel("Modules: ", JLabel.LEFT);
		lblModulesTaught.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Name: ", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblOfficeLocation = new JLabel("Office Location: ", JLabel.LEFT);
		lblOfficeLocation.setFont(new Font("Calibri", Font.BOLD, 16));
		lblOfficeHours = new JLabel("Office Hours: ", JLabel.LEFT);
		lblOfficeHours.setFont(new Font("Calibri", Font.BOLD, 16));
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
		txtTutorCode = new JTextField(10);
		txtTutorCode.setEditable(false);
		txtName = new JTextField(30);
		txtPersonalWebsite = new JTextField(30);

		/**
		 * JTextArea Properties and Values.
		 * Any text area used is created and values set here.
		 */
		taDisplay = new JTextArea(12, 30);
		taDisplay.setEditable(false);

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
		btnUpdate = new JButton("Submit");
		btnUpdate.setFont(new Font("Calibri", Font.BOLD, 16));
		btnUpdate.addActionListener(this);
		btnSelect = new JButton("Select");
		btnSelect.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSelect.addActionListener(this);

		/**
		 * JScrollPane Properties and Values.
		 * Scroll Pane properties and values set here.
		 */
		spDisplay = new JScrollPane(taDisplay);
		spDisplay.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);

		
		/**
		 * Array List linked to the course treemap.
		 * The for loop will loop through the course treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Course> lineArray = new ArrayList<_Course>();
		Set<Map.Entry<Integer, _Course>> stored = courses.entrySet();
		for (Map.Entry<Integer, _Course> coursesStored : stored) {
			lineArray.add(coursesStored.getValue());
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
		lstModules.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);


		/**
		 * JComboBox models are created here. Java Swing allows JComboBoxes 
		 * to have DefaultComboBoxModels implemented to allow for easier values
		 * added. Sometimes more than one.
		 */
		options[0] = new DefaultComboBoxModel(
				new String[] { "- Select Floor - ", "Ground Floor", "1st Floor", "2nd Floor", "3rd Floor" });
		options[1] = new DefaultComboBoxModel(
				new String[] { "- Select Hours - ", "Mon - Fri, 9 - 6", "Mon - Wed, 9 - 3", "Daily, 9 - 5" });
		options[2] = new DefaultComboBoxModel(
				new String[] { "- Select Position - ", "Head Of Year", "Instructor", "Tutor" });
		options[3] = new DefaultComboBoxModel(
				new String[] { "- Select Status - ", "Full-Time", "Part-Time", "Temorary", "Placement/Internship" });
		options[4] = new DefaultComboBoxModel(new String[] { "- Select Course - " });
		options[5] = new DefaultComboBoxModel(new String[] { "" });

		
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
		cmbCourse = new JComboBox(lineArray.toArray());
		cmbCourse.addActionListener(this);
		cmbCourse.setToolTipText("Select a Course");

		
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
		addComp(lblHeader, centre, 1, 1, 4, 1, 1, 1);
		addComp(pnlDisplay, centre, 3, 3, 5, 3, 3, 3);
		addComp(lblStaffID, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtStaffID, centre, 2, 2, 1, 1, 1, 1);
		addComp(btnSelect, centre, 3, 2, 2, 1, 1, 1);
		addComp(lblTutorCode, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtTutorCode, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblName, centre, 1, 4, 1, 1, 1, 1);
		addComp(txtName, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblCourseTaught, centre, 1, 5, 1, 1, 1, 1);
		addComp(cmbCourse, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblModulesTaught, centre, 1, 6, 1, 1, 1, 1);
		addComp(lstModules, centre, 2, 6, 1, 1, 1, 1);
		addComp(lblOfficeLocation, centre, 1, 7, 1, 1, 1, 1);
		addComp(cmbOfficeLocation, centre, 2, 7, 1, 1, 1, 1);
		addComp(lblOfficeHours, centre, 1, 8, 1, 1, 1, 1);
		addComp(cmbOfficeHours, centre, 2, 8, 1, 1, 1, 1);
		addComp(lblPosition, centre, 1, 9, 1, 1, 1, 1);
		addComp(cmbPosition, centre, 2, 9, 1, 1, 1, 1);
		addComp(lblEmploymentStatus, centre, 1, 10, 1, 1, 1, 1);
		addComp(cmbEmploymentStatus, centre, 2, 10, 1, 1, 1, 1);
		addComp(lblPersonalWebsite, centre, 1, 11, 1, 1, 1, 1);
		addComp(txtPersonalWebsite, centre, 2, 11, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 12, 2, 1, 1, 1);
		addComp(btnReset, centre, 3, 12, 1, 1, 1, 1);
		addComp(btnUpdate, centre, 4, 12, 1, 1, 1, 1);

		displayTutors();

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
	private void displayTutors() {
		taDisplay.append("");
		taDisplay.append("Staff ID   Tutor Code      Name         Modules Taught   Course\n");

		ArrayList<_Tutor> tutorArray = new ArrayList<_Tutor>();
		Set<Map.Entry<Integer, _Tutor>> tutorsstored = tutors.entrySet();

		for (Map.Entry<Integer, _Tutor> tutorsStored : tutorsstored) {
			tutorArray.add(tutorsStored.getValue());
			taDisplay.append("" + tutorsStored.getValue().toDisplay());
		}
	}

	/**
	 * ResetForm Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	private void formReset() {
		valid = false;

		txtStaffID.setText("");
		txtTutorCode.setText("");
		lstModules.clearSelection();
		txtName.setText("");
		cmbOfficeLocation.setSelectedIndex(0);
		cmbCourse.setSelectedIndex(0);
		cmbOfficeHours.setSelectedIndex(0);
		cmbPosition.setSelectedIndex(0);
		txtPersonalWebsite.setText("");

		JOptionPane.showMessageDialog(null, "Form Reset!", "Confirmation!", JOptionPane.OK_OPTION);

	}

	@Override
	public void actionPerformed(ActionEvent e) {

		/**
		 * exit button actionlistener. Once interacted, the program will trigger
		 * anything within the statement.
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
			_Tutor editTutor = new _Tutor();
			editTutor = tutors.get(Integer.parseInt(txtStaffID.getText()));

			txtStaffID.setText(Integer.toString(editTutor.getStaffID()));
			txtTutorCode.setText(Integer.toString(editTutor.getTutorCode()));
			txtName.setText(editTutor.getName().toString());
			lstModules.setSelectedValue(editTutor.getModulesTaught(), true);
			cmbCourse.setSelectedItem(editTutor.getCourse());
			cmbOfficeLocation.setSelectedItem(editTutor.getOfficeLocation());
			cmbOfficeHours.setSelectedItem(editTutor.getOfficeHours());
			cmbPosition.setSelectedItem(editTutor.getPosition());
			cmbEmploymentStatus.setSelectedItem(editTutor.getEmploymentStatus());
			txtPersonalWebsite.setText(editTutor.getPersonalWebsite());
			btnSelect.setEnabled(false);
			txtStaffID.setEnabled(false);

		}

		/**
		 * combo box actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == cmbCourse) {

			lstDataArray.clear();

			for (int i = 0; i < relatedmoduleDATA.size(); i++) {

				String relatedCourse = relatedmoduleDATA.get(i).getRelatedCourse();
				String comboCourse = cmbCourse.getSelectedItem().toString();
				String MATCHED;
				if (relatedCourse.toString().equals(comboCourse)) {

					MATCHED = relatedmoduleDATA.get(i).getModuleName();
					lstDataArray.addElement(MATCHED);
				}

			}
		}

		/**
		 * update button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnUpdate) {
			valid = true;
			tutors.remove(Integer.parseInt(txtStaffID.getText()));
			_Tutor updateTutor = new _Tutor();

			try {
				updateTutor.setName(txtName.getText());
			} catch (_ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}

			if (valid == true) {
				updateTutor.setStaffID(Integer.parseInt(txtStaffID.getText()));
				updateTutor.setTutorCode(Integer.parseInt(txtTutorCode.getText()));
				updateTutor.setCourse(cmbCourse.getSelectedItem().toString());
				updateTutor.setModulesTaught(lstModules.getSelectedValuesList().toArray());
				updateTutor.setOfficeLocation(cmbOfficeLocation.getSelectedItem().toString());
				updateTutor.setOfficeHours(cmbOfficeHours.getSelectedItem().toString());
				updateTutor.setPosition(cmbPosition.getSelectedItem().toString());
				updateTutor.setEmploymentStatus(cmbEmploymentStatus.getSelectedItem().toString());
				updateTutor.setPersonalWebsite(txtPersonalWebsite.getText());
				tutors.put(updateTutor.getStaffID(), updateTutor);
				formReset();
			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}

	}
	// TODO Auto-generated method stub

}
