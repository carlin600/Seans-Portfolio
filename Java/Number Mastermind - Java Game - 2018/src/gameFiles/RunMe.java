package gameFiles;

import javax.swing.ImageIcon;
import javax.swing.JFrame;

//import Assignment2SeanCarlin.NMMSounds;

 public class RunMe
 {

	public static void main(String[] args) 
	{
		SplashStart s = new SplashStart();
		s.setTitle("Number Mastermind! - © Sean Carlin ");
		s.setSize(800,450);
		s.setIconImage(new ImageIcon("icon.jpg").getImage());
		s.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		s.setVisible(true);
		s.setResizable(false);
		s.setLocationRelativeTo(null);

	}
	
	

	
	

}


   