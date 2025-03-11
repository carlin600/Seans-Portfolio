/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * Imported Libraries used for this class.
 */
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.*;
import javax.swing.*;

/**
 * This class represents the heart of the Student Management System.
 * Anything that is used within other classes pass through here first, all
 * TreeMaps and LinkedLists etc  are declared here and passed through to
 * their relevant classes.
 * 
 * @author Sean Carlin
 *
 */
public class System_Menu extends JFrame implements ActionListener {

	/**
	 * Java Swing Variable Declarations. All Components used for an aesthetic and
	 * User Friendly GUI.
	 */
	private JButton btnAdd, btnEdit, btnDelete, btnDisplay, btnStats, btnAssignments, btnSearch, btnExit;
	private JPanel centre;
	private JLabel lblHeader;
	private JPopupMenu pmAdd, pmEdit, pmDelete, pmDisplay, pmStats, pmAssignments;
	private JMenuItem miAddStudent, miAddCourse, miAddTutor, miAddAcademic, miAddStaff, miAddModule, miEditStudent,
			miEditCourse, miEditTutor, miEditAcademic, miEditStaff, miEditModule, miClassStats, miStudentStats,
			miAddAssignment, miShowAssignments, miMarkAssignments, miSearch, miPopulate, miInfo, miCodes;
	private JMenuBar jmb;
	private JMenu admin;

	/**
	 * Image Icon Declarations for use of imagery with JButtons throughout the GUI.
	 */
	private ImageIcon tutor, administrator, assignment, staff, classStats, course, delete, display, edit, exit, file,
			grade, module, options, plus, result, search, showResults, stats, student, studentStats, system, academic,
			help, populate, info;

	/**
	 * All TreeMap Declarations (Then initialized properly in their relevant
	 * classes.) One LinkedList Declaration for Statistics. If any changes were
	 * needed, make them here, e.g Class change or new TreeMap declared.
	 */
	private TreeMap<Integer, _Student> students = new TreeMap<Integer, _Student>();
	private TreeMap<Integer, _Staff> staffs = new TreeMap<Integer, _Staff>();
	private TreeMap<Integer, _Academic> academics = new TreeMap<Integer, _Academic>();
	private TreeMap<Integer, _Tutor> tutors = new TreeMap<Integer, _Tutor>();
	private TreeMap<Integer, _Course> courses = new TreeMap<Integer, _Course>();
	private TreeMap<Integer, _Module> modules = new TreeMap<Integer, _Module>();
	private TreeMap<Integer, _Assignment> assignments = new TreeMap<Integer, _Assignment>();
	private TreeMap<Integer, _MarkedAssignment> markedAssignments = new TreeMap<Integer, _MarkedAssignment>();
	private LinkedList<_Statistics> statistics = new LinkedList<_Statistics>();

	/**
	 * All File declarations and Named. Each file represents data to be written out
	 * and pulled in upon application compilation.
	 */
	File studentsFile = new File("students.dat");
	File academicsFile = new File("academics.dat");
	File tutorsFile = new File("tutors.dat");
	File coursesFile = new File("courses.dat");
	File modulesFile = new File("modules.dat");
	File staffsFile = new File("staffs.dat");
	File assignmentsFile = new File("assignments.dat");
	File resultsFile = new File("results.dat");

