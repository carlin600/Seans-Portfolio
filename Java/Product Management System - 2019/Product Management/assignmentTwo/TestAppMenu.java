  package assignmentTwo;

import javax.swing.JFrame;
import javax.swing.UIManager;
import javax.swing.UIManager.LookAndFeelInfo;


public class TestAppMenu {
	
	public static void main(String[] args) 
	{

		try {
		    for (LookAndFeelInfo info : UIManager.getInstalledLookAndFeels()) {
		        if ("Nimbus".equals(info.getName())) {
		            UIManager.setLookAndFeel(info.getClassName());
		            break;
		        }
		    }
		} catch (Exception e1) {
			//tried other look and feels but Jtattoo wouldnt work cause then id have to download new stuff and
			//import but youd have to do it to get it to work so there was no point ~Sc
			
		}
		
		//opens up the splash screen and sets its properties etc.
		AppSplash AS = new AppSplash();
		AS.setTitle("One World Health Products - © Sean Carlin ");
		AS.setSize(1200,650);
		AS.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		AS.setVisible(true);
		AS.setResizable(false);
		
	}

}
