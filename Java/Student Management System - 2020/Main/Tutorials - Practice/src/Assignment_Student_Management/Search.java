package Assignment_Student_Management;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import javax.swing.*;

public class Search extends JFrame implements ActionListener {

	private JLabel lblHeader, lblHeading, lblSearch;
	private JComboBox cmbDisplay;
	private DefaultComboBoxModel[] options = new DefaultComboBoxModel[1];
	private JPanel centre;
	private JButton btnExit, btnSelect;
	private JTextArea taDisplay;
	private JTextField txtSearch;

	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;
	private TreeMap<Integer, _Tutor> tutors;
	private TreeMap<Integer, _Student> students;
	private TreeMap<Integer, _Academic> academics;
	private TreeMap<Integer, _Staff> staffs;

	public Search(TreeMap<Integer, _Course> coursesIn, TreeMap<Integer, _Module> modulesIn,
			TreeMap<Integer, _Tutor> tutorsIn, TreeMap<Integer, _Student> studentsIn,
			TreeMap<Integer, _Academic> academicsIn, TreeMap<Integer, _Staff> staffsIn) {

		courses = coursesIn;
		modules = modulesIn;
		tutors = tutorsIn;
		students = studentsIn;
		academics = academicsIn;
		staffs = staffsIn;

		lblHeader = new JLabel("Display Category", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblHeading = new JLabel("Select Category:", JLabel.RIGHT);
		lblHeading.setFont(new Font("Calibri", Font.BOLD, 18));
		lblSearch = new JLabel("Search:", JLabel.RIGHT);
		lblSearch.setFont(new Font("Calibri", Font.BOLD, 18));

		options[0] = new DefaultComboBoxModel(new String[] { "- Select Category - ", "Students", "Courses", "Staff",
				"Tutors", "Academics", "Modules" });

		cmbDisplay = new JComboBox(options[0]);
		cmbDisplay.addActionListener(this);

		taDisplay = new JTextArea(20, 20);
		taDisplay.setEditable(false);

		txtSearch = new JTextField(15);

		btnSelect = new JButton("Select");
		btnSelect.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSelect.addActionListener(this);

		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);

		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 2, 4, 1, 1, 1);
		addComp(lblHeading, centre, 1, 3, 1, 1, 1, 1);
		addComp(cmbDisplay, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblSearch, centre, 3, 3, 1, 1, 1, 1);
		addComp(txtSearch, centre, 4, 3, 1, 1, 1, 1);
		addComp(btnSelect, centre, 5, 3, 1, 1, 1, 1);
		addComp(taDisplay, centre, 1, 4, 5, 4, 4, 4);
		addComp(btnExit, centre, 1, 8, 5, 1, 1, 1);

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

	private void resetDisplay() {
		taDisplay.setText("");
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

		if (e.getSource() == btnSelect) {

			int number;
			number = cmbDisplay.getSelectedIndex();

			switch (number) {
			case 0:
				resetDisplay();
				JOptionPane.showConfirmDialog(null, "Please Select Category!", "Warning", JOptionPane.WARNING_MESSAGE);
				break;

			case 1:
				resetDisplay();
				_Student searchStudent = new _Student();
				searchStudent = students.get(Integer.parseInt(txtSearch.getText()));
				taDisplay.append("Displaying " + searchStudent.getName() + "'s Details\n" + searchStudent.toDetails());
				break;

			case 2:
				resetDisplay();
				_Course searchCourse = new _Course();
				searchCourse = courses.get(Integer.parseInt(txtSearch.getText()));
				taDisplay.append(
						"Displaying " + searchCourse.getCourseName() + "'s Details\n" + searchCourse.toDetails());
				break;

			case 3:
				resetDisplay();
				_Staff searchStaff = new _Staff();
				searchStaff = staffs.get(Integer.parseInt(txtSearch.getText()));
				taDisplay.append("Displaying " + searchStaff.getName() + "'s Details\n" + searchStaff.toDetails());
				break;

			case 4:
				resetDisplay();
				_Tutor searchTutor = new _Tutor();
				searchTutor = tutors.get(Integer.parseInt(txtSearch.getText()));
				taDisplay.append("Displaying " + searchTutor.getName() + "'s Details\n" + searchTutor.toDetails());
				break;

			case 5:
				resetDisplay();
				_Academic searchAcademic = new _Academic();
				searchAcademic = academics.get(Integer.parseInt(txtSearch.getText()));
				taDisplay
						.append("Displaying " + searchAcademic.getName() + "'s Details\n" + searchAcademic.toDetails());
				break;

			case 6:
				resetDisplay();
				_Module searchModule = new _Module();
				searchModule = modules.get(Integer.parseInt(txtSearch.getText()));
				taDisplay.append(
						"Displaying " + searchModule.getModuleName() + "'s Details\n" + searchModule.toDetails());
				break;
			}

		}

		if (e.getSource() == cmbDisplay) {
			int number;
			number = cmbDisplay.getSelectedIndex();

			switch (number) {
			case 0:
				resetDisplay();
				break;

			case 1:
				resetDisplay();
				taDisplay.append("Displaying all Students \n");

				Set<Map.Entry<Integer, _Student>> stored = students.entrySet();

				for (Map.Entry<Integer, _Student> studentsStored : stored) {
					taDisplay.append("" + studentsStored.getValue().toDisplayFull());
				}

				break;

			case 2:
				resetDisplay();
				taDisplay.append("Displaying all Courses \n");

				Set<Map.Entry<Integer, _Course>> coursed = courses.entrySet();

				for (Map.Entry<Integer, _Course> coursesStored : coursed) {
					taDisplay.append("" + coursesStored.getValue().toDisplay());
				}
				break;

			case 3:
				resetDisplay();
				taDisplay.append("Displaying all Staff \n");

				Set<Map.Entry<Integer, _Staff>> staffed = staffs.entrySet();

				for (Map.Entry<Integer, _Staff> staffStored : staffed) {
					taDisplay.append("" + staffStored.getValue());
				}
				break;

			case 4:
				resetDisplay();
				taDisplay.append("Displaying all Tutors \n");

				Set<Map.Entry<Integer, _Tutor>> tutored = tutors.entrySet();

				for (Map.Entry<Integer, _Tutor> tutorsStored : tutored) {
					taDisplay.append("" + tutorsStored.getValue().toDisplay());
				}
				break;

			case 5:
				resetDisplay();
				taDisplay.append("Displaying all Academics \n");

				Set<Map.Entry<Integer, _Academic>> academiced = academics.entrySet();

				for (Map.Entry<Integer, _Academic> academicsStored : academiced) {
					taDisplay.append("" + academicsStored.getValue().toDisplay());
				}
				break;

			case 6:
				resetDisplay();

				taDisplay.append("Displaying all Modules \n");

				Set<Map.Entry<Integer, _Module>> moduled = modules.entrySet();

				for (Map.Entry<Integer, _Module> modulesStored : moduled) {
					taDisplay.append("" + modulesStored.getValue().toDisplay());
				}
				break;
			}

		}
	}

}
