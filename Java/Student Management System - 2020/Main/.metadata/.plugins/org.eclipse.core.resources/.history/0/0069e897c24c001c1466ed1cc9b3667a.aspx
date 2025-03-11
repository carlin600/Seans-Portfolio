/**
 * Assignment Package
 */
package Assignment_Student_Management;

/**
 * Imported Libraries used for this class.
 */

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.UIManager.LookAndFeelInfo;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
/**
 * This class represents the splash screen that greets the user upon startup for 
 * a few seconds, it will then close and open up the system.
 * 
 * @author Sean Carlin
 *
 */
public class System_Splash_Screen extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations, not much to be used as its only for 
	 * the splash screen.
	 */
	private Container cPane;
	private JPanel pC;
	private JLabel lblDisImage;
	private ImageIcon splash, img;
	private Timer t;

	System_Splash_Screen() {

		// ImageIcon img = new ImageIcon("C:\\Users\\Temporary\\OneDrive - Edge Hill
		// University\\OOP - CIS2149\\Eclipse Library\\Tutorials -
		// Practice\\src\\Assignment_Student_Management\\EHU.jpg");

		cPane = getContentPane();
		cPane.setBackground(Color.BLACK);

		splash = (new ImageIcon(new ImageIcon(getClass().getResource("splash.JPG")).getImage().getScaledInstance(1200,
				650, Image.SCALE_SMOOTH)));

		pC = new JPanel();
		pC.setLayout(new FlowLayout(FlowLayout.CENTER, 400, 25));

		lblDisImage = new JLabel("", JLabel.CENTER);
		lblDisImage.setIcon(splash);
		pC.add(lblDisImage);

		cPane.add(pC, BorderLayout.CENTER);

		// timer to control splash screen
		ActionListener timeloop = new TimeLoop();

		t = new Timer(2500, timeloop);
		t.start();

		this.setVisible(false);
	}

	/**
	 * Timer function implemented to run the splash screen 
	 * for a few seconds before opening the main system.
	 * @author Sean Carlin
	 *
	 */
	class TimeLoop implements ActionListener {
		public void actionPerformed(ActionEvent e) {
			t.stop();

//			try {
//				for (LookAndFeelInfo info : UIManager.getInstalledLookAndFeels()) {
//					if ("Nimbus".equals(info.getName())) {
//						UIManager.setLookAndFeel(info.getClassName());
//						break;
//					}
//				}
//			} catch (Exception e1) {
//
//			}
			/**
			 * Opens specified form with its set properties - in this case the main system.
			 */
			System_Menu SM = new System_Menu();
			SM.setTitle("EHU User Management - © Sean Carlin ");
			// SM.setIconImage(img.getImage());
			SM.setSize(1000, 600);
			SM.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			SM.setVisible(true);
			SM.setResizable(false);
			SM.setLocationRelativeTo(null);
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

	}

}
