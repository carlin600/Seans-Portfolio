package Assignment_Student_Management;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import javax.swing.*;

public class Add_Course extends JFrame implements ActionListener {

	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Module> modules;

	public Add_Course(TreeMap<Integer, _Course> courses, TreeMap<Integer, _Module> modules) {
		// TODO Auto-generated constructor stub

		courses = courses;
		modules = modules;

	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		// TODO Auto-generated method stub

	}

}