	/**
	 * System Menu default constructor.
	 */
	public System_Menu() {
		/**
		 * Methods created for <i>File Readers<i> to be called upon application load.
		 */
		studentsIN();
		academicsIN();
		tutorsIN();
		coursesIN();
		modulesIN();
		staffsIN();
		assignmentsIN();
		resultsIN();

		/**
		 * Image Icon Initialisation and assigned Images, included with ScaledInstance
		 * properties.
		 */
		assignment = (new ImageIcon(new ImageIcon(getClass().getResource("assignment.png")).getImage()
				.getScaledInstance(25, 25, Image.SCALE_SMOOTH)));
		academic = (new ImageIcon(new ImageIcon(getClass().getResource("academic.png")).getImage().getScaledInstance(25,
				25, Image.SCALE_SMOOTH)));
		classStats = (new ImageIcon(new ImageIcon(getClass().getResource("ClassStats.png")).getImage()
				.getScaledInstance(25, 25, Image.SCALE_SMOOTH)));
		course = (new ImageIcon(new ImageIcon(getClass().getResource("Course.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		delete = (new ImageIcon(new ImageIcon(getClass().getResource("delete.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		display = (new ImageIcon(new ImageIcon(getClass().getResource("Display.png")).getImage().getScaledInstance(25,
				25, Image.SCALE_SMOOTH)));
		edit = (new ImageIcon(new ImageIcon(getClass().getResource("edit.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		exit = (new ImageIcon(new ImageIcon(getClass().getResource("exit.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		file = (new ImageIcon(new ImageIcon(getClass().getResource("file.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		grade = (new ImageIcon(new ImageIcon(getClass().getResource("grade.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		module = (new ImageIcon(new ImageIcon(getClass().getResource("module.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		options = (new ImageIcon(new ImageIcon(getClass().getResource("options.png")).getImage().getScaledInstance(25,
				25, Image.SCALE_SMOOTH)));
		plus = (new ImageIcon(new ImageIcon(getClass().getResource("plus.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		result = (new ImageIcon(new ImageIcon(getClass().getResource("results.png")).getImage().getScaledInstance(25,
				25, Image.SCALE_SMOOTH)));
		search = (new ImageIcon(new ImageIcon(getClass().getResource("search.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		showResults = (new ImageIcon(new ImageIcon(getClass().getResource("showResults.png")).getImage()
				.getScaledInstance(25, 25, Image.SCALE_SMOOTH)));
		stats = (new ImageIcon(new ImageIcon(getClass().getResource("stats.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		student = (new ImageIcon(new ImageIcon(getClass().getResource("student.png")).getImage().getScaledInstance(25,
				25, Image.SCALE_SMOOTH)));
		studentStats = (new ImageIcon(new ImageIcon(getClass().getResource("studentStats.png")).getImage()
				.getScaledInstance(25, 25, Image.SCALE_SMOOTH)));
		system = (new ImageIcon(new ImageIcon(getClass().getResource("system.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		tutor = (new ImageIcon(new ImageIcon(getClass().getResource("Tutor.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		staff = (new ImageIcon(new ImageIcon(getClass().getResource("staff.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		administrator = (new ImageIcon(new ImageIcon(getClass().getResource("administrator.png")).getImage()
				.getScaledInstance(25, 25, Image.SCALE_SMOOTH)));
		help = (new ImageIcon(new ImageIcon(getClass().getResource("help.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));
		populate = (new ImageIcon(new ImageIcon(getClass().getResource("populate.png")).getImage().getScaledInstance(25,
				25, Image.SCALE_SMOOTH)));
		info = (new ImageIcon(new ImageIcon(getClass().getResource("info.png")).getImage().getScaledInstance(25, 25,
				Image.SCALE_SMOOTH)));

		/**
		 * JButton Initialisation and Properties. Any Button component is declared and
		 * built here. All Properties and values applied, text, text size, font etc.
		 */
		btnAdd = new JButton("Add", plus);
		btnAdd.setFont(new Font("Calibri", Font.BOLD, 20));
		btnAdd.addActionListener(this);
		btnAdd.setToolTipText("Add Section");

		btnEdit = new JButton("Edit", edit);
		btnEdit.setFont(new Font("Calibri", Font.BOLD, 20));
		btnEdit.addActionListener(this);
		btnEdit.setToolTipText("Edit Section");

		btnDelete = new JButton("Delete", delete);
		btnDelete.setFont(new Font("Calibri", Font.BOLD, 20));
		btnDelete.addActionListener(this);
		btnDelete.setToolTipText("Delete Members");

		btnDisplay = new JButton("Display", display);
		btnDisplay.setFont(new Font("Calibri", Font.BOLD, 20));
		btnDisplay.addActionListener(this);
		btnDisplay.setToolTipText("Display Members");

		btnStats = new JButton("Statistics", stats);
		btnStats.setFont(new Font("Calibri", Font.BOLD, 20));
		btnStats.addActionListener(this);
		btnStats.setToolTipText("Statistics Section");

		btnAssignments = new JButton("Assignments", result);
		btnAssignments.setFont(new Font("Calibri", Font.BOLD, 20));
		btnAssignments.addActionListener(this);
		btnAssignments.setToolTipText("Assignment Section");

		btnSearch = new JButton("Search User", search);
		btnSearch.setFont(new Font("Calibri", Font.BOLD, 20));
		btnSearch.addActionListener(this);
		btnSearch.setToolTipText("Search for a Member");

		btnExit = new JButton("Exit", exit);
		btnExit.setFont(new Font("Calibri", Font.BOLD, 20));
		btnExit.addActionListener(this);
		btnExit.setToolTipText("Exit Student Management System");

		/**
		 * JLabel Initialisation and Properties/Values.
		 */
		lblHeader = new JLabel("Please select an option.", options, JLabel.CENTER);
		lblHeader.setFont(new Font("Calibri", Font.BOLD, 20));

		/**
		 * All JPopupMenu and JMenuItem Initialisations, Properties and Values. Text, Text
		 * size, font and which menu item goes to which popup menu etc.
		 */
		/**
		 * 'Add' JPopupMenu.
		 */
		JPopupMenu pmAdd = new JPopupMenu("Add");
		JMenuItem miAddStudent = new JMenuItem("Add Student", student);
		miAddStudent.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miAddCourse = new JMenuItem("Add Course", course);
		miAddCourse.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miAddTutor = new JMenuItem("Add Tutor", tutor);
		miAddTutor.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miAddAcademic = new JMenuItem("Add Academic", academic);
		miAddAcademic.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miAddStaff = new JMenuItem("Add Staff", staff);
		miAddStaff.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miAddModule = new JMenuItem("Add Module", module);
		miAddModule.setFont(new Font("Calibri", Font.ITALIC, 18));
		pmAdd.add(miAddStudent);
		pmAdd.add(miAddStaff);
		pmAdd.add(miAddTutor);
		pmAdd.add(miAddAcademic);
		pmAdd.add(miAddModule);

		/**
		 * 'Edit' JPopupMenu.
		 */
		JPopupMenu pmEdit = new JPopupMenu("Edit");
		JMenuItem miEditStudent = new JMenuItem("Edit Student", student);
		miEditStudent.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miEditCourse = new JMenuItem("Edit Course", course);
		miEditCourse.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miEditTutor = new JMenuItem("Edit Tutor", tutor);
		miEditTutor.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miEditAcademic = new JMenuItem("Edit Academic", academic);
		miEditAcademic.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miEditStaff = new JMenuItem("Edit Staff", staff);
		miEditStaff.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miEditModule = new JMenuItem("Edit Module", module);
		miEditModule.setFont(new Font("Calibri", Font.ITALIC, 18));
		pmEdit.add(miEditStudent);
		pmEdit.add(miEditStaff);
		pmEdit.add(miEditTutor);
		pmEdit.add(miEditAcademic);
		pmEdit.add(miEditModule);

		/**
		 * 'Statistics' JPopupMenu.
		 */
		JPopupMenu pmStats = new JPopupMenu("Statistics");
		JMenuItem miClassStats = new JMenuItem("Class Statistics", stats);
		miClassStats.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miStudentStats = new JMenuItem("Student Statistics", studentStats);
		miStudentStats.setFont(new Font("Calibri", Font.ITALIC, 18));
		// pmStats.add(miClassStats);
		pmStats.add(miStudentStats);

		/**
		 * 'Assignments' JPopupMenu.
		 */
		JPopupMenu pmAssignments = new JPopupMenu("Assignments");
		JMenuItem miAddAssignment = new JMenuItem("Add Assignment", assignment);
		miAddAssignment.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miMarkAssignments = new JMenuItem("Mark Assignment", grade);
		miMarkAssignments.setFont(new Font("Calibri", Font.ITALIC, 18));
		JMenuItem miShowAssignments = new JMenuItem("Show Assignments", showResults);
		miShowAssignments.setFont(new Font("Calibri", Font.ITALIC, 18));
		pmAssignments.add(miAddAssignment);
		pmAssignments.add(miMarkAssignments);
		pmAssignments.add(miShowAssignments);

		/**
		 * JMenu Bar Initialisation. Properties and Values set. Menu Items for system
		 * functionality also initialised. (Populate and Info).
		 */
		jmb = new JMenuBar();
		admin = new JMenu("Admin");
		admin.setIcon(administrator);
		admin.setFont(new Font("Calibri", Font.BOLD, 14));

		miPopulate = new JMenuItem("Populate", populate);
		miPopulate.setFont(new Font("Calibri", Font.ITALIC, 16));
		miInfo = new JMenuItem("Help", help);
		miInfo.setFont(new Font("Calibri", Font.ITALIC, 16));
		miCodes = new JMenuItem("Codes", help);
		miCodes.setFont(new Font("Calibri", Font.ITALIC, 16));

		admin.add(miPopulate);
		admin.add(miInfo);
		admin.add(miCodes);
		jmb.add(admin);
		setJMenuBar(jmb);

		/**
		 * This section includes all ActionListenrs for the JMenuItem Buttons and
		 * JButtons. Each new form of a desired class is initialised and created here.
		 * Including properties, values and sizing of each Swing based Form.
		 */

		/**
		 * Add Button - Triggers Add JPopupMenu
		 */
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				pmAdd.show(btnAdd, btnAdd.getWidth() / 2, btnAdd.getHeight() / 2);
			}
		});
		/**
		 * Add Student Menu Item.
		 */
		miAddStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Add_Student AS = new Add_Student(students, modules, courses);
				AS.setTitle("Add Student - © Sean Carlin ");
				AS.setSize(1000, 600);
				AS.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				AS.setVisible(true);
				AS.setResizable(false);
				AS.setLocationRelativeTo(null);

			}
		});

		/*
		 * miAddCourse.addActionListener(new ActionListener () { public void
		 * actionPerformed(ActionEvent e) { Add_Course AC = new
		 * Add_Course(courses,modules); AC.setTitle("Add Course - © Sean Carlin ");
		 * AC.setSize(1000,600); AC.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		 * AC.setVisible(true); AC.setResizable(false); AC.setLocationRelativeTo(null);
		 * 
		 * } });
		 */

		/**
		 * Add Tutor Menu Item.
		 */
		miAddTutor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Add_Tutor AT = new Add_Tutor(tutors, staffs, courses, modules);
				AT.setTitle("Add Tutor - © Sean Carlin ");
				AT.setSize(1000, 600);
				AT.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				AT.setVisible(true);
				AT.setResizable(false);
				AT.setLocationRelativeTo(null);
			}
		});
		/**
		 * Add Academic Menu Item.
		 */
		miAddAcademic.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Add_Academic AA = new Add_Academic(staffs, academics, courses, students);
				AA.setTitle("Add Academic - © Sean Carlin ");
				AA.setSize(1000, 600);
				AA.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				AA.setVisible(true);
				AA.setResizable(false);
				AA.setLocationRelativeTo(null);
			}
		});
		/**
		 * Add Module Menu Item.
		 */
		miAddModule.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Add_Module AM = new Add_Module(tutors, academics, modules, courses);
				AM.setTitle("Add Module - © Sean Carlin ");
				AM.setSize(1000, 600);
				AM.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				AM.setVisible(true);
				AM.setResizable(false);
				AM.setLocationRelativeTo(null);
			}
		});
		/**
		 * Add Staff Menu Item.
		 */
		miAddStaff.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Add_Staff AS = new Add_Staff(staffs);
				AS.setTitle("Add Staff - © Sean Carlin ");
				AS.setSize(1000, 600);
				AS.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				AS.setVisible(true);
				AS.setResizable(false);
				AS.setLocationRelativeTo(null);
			}
		});

		/**
		 * Edit Button - Triggers Edit JPopupMenu
		 */
		btnEdit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				pmEdit.show(btnEdit, btnEdit.getWidth() / 2, btnAdd.getHeight() / 2);
			}
		});
		/**
		 * Edit Student Menu Item.
		 */
		miEditStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Edit_Student ES = new Edit_Student(students, modules, courses);
				ES.setTitle("Edit Student - © Sean Carlin ");
				ES.setSize(1000, 600);
				ES.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				ES.setVisible(true);
				ES.setResizable(false);
				ES.setLocationRelativeTo(null);
			}
		});
		/**
		 * Edit Course Menu Item.
		 */
		miEditCourse.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Edit_Course EC = new Edit_Course();
				EC.setTitle("Add Course - © Sean Carlin ");
				EC.setSize(1000, 600);
				EC.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				EC.setVisible(true);
				EC.setResizable(false);
				EC.setLocationRelativeTo(null);

			}
		});
		/**
		 * Edit Tutor Menu Item.
		 */
		miEditTutor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Edit_Tutor ET = new Edit_Tutor(tutors, staffs, courses, modules);
				ET.setTitle("Edit Tutor - © Sean Carlin ");
				ET.setSize(1000, 600);
				ET.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				ET.setVisible(true);
				ET.setResizable(false);
				ET.setLocationRelativeTo(null);
			}
		});
		/**
		 * Edit Academic Menu Item.
		 */
		miEditAcademic.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Edit_Academic EA = new Edit_Academic(staffs, academics, courses, students);
				EA.setTitle("Edit Academic - © Sean Carlin ");
				EA.setSize(1000, 600);
				EA.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				EA.setVisible(true);
				EA.setResizable(false);
				EA.setLocationRelativeTo(null);
			}
		});
		/**
		 * Edit Staff Menu Item.
		 */
		miEditStaff.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Edit_Staff ES = new Edit_Staff(staffs);
				ES.setTitle("Edit Staff - © Sean Carlin ");
				ES.setSize(1000, 600);
				ES.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				ES.setVisible(true);
				ES.setResizable(false);
				ES.setLocationRelativeTo(null);
			}
		});
		/**
		 * Edit Module Menu Item.
		 */
		miEditModule.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Edit_Module EM = new Edit_Module(tutors, academics, modules, courses);
				EM.setTitle("Edit Module - © Sean Carlin ");
				EM.setSize(1000, 600);
				EM.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				EM.setVisible(true);
				EM.setResizable(false);
				EM.setLocationRelativeTo(null);
			}
		});

		/**
		 * Delete Button - Opens Delete Form.
		 */
		btnDelete.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Delete Del = new Delete(courses, modules, tutors, students, academics, staffs);
				Del.setTitle("Delete Student - © Sean Carlin ");
				Del.setSize(1000, 600);
				Del.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				Del.setVisible(true);
				Del.setResizable(false);
				Del.setLocationRelativeTo(null);
			}
		});

		/**
		 * Display Button - Opens Display Form.
		 */
		btnDisplay.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Display D = new Display(courses, modules, tutors, students, academics, staffs);
				D.setTitle("Display Category - © Sean Carlin ");
				D.setSize(1000, 600);
				D.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				D.setVisible(true);
				D.setResizable(false);
				D.setLocationRelativeTo(null);
			}
		});

		/**
		 * Statistics Button - Opens Statistics JPopupMenu.
		 */
		btnStats.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				pmStats.show(btnStats, btnStats.getWidth() / 2, btnAdd.getHeight() / 2);
			}
		});

		/**
		 * Class Stats Menu Item button, opens Class Statistics Form, Discontinued
		 * during development, explanation within Report.
		 */
		/*
		 * miClassStats.addActionListener(new ActionListener () { public void
		 * actionPerformed(ActionEvent e) { Class_Stats CS = new Class_Stats();
		 * CS.setTitle("Class Statistics - © Sean Carlin "); CS.setSize(1000,600);
		 * CS.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE); CS.setVisible(true);
		 * CS.setResizable(false); CS.setLocationRelativeTo(null); } });
		 */

		/**
		 * Student Statistics Menu Item.
		 */
		miStudentStats.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Student_Stats SS = new Student_Stats(assignments, courses, modules, markedAssignments, students,
						statistics);
				SS.setTitle("Student Statistics - © Sean Carlin ");
				SS.setSize(1000, 600);
				SS.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				SS.setVisible(true);
				SS.setResizable(false);
				SS.setLocationRelativeTo(null);
			}
		});

		/**
		 * Assignment Button - Opens assignment JPopupMenu.
		 */
		btnAssignments.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				pmAssignments.show(btnAssignments, btnAssignments.getWidth() / 2, btnAdd.getHeight() / 2);
			}
		});
		/**
		 * Add Assignment Menu Item.
		 */
		miAddAssignment.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Add_Assignment AAS = new Add_Assignment(assignments, courses, modules);
				AAS.setTitle("Add Assignment - © Sean Carlin ");
				AAS.setSize(1000, 600);
				AAS.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				AAS.setVisible(true);
				AAS.setResizable(false);
				AAS.setLocationRelativeTo(null);
			}
		});
		/**
		 * Mark Assignment Menu Item.
		 */
		miMarkAssignments.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Mark_Assignment MA = new Mark_Assignment(assignments, courses, modules, markedAssignments, students);
				MA.setTitle("Add Results - © Sean Carlin ");
				MA.setSize(1000, 600);
				MA.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				MA.setVisible(true);
				MA.setResizable(false);
				MA.setLocationRelativeTo(null);
			}
		});
		/**
		 * Show Assignment Menu Item.
		 */
		miShowAssignments.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Show_Assignments SA = new Show_Assignments(assignments, modules, courses);
				SA.setTitle("Show Results - © Sean Carlin ");
				SA.setSize(1000, 600);
				SA.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				SA.setVisible(true);
				SA.setResizable(false);
				SA.setLocationRelativeTo(null);
			}
		});

		/**
		 * Populate Menu Item Button. This populates the TreeMaps so the <i>AutoGen
		 * ID's<i> work. This does not populate full data, only enough sufficient data
		 * so - functionality is there.
		 */
		miPopulate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				/**
				 * New Student
				 */
				_Student newStudent = new _Student();
				newStudent.setStudentID(5001);
				try {
					newStudent.setName("Sean Carlin");
				} catch (_ApplicantException e4) {
					// TODO Auto-generated catch block
					e4.printStackTrace();
				}
				newStudent.setYear("2nd Year");
				newStudent.setCourse("Computing");
				newStudent.setModulesTaken(null);
				newStudent.setGender("Male");
				students.put(newStudent.getStudentID(), newStudent);

				/**
				 * New Academic.
				 */
				_Academic newAcademic = new _Academic();
				try {
					newAcademic.setName("David Lyon");
				} catch (_ApplicantException e3) {
					// TODO Auto-generated catch block
					e3.printStackTrace();
				}
				newAcademic.setAcademicCode(1001);
				newAcademic.setAreaExpertise("Computing");
				newAcademic.setStudentSupervised("Sean Carlin");
				newAcademic.setStaffID(4002);
				newAcademic.setOfficeLocation("1st Floor");
				newAcademic.setOfficeHours("9-5");
				newAcademic.setPosition("Head of Year");
				newAcademic.setEmploymentStatus("Full-Time");
				newAcademic.setPersonalWebsite("None");
				academics.put(newAcademic.getStaffID(), newAcademic);

				/**
				 * New Module.
				 */
				_Module newModule = new _Module();
				newModule.setModuleCode(3001);
				try {
					newModule.setModuleName("Software Engineering");
				} catch (_ApplicantException e3) {
					// TODO Auto-generated catch block
					e3.printStackTrace();
				}
				newModule.setLeader("David Lyon");
				newModule.setModerator("Max Coyle");
				newModule.setRelatedCourse("Computing");
				modules.put(newModule.getModuleCode(), newModule);

				/**
				 * Section of New Course's.
				 */
				_Course newCourse = new _Course();
				newCourse.setCourseID(2001);
				newCourse.setCourseName("Computing");
				newCourse.setRelatedModules(null);
				courses.put(newCourse.getCourseID(), newCourse);

				_Course newCourse1 = new _Course();
				newCourse1.setCourseID(2002);
				newCourse1.setCourseName("Media");
				newCourse1.setRelatedModules(null);
				courses.put(newCourse1.getCourseID(), newCourse1);

				_Course newCourse2 = new _Course();
				newCourse2.setCourseID(2003);
				newCourse2.setCourseName("Policing");
				newCourse2.setRelatedModules(null);
				courses.put(newCourse2.getCourseID(), newCourse2);

				_Course newCourse3 = new _Course();
				newCourse3.setCourseID(2004);
				newCourse3.setCourseName("Sports Therapy");
				newCourse3.setRelatedModules(null);
				courses.put(newCourse3.getCourseID(), newCourse3);

				_Course newCourse4 = new _Course();
				newCourse4.setCourseID(2005);
				newCourse4.setCourseName("Marketing");
				newCourse4.setRelatedModules(null);
				courses.put(newCourse4.getCourseID(), newCourse4);

				_Course newCourse5 = new _Course();
				newCourse5.setCourseID(2006);
				newCourse5.setCourseName("Primary Education");
				newCourse5.setRelatedModules(null);
				courses.put(newCourse5.getCourseID(), newCourse5);

				_Course newCourse6 = new _Course();
				newCourse6.setCourseID(2007);
				newCourse6.setCourseName("Criminology");
				newCourse6.setRelatedModules(null);
				courses.put(newCourse6.getCourseID(), newCourse6);

				/**
				 * New Staff.
				 */
				_Staff newStaff = new _Staff();
				try {
					newStaff.setName("James Watson");
				} catch (_ApplicantException e2) {
					// TODO Auto-generated catch block
					e2.printStackTrace();
				}
				newStaff.setStaffID(4001);
				newStaff.setOfficeLocation("Ground Floor");
				newStaff.setOfficeHours("9-5");
				newStaff.setPosition("Cleaner");
				newStaff.setEmploymentStatus("Full-Time");
				newStaff.setPersonalWebsite("None");
				staffs.put(newStaff.getStaffID(), newStaff);

				/**
				 * New Tutor.
				 */
				_Tutor newTutor = new _Tutor();
				try {
					newTutor.setName("Max Coyle");
				} catch (_ApplicantException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
				newTutor.setStaffID(4003);
				newTutor.setTutorCode(6001);
				newTutor.setCourse("Computing");
				newTutor.setModulesTaught(null);
				newTutor.setOfficeLocation("Ground Floor");
				newTutor.setOfficeHours("9-5");
				newTutor.setPosition("Tutor");
				newTutor.setEmploymentStatus("Part-Time");
				newTutor.setPersonalWebsite("None");
				tutors.put(newTutor.getStaffID(), newTutor);

				/**
				 * New Assignment.
				 */
				_Assignment newAssignment = new _Assignment();
				try {
					newAssignment.setAssignmentName("First Assignment");
				} catch (_ApplicantException e1) {
					JOptionPane.showMessageDialog(null, "" + e1, "ERROR!", JOptionPane.ERROR_MESSAGE);
				}
				newAssignment.setAssignmentID(7001);
				newAssignment.setAssignmentCourse("Computing");
				newAssignment.setAssignmentModule("Databases");
				newAssignment.setAssignmentDesc("First Ever Assignment");
				newAssignment.setDateAssigned("18/11/2020");
				assignments.put(newAssignment.getAssignmentID(), newAssignment);

				/**
				 * New Marked Assignment.
				 */
				_MarkedAssignment newResults = new _MarkedAssignment();
				try {
					newResults.setAssignmentMark(64);
				} catch (NumberFormatException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				} catch (_ApplicantException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}

				newResults.setAssignmentID(7001);
				newResults.setResultID(8001);
				newResults.setAssignmentStudent("Sean Carlin");
				newResults.setAssignmentGrade("Excellent");
				newResults.setAssignmentFeedback("Great Work!");
				try {
					newResults.setAssignmentName("Databases");
				} catch (_ApplicantException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
				markedAssignments.put(newResults.getResultID(), newResults);

				// add in more assignments etc
				JOptionPane.showMessageDialog(null,
						"All Data Fields and TreeMaps populated for Demonstration Use."
								+ " \n NOTE - NOT ALL DATA FIELDS WILL WORK. THIS IS SOLELY FOR AUTOGEN IDENTIFIERS."
								+ " \n PLEASE ADD IN YOUR OWN TO VIEW FULL FUNCTIONALITY!",
						"Confirmation", JOptionPane.INFORMATION_MESSAGE, info);
			}
		});

		/**
		 * Info Menu Item - Displays Information window.
		 */
		miInfo.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null,
						"Welcome to the Student Management System! \nIf you need the AutoGen ID set-up, please click on the 'Populate' tab \nwithin the admin section.",
						"Information", JOptionPane.INFORMATION_MESSAGE, info);

			}
		});

		/**
		 * Codes Menu Item, displays all AutoGen codes in relevance to their
		 * Class/Value.
		 */
		miCodes.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JOptionPane.showMessageDialog(null,
						"ID Codes \n Academic - 1000 \nCourse - 2000 \nModule - 3000 \nStaff - 4000 \nStudent - 5000 \nTutor - 6000 \nResults - 7000 \nReport - 8000",
						"Information", JOptionPane.INFORMATION_MESSAGE, info);

			}
		});

		/**
		 * Search Button - Opens search form.
		 */
		btnSearch.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Search S = new Search(courses, modules, tutors, students, academics, staffs);
				S.setTitle("Search - © Sean Carlin ");
				S.setSize(1000, 600);
				S.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
				S.setVisible(true);
				S.setResizable(false);
				S.setLocationRelativeTo(null);
			}
		});

		/**
		 * JPanel Initialisation and Properties.
		 */
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		centre = new JPanel();
		centre.setLayout(new GridBagLayout());
		centre.setBackground(Color.CYAN);

		/**
		 * <b>AddComp Method Values.<b> This section is where all Swing Components and
		 * Objects are passed into the AddComp Method and placed within the <i>GridBag
		 * Layout<i>
		 */
		addComp(centre, main, 1, 1, 1, 1, 1, 1);
		addComp(lblHeader, centre, 1, 2, 2, 1, 1, 1);
		addComp(btnAdd, centre, 1, 3, 1, 1, 1, 1);
		addComp(btnEdit, centre, 1, 4, 1, 1, 1, 1);
		addComp(btnDelete, centre, 1, 5, 1, 1, 1, 1);
		addComp(btnDisplay, centre, 2, 3, 1, 1, 1, 1);
		addComp(btnAssignments, centre, 2, 4, 1, 1, 1, 1);
		addComp(btnStats, centre, 2, 5, 1, 1, 1, 1);
		addComp(btnSearch, centre, 1, 6, 2, 1, 1, 1);
		addComp(btnExit, centre, 1, 7, 2, 1, 1, 1);
	}

	/**
	 * AddComp Constructor and setter method.
	 * 
	 * @param c       the component.
	 * @param main    the container.
	 * @param gridX   the X axis.
	 * @param gridY   the Y axis.
	 * @param width   the component width.
	 * @param height  the component height.
	 * @param weightX the X axis weight.
	 * @param weightY the Y axis height.
	 */
	private void addComp(Component c, Container main, int gridX, int gridY, int width, int height, int weightX,
			int weightY) {
		GridBagConstraints gc = new GridBagConstraints(); // creates constraints object gc
		gc.fill = GridBagConstraints.BOTH;
		gc.insets = new Insets(8, 8, 8, 8);
		gc.gridx = gridX;
		gc.gridy = gridY;
		gc.gridwidth = width;
		gc.gridheight = height;
		gc.weightx = weightX;
		gc.weighty = weightY;

		getContentPane().add(c, gc); // adds components to the gridbag
	}

	/**
	 * StudentsIn Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void studentsIN() {

		try {
			FileInputStream fis = new FileInputStream(studentsFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			students = (TreeMap<Integer, _Student>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Student Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Student File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Student File!", "Error!",
					JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * StudentsOUT Method. Within this method, data is written to the specified
	 * '.dat' File which stores the data for the next compilation.
	 */
	private void studentsOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(studentsFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(students);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Student File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Student Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * tutorsIn Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void tutorsIN() {

		try {
			FileInputStream fis = new FileInputStream(tutorsFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			tutors = (TreeMap<Integer, _Tutor>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Tutor Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Tutor File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Tutor File!", "Error!", JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * tutorsOUT Method. Within this method, data is written to the specified '.dat'
	 * File which stores the data for the next compilation.
	 */
	private void tutorsOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(tutorsFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(tutors);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Tutor File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Tutor Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * academicsIN Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void academicsIN() {

		try {
			FileInputStream fis = new FileInputStream(academicsFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			academics = (TreeMap<Integer, _Academic>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Academic Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Academic File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Academic File!", "Error!",
					JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * academicsOUT Method. Within this method, data is written to the specified
	 * '.dat' File which stores the data for the next compilation.
	 */
	private void academicsOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(academicsFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(academics);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Academic File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Academic Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * modulesIN Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void modulesIN() {

		try {
			FileInputStream fis = new FileInputStream(modulesFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			modules = (TreeMap<Integer, _Module>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Module Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Module File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Module File!", "Error!",
					JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * modulesOUT Method. Within this method, data is written to the specified
	 * '.dat' File which stores the data for the next compilation.
	 */
	private void modulesOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(modulesFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(modules);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Module File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Module Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * coursesIN Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void coursesIN() {

		try {
			FileInputStream fis = new FileInputStream(coursesFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			courses = (TreeMap<Integer, _Course>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Course Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Course File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Course File!", "Error!",
					JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * coursesOUT Method. Within this method, data is written to the specified
	 * '.dat' File which stores the data for the next compilation.
	 */
	private void coursesOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(coursesFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(courses);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Course File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Course Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * staffsIN Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void staffsIN() {

		try {
			FileInputStream fis = new FileInputStream(staffsFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			staffs = (TreeMap<Integer, _Staff>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Staff Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Staff File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Staff File!", "Error!", JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * staffsOUT Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void staffsOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(staffsFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(staffs);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Staff File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Staff Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * assignmentsIN Method. Within this method, data is pulled in from the
	 * specified '.dat' File to its Class that called the method.
	 */
	private void assignmentsIN() {

		try {
			FileInputStream fis = new FileInputStream(assignmentsFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			assignments = (TreeMap<Integer, _Assignment>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Assignment Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Assignment File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Assignment File!", "Error!",
					JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * assignmentsOUT Method. Within this method, data is pulled in from the
	 * specified '.dat' File to its Class that called the method.
	 */
	private void assignmentsOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(assignmentsFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(assignments);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Assignment File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Assignment Data!", "Error!",
					JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * resultsIN Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void resultsIN() {

		try {
			FileInputStream fis = new FileInputStream(resultsFile);
			ObjectInputStream ois = new ObjectInputStream(fis);
			markedAssignments = (TreeMap<Integer, _MarkedAssignment>) ois.readObject();
			ois.close();
			fis.close();
		} catch (ClassNotFoundException cEx) {
			JOptionPane.showMessageDialog(null, "Failed To Read Results Data!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "No Results File Found!", "Error!", JOptionPane.ERROR_MESSAGE);

		} catch (IOException ioEx) {
			JOptionPane.showMessageDialog(null, "Could Not Read From Results File!", "Error!",
					JOptionPane.ERROR_MESSAGE);

		}
	}

	/**
	 * resultsOUT Method. Within this method, data is pulled in from the specified
	 * '.dat' File to its Class that called the method.
	 */
	private void resultsOUT() {
		try {
			FileOutputStream fos = new FileOutputStream(resultsFile);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(markedAssignments);
			oos.close();
			fos.close();
		} catch (FileNotFoundException fEx) {
			JOptionPane.showMessageDialog(null, "Results File Not Found!", "Error!", JOptionPane.ERROR_MESSAGE);
		} catch (IOException ioEX) {
			JOptionPane.showMessageDialog(null, "Failed to Output Results Data!", "Error!", JOptionPane.ERROR_MESSAGE);
		}
	}

	/**
	 * JButton ActionEvents/ActionPerformed properties.
	 */
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

		/**
		 * Exit Button actionPerformed. Prompts user with a reassuring exit message. If
		 * yes selected, all write out to file methods are called.
		 */
		if (e.getSource() == btnExit) {
			// may need more code here to write out to file
			int option = JOptionPane.showConfirmDialog(null, "Are you sure you wish to Exit?", "Warning",
					JOptionPane.YES_NO_OPTION);

			if (option == JOptionPane.YES_OPTION) {
				studentsOUT();
				academicsOUT();
				tutorsOUT();
				coursesOUT();
				modulesOUT();
				staffsOUT();
				assignmentsOUT();
				resultsOUT();

				System.exit(0);
			}

		}

	}

}
