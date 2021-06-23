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
import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;


/**
 * This class represents Student Statistics.
 *
 * @author Sean Carlin
 *
 */
public class Student_Stats extends JFrame implements ActionListener {

	
	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblStudents, lblAssignment, lblHeader, lblName, lblCourse, lblAssignmentName, lblMark, lblAverage,
			lblFeedback;
	private JTextField txtStudent, txtAssignment, txtName, txtCourse, txtAssignmentName, txtMark, txtAverage,
			txtFeedback;
	private JButton btnSelectStudent, btnSelectAssignment, btnExit, btnReset, btnGenReport;
	private JTextArea taStudent, taModules, taAssignment;
	private JPanel centre;
	private ArrayList<_MarkedAssignment> relatedAssignmentDATA;
	private DefaultListModel lstDataArray;
	private JList lstAssignments;

	
	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Assignment> assignments;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;
	private TreeMap<Integer, _MarkedAssignment> results;
	private TreeMap<Integer, _Student> students;

	/**
	 * LinkedList being initialised.
	 */
	private LinkedList<_Statistics> statistics;

	/**
	 * The student Statistics default constructor.
	 * @param assignmentsIn the assignment treemap.
	 * @param coursesIn the courses treemap.
	 * @param modulesIn the modules treemap.
	 * @param resultsIn the results treemap.
	 * @param studentsIn the students treemap.
	 * @param statisticsIn the statistics linkedlist.
	 */
	public Student_Stats(TreeMap<Integer, _Assignment> assignmentsIn, TreeMap<Integer, _Course> coursesIn,
			TreeMap<Integer, _Module> modulesIn, TreeMap<Integer, _MarkedAssignment> resultsIn,
			TreeMap<Integer, _Student> studentsIn, LinkedList<_Statistics> statisticsIn) {


		/**
		 * initialising passed in treemaps and Linkedlist.
		 */
		assignments = assignmentsIn;
		courses = coursesIn;
		modules = modulesIn;
		results = resultsIn;
		students = studentsIn;
		statistics = statisticsIn;


		/**
		 * JLabel initialisation and properties. 
		 * Any label used is created and values are set here.
		 */
		lblHeader = new JLabel("Student Statistics", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblStudents = new JLabel("Select Student", JLabel.CENTER);
		lblStudents.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignment = new JLabel("Select Assignment", JLabel.CENTER);
		lblAssignment.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Student Name:  ", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblCourse = new JLabel("Course: ", JLabel.LEFT);
		lblCourse.setFont(new Font("Calibri", Font.BOLD, 16));
		lblMark = new JLabel("Assignment Mark: ", JLabel.LEFT);
		lblMark.setFont(new Font("Calibri", Font.BOLD, 16));
		lblFeedback = new JLabel("Feedback: ", JLabel.LEFT);
		lblFeedback.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAssignmentName = new JLabel("Assignment Name ", JLabel.LEFT);
		lblAssignmentName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAverage = new JLabel("Students Average:", JLabel.LEFT);
		lblAverage.setFont(new Font("Calibri", Font.BOLD, 16));


		/**
		 * JTextField Properties and Values.
		 * Any text field used is created and values set here.
		 */
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
		btnReset = new JButton("Reset");
		btnReset.setFont(new Font("Calibri", Font.BOLD, 16));
		btnReset.addActionListener(this);
		btnSelectStudent = new JButton("Select Student");
		btnSelectStudent.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSelectStudent.addActionListener(this);
		btnSelectAssignment = new JButton("Select Assignment");
		btnSelectAssignment.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSelectAssignment.addActionListener(this);
		btnGenReport = new JButton("Generate Report");
		btnGenReport.setFont(new Font("Calibri", Font.BOLD, 16));
		btnGenReport.addActionListener(this);


		/**
		 * JTextField Properties and Values.
		 * Any text field used is created and values set here.
		 */
		txtStudent = new JTextField(30);
		txtAssignment = new JTextField(30);
		txtName = new JTextField(30);
		txtName.setEditable(false);
		txtCourse = new JTextField(30);
		txtCourse.setEditable(false);
		txtAssignmentName = new JTextField(30);
		txtAssignmentName.setEditable(false);
		txtMark = new JTextField(30);
		txtMark.setEditable(false);
		txtAverage = new JTextField(30);
		txtAverage.setEditable(false);
		txtFeedback = new JTextField(30);
		txtFeedback.setEditable(false);

		/**
		 * JTextArea Properties and Values.
		 * Any text area used is created and values set here.
		 */
		taStudent = new JTextArea(10, 10);
		taStudent.setEditable(false);
		taModules = new JTextArea(10, 10);
		taModules.setEditable(false);
		taAssignment = new JTextArea(10, 10);
		taAssignment.setEditable(false);

		/**
		 * Array List linked to the assignment treemap.
		 * The for loop will loop through the assignment treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Assignment> assignmentArray = new ArrayList<_Assignment>();
		Set<Map.Entry<Integer, _Assignment>> assignmentstored = assignments.entrySet();

		for (Map.Entry<Integer, _Assignment> assignmentStored : assignmentstored) {
			assignmentArray.add(assignmentStored.getValue());
		}

		
		/**
		 * Array List linked to the markedassignment treemap.
		 * The for loop will loop through the markedassignment treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_MarkedAssignment> markedassignmentArray = new ArrayList<_MarkedAssignment>();
		Set<Map.Entry<Integer, _MarkedAssignment>> markedassignmentstored = results.entrySet();

		for (Map.Entry<Integer, _MarkedAssignment> markedAssignmentStored : markedassignmentstored) {
			markedassignmentArray.add(markedAssignmentStored.getValue());
		}
		relatedAssignmentDATA = markedassignmentArray;

		/**
		 * DefaultListModel declarations and properties.
		 */
		lstDataArray = new DefaultListModel();
		lstDataArray.addElement("  ");
		lstAssignments = new JList(lstDataArray);
		lstAssignments.setVisibleRowCount(6);


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
		addComp(lblHeader, centre, 1, 1, 1, 1, 1, 1);
		addComp(lblStudents, centre, 1, 2, 2, 1, 1, 1);
		addComp(taStudent, centre, 1, 3, 2, 1, 1, 1);
		addComp(txtStudent, centre, 1, 4, 2, 1, 1, 1);
		addComp(btnSelectStudent, centre, 1, 5, 2, 1, 1, 1);
		addComp(lblAssignment, centre, 3, 2, 2, 1, 1, 1);
		addComp(lstAssignments, centre, 3, 3, 2, 1, 1, 1);
		addComp(txtAssignment, centre, 3, 4, 2, 1, 1, 1);
		addComp(btnSelectAssignment, centre, 3, 5, 2, 1, 1, 1);
		addComp(lblName, centre, 1, 6, 1, 1, 1, 1);
		addComp(txtName, centre, 2, 6, 1, 1, 1, 1);
		addComp(lblCourse, centre, 1, 7, 1, 1, 1, 1);
		addComp(txtCourse, centre, 2, 7, 1, 1, 1, 1);
		addComp(lblAssignmentName, centre, 1, 8, 1, 1, 1, 1);
		addComp(txtAssignmentName, centre, 2, 8, 1, 1, 1, 1);
		addComp(lblMark, centre, 3, 6, 1, 1, 1, 1);
		addComp(txtMark, centre, 4, 6, 1, 1, 1, 1);
		addComp(lblFeedback, centre, 3, 7, 1, 1, 1, 1);
		addComp(txtFeedback, centre, 4, 7, 1, 1, 1, 1);
		addComp(lblAverage, centre, 3, 8, 1, 1, 1, 1);
		addComp(txtAverage, centre, 4, 8, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 9, 1, 1, 1, 1);
		addComp(btnReset, centre, 2, 9, 1, 1, 1, 1);
		addComp(btnGenReport, centre, 3, 9, 2, 1, 1, 1);

		displayStudent();

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
	public void displayStudent() {
		taStudent.append("");

		ArrayList<_Student> studentArray = new ArrayList<_Student>();
		Set<Map.Entry<Integer, _Student>> studentstored = students.entrySet();

		for (Map.Entry<Integer, _Student> studentsStored : studentstored) {
			studentArray.add(studentsStored.getValue());
			taStudent.append("" + studentsStored.getValue().toDisplayFull());
		}

	}

	/**
	 * ResetForm Method. 
	 * Once callsed this method will clear the form of all values.
	 */
	public void formReset() {

		txtStudent.setText("");
		txtStudent.setEditable(true);
		txtAssignment.setText("");
		txtAssignment.setEditable(false);
		txtName.setText("");
		txtCourse.setText("");
		txtAssignmentName.setText("");
		txtMark.setText("");
		txtAverage.setText("");
		txtFeedback.setText("");
		btnSelectStudent.setEnabled(true);
		btnSelectAssignment.setEnabled(true);
		btnGenReport.setEnabled(true);

		taStudent.setText("");
		taModules.setText("");
		taAssignment.setText("");
		lstDataArray.clear();
		displayStudent();
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
		 * select student button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnSelectStudent) {
			_Student selectStudent = new _Student();
			selectStudent = students.get(Integer.parseInt(txtStudent.getText().toString()));
			txtName.setText(selectStudent.getName());
			txtCourse.setText(selectStudent.getCourse());

			for (int i = 0; i < relatedAssignmentDATA.size(); i++) {

				String relatedStudent = relatedAssignmentDATA.get(i).getAssignmentStudent();
				String student = txtName.getText().toString();
				String MATCHED;

				if (relatedStudent.toString().equals(student)) {
					MATCHED = relatedAssignmentDATA.get(i).toString();
					lstDataArray.addElement(MATCHED);
				}
			}

			btnSelectStudent.setEnabled(false);
			txtStudent.setEditable(false);
			btnSelectAssignment.setEnabled(true);
			txtAssignment.setEditable(true);

		}

		/**
		 * select assignment button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnSelectAssignment) {
			_MarkedAssignment selectAssignment = new _MarkedAssignment();
			selectAssignment = results.get(Integer.parseInt(txtAssignment.getText()));

			txtAssignmentName.setText(selectAssignment.getAssignmentName());
			txtMark.setText(Integer.toString(selectAssignment.getAssignmentMark()));
			txtFeedback.setText(selectAssignment.getAssignmentFeedback());
			int average = Integer.parseInt(txtMark.getText());
			average = average * 100 / 80;
			txtAverage.setText(Integer.toString(average));

			btnSelectAssignment.setEnabled(false);
			txtAssignment.setEditable(false);
		}

		/**
		 * genarate report button actionlistener. 
		 * Once interacted, the program will trigger anything within the statement.
		 */
		if (e.getSource() == btnGenReport) {

			btnGenReport.setEnabled(false);

			_Statistics newStat = new _Statistics();
			// newStat.setStatisticID(Integer.parseInt(""));
			newStat.setMark(Integer.parseInt(txtMark.getText()));
			newStat.setStudentName(txtName.getText());
			newStat.setCourse(txtCourse.getText());
			newStat.setAssignmentName(txtAssignmentName.getText());
			newStat.setFeedback(txtFeedback.getText());
			newStat.setAverage(txtAverage.getText());
			statistics.add(newStat);

			_Statistics print;
			String report;
			// open the text file to add the all sales report
			File inFile = new File(txtName.getText().toString() + ".txt");
			PrintWriter in = null;
			try {
				in = new PrintWriter(inFile);
			} catch (FileNotFoundException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
			// set the header for the report
			in.println(
					" - - - - - - - - - - - - - - - - - - - - A L L  S T A S T I S T I C S  R E P O R T - - - - - - - - - - - - - - - - - - - - - ");
			in.println(
					"- - - - - - - - - - - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
			in.println("");
			in.println(
					"Statistics ID       Mark      Student Name        Course            Assignment Name         FeedBack       Average");
			in.println(
					" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  ");

			// loop through requests in queue to allocate if multiple
			// while(statistics.isEmpty() == false)
			// {
			print = statistics.peek();
			print = newStat;

			// generate string for report and send it to the text file
			report = String.format(" " + print.getStatisticID() + "			 " + print.getMark() + "	 "
					+ print.getStudentName() + "	 " + print.getCourse() + " 		" + print.getAssignmentName()
					+ "	 " + print.getFeedback() + " 		" + print.getAverage());

			in.println(report);
			// remove (pop) request from the queue
			statistics.remove(report);

			// }
			in.close();

			JOptionPane.showMessageDialog(null, "Report for " + txtName.getText() + " generated!", "Error!",
					JOptionPane.OK_OPTION);
			formReset();

		}
	}

}
