package Assignment_Student_Management;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import javax.swing.*;

public class Add_Academic extends JFrame implements ActionListener {

	private JLabel lblHeader, lblStaffID, lblAcademicCode, lblName, lblOfficeLocation, lblOfficeHours, lblPosition,
			lblEmploymentStatus, lblPersonalWebsite, lblAreaExpertise, lblStudentSupervised;
	private JButton btnExit, btnReset, btnSubmit;
	private JTextField txtStaffID, txtAcademicCode, txtName, txtPersonalWebsite;
	private JComboBox cmbOfficeLocation, cmbOfficeHours, cmbAreaExpertise, cmbStudentSupervised, cmbPosition,
			cmbEmploymentStatus;
	private JPanel centre;
	private DefaultComboBoxModel[] options = new DefaultComboBoxModel[10];
	private boolean valid;
	private int staffID, academicCode;
	// modules left out for obvious reason

	private TreeMap<Integer, _Staff> staffs;
	private TreeMap<Integer, _Academic> academics;
	private TreeMap<Integer, _Course> courses;
	private TreeMap<Integer, _Student> students;

	Add_Academic(TreeMap<Integer, _Staff> staffsIn, TreeMap<Integer, _Academic> academicsIn,
			TreeMap<Integer, _Course> coursesIn, TreeMap<Integer, _Student> studentsIn) {
		staffs = staffsIn;
		academics = academicsIn;
		courses = coursesIn;
		students = studentsIn;

		lblHeader = new JLabel("Add New Academic", JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));
		lblStaffID = new JLabel("StaffID: ", JLabel.LEFT);
		lblStaffID.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAcademicCode = new JLabel("Academic Code: ", JLabel.LEFT);
		lblAcademicCode.setFont(new Font("Calibri", Font.BOLD, 16));
		lblName = new JLabel("Name: ", JLabel.LEFT);
		lblName.setFont(new Font("Calibri", Font.BOLD, 16));
		lblAreaExpertise = new JLabel("Area Expertise: ", JLabel.LEFT);
		lblAreaExpertise.setFont(new Font("Calibri", Font.BOLD, 16));
		lblStudentSupervised = new JLabel("Student Supervised: ", JLabel.LEFT);
		lblStudentSupervised.setFont(new Font("Calibri", Font.BOLD, 16));
		lblOfficeLocation = new JLabel("Office Location: ", JLabel.LEFT);
		lblOfficeLocation.setFont(new Font("Calibri", Font.BOLD, 16));
		lblOfficeHours = new JLabel("Office Hours: ", JLabel.LEFT);
		lblOfficeHours.setFont(new Font("Calibri", Font.BOLD, 16));
		lblPosition = new JLabel("Position: ", JLabel.LEFT);
		lblPosition.setFont(new Font("Calibri", Font.BOLD, 16));
		lblEmploymentStatus = new JLabel("Employment Status: ", JLabel.LEFT);
		lblEmploymentStatus.setFont(new Font("Calibri", Font.BOLD, 16));
		lblPersonalWebsite = new JLabel("Personal Website: (Optional) ", JLabel.LEFT);
		lblPersonalWebsite.setFont(new Font("Calibri", Font.BOLD, 16));

		// JTextboxes
		txtStaffID = new JTextField(10);
		txtStaffID.setEditable(false);
		txtAcademicCode = new JTextField(10);
		txtAcademicCode.setEditable(false);
		txtName = new JTextField(10);
		txtPersonalWebsite = new JTextField(20);

		// JButtons
		btnExit = new JButton("Exit");
		btnExit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnExit.addActionListener(this);
		btnReset = new JButton("Reset");
		btnReset.setFont(new Font("Calibri", Font.BOLD, 16));
		btnReset.addActionListener(this);
		btnSubmit = new JButton("Submit");
		btnSubmit.setFont(new Font("Calibri", Font.BOLD, 16));
		btnSubmit.addActionListener(this);

