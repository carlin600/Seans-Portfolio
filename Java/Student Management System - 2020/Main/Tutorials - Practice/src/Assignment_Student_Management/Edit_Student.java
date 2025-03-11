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
 * This class represents editing a student.
 *
 * @author Sean Carlin
 *
 */
public class Edit_Student extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblSelectStudent, lblStudentID, lblName, lblYear, lblCourse, lblModules, lblGender;
	private JButton btnExit, btnReset, btnUpdate, btnSelect;
	private JTextField txtStudentID, txtName, txtStudent;
	private JTextArea taDisplay;
	private JComboBox cmbCourse, cmbYear, cmbGender;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[10];
	private JRadioButton optMale, optFemale;
	private JPanel centre;
	private JPanel pnlDisplay;
	private JList lstModules;
	private boolean valid;
	private ImageIcon exit;
	private int studentID;
	private JScrollPane spDisplay;
	private ArrayList<_Module> relatedmoduleDATA;
	private DefaultListModel lstDataArray;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Student> students;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	/**
	 * Edit Student Constructor
	 * @param studentsIn the student treemap.
	 * @param modulesIn the modules treemap.
	 * @param coursesIn the courses treemap.
	 */
	Edit_Student(TreeMap<Integer, _Student> studentsIn, TreeMap<Integer, _Module> modulesIn,
			TreeMap<Integer, _Course> coursesIn) {
		
		/**
		 * TreeMaps being initialised.
		 */
		students = studentsIn;
		modules = modulesIn;
		courses = coursesIn;

		/**
		 * JLabel initialisation and properties. 
		 * Any label used is created and values are set here.
		 */
		lblHeader = new JLabel("Edit A Student", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblStudentID = new JLabel("StudentID: ", JLabel.LEFT);
		lblStudentID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Name: ", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblYear = new JLabel("Year: ", JLabel.LEFT);
		lblYear.setFont(new Font("Calibri", Font.BOLD, 16));
		lblCourse = new JLabel("Course: ", JLabel.LEFT);
		lblCourse.setFont(new Font("Calibri", Font.BOLD, 16));
		lblModules = new JLabel("Modules: ", JLabel.LEFT);
		lblModules.setFont(new Font("Calibri", Font.BOLD, 16));
		lblGender = new JLabel("Gender: ", JLabel.LEFT);
		lblGender.setFont(new Font("Calibri", Font.BOLD, 16));
		lblSelectStudent = new JLabel("Select Student (Via ID): ", JLabel.LEFT);
		lblSelectStudent.setFont(new Font("Calibri", Font.BOLD, 16));
		lblSelectStudent.setToolTipText("Select a student you wish to edit.");

		/**
		 * JTextField Properties and Values.
		 * Any text field used is created and values set here.
		 */
		txtStudentID = new JTextField(10);
		txtStudentID.setText("");
		txtStudentID.setEditable(false);
		txtName = new JTextField(30);
		txtStudent = new JTextField(5);

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
		btnUpdate = new JButton("Update");
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
		 * JComboBox models are created here. Java Swing allows JComboBoxes 
		 * to have DefaultComboBoxModels implemented to allow for easier values
		 * added. Sometimes more than one.
		 */
		models[0] = new DefaultComboBoxModel(
				new String[] { "- Select Year - ", "Year 1", "Year 2", "Year 3", "Year 4", "Year 5" });
		models[1] = new DefaultComboBoxModel(new String[] { "- Select Course - ", "Computing", "Animation",
				"Business and Management", "Policing", "Politics" });
		models[2] = new DefaultComboBoxModel(new String[] { "Databases", "Web Design", "Computer Networks",
				"Object-Oriented Programming", "Games Engines", "Software Engineering", "Project Management" });
		models[3] = new DefaultComboBoxModel(new String[] { "Animation Studio Skills", "Animation Light",
				"Animation on Screen", "Fan Cultures and Subcultures", "Animation and the real world" });
		models[4] = new DefaultComboBoxModel(new String[] { "Business Economics", "People and Organisations",
				"Marketing for Business", "Business Start-Up", "Statistics for Economics", "Operations Management",
				"Digital Marketing" });
		models[5] = new DefaultComboBoxModel(new String[] { "Legal Methods", "Policing Skills", "Criminal Law",
				"Police Powers", "Criminal Investigations", "Criminology Research", "Professional Policing" });
		models[6] = new DefaultComboBoxModel(new String[] { "Critical Criminology Theory", "Crime, Law and Society",
				"Europen Politics", "Politics of Imprisonment", "Elections and Voting Systems", "Politics of Policing" });
		models[7] = new DefaultComboBoxModel(new String[] { " - Make Selection - " });
		models[8] = new DefaultComboBoxModel(new String[] { " - Select Gender - ", "Male", "Female" });

		
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
		lstModules.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);

		/**
		 * JComboBox declarations and properties.
		 */
		cmbYear = new JComboBox(models[0]);
		cmbYear.addActionListener(this);
		cmbCourse = new JComboBox(courseArray.toArray());
		cmbCourse.addActionListener(this);
		cmbCourse.setToolTipText("Select a Course");
		cmbGender = new JComboBox(models[8]);
		cmbGender.addActionListener(this);

	

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
		addComp(pnlDisplay, centre, 3, 3, 2, 3, 3, 3);
		addComp(lblHeader, centre, 1, 1, 4, 1, 2, 2);
		addComp(lblSelectStudent, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtStudent, centre, 2, 2, 1, 1, 1, 1);
		addComp(btnSelect, centre, 3, 2, 2, 1, 1, 1);
		addComp(lblName, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtName, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblYear, centre, 1, 4, 1, 1, 1, 1);
		addComp(cmbYear, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblCourse, centre, 1, 5, 1, 1, 1, 1);
		addComp(cmbCourse, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblModules, centre, 1, 6, 1, 1, 1, 1);
		addComp(lstModules, centre, 2, 6, 1, 1, 1, 1);
		addComp(lblGender, centre, 1, 7, 1, 1, 1, 1);
		addComp(cmbGender, centre, 2, 7, 1, 1, 1, 1);
		addComp(btnReset, centre, 3, 8, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 8, 2, 1, 1, 1);
		addComp(btnUpdate, centre, 4, 8, 1, 1, 1, 1);

		displayStudents();

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
	private void displayStudents() {
		taDisplay.append(" ");
		taDisplay.append("Student ID	Name	Year	Course	Modules	Gender \n");

		ArrayList<_Student> studentArray = new ArrayList<_Student>();
		Set<Map.Entry<Integer, _Student>> studentstored = students.entrySet();

		for (Map.Entry<Integer, _Student> studentsStored : studentstored) {
			studentArray.add(studentsStored.getValue());
			taDisplay.append("" + studentsStored.getValue().toDisplayFull());
		}
	}

	/**
	 * ResetForm Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	private void formReset() {
		valid = false;
		displayStudents();
		txtName.setText("");
		cmbYear.setSelectedIndex(0);
		cmbCourse.setSelectedIndex(0);
		lstModules.clearSelection();
		cmbGender.setSelectedIndex(0);
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
		 * select button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnSelect) {
			_Student editStudent = new _Student();
			editStudent = students.get(Integer.parseInt(txtStudent.getText()));

			txtStudent.setText(Integer.toString(editStudent.getStudentID()));
			txtName.setText(editStudent.getName().toString());
			cmbYear.setSelectedItem(editStudent.getYear());
			cmbCourse.setSelectedItem(editStudent.getCourse());
			lstModules.setSelectedValue(editStudent.getModulesTaken(), true);
			cmbGender.setSelectedItem(editStudent.getGender());

			// students.put(editStudent.getStudentID(), editStudent);
			// btnSelect.setEnabled(false);
			// txtStudent.setEnabled(false);

		}

		/**
		 * update button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnUpdate) {
			valid = true;

			students.remove(Integer.parseInt(txtStudent.getText()));
			_Student newStudent = new _Student();

			try {
				newStudent.setName(txtName.getText());
			} catch (_ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}

			if (valid == true) {
				newStudent.setStudentID(Integer.parseInt(txtStudent.getText()));
				newStudent.setYear(cmbYear.getSelectedItem().toString());
				newStudent.setCourse(cmbCourse.getSelectedItem().toString());
				newStudent.setModulesTaken(lstModules.getSelectedValuesList().toArray());
				newStudent.setGender(cmbGender.getSelectedItem().toString());
				students.put(newStudent.getStudentID(), newStudent);
				JOptionPane.showMessageDialog(null, "Student Updated!", "Confirmation!", JOptionPane.PLAIN_MESSAGE);

			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}

	}

}