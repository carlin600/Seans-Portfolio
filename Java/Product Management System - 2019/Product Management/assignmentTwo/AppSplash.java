package assignmentTwo;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.UIManager.LookAndFeelInfo;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class AppSplash extends JFrame implements ActionListener {
	
	private Container cPane;
	private JPanel pC;
	private JLabel lblDisImage;
	private ImageIcon shop;
	private Timer t;
	
	AppSplash()		
	{
		cPane = getContentPane();
		cPane.setBackground(Color.BLACK);
		
		shop = (new ImageIcon(new ImageIcon(getClass().getResource("shopping 3.jpeg")).getImage().getScaledInstance(1200,650,
				Image.SCALE_SMOOTH)));
	
		pC = new JPanel();
		pC.setLayout(new FlowLayout(FlowLayout.CENTER,400,25));
		
		lblDisImage = new JLabel("", JLabel.CENTER);
		lblDisImage.setIcon(shop);
		pC.add(lblDisImage);
		
		cPane.add(pC, BorderLayout.CENTER);
		
		//timer to control splash screen
		ActionListener timeloop = new TimeLoop();
		
		t = new Timer(2500, timeloop);
		t.start();
				
		this.setVisible(false);
	}
	
	class TimeLoop implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
		{
			t.stop();
			
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
			
			AppMenu AM = new AppMenu();
			AM.setTitle("One World Health Products - © Sean Carlin ");
			AM.setSize(1200,650);
			AM.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			AM.setVisible(true);

		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
	}		
	
	

	
	
}
