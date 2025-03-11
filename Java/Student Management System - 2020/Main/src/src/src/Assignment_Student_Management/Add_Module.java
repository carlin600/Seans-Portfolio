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
 * This class represents adding a module to the system.
 *
 * @author Sean Carlin
 *
 */
public class Add_Module extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblModuleCode, lblModuleName, lblLeader, lblModerator, lblRelatedCourse;
	private JTextField txtModuleCode, txtModuleName;
	private JComboBox cmbLeader, cmbModerator, cmbRelatedCourse;
	private JButton btnExit, btnReset, btnSubmit;
	private int moduleCode;
	private JPanel centre;
	private boolean valid;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Tutor> tutors;
	private TreeMap<Integer, _Academic> academics;
	private TreeMap<Integer, _Module> modules;
	private TreeMap<Integer, _Course> courses;

	/**
	 * add module default constructor
	 * 
	 * @param tutorsIn    the tutor treemap.
	 * @param academicsIn the academic treemap.
	 * @param modulesIn   the module treemap.
	 * @param coursesIn   the courses treemap.
	 */
	public Add_Module(TreeMap<Integer, _Tutor> tutorsIn, TreeMap<Integer, _Academic> academicsIn,
			TreeMap<Integer, _Module> modulesIn, TreeMap<Integer, _Course> coursesIn) {

		/**
		 * TreeMaps being initialised.
		 */
		tutors = tutorsIn;
		academics = academicsIn;
		modules = modulesIn;
		courses = coursesIn;

		/**
		 * JLabel initialisation and properties. Any label used is created and values
		 * are set here.
		 */
		lblHeader = new JLabel("Add New Module", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblModuleCode = new JLabel("Module Code: ", JLabel.LEFT);
		lblModuleCode.setFont(new Font("Calibri", Font.BOLD, 16));
		lblModuleName = new JLabel("Module Name: ", JLabel.LEFT);
		lblModuleName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblLeader = new JLabel("Leader: ", JLabel.LEFT);
		lblLeader.setFont(new Font("Calibri", Font.BOLD, 16));
		lblModerator = new JLabel("Moderator: ", JLabel.LEFT);
		lblModerator.setFont(new Font("Calibri", Font.BOLD, 16));
		lblRelatedCourse = new JLabel("Related Course: ", JLabel.LEFT);
		lblRelatedCourse.setFont(new Font("Calibri", Font.BOLD, 16));

		/**
		 * JTextField Properties and Values. Any text field used is created and values
		 * set here.
		 */
		txtModuleCode = new JTextField(10);
		txtModuleCode.setEditable(false);
		txtModuleName = new JTextField(10);

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
		 * Array List linked to the tutor treemap. The for loop will loop through the
		 * tutor treemap and add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Tutor> tutorArray = new ArrayList<_Tutor>();
		Set<Map.Entry<Integer, _Tutor>> tutorstored = tutors.entrySet();
		for (Map.Entry<Integer, _Tutor> tutorsStored : tutorstored) {
			tutorArray.add(tutorsStored.getValue());
		}

		/**
		 * Array List linked to the academic treemap. The for loop will loop through the
		 * academic treemap and add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Academic> academicArray = new ArrayList<_Academic>();
		Set<Map.Entry<Integer, _Academic>> academicstored = academics.entrySet();

		for (Map.Entry<Integer, _Academic> academicsStored : academicstored) {
			academicArray.add(academicsStored.getValue());
		}

		/**
		 * Array List linked to the course treemap. The for loop will loop through the
		 * course treemap and add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Course> courseArray = new ArrayList<_Course>();
		Set<Map.Entry<Integer, _Course>> coursestored = courses.entrySet();
		for (Map.Entry<Integer, _Course> coursesStored : coursestored) {
			courseArray.add(coursesStored.getValue());
		}

		/**
		 * JComboBox declarations and properties.
		 */
		cmbLeader = new JComboBox(academicArray.toArray());
		cmbLeader.addActionListener(this);
		cmbModerator = new JComboBox(tutorArray.toArray());
		cmbModerator.addActionListener(this);
		cmbRelatedCourse = new JComboBox(courseArray.toArray());
		cmbRelatedCourse.addActionListener(this);

		/**
		 * Autogen Engines. This is where the ID is automatically incremented by 1. It
		 * pulls the last entry from the map and adds 1 on.
		 */
		moduleCode = modules.lastEntry().getValue().getModuleCode() + 1;
		txtModuleCode.setText(Integer.toString(moduleCode));

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
		addComp(lblHeader, centre, 1, 1, 3, 1, 2, 2);
		addComp(lblModuleCode, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtModuleCode, centre, 2, 2, 1, 1, 1, 1);
		addComp(lblModuleName, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtModuleName, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblLeader, centre, 1, 4, 1, 1, 1, 1);
		addComp(cmbLeader, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblModerator, centre, 1, 5, 1, 1, 1, 1);
		addComp(cmbModerator, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblRelatedCourse, centre, 1, 6, 1, 1, 1, 1);
		addComp(cmbRelatedCourse, centre, 2, 6, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 7, 1, 1, 1, 1);
		addComp(btnReset, centre, 2, 7, 1, 1, 1, 1);
		addComp(btnSubmit, centre, 3, 7, 1, 1, 1, 1);

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
		gc.insets = new Insets(10, 10, 10, 10);
		gc.gridx = gridX;
		gc.gridy = gridY;
		gc.gridwidth = width;
		gc.gridheight = height;
		gc.weightx = weightX;
		gc.weighty = weightY;

		getContentPane().add(c, gc); // adds components to the gridbag
	}

	/**
	 * ResetForm Method. Once callsed this method will clear the form of all values.
	 */
	public void formReset() {
		valid = false;

		txtModuleName.setText("");
		cmbLeader.setSelectedIndex(0);
		cmbModerator.setSelectedIndex(0);
		cmbRelatedCourse.setSelectedIndex(0);

		// autogen Staff ID
		moduleCode = modules.lastEntry().getValue().getModuleCode() + 1;
		txtModuleCode.setText(Integer.toString(moduleCode));
		JOptionPane.showMessageDialog(null, "Form Reset!", "Confirmation!", JOptionPane.OK_OPTION);

	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

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
		 * reset button actionlistener. Once interacted, the program will trigger
		 * anything within the statement.
		 */
		if (e.getSource() == btnReset) {

			formReset();
		}

		/**
		 * submit button actionlistener. Once interacted, the program will trigger
		 * anything within the statement.
		 */
		if (e.getSource() == btnSubmit) {
			_Module newModule = new _Module();

			try {
				newModule.setModuleName(txtModuleName.getText());
			} catch (_ApplicantException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}

			newModule.setModuleCode(Integer.parseInt(txtModuleCode.getText()));
			newModule.setLeader(cmbLeader.getSelectedItem().toString());
			newModule.setModerator(cmbModerator.getSelectedItem().toString());
			newModule.setRelatedCourse(cmbRelatedCourse.getSelectedItem().toString());
			modules.put(newModule.getModuleCode(), newModule);
			JOptionPane.showMessageDialog(null, "Module Added!", "Confirmation!", JOptionPane.OK_OPTION);
			formReset();

		}

	}

}
