/**
 * Assignment Package
 */
package Assignment_Student_Management;

/**
 * Imported Libraries used for this class.
 */
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;
import javax.swing.UIManager;
import javax.swing.UIManager.LookAndFeelInfo;

/**
 * This is the test class that containts the main method to run the splash
 * screen class.
 * 
 * @author Sean Carlin
 *
 */
public class System_Menu_Test extends JFrame implements ActionListener {

	/**
	 * Class main method which is run on program start.
	 * 
	 * @param args passed in arguments.
	 */
	public static void main(String[] args) {

		/**
		 * This is the theme engine basically. The try catch method loops through the
		 * library to find pre-stored themes and sets the inputted one.
		 */
		
		  try { for (LookAndFeelInfo info : UIManager.getInstalledLookAndFeels()) { if
		  ("Nimbus".equals(info.getName())) {
		  UIManager.setLookAndFeel(info.getClassName()); break; } } } catch (Exception
		  e1) {
		  
		  }
		 

		/**
		 * Opens specified form with its set properties - in this case splash screen
		 */
		System_Splash_Screen SSS = new System_Splash_Screen();
		SSS.setTitle("Student Management System - © Sean Carlin ");
		SSS.setSize(1000, 600);
		SSS.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		SSS.setVisible(true);
		SSS.setResizable(false);
		SSS.setLocationRelativeTo(null);

	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		// TODO Auto-generated method stub

	}

}
