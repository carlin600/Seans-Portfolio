package assignmentOne;
import java.awt.*;
import javax.swing.*;
import javax.swing.UIManager.LookAndFeelInfo;
import java.awt.image.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;



public class testGUI  {



public static void main(String[] args) 
{
	//sets the window icon image, although it doesnt work.
	Image ucas = new ImageIcon("ucas.jpg").getImage();
	
	//opens up the splash screen and sets its properties etc.
	AppSplash AS = new AppSplash();
	AS.setTitle("UCAS Applications - © Sean Carlin ");
	AS.setSize(1600,800);
	AS.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	AS.setVisible(true);
	AS.setResizable(false);
	AS.setIconImage(ucas);
	
}



}




	

	