		ArrayList<_Course> courseArray = new ArrayList<_Course>();
		Set<Map.Entry<Integer, _Course>> coursestored = courses.entrySet();
		for (Map.Entry<Integer, _Course> coursesStored : coursestored) {
			courseArray.add(coursesStored.getValue());
		}

		ArrayList<_Student> studentArray = new ArrayList<_Student>();
		Set<Map.Entry<Integer, _Student>> studentstored = students.entrySet();

		for (Map.Entry<Integer, _Student> studentsStored : studentstored) {
			studentArray.add(studentsStored.getValue());
		}

		// JComboBox
		options[0] = new DefaultComboBoxModel(
				new String[] { "- Select Floor - ", "Ground Floor", "1st Floor", "2nd Floor", "3rd Floor" });
		options[1] = new DefaultComboBoxModel(
				new String[] { "- Select Hours - ", "Mon - Fri, 9 - 6", "Mon - Wed, 9 - 3", "Daily, 9 - 5" });
		options[2] = new DefaultComboBoxModel(new String[] { "- Select Position - ", "Social Officer ",
				"Student Services", "Instructor", "Cleaner", "Janitor", "Security" });
		options[3] = new DefaultComboBoxModel(
				new String[] { "- Select Status - ", "Full-Time", "Part-Time", "Temorary", "Placement/Internship" });
		options[4] = new DefaultComboBoxModel(new String[] { "" });

		cmbOfficeLocation = new JComboBox(options[0]);
		cmbOfficeLocation.addActionListener(this);
		cmbOfficeHours = new JComboBox(options[1]);
		cmbOfficeHours.addActionListener(this);
		cmbPosition = new JComboBox(options[2]);
		cmbPosition.addActionListener(this);
		cmbEmploymentStatus = new JComboBox(options[3]);
		cmbEmploymentStatus.addActionListener(this);
		cmbAreaExpertise = new JComboBox(courseArray.toArray());
		cmbAreaExpertise.addActionListener(this);
		cmbStudentSupervised = new JComboBox(studentArray.toArray());
		cmbStudentSupervised.addActionListener(this);

		// autogen Staff ID
		staffID = staffs.lastEntry().getValue().getStaffID() + 1;
		txtStaffID.setText(Integer.toString(staffID));

