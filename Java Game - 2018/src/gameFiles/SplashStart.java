package gameFiles;

import java.awt.*;
import java.awt.event.*;

import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.swing.*;

import javax.swing.JFrame;
import javax.swing.JPanel;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;


public class SplashStart   extends JFrame implements ActionListener
{
	private Container cPane;
	private JPanel pN, pC;
	private JLabel lblPic, lblTitle;
	private ImageIcon img;
	private Timer t;
	
	
	
	SplashStart()		
	{
		cPane = getContentPane();
		cPane.setBackground(Color.BLACK);
		
		pN = new JPanel();
		pN.setLayout(new FlowLayout(FlowLayout.CENTER,450,25));
		pC = new JPanel();
		pC.setLayout(new FlowLayout(FlowLayout.CENTER,400,25));
		
		//panel north
		lblTitle = new JLabel("Welcome To Number Mastermind!");
		lblTitle.setFont(new Font("dialog", Font.BOLD, 48));
		pN.add(lblTitle);
		
		//centre
		lblPic = new JLabel(" Number Mastermind!");
		img = new ImageIcon("icon.jpg"); 
		
		lblPic.setIcon(img);
		pC.add(lblPic);
		
		cPane.add(pN,BorderLayout.NORTH);
		cPane.add(pC, BorderLayout.CENTER);
		
		//timer to control splash screen
		ActionListener timeloop = new TimeLoop();
		
		t = new Timer(3000, timeloop);
		t.start();
				
		this.setVisible(false);
		playStartup();

	}
	
	class TimeLoop implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
		{
			t.stop();
			NumberMastermind NMM = new NumberMastermind();
			NMM.setTitle("Number Mastermind! - © Sean Carlin ");
			NMM.setSize(1600,900);			
			NMM.setIconImage(new ImageIcon("icon.jpg").getImage());
		//	JFrame.setDefaultLookAndFeelDecorated(true);
			NMM.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			NMM.setVisible(true);
			NMM.setResizable(false);
			NMM.setLocationRelativeTo(null);

		}
	}		
	

	@Override
	public void actionPerformed(ActionEvent e) {

		
	}

	public void playStartup() {
		try {

			AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("startup.wav").getAbsoluteFile());
			Clip clip = AudioSystem.getClip();
			clip.open(audioInputStream);
			clip.start();

		} catch (Exception ex) {
			System.out.println("Error with playing sound.");
			ex.printStackTrace();
		}
	}
	
	
	
}
