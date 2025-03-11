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
 * This class represents showing marked assignments.
 *
 * @author Sean Carlin
 *
 */
public class Mark_Assignment extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader, lblMark, lblDisplay, lblResultID, lblAssignment, lblStudent, lblGrade, lblFeedback,
			lblStudentDetails, lblAssignmentDetails;
	private JTextField txtResult, txtFeedback, txtAssignment, txtGrade, txtMark;
	private JTextArea taAssignmentDetails, taStudentDetails, taDisplay;
	private JComboBox cmbAssignment, cmbStudent;
	private JButton btnExit, btnReset, btnSubmit, btnSelect;
	private JPanel centre, pnlDisplay;
	private DefaultComboBoxModel[] options = new DefaultComboBoxModel[10];
	private JScrollPane spDisplay;
	private boolean valid;
	private int resultID;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Assignment> assignments;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;
	private TreeMap<Integer, _MarkedAssignment> results;
	private TreeMap<Integer, _Student> students;

	/**
	 * The marked assignments default constructor.
	 * @param assignmentsIn the assignment treemap.
	 * @param coursesIn the course treemap.
	 * @param modulesIn the modules treemap.
	 * @param resultsIn the results treemap.
	 * @param studentsIn the students treemap.
	 */
	Mark_Assignment(TreeMap<Integer, _Assignment> assignmentsIn, TreeMap<Integer, _Course> coursesIn,
			TreeMap<Integer, _Module> modulesIn, TreeMap<Integer, _MarkedAssignment> resultsIn,
			TreeMap<Integer, _Student> studentsIn) {

		/**
		 * TreeMaps being initialised.
		 */
		assignments = assignmentsIn;
		courses = coursesIn;
		modules = modulesIn;
		results = resultsIn;
		students = studentsIn;

		
		/**
		 * JLabel initialisation and properties. 
		 * Any label used is created and values are set here.
		 */
		lblHeader = new JLabel("Mark Assignment", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblDisplay = new JLabel("Displaying Assignments", JLabel.CENTER);
		lblDisplay.setFont(new Font("Calibri", Font.BOLD, 20));
		lblResultID = new JLabel("Result ID: ", JLabel.LEFT);
		lblResultID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignment = new JLabel("Select Assignment: ", JLabel.LEFT);
		lblAssignment.setFont(new Font("Calibri", Font.BOLD, 16));
		lblStudent = new JLabel("Select Student:  ", JLabel.LEFT);
		lblStudent.setFont(new Font("Calibri", Font.BOLD, 16));
		lblGrade = new JLabel("Set Grade: ", JLabel.LEFT);
		lblGrade.setFont(new Font("Calibri", Font.BOLD, 16));
		lblMark = new JLabel("Set Mark: ", JLabel.LEFT);
		lblMark.setFont(new Font("Calibri", Font.BOLD, 16));
		lblFeedback = new JLabel("Feedback: ", JLabel.LEFT);
		lblFeedback.setFont(new Font("Calibri", Font.BOLD, 16));
		lblStudentDetails = new JLabel("Student Details", JLabel.CENTER);
		lblStudentDetails.setFont(new Font("Calibri", Font.BOLD, 16));

		
		/**
		 * JTextField Properties and Values.
		 * Any text field used is created and values set here.
		 */
		txtResult = new JTextField(10);
		txtResult.setEditable(false);
		txtFeedback = new JTextField(30);
		txtAssignment = new JTextField(10);
		txtGrade = new JTextField(10);
		txtGrade.setText("Automatically Assigned.");
		txtGrade.setEditable(false);
		txtMark = new JTextField(10);

		
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
		btnSelect = new JButton("Select");
		btnSelect.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSelect.addActionListener(this);

		/**
		 * JTextArea Properties and Values.
		 * Any text area used is created and values set here.
		 */
		taAssignmentDetails = new JTextArea(12, 30);
		taAssignmentDetails.setEditable(false);
		taAssignmentDetails.setText("Assignment Details");
		taStudentDetails = new JTextArea(12, 30);
		taStudentDetails.setEditable(false);
		taDisplay = new JTextArea(12, 30);
		taDisplay.setEditable(false);

		/**
		 * JScrollPane Properties and Values.
		 * Scroll Pane properties and values set here.
		 */
		spDisplay = new JScrollPane(taDisplay);
		spDisplay.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);

		/**
		 * Array List linked to the student treemap.
		 * The for loop will loop through the student treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Student> studentArray = new ArrayList<_Student>();
		Set<Map.Entry<Integer, _Student>> studentstored = students.entrySet();

		for (Map.Entry<Integer, _Student> studentsStored : studentstored) {
			studentArray.add(studentsStored.getValue());
		}

		/**
		 * JComboBox declarations and properties.
		 */
		cmbStudent = new JComboBox(studentArray.toArray());
		cmbStudent.addActionListener(this);

		

		/**
		 * Autogen Engines. This is where the ID is automatically incremented
		 * by 1. It pulls the last entry from the map and adds 1 on.
		 */
		resultID = results.lastEntry().getValue().getResultID() + 1;
		txtResult.setText(Integer.toString(resultID));

		
		
		
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
		addComp(lblResultID, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtResult, centre, 2, 2, 1, 1, 1, 1);
		addComp(btnSelect, centre, 3, 3, 1, 1, 1, 1);
		addComp(lblAssignment, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtAssignment, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblStudent, centre, 1, 4, 1, 1, 1, 1);
		addComp(cmbStudent, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblMark, centre, 1, 5, 1, 1, 1, 1);
		addComp(txtMark, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblGrade, centre, 1, 6, 1, 1, 1, 1);
		addComp(txtGrade, centre, 2, 6, 1, 1, 1, 1);
		addComp(lblFeedback, centre, 1, 7, 1, 1, 1, 1);
		addComp(txtFeedback, centre, 2, 7, 1, 1, 1, 1);
		addComp(taAssignmentDetails, centre, 3, 7, 1, 5, 1, 1);
		addComp(lblDisplay, centre, 3, 4, 2, 1, 1, 1);
		addComp(pnlDisplay, centre, 3, 5, 2, 2, 1, 1);
		addComp(btnExit, centre, 1, 15, 1, 1, 1, 1);
		addComp(btnReset, centre, 2, 15, 1, 1, 1, 1);
		addComp(btnSubmit, centre, 3, 15, 2, 1, 1, 1);

		displayAssignments();
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
	 * display assignments Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	public void displayAssignments() {
		taDisplay.append("");
		taDisplay.append("Assignment ID   Assignment Name \n");

		ArrayList<_Assignment> assignmentArray = new ArrayList<_Assignment>();
		Set<Map.Entry<Integer, _Assignment>> assignmentstored = assignments.entrySet();

		for (Map.Entry<Integer, _Assignment> assignmentsStored : assignmentstored) {
			assignmentArray.add(assignmentsStored.getValue());
			taDisplay.append("" + assignmentsStored.getValue().toString());
		}
	}

	/**
	 * ResetForm Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	public void formReset() {
		valid = false;
		txtFeedback.setText("");
		txtResult.setText("");
		taAssignmentDetails.setText("");
		taStudentDetails.setText("");
		txtAssignment.setText("");
		txtGrade.setText("Automatically Assigned");
		cmbStudent.setSelectedIndex(0);
		txtGrade.setText("");
		txtMark.setText("");
		displayAssignments();

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
			_Assignment getAssignment = new _Assignment();
			getAssignment = assignments.get(Integer.parseInt(txtAssignment.getText().toString()));
			taAssignmentDetails.append(getAssignment.toDetails());
		}

	
		/**
		 * submit button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnSubmit) {
			valid = true;

			int mark = Integer.parseInt(txtMark.getText());
			String grade = null;

			if (mark >= 70) {
				grade = "Outstanding";
			} else if (mark >= 60 || mark <= 69) {
				grade = "Excellent";
			} else if (mark >= 50 || mark <= 59) {
				grade = "Very Good";
			} else if (mark >= 40 || mark <= 49) {
				grade = "Good";
			} else if (mark >= 30 || mark <= 39) {
				grade = "Pass";
			} else if (mark >= 20 || mark <= 29) {
				grade = "Narrow Fail";
			} else if (mark >= 0 || mark <= 20) {
				grade = "Fail";
			} else {
				JOptionPane.showMessageDialog(null, "Enter Mark Value!", "ERROR!", JOptionPane.OK_OPTION);
			}
			txtGrade.setText(grade.toString());
			_MarkedAssignment newResults = new _MarkedAssignment();

			try {
				newResults.setAssignmentMark(Integer.parseInt(txtMark.getText()));
			} catch (NumberFormatException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
				valid = false;
			} catch (_ApplicantException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
				valid = false;
			}

			if (valid == true) {
				_Assignment getAssignment = new _Assignment();
				getAssignment = assignments.get(Integer.parseInt(txtAssignment.getText().toString()));

				newResults.setAssignmentID(Integer.parseInt(txtAssignment.getText()));
				newResults.setResultID(Integer.parseInt(txtResult.getText()));
				newResults.setAssignmentStudent(cmbStudent.getSelectedItem().toString());
				newResults.setAssignmentGrade(txtGrade.getText());
				newResults.setAssignmentFeedback(txtFeedback.getText());
				try {
					newResults.setAssignmentName(getAssignment.getAssignmentName().toString());
				} catch (_ApplicantException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
				results.put(newResults.getResultID(), newResults);

				JOptionPane.showMessageDialog(null, "Results Added!", "Confirmation!", JOptionPane.OK_OPTION);
				formReset();

			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}

	}

}