		academicCode = academics.lastEntry().getValue().getAcademicCode() + 1;
		txtAcademicCode.setText(Integer.toString(academicCode));

		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 2, 1, 2, 1, 2, 2);
		addComp(lblStaffID, centre, 1, 2, 1, 1, 1, 1);
		addComp(txtStaffID, centre, 2, 2, 1, 1, 1, 1);
		addComp(lblAcademicCode, centre, 1, 3, 1, 1, 1, 1);
		addComp(txtAcademicCode, centre, 2, 3, 1, 1, 1, 1);
		addComp(lblName, centre, 1, 4, 1, 1, 1, 1);
		addComp(txtName, centre, 2, 4, 1, 1, 1, 1);
		addComp(lblAreaExpertise, centre, 1, 5, 1, 1, 1, 1);
		addComp(cmbAreaExpertise, centre, 2, 5, 1, 1, 1, 1);
		addComp(lblStudentSupervised, centre, 1, 6, 1, 1, 1, 1);
		addComp(cmbStudentSupervised, centre, 2, 6, 1, 1, 1, 1);
		addComp(lblOfficeLocation, centre, 1, 7, 1, 1, 1, 1);
		addComp(cmbOfficeLocation, centre, 2, 7, 1, 1, 1, 1);
		addComp(lblOfficeHours, centre, 1, 8, 1, 1, 1, 1);
		addComp(cmbOfficeHours, centre, 2, 8, 1, 1, 1, 1);
		addComp(lblPosition, centre, 1, 9, 1, 1, 1, 1);
		addComp(cmbPosition, centre, 2, 9, 1, 1, 1, 1);
		addComp(lblEmploymentStatus, centre, 1, 10, 1, 1, 1, 1);
		addComp(cmbEmploymentStatus, centre, 2, 10, 1, 1, 1, 1);
		addComp(lblPersonalWebsite, centre, 1, 11, 1, 1, 1, 1);
		addComp(txtPersonalWebsite, centre, 2, 11, 1, 1, 1, 1);
		addComp(btnExit, centre, 1, 12, 1, 1, 1, 1);
		addComp(btnReset, centre, 2, 12, 1, 1, 1, 1);
		addComp(btnSubmit, centre, 4, 12, 2, 1, 1, 1);

	}

	private void addComp(Component c, Container main, int gridX, int gridY, int width, int height, int weightX,
			int weightY) {
		GridBagConstraints gc = new GridBagConstraints(); // creates constraints object gc
		gc.fill = GridBagConstraints.BOTH;
		gc.insets = new Insets(10, 10, 10, 10);
		gc.gridx = gridX;
		gc.gridy = gridY;
		gc.gridwidth = width;
		gc.gridheight = height;
		gc.weightx = weightX;
		gc.weighty = weightY;

		getContentPane().add(c, gc); // adds components to the gridbag
	}

	public void resetForm() {
		valid = false;

		txtName.setText("");
		cmbOfficeLocation.setSelectedIndex(0);
		cmbAreaExpertise.setSelectedIndex(0);
		cmbStudentSupervised.setSelectedIndex(0);
		cmbOfficeHours.setSelectedIndex(0);
		cmbPosition.setSelectedIndex(0);
		cmbEmploymentStatus.setSelectedIndex(0);
		txtPersonalWebsite.setText("");
		// autogen Staff ID
		staffID = staffs.lastEntry().getValue().getStaffID() + 1;
		txtStaffID.setText(Integer.toString(staffID));

		academicCode = academics.lastEntry().getValue().getAcademicCode() + 1;
		txtAcademicCode.setText(Integer.toString(academicCode));

		JOptionPane.showMessageDialog(null, "Form Reset!", "Confirmation!", JOptionPane.OK_OPTION);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		if (e.getSource() == btnExit) {
			int option = JOptionPane.showConfirmDialog(null, "Are you sure you wish to Exit?", "Warning",
					JOptionPane.YES_NO_OPTION);

			if (option == JOptionPane.YES_OPTION) {
				this.setVisible(false);
			}

		}

		if (e.getSource() == btnReset) {
			resetForm();

		}

		if (e.getSource() == btnSubmit) {
			valid = true;

			_Academic newAcademic = new _Academic();

			try {
				newAcademic.setName(txtName.getText());
			} catch (_ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}

			if (valid == true) {
				newAcademic.setStaffID(Integer.parseInt(txtStaffID.getText()));
				newAcademic.setAcademicCode(Integer.parseInt(txtAcademicCode.getText()));
				newAcademic.setAreaExpertise(cmbAreaExpertise.getSelectedItem().toString());
				newAcademic.setStudentSupervised(cmbStudentSupervised.getSelectedItem().toString());
				newAcademic.setOfficeLocation(cmbOfficeLocation.getSelectedItem().toString());
				newAcademic.setOfficeHours(cmbOfficeHours.getSelectedItem().toString());
				newAcademic.setPosition(cmbPosition.getSelectedItem().toString());
				newAcademic.setEmploymentStatus(cmbEmploymentStatus.getSelectedItem().toString());
				newAcademic.setPersonalWebsite(txtPersonalWebsite.getText());
				academics.put(newAcademic.getStaffID(), newAcademic);

				JOptionPane.showMessageDialog(null, "Academic Submitted!", "Confirmation!", JOptionPane.PLAIN_MESSAGE);
				resetForm();

			} else if (valid == false) {
				JOptionPane.showMessageDialog(null, "Fill in remaining fields!", "Error!", JOptionPane.ERROR_MESSAGE);
			}

		}
	}

}
