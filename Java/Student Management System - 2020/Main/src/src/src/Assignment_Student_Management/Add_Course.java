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
 * This class represents the course class used within the system.
 *
 * @author Sean Carlin
 *
 */
public class Add_Course extends JFrame implements ActionListener {

	/**
	 * TreeMaps being initialised.
	 */
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	public Add_Course(TreeMap<Integer, _Course> courses, TreeMap<Integer, _Module> modules) {
		// TODO Auto-generated constructor stub

		/**
		 * TreeMaps being initialised.
		 */
		courses = courses;
		modules = modules;

	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		// TODO Auto-generated method stub

	}

}
