package gameFiles;


/**
 * @author Sean Carlin
 */

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.IOException;
import java.util.Random;

import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.swing.*;

public class NumberMastermind extends JFrame implements ActionListener {

	/**
	 * Component declaration and properties.
	 */
	Container cPane;
	private JLabel lblTitle, lblPlayer, lblTries, lblTime, lblLocked;
	private JButton btnExit, btnReset, btnStart, btnCheck, btnAgain;
	private JButton[] nums = new JButton[10];
	private JLabel[] status = new JLabel[4];
	private JLabel[] display = new JLabel[4];
	int[] guess = new int[4];
	int[] code = new int[4];
	// private String player;

	private JPanel pNorth, pSouth, pEast, pWest, pCenter, pCenter2;
	private JTextField txtPlayer, txtTries, txtTime;
	private ImageIcon lblDisplayImage, fail, success;

	private Timer t = new Timer(1000, this);
	private int myTime;

	private JMenuBar mb;
	private JMenu mSystem;
	private JMenuItem mIRules, mIBestTimes, mIExit;
	private Rules rules;
	private BestTimes bestTimes;

	private int CurrentPos = 0; // max 4
	private int Tries = 0; // max 8

	// array for player guess - one dimensional w/4 spaces
	// array for lock number - one dimensional w/4 spaces
	// array for player details - one dimensional array w/name, tries and time

