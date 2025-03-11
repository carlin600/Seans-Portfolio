package Assignment_Student_Management;

import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;
import javax.swing.UIManager;
import javax.swing.UIManager.LookAndFeelInfo;

public class System_Menu_Test extends JFrame implements ActionListener {

	public static void main(String[] args) {

		try {
			for (LookAndFeelInfo info : UIManager.getInstalledLookAndFeels()) {
				if ("Nimbus".equals(info.getName())) {
					UIManager.setLookAndFeel(info.getClassName());
					break;
				}
			}
		} catch (Exception e1) {

		}

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
