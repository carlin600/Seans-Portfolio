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
 * This class represents showing assignments.
 *
 * @author Sean Carlin
 *
 */

public class Show_Assignments extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JLabel lblHeader;
	private JPanel centre;
	private JButton btnExit;
	private JTextArea taDisplay;
	private ArrayList<_Module> relatedmoduleDATA;
	private DefaultListModel lstDataArray;

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Assignment> assignments;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	/**
	 * show assignments default constructor.
	 * @param assignmentsIn the assignments treemap.
	 * @param modulesIn the modules treemap.
	 * @param coursesIn the course treemap.
	 */
	public Show_Assignments(TreeMap<Integer, _Assignment> assignmentsIn, TreeMap<Integer, _Module> modulesIn,
			TreeMap<Integer, _Course> coursesIn) {

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
		lblHeader = new JLabel("Display Assignments", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));

		/**
		 * JTextArea Properties and Values.
		 * Any text area used is created and values set here.
		 */
		taDisplay = new JTextArea(20, 20);
		taDisplay.setEditable(false);

		
		/**
		 * Array List linked to the assignment treemap.
		 * The for loop will loop through the assignment treemap and
		 * add each item from the map into the arraylist to be used
		 * effectively within this section.
		 */
		ArrayList<_Assignment> assignmentArray = new ArrayList<_Assignment>();
		Set<Map.Entry<Integer, _Assignment>> assignmentstored = assignments.entrySet();

		for (Map.Entry<Integer, _Assignment> assignmentsStored : assignmentstored) {
			assignmentArray.add(assignmentsStored.getValue());
			taDisplay.append("\n" + assignmentsStored.getValue().toString());
		}

		/**
		 * JButton Initialisation and Properties. Any Button component is declared and
		 * built here. All Properties and values applied, text, text size, font etc.
		 */
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
		 * <b>AddComp Method Values.<b> This section is where all Swing Components and
		 * Objects are passed into the AddComp Method and placed within the <i>GridBag
		 * Layout<i>
		 */
		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 2, 4, 1, 1, 1);
		addComp(taDisplay, centre, 1, 4, 4, 4, 4, 4);
		addComp(btnExit, centre, 1, 8, 4, 1, 1, 1);

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

	}

}