	NumberMastermind() {

		/**
		 * Calls function to create a combination.
		 */
		Combination();

		lblDisplayImage = (new ImageIcon(
				new ImageIcon("door.jpg").getImage().getScaledInstance(215, 348, Image.SCALE_SMOOTH)));
		fail = (new ImageIcon(new ImageIcon("fail.jpg").getImage().getScaledInstance(400, 460, Image.SCALE_SMOOTH)));
		success = (new ImageIcon(
				new ImageIcon("success.jpg").getImage().getScaledInstance(350, 325, Image.SCALE_SMOOTH)));

		cPane = getContentPane();
		cPane.setBackground(Color.ORANGE);
		cPane.setForeground(Color.BLACK);
		cPane.setLayout(new BorderLayout());

		pNorth = new JPanel();
		pEast = new JPanel();
		pSouth = new JPanel();
		pWest = new JPanel();
		pCenter = new JPanel();
		pCenter2 = new JPanel();
		pCenter2.setLayout(null);

		///////////////////////////////////// N O R T H P A N E L

		pNorth.setLayout(new BorderLayout());
		pNorth.setBackground(Color.ORANGE);
		pNorth.setForeground(Color.BLACK);

		// Analyse
		rules = new Rules();
		rules.setTitle("Rules for Number Mastermind!");
		rules.setSize(800, 600);
		rules.setVisible(false);

		bestTimes = new BestTimes();
		bestTimes.setTitle("Best Times for Number Mastermind!");
		bestTimes.setSize(800, 600);
		bestTimes.setVisible(false);

		mb = new JMenuBar();
		mSystem = new JMenu("Menu");
		mIRules = new JMenuItem("Rules");
		mIBestTimes = new JMenuItem("Best Times");
		mIExit = new JMenuItem("Exit Game");

		

		/**
		 * Menu item actionlisteners.
		 * Once 'actioned' the windows are set visible to the user.
		 */
		mIRules.addActionListener(new ActionListener() {
			// anonymous inner class

			public void actionPerformed(ActionEvent e) {
				rules.setVisible(true);
			}
		});

		mIBestTimes.addActionListener(new ActionListener() {
			// anonymous inner class

			public void actionPerformed(ActionEvent e) {
				bestTimes.setVisible(true);
			}
		});

		mIExit.addActionListener(new ActionListener() {
			// anonymous inner class

			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});

		mSystem.add(mIRules);
		mSystem.add(mIBestTimes);
		mSystem.add(mIExit);
		mb.add(mSystem);
		setJMenuBar(mb);

		lblTitle = new JLabel(" Number Mastermind! ", SwingConstants.CENTER);
		lblTitle.setFont(new Font("Calibri", Font.BOLD, 34));
		lblTitle.setBorder(BorderFactory.createRaisedBevelBorder());
		lblTitle.setBackground(Color.ORANGE);
		lblTitle.setForeground(Color.BLACK);
		lblTitle.setOpaque(true);

		pNorth.add(lblTitle);

		///////////////////////////////////// E N D O F N O R T H P A N E L

		
		
		///////////////////////////////////// E A S T P A N E L

		pEast.setLayout(new GridLayout(10, 1));
		pEast.setBackground(Color.ORANGE);
		pEast.setForeground(Color.BLACK);

		for (int i = 0; i < 10; i++) {
			nums[i] = new JButton(" " + i + " ");
			nums[i].setPreferredSize(new Dimension(80, 60));
			nums[i].setFont(new Font("Calibri", Font.BOLD, 30));
			nums[i].setBackground(Color.ORANGE);
			nums[i].setForeground(Color.BLACK);
			nums[i].setBorder(BorderFactory.createRaisedBevelBorder());
			nums[i].addActionListener(this);
			nums[i].setEnabled(false);

			pEast.add(nums[i]);
		}

		///////////////////////////////////// W E S T P A N E L

		pWest.setLayout(new GridLayout(6, 1));
		pWest.setBackground(Color.ORANGE);
		pWest.setForeground(Color.BLACK);

		lblPlayer = new JLabel("Player Name", SwingConstants.CENTER);
		lblPlayer.setFont(new Font("Calibri", Font.BOLD, 34));
		lblPlayer.setBorder(BorderFactory.createRaisedBevelBorder());
		lblPlayer.setBackground(Color.ORANGE);
		lblPlayer.setForeground(Color.BLACK);
		lblPlayer.setOpaque(true);

		txtPlayer = new JTextField(5);
		txtPlayer.setHorizontalAlignment(JTextField.CENTER);
		txtPlayer.setFont(new Font("Dialog", Font.BOLD, 34));
		txtPlayer.setText("");
		txtPlayer.setBackground(Color.ORANGE);
		txtPlayer.setForeground(Color.BLACK);

		pWest.add(lblPlayer);
		pWest.add(txtPlayer);

		lblTries = new JLabel("Tries", SwingConstants.CENTER);
		lblTries.setFont(new Font("Calibri", Font.BOLD, 40));
		lblTries.setBorder(BorderFactory.createRaisedBevelBorder());
		lblTries.setBackground(Color.ORANGE);
		lblTries.setForeground(Color.BLACK);
		lblTries.setOpaque(true);
		

		txtTries = new JTextField(5);
		txtTries.setHorizontalAlignment(JTextField.CENTER);
		txtTries.setText("");
		txtTries.setFont(new Font("Calibri", Font.BOLD, 45));
		txtTries.setBackground(Color.ORANGE);
		txtTries.setForeground(Color.BLACK);
		txtTries.setEditable(false);

		pWest.add(lblTries);
		pWest.add(txtTries);

		lblTime = new JLabel("Time Taken", SwingConstants.CENTER);
		lblTime.setFont(new Font("Calibri", Font.BOLD, 34));
		lblTime.setBorder(BorderFactory.createRaisedBevelBorder());
		lblTime.setBackground(Color.ORANGE);
		lblTime.setForeground(Color.BLACK);
		lblTime.setOpaque(true);

		txtTime = new JTextField(5);
		txtTime.setHorizontalAlignment(JTextField.CENTER);
		txtTime.setText("");
		txtTime.setFont(new Font("Calibri", Font.BOLD, 45));
		txtTime.setBackground(Color.ORANGE);
		txtTime.setForeground(Color.BLACK);
		txtTime.setEditable(false);

		pWest.add(lblTime);
		pWest.add(txtTime);

		///////////////////////////////////// E N D O F W E S T P A N E L

		///////////////////////////////////// S O U T H P A N E L

		pSouth.setLayout(new GridLayout(1, 3));
		pSouth.setBackground(Color.ORANGE);

		btnReset = new JButton(" Reset ");
		btnReset.setPreferredSize(new Dimension(80, 70));
		btnReset.setFont(new Font("Calibri", Font.BOLD, 40));
		btnReset.setBackground(Color.ORANGE);
		btnReset.setForeground(Color.BLACK);
		btnReset.setBorder(BorderFactory.createRaisedBevelBorder());

		btnStart = new JButton(" Start ");
		btnStart.setFont(new Font("Calibri", Font.CENTER_BASELINE, 40));
		btnStart.setBackground(Color.ORANGE);
		btnStart.setForeground(Color.BLACK);
		btnStart.setBorder(BorderFactory.createRaisedBevelBorder());

		btnExit = new JButton(" Exit ");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 40));
		btnExit.setBackground(Color.ORANGE);
		btnExit.setForeground(Color.BLACK);
		btnExit.setBorder(BorderFactory.createRaisedBevelBorder());

		pSouth.add(btnReset);
		pSouth.add(btnExit);
		pSouth.add(btnStart);

		///////////////////////////////////// E N D O F S O U T H P A N E L

		//////////////////////////////////// C E N T R E P A N E L

		pCenter.setLayout(new BorderLayout());
		pCenter.setBackground(Color.ORANGE);
		pCenter2.setBackground(Color.ORANGE);

		int lblX = 120;
		int lblY = 60;

		for (int i = 0; i < 4; i++) {

			status[i] = new JLabel("  ");
			status[i].setFont(new Font("Calibri", Font.BOLD, 24));
			status[i].setBorder(BorderFactory.createRaisedBevelBorder());
			status[i].setBackground(Color.ORANGE);
			status[i].setForeground(Color.BLACK);
			status[i].setOpaque(true);
			pCenter2.add(status[i]);
			status[i].setBounds(lblX, 120, 100, 50);
			lblX += 300;

		}

		for (int i = 0; i < 4; i++) {
			display[i] = new JLabel("  ");
			display[i].setIcon(lblDisplayImage);
			display[i].setFont(new Font("Calibri", Font.BOLD, 26));
			display[i].setBorder(BorderFactory.createRaisedBevelBorder());
			display[i].setBackground(Color.BLACK);
			display[i].setForeground(Color.white);
			display[i].setOpaque(true);
			pCenter2.add(display[i]);
			display[i].setBounds(lblY, 200, 220, 350);
			lblY += 300;
		}

		btnCheck = new JButton(" Check ");
		btnCheck.setFont(new Font("Calibri", Font.BOLD, 35));
		btnCheck.setPreferredSize(new Dimension(80, 70));
		btnCheck.setBackground(Color.ORANGE);
		btnCheck.setForeground(Color.BLACK);
		btnCheck.setBorder(BorderFactory.createRaisedBevelBorder());
		btnCheck.setEnabled(false);

		btnAgain = new JButton(" Try Again ");
		btnAgain.setFont(new Font("Calibri", Font.BOLD, 35));
		btnAgain.setPreferredSize(new Dimension(80, 70));
		btnAgain.setBackground(Color.ORANGE);
		btnAgain.setForeground(Color.BLACK);
		btnAgain.setBorder(BorderFactory.createRaisedBevelBorder());
		btnAgain.setEnabled(false);

		lblLocked = new JLabel("", SwingConstants.CENTER);
		lblLocked.setText(" [ L O C K E D ] ");
		lblLocked.setFont(new Font("Calibri", Font.BOLD, 24));
		lblLocked.setBorder(BorderFactory.createRaisedBevelBorder());
		lblLocked.setBackground(Color.RED);
		lblLocked.setForeground(Color.WHITE);
		lblLocked.setOpaque(true);
		lblLocked.setBounds(515, 585, 200, 50);

		JPanel pSouth2 = new JPanel(new GridLayout(1, 2));

		pSouth2.add(btnCheck);
		pSouth2.add(btnAgain);
		pCenter.add(pSouth2, BorderLayout.SOUTH);

		// pCenter.add(btnCheck, BorderLayout.SOUTH);
		// pCenter.add(btnAgain, BorderLayout.SOUTH);
		pCenter.add(pCenter2, BorderLayout.CENTER);

		pCenter2.add(lblLocked);

		cPane.add(pNorth, BorderLayout.NORTH);
		cPane.add(pEast, BorderLayout.EAST);
		cPane.add(pSouth, BorderLayout.SOUTH);
		cPane.add(pWest, BorderLayout.WEST);
		cPane.add(pCenter, BorderLayout.CENTER);

		btnAgain.addActionListener(this);
		btnCheck.addActionListener(this);
		btnExit.addActionListener(this);
		btnReset.addActionListener(this);
		btnStart.addActionListener(this);

	}

	@Override
	public void actionPerformed(ActionEvent e) {

		/**
		 * Button actionlisteners. 
		 * 
		 */
		
		if (e.getSource() == btnExit)

			System.exit(0);

		//Starts the game
		if (e.getSource() == btnStart) {
			t.start();
			myTime = 0;
			Tries = 1;
			txtTime.setText("" + 0);
			txtTries.setText("" + 1);

			for (int i = 0; i < 10; i++) {
				nums[i].setEnabled(true);

			}
			btnCheck.setEnabled(true);
			btnStart.setEnabled(false);
			playButton();
			playMusic();

			// start the timer here
			// start counting the number of tries etc

		}

		//This checks the combination if its right or wrong. 
		if (e.getSource() == btnAgain) {
			btnCheck.setEnabled(true);
			btnAgain.setEnabled(false);

			CurrentPos = 0;

			//For loop resets the combination windows to their blank state, awaiting user to click on more numbers.
			for (int j = 0; j < 10; j++) {
				nums[j].setEnabled(true);

				for (int x = 0; x < 4; x++) {
					display[x].setIcon(lblDisplayImage);
					display[x].setEnabled(true);
					status[x].setBackground(Color.ORANGE);
					status[x].setText(" ");
				}
			}
			Tries = Tries + 1;
			txtTries.setText("" + Tries);
			playButton();

			//Once tries reach 8, game over. 
			if (Tries == 8) {
				playFail();
				btnAgain.setEnabled(false);
				btnCheck.setEnabled(false);
				btnStart.setEnabled(false);
				JOptionPane.showMessageDialog(null, "Failure!! \n" + txtPlayer.getText() + " You've Failed!",
						"You Are A Disgrace To This Parish!", JOptionPane.INFORMATION_MESSAGE, fail);

			}

		}

		/**
		 * This function checks the combination by going through each windows number and comparing it to the combination.
		 * Notice how blocks are set to a specific colour;
			Green means it in the correct position and correct number.
			Yellow means right number in wrong position.
			Red means number isnt in combination at all.
		 */
		
		if (e.getSource() == btnCheck) {

			int correct = 0;

			if (code[0] == guess[0]) {
				status[0].setBackground(Color.GREEN);
				correct++;
			} else if (code[0] == guess[1]) {
				status[1].setBackground(Color.YELLOW);
			} else if (code[0] == guess[2]) {
				status[2].setBackground(Color.YELLOW);
			} else if (code[0] == guess[3]) {
				status[3].setBackground(Color.YELLOW);
			} else {
				status[0].setBackground(Color.RED);
			}

			if (code[1] == guess[1]) {
				status[1].setBackground(Color.GREEN);
				correct++;

			} else if (code[1] == guess[0]) {
				status[0].setBackground(Color.YELLOW);
			} else if (code[1] == guess[2]) {
				status[2].setBackground(Color.YELLOW);
			} else if (code[1] == guess[3]) {
				status[3].setBackground(Color.YELLOW);
			} else {
				status[1].setBackground(Color.RED);
			}

			if (code[2] == guess[2]) {
				status[2].setBackground(Color.GREEN);
				correct++;

			} else if (code[2] == guess[1]) {
				status[1].setBackground(Color.YELLOW);
			} else if (code[2] == guess[0]) {
				status[0].setBackground(Color.YELLOW);
			} else if (code[2] == guess[3]) {
				status[3].setBackground(Color.YELLOW);
			} else {
				status[2].setBackground(Color.RED);
			}

			if (code[3] == guess[3]) {
				status[3].setBackground(Color.GREEN);
				correct++;

			} else if (code[3] == guess[1]) {
				status[1].setBackground(Color.YELLOW);
			} else if (code[3] == guess[0]) {
				status[0].setBackground(Color.YELLOW);
			} else if (code[3] == guess[2]) {
				status[2].setBackground(Color.YELLOW);
			} else {
				status[3].setBackground(Color.RED);
			}

			btnAgain.setEnabled(true);
			playButton();

			if (correct < 4) {
				playWrong();
			}

			if (correct == 4) {
				playSuccess();
				lblLocked.setText(" [ U N L O C K E D ] ");
				lblLocked.setBackground(Color.GREEN);
				lblLocked.setForeground(Color.WHITE);
				btnAgain.setEnabled(false);
				btnCheck.setEnabled(false);
				t.stop();
				JOptionPane.showMessageDialog(null,
						"Congratulations " + txtPlayer.getText() + "!"
								+ " \nYou've Cracked The Safe! \nIn A Total Of " + txtTime.getText()
								+ " Seconds! \nWith only " + txtTries.getText() + " Tries!",
						"Winner Winner Chicken Dinner!", JOptionPane.INFORMATION_MESSAGE, success);
				
				try {
					BestTimes2.WriteOutBestTimes("\n\n" + txtPlayer.getText() + " " + txtTries.getText() + " " + txtTime.getText());
				} catch (IOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}

			}

		}

		/**
		 * Reset function
		 * Resets the games combination, and clears all data.
		 */
		if (e.getSource() == btnReset) {

			for (int j = 0; j < 10; j++) {
				nums[j].setEnabled(false);
				btnCheck.setEnabled(false);
				btnStart.setEnabled(true);
				btnAgain.setEnabled(false);
				lblLocked.setText(" [ L O C K E D ] ");
				lblLocked.setBackground(Color.RED);

				for (int x = 0; x < 4; x++) {
					display[x].setIcon(lblDisplayImage);
					display[x].setEnabled(true);
					status[x].setText(" ");
					status[x].setBackground(Color.ORANGE);
				}

			}

			System.out.print("\n\n\n\n");
			Combination();
			Tries = 0;
			CurrentPos = 0;
			t.stop();
			myTime = 0;
			txtTime.setText("");
			txtPlayer.setText("");
			txtTries.setText("");
			playButton();
			playMusic();
			

		}

		else {

			if (e.getSource() == t) {
				myTime++;
				txtTime.setText("" + myTime);
			}

			for (int i = 0; i < 10; i++) {

				if (e.getSource() == nums[i]) {
					display[CurrentPos].setFont(new Font("", Font.BOLD, 360));
					display[CurrentPos].setText("" + i + "");
					display[CurrentPos].setIcon(null);
					display[CurrentPos].setEnabled(false);
					nums[i].setEnabled(false);
					guess[CurrentPos] = i;
					CurrentPos++;
					playButton();

				}
				if (CurrentPos == 4) {
					break;
				}
			}

		}
	}

	/**
	 * Autogenerates the 4 digit combination to the safe.
	 * - via for loops and if statements.
	 * @return
	 */
	public int Combination() {
		for (int i = 0; i < 4; i++) {
			code[i] = 0;
		}

		for (int i = 0; i < 4; i++) {
			code[i] = (int) (Math.random() * 10);

			for (int j = 0; j < i; j++) {
				if (code[i] == code[j]) {
					code[j] = (int) (Math.random() * 10);
				}
			}
		}
		for (int i = 0; i < 4; i++) {
			System.out.println(code[i]);
		}
		// NOT ALL COME OUT UNIQUE - THEY STILL KEEP REPEATING SAME NUMBERS - JUST RESET
		// GAME FOR NEW COMBINATION - ~SEANC
		return 0;
	}
	
	/**
	 * The following methods below are all functions that play the specified sound.
	 */

	public void playMusic() {
		try {
			
			AudioInputStream audioInputStream = AudioSystem
					.getAudioInputStream(new File("theme.wav").getAbsoluteFile());
			Clip clip = AudioSystem.getClip();
			clip.open(audioInputStream);
			clip.start();
		} catch (Exception ex) {
			System.out.println("Error with playing sound.");
			ex.printStackTrace();
		}

	}

	public void playButton() {
		try {

			AudioInputStream audioInputStream = AudioSystem
					.getAudioInputStream(new File("button.wav").getAbsoluteFile());
			Clip clip = AudioSystem.getClip();
			clip.open(audioInputStream);
			clip.start();
		} catch (Exception ex) {
			System.out.println("Error with playing sound.");
			ex.printStackTrace();
		}

	}

	public void playFail() {
		try {

			AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(new File("fail.wav").getAbsoluteFile());
			Clip clip = AudioSystem.getClip();
			clip.open(audioInputStream);
			clip.start();
		} catch (Exception ex) {
			System.out.println("Error with playing sound.");
			ex.printStackTrace();
		}
	}

	public void playSuccess() {
		try {

			AudioInputStream audioInputStream = AudioSystem
					.getAudioInputStream(new File("success.wav").getAbsoluteFile());
			Clip clip = AudioSystem.getClip();
			clip.open(audioInputStream);
			clip.start();
		} catch (Exception ex) {
			System.out.println("Error with playing sound.");
			ex.printStackTrace();
		}
	}

	public void playWrong() {
		try {

			AudioInputStream audioInputStream = AudioSystem
					.getAudioInputStream(new File("wrong.wav").getAbsoluteFile());
			Clip clip = AudioSystem.getClip();
			clip.open(audioInputStream);
			clip.start();

		} catch (Exception ex) {
			System.out.println("Error with playing sound.");
			ex.printStackTrace();
		}
	}

}
