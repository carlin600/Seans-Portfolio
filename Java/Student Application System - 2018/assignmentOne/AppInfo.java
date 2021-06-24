package assignmentOne;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class AppInfo extends JFrame implements ActionListener {
	
	private JTextArea txtArea;
	private JButton btnExit;
	private JLabel lbl;
	private JScrollPane jsp;
	private Container cn;

	private FileInputStream in;

	private String s = "";
	private char ch;
	private int no;

	AppInfo() {

	cn = getContentPane();

	lbl = new JLabel("Information", SwingConstants.CENTER);
	lbl.setFont(new Font("Dialog", Font.BOLD, 30));
	lbl.setForeground(Color.BLUE);
	cn.add(lbl, BorderLayout.NORTH);

	btnExit = new JButton("Return");
	btnExit.setFont(new Font("Dialog", Font.BOLD, 18));
	btnExit.addActionListener(this);
	cn.add(btnExit, BorderLayout.SOUTH);

	txtArea = new JTextArea(20, 70);
	txtArea.setFont(new Font("Dialog", Font.BOLD, 16));

	jsp = new JScrollPane(txtArea);
	cn.add(jsp, BorderLayout.CENTER);

	// read a text file into a string s and when finished set the text property of
	// the JTextArea
	try {
		// Rules.txt created in Notepad and saved in the project folder
		in = new FileInputStream("AppInfo.txt");
		try {
			while ((no = in.read()) != -1) {
				ch = (char) no;
				s += ch;
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		txtArea.setText(s);

	} catch (FileNotFoundException ef) {
		JOptionPane.showMessageDialog(null, "Unable To Read Application Information!" + s);
	}
}

	public void actionPerformed(ActionEvent e) {
		this.setVisible(false);
		// this.dispose();
	}

}
