package Assignment_Student_Management;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.*;
import javax.swing.*;

public class Add_Student extends JFrame implements ActionListener {

	private JLabel lblHeader, lblStudentID, lblName, lblYear, lblCourse, lblModules, lblGender;
	private JButton btnExit, btnReset, btnSubmit;
	private JTextField txtStudentID, txtName;
	private JComboBox cmbCourse, cmbYear, cmbGender;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[10];
	private JRadioButton optMale, optFemale;
	private JPanel centre, pnlGender, pnlModules;
	private boolean valid;
	private ImageIcon exit;
	private int studentID;
	private ArrayList<_Module> relatedmoduleDATA;
	private DefaultListModel lstDataArray;
	private JList lstModules;

	private TreeMap<Integer, _Student> students;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	Add_Student(TreeMap<Integer, _Student> studentsIn, TreeMap<Integer, _Module> modulesIn,
			TreeMap<Integer, _Course> coursesIn) {
		students = studentsIn;
		modules = modulesIn;
		courses = coursesIn;

		// Jlabels
		lblHeader = new JLabel("Add New Student", JLabel.CENTER);
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

		// JTextboxes
		txtStudentID = new JTextField(10);
		txtStudentID.setText("1001");
		txtStudentID.setEditable(false);
		txtName = new JTextField(30);

		// JButtons
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
		btnReset = new JButton("Reset");
		btnReset.setFont(new Font("Calibri", Font.BOLD, 16));
		btnReset.addActionListener(this);
		btnSubmit = new JButton("Submit");
		btnSubmit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSubmit.addActionListener(this);

		// JComboBox
		models[0] = new DefaultComboBoxModel(
				new String[] { "- Select Year - ", "Year 1", "Year 2", "Year 3", "Year 4", "Year 5" });
		models[1] = new DefaultComboBoxModel(new String[] { "- Select Course - ", "Computing", "Animation",
				"Business & Management", "Policing", "Politics" });
		models[2] = new DefaultComboBoxModel(new String[] { "Databases", "Web Design", "Computer Networks",
				"Object-Oriented Programming", "Games Engines", "Software Engineering", "Project Management" });
		models[3] = new DefaultComboBoxModel(new String[] { "Animation Studio Skills", "Animation Light",
				"Animation on Screen", "Fan Cultures & Subcultures", "Animation & the real world" });
		models[4] = new DefaultComboBoxModel(new String[] { "Business Economics", "People & Organisations",
				"Marketing for Business", "Business Start-Up", "Statistics for Economics", "Operations Management",
				"Digital Marketing" });
		models[5] = new DefaultComboBoxModel(new String[] { "Legal Methods", "Policing Skills", "Criminal Law",
				"Police Powers", "Criminal Investigations", "Criminology Research", "Professional Policing" });
		models[6] = new DefaultComboBoxModel(new String[] { "Critical Criminology Theory", "Crime, Law & Society",
				"Europen Politics", "Politics of Imprisonment", "Elections & Voting Systems", "Politics of Policing" });
		models[7] = new DefaultComboBoxModel(new String[] { " - Make Selection - " });
		models[8] = new DefaultComboBoxModel(new String[] { " - Select Gender - ", "Male", "Female" });

		// JRadiobutton
		/*
		 * JRadioButton optMale = new JRadioButton("Male"); optMale.setFont(new
		 * Font("Calibri", Font.BOLD, 16)); JRadioButton optFemale = new
		 * JRadioButton("Female"); optFemale.setFont(new Font("Calibri", Font.BOLD,
		 * 16));
		 * 
		 * ButtonGroup grpGender = new ButtonGroup(); grpGender.add(optMale);
		 * grpGender.add(optFemale);
		 */

		ArrayList<_Course> courseArray = new ArrayList<_Course>();
		Set<Map.Entry<Integer, _Course>> coursestored = courses.entrySet();
		for (Map.Entry<Integer, _Course> coursesStored : coursestored) {
			courseArray.add(coursesStored.getValue());
		}

		ArrayList<_Module> moduleArray = new ArrayList<_Module>();
		Set<Map.Entry<Integer, _Module>> modulestored = modules.entrySet();

		for (Map.Entry<Integer, _Module> modulesStored : modulestored) {
			moduleArray.add(modulesStored.getValue());
		}

		relatedmoduleDATA = moduleArray;

		lstDataArray = new DefaultListModel();
		lstDataArray.addElement("  ");
		lstModules = new JList(lstDataArray);
		lstModules.setVisibleRowCount(6);
		lstModules.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);

		cmbCourse = new JComboBox(courseArray.toArray());
		cmbCourse.addActionListener(this);
		cmbCourse.setToolTipText("Select a Course");
		cmbYear = new JComboBox(models[0]);
		cmbYear.addActionListener(this);
		cmbGender = new JComboBox(models[8]);
		cmbGender.addActionListener(this);

		// Autogen student ID
		studentID = students.lastEntry().getValue().getStudentID() + 1;
		txtStudentID.setText(Integer.toString(studentID));

		// JPanel properties
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 1, 4, 1, 2, 2);
		addComp(lblStudentID, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtStudentID, centre, 2, 2, 1, 1, 1, 1);
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
		addComp(btnSubmit, centre, 4, 8, 1, 1, 1, 1);

	}

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

	public void formReset() {
		valid = false;

		txtName.setText("");
		cmbYear.setSelectedIndex(0);
		cmbCourse.setSelectedIndex(0);
		lstModules.clearSelection();
		lstDataArray.clear();
		cmbGender.setSelectedIndex(0);
		JOptionPane.showMessageDialog(null, "Form Reset!", "Confirmation!", JOptionPane.OK_OPTION);
		// Autogen student ID
		studentID = students.lastEntry().getValue().getStudentID() + 1;
		txtStudentID.setText(Integer.toString(studentID));
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		if (e.getSource() == btnExit) {
			int option = JOptionPane.showConfirmDialog(null, "Are you sure you wish to Exit?", "Warning",
					JOptionPane.YES_NO_OPTION);

			if (option == JOptionPane.YES_OPTION) {
				this.setVisible(false);
			}

		}

		if (e.getSource() == btnReset) {

			formReset();

		}

		if (e.getSource() == btnSubmit) {
			valid = true;

			_Student newStudent = new _Student();

			try {
				newStudent.setName(txtName.getText());
			} catch (_ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}

			if (valid == true) {
				newStudent.setStudentID(Integer.parseInt(txtStudentID.getText()));
				newStudent.setYear(cmbYear.getSelectedItem().toString());
				newStudent.setCourse(cmbCourse.getSelectedItem().toString());
				newStudent.setModulesTaken(lstModules.getSelectedValuesList().toArray());
				newStudent.setGender(cmbGender.getSelectedItem().toString());
				students.put(newStudent.getStudentID(), newStudent);
				JOptionPane.showMessageDialog(null, "Student Submitted!", "Confirmation!", JOptionPane.PLAIN_MESSAGE);
				formReset();

			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}

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

	}
}
