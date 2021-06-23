/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * Imported Libraries used for this class.
 */
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import javax.swing.*;

/**
 * This class represents Deleting a User from the system.
 * 
 * @author Sean Carlin
 *
 */
public class Delete extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblHeading, lblDelete;
	private JComboBox cmbDisplay;
	private DefaultComboBoxModel[] options = new DefaultComboBoxModel[10];
	private JPanel centre;
	private JButton btnDelete, btnExit;
	private JTextArea taDisplay;
	private JTextField txtDelete;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;
	private TreeMap<Integer, _Tutor> tutors;
	private TreeMap<Integer, _Student> students;
	private TreeMap<Integer, _Academic> academics;
	private TreeMap<Integer, _Staff> staffs;

	/**
	 * Delete default constructor
	 * 
	 * @param coursesIn   the course treemap.
	 * @param modulesIn   the module treemap.
	 * @param tutorsIn    the tutor treemap.
	 * @param studentsIn  the student treemap.
	 * @param academicsIn the academic treemap.
	 * @param staffsIn    the staff treemap.
	 */
	public Delete(TreeMap<Integer, _Course> coursesIn, TreeMap<Integer, _Module> modulesIn,
			TreeMap<Integer, _Tutor> tutorsIn, TreeMap<Integer, _Student> studentsIn,
			TreeMap<Integer, _Academic> academicsIn, TreeMap<Integer, _Staff> staffsIn) {

		/**
		 * initialising passed in treemaps.
		 */
		courses = coursesIn;
		modules = modulesIn;
		tutors = tutorsIn;
		students = studentsIn;
		academics = academicsIn;
		staffs = staffsIn;

		/**
		 * JComboBox models are created here. Java Swing allows JComboBoxes to have
		 * DefaultComboBoxModels implemented to allow for easier values added. Sometimes
		 * more than one.
		 */
		options[0] = new DefaultComboBoxModel(new String[] { "- Select Category - ", "Students", "Courses", "Staff",
				"Tutors", "Academics", "Modules" });

		/**
		 * JLabel initialisation and properties. Any label used is created and values
		 * are set here.
		 */
		lblHeader = new JLabel("Display Category", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblHeading = new JLabel("Select Category:", JLabel.RIGHT);
		lblHeading.setFont(new Font("Calibri", Font.BOLD, 18));
		lblDelete = new JLabel("Delete Via [number]: ", JLabel.RIGHT);
		lblDelete.setFont(new Font("Calibri", Font.BOLD, 18));

		/**
		 * JComboBox declarations and properties.
		 */
		cmbDisplay = new JComboBox(options[0]);
		cmbDisplay.addActionListener(this);

		/**
		 * JTextArea Properties and Values. Any text area used is created and values set
		 * here.
		 */
		taDisplay = new JTextArea(20, 20);
		taDisplay.setEditable(false);

		/**
		 * JTextField Properties and Values. Any text field used is created and values
		 * set here.
		 */
		txtDelete = new JTextField(15);

		/**
		 * JButton Initialisation and Properties. Any Button component is declared and
		 * built here. All Properties and values applied, text, text size, font etc.
		 */
		btnDelete = new JButton("Delete");
		btnDelete.setFont(new Font("Calibri", Font.BOLD, 16));
		btnDelete.addActionListener(this);
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);

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
		 * AddComp Method Values. This section is where all Swing Components and
		 * Objects are passed into the AddComp Method and placed within the GridBag
		 * Layout
		 */
		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 2, 4, 1, 1, 1);
		addComp(lblHeading, centre, 1, 3, 1, 1, 1, 1);
		addComp(cmbDisplay, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblDelete, centre, 3, 3, 1, 1, 1, 1);
		addComp(txtDelete, centre, 4, 3, 1, 1, 1, 1);
		addComp(taDisplay, centre, 1, 4, 4, 4, 4, 4);
		addComp(btnExit, centre, 1, 8, 2, 1, 1, 1);
		addComp(btnDelete, centre, 3, 8, 2, 1, 1, 1);

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
	 * resetdisplay Method. Once callsed this method will clear the form of all
	 * values.
	 */
	private void resetDisplay() {
		taDisplay.setText("");
		txtDelete.setText("");
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		/**
		 * Exit button actionlistener. Once interacted, the program will trigger
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
		 * delete button actionlistener. Once interacted, the program will trigger
		 * anything within the statement.
		 */
		if (e.getSource() == btnDelete) {
			int del = JOptionPane.showConfirmDialog(null,
					"Are you sure you wish to delete the " + cmbDisplay.getSelectedItem().toString() + " selected?",
					"Warning", JOptionPane.YES_NO_OPTION);

			if (del == JOptionPane.YES_OPTION) {

				if (cmbDisplay.getSelectedIndex() == 1) {
					_Student delStudent = new _Student();
					delStudent = students.get(Integer.parseInt(txtDelete.getText()));
					students.remove(Integer.parseInt(txtDelete.getText()));
					cmbDisplay.setSelectedIndex(0);
					resetDisplay();
				} else if (cmbDisplay.getSelectedIndex() == 2) {
					_Course delCourse = new _Course();
					delCourse = courses.get(Integer.parseInt(txtDelete.getText()));
					courses.remove(Integer.parseInt(txtDelete.getText()));
					cmbDisplay.setSelectedIndex(0);
					resetDisplay();

				} else if (cmbDisplay.getSelectedIndex() == 3) {
					_Staff delStaff = new _Staff();
					delStaff = staffs.get(Integer.parseInt(txtDelete.getText()));
					staffs.remove(Integer.parseInt(txtDelete.getText()));
					cmbDisplay.setSelectedIndex(0);
					resetDisplay();

				} else if (cmbDisplay.getSelectedIndex() == 4) {
					_Tutor delTutor = new _Tutor();
					delTutor = tutors.get(Integer.parseInt(txtDelete.getText()));
					tutors.remove(Integer.parseInt(txtDelete.getText()));
					cmbDisplay.setSelectedIndex(0);
					resetDisplay();

				} else if (cmbDisplay.getSelectedIndex() == 5) {
					_Academic delAcademic = new _Academic();
					delAcademic = academics.get(Integer.parseInt(txtDelete.getText()));
					academics.remove(Integer.parseInt(txtDelete.getText()));
					cmbDisplay.setSelectedIndex(0);
					resetDisplay();

				} else if (cmbDisplay.getSelectedIndex() == 6) {
					_Module delModule = new _Module();
					delModule = modules.get(Integer.parseInt(txtDelete.getText()));
					modules.remove(Integer.parseInt(txtDelete.getText()));
					cmbDisplay.setSelectedIndex(0);
					resetDisplay();

				}

			}

		}

		/**
		 * Display Combobox actionlistener. Once interacted, the program will trigger
		 * anything within the statement.
		 */
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
				taDisplay.append("Student ID	Name	Year	Course	Modules	Gender \n");

				Set<Map.Entry<Integer, _Student>> stored = students.entrySet();

				for (Map.Entry<Integer, _Student> studentsStored : stored) {
					taDisplay.append("" + studentsStored.getValue().toDisplayFull());
				}

				break;

			case 2:
				resetDisplay();
				taDisplay.append("Displaying all Courses \n");
				taDisplay.append("Course ID     Name               Related Modules \n");

				Set<Map.Entry<Integer, _Course>> coursed = courses.entrySet();

				for (Map.Entry<Integer, _Course> coursesStored : coursed) {
					taDisplay.append("" + coursesStored.getValue().toDisplay());
				}
				break;

			case 3:
				resetDisplay();
				taDisplay.append("Displaying all Staff \n");
				taDisplay.append(
						"Staff ID   Name                 Office Location        Office Hours         Position        Status    Website\n");

				Set<Map.Entry<Integer, _Staff>> staffed = staffs.entrySet();

				for (Map.Entry<Integer, _Staff> staffStored : staffed) {
					taDisplay.append("" + staffStored.getValue());
				}
				break;

			case 4:
				resetDisplay();
				taDisplay.append("Displaying all Tutors \n");
				taDisplay.append("Staff ID   Tutor Code      Name         Modules Taught   Course\n");

				Set<Map.Entry<Integer, _Tutor>> tutored = tutors.entrySet();

				for (Map.Entry<Integer, _Tutor> tutorsStored : tutored) {
					taDisplay.append("" + tutorsStored.getValue().toDisplay());
				}
				break;

			case 5:
				resetDisplay();
				taDisplay.append("Displaying all Academics \n");
				taDisplay.append("Name	Academic Code	   Expertise	Student Supervised \n");

				Set<Map.Entry<Integer, _Academic>> academiced = academics.entrySet();

				for (Map.Entry<Integer, _Academic> academicsStored : academiced) {
					taDisplay.append("" + academicsStored.getValue().toDisplay());
				}
				break;

			case 6:
				resetDisplay();

				taDisplay.append("Displaying all Modules \n");
				taDisplay.append(
						"Module Code     Name                           Leader           Moderator    Related Course\n");

				Set<Map.Entry<Integer, _Module>> moduled = modules.entrySet();

				for (Map.Entry<Integer, _Module> modulesStored : moduled) {
					taDisplay.append("" + modulesStored.getValue().toDisplay());
				}
				break;
			}

		}
	}

}
