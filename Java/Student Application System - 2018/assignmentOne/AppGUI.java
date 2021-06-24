package assignmentOne;

import java.awt.Color;
import java.awt.Component;
import java.awt.Container;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Image;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.time.LocalDate;

import javax.swing.*;
import general.My;

public class AppGUI extends JFrame implements ActionListener {

	// declare components
	//Others
	private JLabel lblHeader,lblGrade,lblDetails,  lblAmount, lblPlacesLeft, lblDisImage, lblDisImage2,  lblBLANK, lblBLANK2,lblBLANK3;
	private JButton btnExit;
	private JTextField txtAmount, txtPlaces;
	
	//add
	private JLabel  lblName, lblTelNo, lblEmail, lblDOA, lblExamBoard,  lblGrades, lblUCAS;
	private JButton btnAddApp, btnAddQual, btnAddNew, btnSubmit, btnReset;
	private JTextField txtName, txtDOA, txtTelNo, txtEmail, txtUCAS, txtGrades;
	private JTextArea taAddDisplay;
	
	//edit
	private JLabel lblEdit;
	private JButton btnEditQual,  btnEditApp, btnEditFind, btnEdit, btnEditCancel, btnUpdate;
	private JTextField txtEditFind;
	private JTextArea taEditDisplay, taEditDisplay2;
	//delete
	private JLabel   lblDelete;
	private JButton  btnDeleteFind, btnDelApp, btnDel, btnDeleteCancel;
	private JTextField txtDeleteFind;
	private JTextArea taDeleteDisplay, taDeleteDisplay2;
	
	//display
	private JButton btnDisApp;
	private JTextArea taDisDisplay;
	
	//allocate
	private JLabel lblAllInfo, lblPlacesAvail;
	private JButton btnAllocateApp, btnAllocate, btnEnter;
	private JTextField txtAllocatePlaces;
	private JTextArea taAllocateDisplay, taAllocateDisplay2;
	 
//--------Navigational items & Layout managers
	//Menu Items & Taskbar.
	private JMenuBar mbTaskbar;
	private JMenu mMenu;
	private JMenuItem miExit, miHelp, miInfo;
	private AppInfo AppInfo;
	
	//Combo Boxes
	private JComboBox cmbExamBoard, cmbGrade;
	private DefaultComboBoxModel[] models = new DefaultComboBoxModel[8];
	
	//Panel Declarations
	private JPanel top, left, add, edit, delete, display, allocate, images, bottom;
	//Image Declarations
	private ImageIcon nwrc, applicationLogo, equivalent, exit, help, info;

	//Integer Variables/Declarations
	private int totalPoints, tempPoints, appAmount;
	private boolean valid;
	private static int countApplicants = 0;
	private static int gradesEntered = 0;
	private static int placesLeft = 0;


	//Declaring the queue classes variable name
	ApplicantQueue applicants = new ApplicantQueue();

	
	//Graphical User Interface properties
	public AppGUI() {

	
		
		// image properties - i set the set size and properties of the images i am using up here, so i can just call them by name -
		//when inserting them to objects.
		nwrc = (new ImageIcon(new ImageIcon(getClass().getResource("nwrc.jpg")).getImage().getScaledInstance(300, 250, Image.SCALE_SMOOTH)));
		applicationLogo = (new ImageIcon(new ImageIcon(getClass().getResource("applicationLogo.png")).getImage().getScaledInstance(300, 250, Image.SCALE_SMOOTH)));
		equivalent = (new ImageIcon(new ImageIcon(getClass().getResource("equiv.jpg")).getImage().getScaledInstance(800, 250, Image.SCALE_SMOOTH)));
		exit = (new ImageIcon(new ImageIcon(getClass().getResource("exit.png")).getImage().getScaledInstance(15, 15,Image.SCALE_SMOOTH)));
		help = (new ImageIcon(new ImageIcon(getClass().getResource("help.png")).getImage().getScaledInstance(15, 15,Image.SCALE_SMOOTH)));
		info = (new ImageIcon(new ImageIcon(getClass().getResource("info.png")).getImage().getScaledInstance(15, 15,Image.SCALE_SMOOTH)));

		
		// menu bar properties & variables
		mbTaskbar = new JMenuBar();
		mMenu = new JMenu("Menu");
		miExit = new JMenuItem("Exit", exit);
		miHelp = new JMenuItem("Help", help);
		miInfo = new JMenuItem("Info", info);
		mMenu.add(miInfo);
		mMenu.add(miHelp);
		mMenu.add(miExit);
		mbTaskbar.add(mMenu);
		setJMenuBar(mbTaskbar);
		
		AppInfo = new AppInfo();
		AppInfo.setTitle("Information");
		AppInfo.setSize(800,600);
		AppInfo.setVisible(false);

		//enables the menu items to be used 
		miHelp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				JOptionPane.showMessageDialog(null,
						"Here is a table showing you what the Grades are equivalent to from the chosen Exam Board.",
						"Help", JOptionPane.INFORMATION_MESSAGE, equivalent);
			}

		});
		
		miInfo.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
					AppInfo.setVisible(true);
			}

		});
		
		miExit.addActionListener(new ActionListener() {
			// anonymous inner class

			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});

	

		// JPanel Properties & Values are set here.
		Container main = getContentPane();
		main.setLayout(new GridBagLayout());
		main.setBackground(Color.CYAN);

		top = new JPanel();
		top.setLayout(new GridBagLayout());
		top.setBackground(Color.CYAN);

		left = new JPanel();
		left.setLayout(new GridBagLayout());
		left.setBackground(Color.CYAN);

		add = new JPanel(); // add panel
		add.setLayout(new GridBagLayout());
		add.setBackground(Color.CYAN);
		add.setVisible(false);

		delete = new JPanel(); // add panel
		delete.setLayout(new GridBagLayout());
		delete.setBackground(Color.CYAN);
		delete.setVisible(false);

		edit = new JPanel(); // add panel
		edit.setLayout(new GridBagLayout());
		edit.setBackground(Color.CYAN);
		edit.setVisible(false);

		images = new JPanel();
		images.setLayout(new GridBagLayout());
		images.setBackground(Color.CYAN);
		images.setVisible(true);

		display = new JPanel();
		display.setLayout(new GridBagLayout());
		display.setBackground(Color.CYAN);
		display.setVisible(false);

		allocate = new JPanel();
		allocate.setLayout(new GridBagLayout());
		allocate.setBackground(Color.CYAN);
		allocate.setVisible(false);

		bottom = new JPanel();
		bottom.setLayout(new GridBagLayout());
		bottom.setBackground(Color.CYAN);

		// Combo-boxes - These are what set the values to the tabs within the combo boxes, 
		//where it is much easier for the user to select their exam board & grade.
		// Properties & Values for combo boxes are set here
		models[0] = new DefaultComboBoxModel(new String[] { " - Select Exam Board - ", "A-Level", "AS-Level", "Irish Leaving Certificate","BTEC Subsidiary", "BTEC Diploma", "BTEC Extended Diploma" });
		models[1] = new DefaultComboBoxModel(new String[] { " - Select Grade - ", "A*", "A", "B", "C", "D", "E" });
		models[2] = new DefaultComboBoxModel(new String[] { " - Select Grade - ", "A", "B", "C", "D", "E" });
		models[3] = new DefaultComboBoxModel(new String[] { " - Select Grade - ", "H1", "H2", "H3", "H4", "H5", "H6", "O1", "O2", "O3", "O4"});
		models[4] = new DefaultComboBoxModel(new String[] {" - Select Grade - ", "D*", "D", "M", "P"  });
		models[5] = new DefaultComboBoxModel(new String[] {" - Select Grade - ", "D*", "D", "M", "P"});
		models[6] = new DefaultComboBoxModel(new String[] {" - Select Grade - ", "D*", "D", "M", "P"});
		models[7] = new DefaultComboBoxModel(new String[] { " - Select Qualification Type - " });

		//Setting the default models for the combo boxes before the user selects their own.
		cmbExamBoard = new JComboBox();
		cmbExamBoard.setModel(models[0]);
		cmbExamBoard.addActionListener(this);
		cmbGrade = new JComboBox();
		cmbGrade.setModel(models[5]);
		cmbGrade.addActionListener(this);
	
		
		
		
		//JLabels
		//Add Section
		lblName = new JLabel("Full Name", JLabel.RIGHT);
		lblName.setFont(new Font("Corbel", Font.BOLD, 18));
		lblTelNo = new JLabel("Telephone Number (+44)", JLabel.RIGHT);
		lblTelNo.setFont(new Font("Corbel", Font.BOLD, 18));
		lblEmail = new JLabel("Email", JLabel.RIGHT);
		lblEmail.setFont(new Font("Corbel", Font.BOLD, 18));
		lblDOA = new JLabel("Date Of Application", JLabel.RIGHT);
		lblDOA.setFont(new Font("Corbel", Font.BOLD, 18));
		lblExamBoard = new JLabel("Exam Board", JLabel.RIGHT);
		lblExamBoard.setFont(new Font("Corbel", Font.BOLD, 18));
		lblGrade = new JLabel("Grade", JLabel.RIGHT);
		lblGrade.setFont(new Font("Corbel", Font.BOLD, 18));
		lblGrades = new JLabel("# Of Grades Added", JLabel.CENTER);
		lblGrades.setFont(new Font("Corbel", Font.BOLD, 18));
		lblUCAS = new JLabel("UCAS Points", JLabel.CENTER);
		lblUCAS.setFont(new Font("Corbel", Font.BOLD, 18));
		
		//Edit Section
		lblEdit = new JLabel("Please enter the EMAIL of the student you wish to select from the list. ", JLabel.CENTER);
		lblEdit.setFont(new Font("Corbel", Font.BOLD, 18));
		
		//Delete Section
		lblDelete = new JLabel("Please enter the EMAIL of the student you wish to select from the list. ",
				JLabel.CENTER);
		lblDelete.setFont(new Font("Corbel", Font.BOLD, 18));
		//Allocate Section
		lblAllInfo = new JLabel("Allocate Applicable Students", JLabel.RIGHT);
		lblAllInfo.setFont(new Font("Corbel", Font.BOLD, 18));
		lblPlacesAvail = new JLabel("Places left:", JLabel.RIGHT);
		lblPlacesAvail.setFont(new Font("Corbel", Font.BOLD, 18));
		lblPlacesLeft = new JLabel("Enter Available Places:", JLabel.RIGHT);
		lblPlacesLeft.setFont(new Font("Corbel", Font.BOLD, 18));
		
		
		//Other Areas
		lblHeader = new JLabel("Foundation Degree Applications", JLabel.CENTER);
		lblHeader.setFont(new Font("Corbel", Font.BOLD, 20));
		lblDetails = new JLabel("Please select an Option. ", JLabel.CENTER);
		lblDetails.setFont(new Font("Corbel", Font.BOLD + Font.ITALIC, 22));
		lblDisImage = new JLabel("", JLabel.CENTER);
		lblDisImage.setIcon(nwrc);
		lblDisImage2 = new JLabel("", JLabel.CENTER);
		lblDisImage2.setIcon(applicationLogo);
		lblAmount = new JLabel("Applications left: ", JLabel.RIGHT);
		lblAmount.setFont(new Font("Corbel", Font.BOLD, 18));
		
		lblBLANK = new JLabel("                    ", JLabel.CENTER);
		lblBLANK.setFont(new Font("Corbel", Font.BOLD, 18));
		lblBLANK2 = new JLabel("                    ", JLabel.CENTER);
		lblBLANK2.setFont(new Font("Corbel", Font.BOLD, 18));
		lblBLANK3 = new JLabel("                    ", JLabel.CENTER);
		lblBLANK3.setFont(new Font("Corbel", Font.BOLD, 18));

		//JText area Properties & Values
		taAddDisplay = new JTextArea(15, 15);
		taAddDisplay.setEditable(false);
		taAddDisplay.setEnabled(false);
		taAddDisplay.setFont(new Font("Courier New", Font.PLAIN, 14));
		taDisDisplay = new JTextArea(30, 30);
		taDisDisplay.setEditable(false);
		taDisDisplay.setEnabled(false);
		taDisDisplay.setFont(new Font("Courier New", Font.PLAIN, 14));
		taEditDisplay = new JTextArea(10, 10);
		taEditDisplay.setEditable(false);
		taEditDisplay.setFont(new Font("Courier New", Font.PLAIN, 14));
		taEditDisplay2 = new JTextArea(10, 10);
		taEditDisplay2.setEditable(false);
		taEditDisplay2.setFont(new Font("Courier New", Font.PLAIN, 14));
		taDeleteDisplay = new JTextArea(10, 10);
		taDeleteDisplay.setEditable(false);
		taDeleteDisplay.setFont(new Font("Courier New", Font.PLAIN, 14));
		taDeleteDisplay2 = new JTextArea(10, 10);
		taDeleteDisplay2.setEditable(false);
		taDeleteDisplay2.setFont(new Font("Courier New", Font.PLAIN, 14));
		taAllocateDisplay = new JTextArea(10, 10);
		taAllocateDisplay.setEditable(false);
		taAllocateDisplay.setFont(new Font("Courier New", Font.PLAIN, 14));
		taAllocateDisplay2 = new JTextArea(10, 10);
		taAllocateDisplay2.setEditable(false);
		taAllocateDisplay2.setFont(new Font("Courier New", Font.PLAIN, 14));

		//Text field Properties & Values
		txtName = new JTextField(10);
		txtDOA = new JTextField(10);
		txtDOA.setEditable(false);
		txtTelNo = new JTextField(10);
		txtEmail = new JTextField(20);
		txtUCAS = new JTextField(5);
		txtUCAS.setEditable(false);
		txtAmount = new JTextField(5);
		txtAmount.setEditable(false);
		txtAmount.setHorizontalAlignment(JTextField.CENTER);
		txtPlaces = new JTextField(5);
		txtPlaces.setText("Awaiting Input");
		txtPlaces.setEditable(false);
		txtPlaces.setHorizontalAlignment(JTextField.CENTER);
		txtAllocatePlaces = new JTextField(5);
		txtAllocatePlaces.setHorizontalAlignment(JTextField.CENTER);
		txtGrades = new JTextField(5);
		txtGrades.setEditable(false);
		txtGrades.setHorizontalAlignment(JTextField.CENTER);
		txtEditFind = new JTextField(20);
		txtDeleteFind = new JTextField(20);

		//JButtons - this is where each button is given its properties and displayed Text,
		//along with the properties for the text e.g font and size.
		//Add Section
		btnAddApp = new JButton("Add Applicant");
		btnAddApp.setFont(new Font("Corbel", Font.BOLD, 16));
		btnAddApp.addActionListener(this);
		btnAddQual = new JButton("Add Another Qualification");
		btnAddQual.setFont(new Font("Corbel", Font.BOLD, 16));
		btnAddQual.addActionListener(this);
		btnEditQual = new JButton("Edit Qualifications");
		btnEditQual.setFont(new Font("Corbel", Font.BOLD, 16));
		btnEditQual.addActionListener(this);		
		btnAddNew = new JButton("Add New Applicant");
		btnAddNew.setFont(new Font("Corbel", Font.BOLD, 16));
		btnAddNew.addActionListener(this);
		btnAddNew.setVisible(false);
		btnSubmit = new JButton("Submit Application");
		btnSubmit.setFont(new Font("Corbel", Font.BOLD, 16));
		btnSubmit.addActionListener(this);
		btnReset = new JButton("Reset Application");
		btnReset.setFont(new Font("Corbel", Font.BOLD, 16));
		btnReset.addActionListener(this);

		//Edit Section
		btnEditApp = new JButton("Edit Applicant");
		btnEditApp.setFont(new Font("Corbel", Font.BOLD, 16));
		btnEditApp.addActionListener(this);
		btnUpdate = new JButton("Update Student");
		btnUpdate.setFont(new Font("Corbel", Font.BOLD, 16));
		btnUpdate.addActionListener(this);
		btnEditFind = new JButton("Find");
		btnEditFind.setFont(new Font("Corbel", Font.BOLD, 16));
		btnEditFind.addActionListener(this);
		btnEdit = new JButton("Edit");
		btnEdit.setFont(new Font("Corbel", Font.BOLD, 16));
		btnEdit.addActionListener(this);
		btnEditCancel = new JButton("Cancel");
		btnEditCancel.setFont(new Font("Corbel", Font.BOLD, 16));
		btnEditCancel.addActionListener(this);

		//Delete Section
		btnDelApp = new JButton("Delete Applicant");
		btnDelApp.setFont(new Font("Corbel", Font.BOLD, 16));
		btnDelApp.addActionListener(this);
		btnDeleteFind = new JButton("Find");
		btnDeleteFind.setFont(new Font("Corbel", Font.BOLD, 16));
		btnDeleteFind.addActionListener(this);
		btnDel = new JButton("Delete Student");
		btnDel.setFont(new Font("Corbel", Font.BOLD, 16));
		btnDel.addActionListener(this);
		btnDeleteCancel = new JButton("Cancel");
		btnDeleteCancel.setFont(new Font("Corbel", Font.BOLD, 16));
		btnDeleteCancel.addActionListener(this);

		//Display Section
		btnDisApp = new JButton("Display Applicant");
		btnDisApp.setFont(new Font("Corbel", Font.BOLD, 16));
		btnDisApp.addActionListener(this);
		
		//Allocate Section
		btnAllocateApp = new JButton("Allocate Students");
		btnAllocateApp.setFont(new Font("Corbel", Font.BOLD, 16));
		btnAllocateApp.addActionListener(this);
		btnAllocate = new JButton("Allocate");
		btnAllocate.setFont(new Font("Corbel", Font.BOLD, 16));
		btnAllocate.addActionListener(this);
		btnAllocate.setEnabled(false);
		btnEnter = new JButton("Enter");
		btnEnter.setFont(new Font("Corbel", Font.BOLD, 16));
		btnEnter.addActionListener(this);
		
		//Other
		btnExit = new JButton("Exit Program");
		btnExit.setFont(new Font("Corbel", Font.BOLD, 16));
		btnExit.addActionListener(this);
		
		//You can edit the applications limit here. ~Sc
		//Sets the maximum amount of applications that can be entered.
		appAmount = 20;
		txtAmount.setText("" + appAmount);
		
		

		// ADDCOMPS - This is where all components in the program are set to their grid value and added to - 
		//the panel they belong to.
		
		//Main Panels
		addComp(top, main, 0, 0, 5, 1, 1, 1);
		addComp(images, main, 3, 1, 2, 1, 1, 1);
		addComp(allocate, main, 3, 1, 2, 1, 1, 1);
		addComp(edit, main, 3, 1, 2, 1, 1, 1);
		addComp(delete, main, 3, 1, 2, 1, 1, 1);
		addComp(display, main, 3, 1, 2, 1, 1, 1);
		addComp(left, main, 1, 1, 2, 1, 1, 1);
		addComp(add, main, 3, 1, 2, 1, 1, 1);
		addComp(bottom, main, 0, 2, 5, 1, 1, 1);

		//Top Section
		addComp(lblHeader, top, 1, 1, 1, 1, 1, 1);
		addComp(lblBLANK, top, 1, 2, 1, 1, 1, 1);
		addComp(lblAmount, top, 2, 1, 1, 1, 1, 1);
		addComp(txtAmount, top, 3, 1, 1, 1, 1, 1);
		addComp(lblPlacesAvail, top, 2, 2, 1, 1, 1, 1);
		addComp(txtPlaces, top, 3, 2, 1, 1, 1, 1);
		addComp(lblDetails, top, 1, 4, 0, 0, 0, 0);

		//Left Section (Overall Panel Selection)
		addComp(btnAddApp, left, 2, 2, 1, 1, 1, 1);
		addComp(btnEditApp, left, 2, 3, 1, 1, 1, 1);
		addComp(btnDelApp, left, 2, 4, 1, 1, 1, 1);
		addComp(btnDisApp, left, 2, 5, 1, 1, 1, 1);
		addComp(btnAllocateApp, left, 2, 6, 1, 1, 1, 1);

		//Add Section
		addComp(lblName, add, 2, 2, 1, 1, 1, 1);
		addComp(txtName, add, 3, 2, 1, 1, 1, 1);
		addComp(lblDOA, add, 2, 3, 1, 1, 1, 1);
		addComp(txtDOA, add, 3, 3, 1, 1, 1, 1);
		addComp(taAddDisplay, add, 4, 1, 5, 5, 10, 2);
		addComp(lblTelNo, add, 2, 4, 1, 1, 1, 1);
		addComp(txtTelNo, add, 3, 4, 1, 1, 1, 1);
		addComp(lblEmail, add, 2, 5, 1, 1, 1, 1);
		addComp(txtEmail, add, 3, 5, 1, 1, 1, 1);
		addComp(lblExamBoard, add, 2, 6, 1, 1, 1, 1);
		addComp(cmbExamBoard, add, 3, 6, 1, 1, 1, 1);
		addComp(lblGrade, add, 2, 7, 1, 1, 1, 1);
		addComp(cmbGrade, add, 3, 7, 1, 1, 1, 1);
		addComp(lblUCAS, add, 2, 8, 1, 1, 1, 1);
		addComp(txtUCAS, add, 3, 8, 1, 1, 1, 1);
		addComp(lblGrades, add, 4, 7, 1, 1, 1, 1);
		addComp(txtGrades, add, 4, 8, 1, 1, 1, 1);
		addComp(btnAddQual, add, 2, 9, 2, 1, 1, 1);
		addComp(btnEditQual, add, 2, 9, 2, 1, 1, 1);
		addComp(btnReset, add, 2, 10, 1, 1, 1, 1);
		addComp(btnSubmit, add, 3, 10, 1, 1, 1, 1);
		addComp(btnUpdate, add, 2, 10, 2, 1, 1, 1);
		addComp(btnAddNew, add, 2, 10, 2, 1, 1, 1);
		
		//Display
		addComp(taDisDisplay, display, 2, 1, 30, 30, 5, 5);
		
		//Edit Section
		addComp(lblEdit, edit, 2, 1, 1, 1, 0, 0);
		addComp(txtEditFind, edit, 2, 2, 1, 1, 0, 0);
		addComp(btnEditFind, edit, 2, 3, 1, 1, 0, 0);
		addComp(btnEdit, edit, 2, 3, 1, 1, 0, 0);
		addComp(btnEditCancel, edit, 2, 4, 1, 1, 0, 0);
		addComp(taEditDisplay, edit, 3, 1, 10, 10, 1, 1);
		addComp(lblBLANK2, edit, 3, 3, 1, 1, 1, 1);
		addComp(taEditDisplay2, edit, 3, 5, 10, 10, 1, 1);
	
		//Delete Section
		addComp(lblDelete, delete, 2, 1, 1, 1, 0, 0);
		addComp(txtDeleteFind, delete, 2, 2, 1, 1, 0, 0);
		addComp(btnDeleteFind, delete, 2, 3, 1, 1, 0, 0);
		addComp(btnDel, delete, 2, 3, 1, 1, 0, 0);
		addComp(btnDeleteCancel, delete, 2, 4, 1, 1, 0, 0);
		addComp(taDeleteDisplay, delete, 3, 1, 10, 10, 1, 1);
		addComp(lblBLANK, delete, 3, 3, 1, 1, 1, 1);
		addComp(taDeleteDisplay2, delete, 3, 5, 10, 10, 1, 1);
		
		//Images
		addComp(lblDisImage, images, 2, 2, 1, 1, 1, 1);
		addComp(lblDisImage2, images, 3, 2, 1, 1, 1, 1);
		
		//Allocate Section
		addComp(txtAllocatePlaces, allocate,3,1,1,1,1,1);
		addComp(lblPlacesLeft, allocate,2,1,1,1,1,1);
		addComp(btnEnter, allocate,3,2,2,1,1,1);
		addComp(lblAllInfo, allocate,2,4,1,1,1,1);
		addComp(btnAllocate, allocate,3,4,1,1,1,1);
		addComp(taAllocateDisplay, allocate, 4, 1, 10, 10, 1, 1);
		addComp(lblBLANK3, delete, 4, 3, 1, 1, 1, 1);
		addComp(taAllocateDisplay2, allocate, 4, 5, 10, 10, 1, 1);
		
		//Bottom Section
		addComp(btnExit, bottom, 1, 3, 1, 1, 1, 1);

	

	}

	//This method is what controls the inputted values from the addComp commands above^
	private void addComp(Component c, Container main, int gridX, int gridY, int width, int height, int weightX,
			int weightY) { // here is GC V
		GridBagConstraints gc = new GridBagConstraints(); // creates constraints object gc
		gc.fill = GridBagConstraints.BOTH; // two constraints that are the same for all components
		gc.insets = new Insets(5, 5, 5, 5); // adds constraints to constraints object gc
		gc.gridx = gridX; //
		gc.gridy = gridY; //
		gc.gridwidth = width; //
		gc.gridheight = height; //
		gc.weightx = weightX; //
		gc.weighty = weightY; //

		main.add(c, gc); // adds components to the GridBag

	}

	//Disables everything within the Add Section
	private void addDisable()
	{
		txtName.setEditable(false);
	txtDOA.setEditable(false);
	txtTelNo.setEditable(false);
	txtEmail.setEditable(false);
	txtUCAS.setEditable(false);
	txtGrades.setEditable(false);
		btnSubmit.setVisible(false);
		btnReset.setVisible(false);
		btnAddNew.setVisible(true);
		btnAddQual.setEnabled(false);
		cmbExamBoard.setEnabled(false);
		cmbGrade.setEnabled(false);
	}
	
	//Enables everything within the Add Section
	private void addEnable()
	{
		lblDetails.setText("Application Form Reset!");
		images.setVisible(false);
		display.setVisible(false);
		txtName.setText("");
		txtDOA.setText("");
		txtTelNo.setText("");
		txtEmail.setText("");
		txtUCAS.setText("0");
		txtGrades.setText("");
		txtName.setEditable(true);
		txtDOA.setEditable(true);
		txtTelNo.setEditable(true);
		txtEmail.setEditable(true);
		txtUCAS.setEditable(false);
		txtGrades.setEditable(true);
		btnUpdate.setVisible(false);
		btnAddQual.setEnabled(true);
		btnSubmit.setVisible(true);
		btnReset.setVisible(true);
		btnAddNew.setVisible(false);
		add.setVisible(true);
		edit.setVisible(false);
		delete.setVisible(false);
		allocate.setVisible(false);
		tempPoints = 0;
		totalPoints = 0;
		gradesEntered = 0;
		txtDOA.setText(LocalDate.now().toString());
		cmbExamBoard.setEnabled(true);
		cmbGrade.setEnabled(true);
		cmbExamBoard.setSelectedIndex(0);
		cmbGrade.setModel(models[7]);

}
	//Disables everything within the Edit Section
	private void editDisable()
	{
		
	}
	
	//Enables everything within the Add Section
	private void editEnable()
	{
		allocate.setVisible(false);
		images.setVisible(false);
		display.setVisible(false);
		add.setVisible(false);
		delete.setVisible(false);
		edit.setVisible(true);
		txtEditFind.setText("");
		taEditDisplay.setText("");
		btnUpdate.setVisible(false);
		btnEditQual.setVisible(false);

		btnEdit.setVisible(false);
		btnEditFind.setVisible(true);
	}
	
	//Disables everything within the Delete Section
	private void delDisable()
	{
		
	}
	//Enables everything within the Delete Section
	private void delEnable()
	{
		taDeleteDisplay.setText("");
	
		btnDeleteFind.setVisible(true);
		btnDel.setVisible(false);

		
	}
	
	//Enables everything within the Allocate Section
	private void allEnable()
	{
		allocate.setVisible(true);
		display.setVisible(false);
		images.setVisible(false);
		add.setVisible(false);
		delete.setVisible(false);
		edit.setVisible(false);
	}
	//Disables everything within the Allocate Section
	private void allDisable()
	{
		
	}

	//This section contains the methods for each button used within the program
	@Override
	public void actionPerformed(ActionEvent e) {

		if (e.getSource() == btnExit)

			System.exit(0);

		// Add -----------------------------
		if (e.getSource() == btnAddApp) {

			
			taAddDisplay.setText("" + applicants.display());
			addEnable();
			lblDetails.setText("Add a New Applicant");

		}
		if (e.getSource() == btnAddQual) {

			tempPoints = Integer.parseInt(txtUCAS.getText()); 
			totalPoints = tempPoints + totalPoints;
			cmbExamBoard.setSelectedIndex(0);
			cmbGrade.setModel(models[7]);
			txtUCAS.setText("0");

			lblDetails.setText("You may add another Qualification");

			gradesEntered++;
			txtGrades.setText("" + gradesEntered);

		}

		if (e.getSource() == btnAddNew) {
			addEnable();
			lblDetails.setText("Add a New Applicant");

		}
		
		if (e.getSource() == btnSubmit) {
			DegreeApp newApp = new DegreeApp();
			valid = true;
			
			
			tempPoints = Integer.parseInt(txtUCAS.getText());
			totalPoints = tempPoints + totalPoints;


		
			String name = txtName.getText();
			LocalDate dateOfApplication = LocalDate.now();
			String telNo = txtTelNo.getText();
			String email = txtEmail.getText();
			int ucasPoints = totalPoints;

			try {
				newApp.setName(name);
				newApp.setTelNo(telNo);
				newApp.setEmail(email);
				newApp.setUcasPoints(ucasPoints);

			} 
			catch (ApplicantException e1) {
				JOptionPane.showMessageDialog(null, "" + e1 + "***", "ERROR!", JOptionPane.ERROR_MESSAGE);
				valid = false;
			}
			
			newApp.setDateOfApplication(dateOfApplication);
			newApp.setPriority(totalPoints);
			newApp.setPlaceConfirmed(false);
			
			
			if(valid == true)
			{
				applicants.add(newApp);
				taAddDisplay.setEnabled(true);
				taAddDisplay.setText("    Name \t  DOA \t     Tel #\t Email\t             Points     Priority\t Place? \n" + applicants.display());
				addDisable();

				lblDetails.setText(
						name + " has applied to NWRC, " + "With a total of " + ucasPoints + " Points! " + "Good Luck!");
				
				
				appAmount += -1;
				txtAmount.setText("" + appAmount);
				countApplicants++;
				
				gradesEntered += 1;
				txtGrades.setText("" + gradesEntered);
				gradesEntered++;
				
			
				if(gradesEntered < 3)
				{
					JOptionPane.showMessageDialog(null, "You've entered less than 3 Qualifications, this may decrease your chances of getting a place!", "WARNING",
							JOptionPane.WARNING_MESSAGE);
				}
			}

			if (appAmount == 0) {
				btnSubmit.setEnabled(false);
				btnReset.setEnabled(false);
				JOptionPane.showMessageDialog(null, "NO APPLICATIONS LEFT, \nNo more available Applications!", "ERROR",
						JOptionPane.ERROR_MESSAGE);

			}

		}

		if (e.getSource() == btnReset) {
			addEnable();
		}

		//This is linked with the combo boxes that sets the values of each box tab when the user selects their qualification.
		if (e.getSource() == cmbExamBoard) {

			  if (cmbExamBoard.getSelectedIndex() == 0) {
				cmbGrade.setModel(models[7]);
			} else if (cmbExamBoard.getSelectedIndex() == 1) {
				cmbGrade.setModel(models[1]);
			} else if (cmbExamBoard.getSelectedIndex() == 2) {
				cmbGrade.setModel(models[2]);
			} else if (cmbExamBoard.getSelectedIndex() == 3) {
				cmbGrade.setModel(models[3]);
			} else if (cmbExamBoard.getSelectedIndex() == 4) {
				cmbGrade.setModel(models[4]);
			} else if (cmbExamBoard.getSelectedIndex() == 5) {
				cmbGrade.setModel(models[5]);
			} else if (cmbExamBoard.getSelectedIndex() == 6) {
				cmbGrade.setModel(models[6]);
			}

		}

		if (e.getSource() == cmbGrade) {
			int number, grade;
			number = cmbExamBoard.getSelectedIndex();
			grade = cmbGrade.getSelectedIndex();
			switch (number) {
			case 1:
				switch(grade)
				{
				case 0:
					txtUCAS.setText("0");
					break;
				case 1:
					txtUCAS.setText("56");
					break;
				case 2:
					txtUCAS.setText("48");
					break;
				case 3:
					txtUCAS.setText("40");
					break;
				case 4:
					txtUCAS.setText("32");
					break;
				case 5:
					txtUCAS.setText("24");
					break;
				case 6:
					txtUCAS.setText("16");
					break;			
				
				}
				break;

			case 2:
				switch(grade)
				{
				case 0:
					txtUCAS.setText("0");
					break;
				case 1:
					txtUCAS.setText("20");
					break;
				case 2:
					txtUCAS.setText("16");
					break;
				case 3:
					txtUCAS.setText("12");
					break;
				case 4:
					txtUCAS.setText("10");
					break;
				case 5:
					txtUCAS.setText("6");
					break;
			
				}
				
				break;
				
			case 3:
				switch(grade)
				{
				case 0:
					txtUCAS.setText("0");
					break;
				case 1:
					txtUCAS.setText("36");
					break;
				case 2:
					txtUCAS.setText("30");
					break;
				case 3:
					txtUCAS.setText("24");
					break;
				case 4:
					txtUCAS.setText("18");
					break;
				case 5:
					txtUCAS.setText("12");
					break;
				case 6:
					txtUCAS.setText("9");
					break;
				case 7:
					txtUCAS.setText("12");
					break;
				case 8:
					txtUCAS.setText("10");
					break;
				case 9:
					txtUCAS.setText("8");
					break;
				case 10:
					txtUCAS.setText("6");
					break;
			
				}
				break;
				
			case 4:
				
				switch(grade)
				{
				case 0:
					txtUCAS.setText("0");
					break;
				case 1:
					txtUCAS.setText("56");
					break;
				case 2:
					txtUCAS.setText("48");
					break;
				case 3:
					txtUCAS.setText("32");
					break;
				case 4:
					txtUCAS.setText("16");
					break;
				case 5:
					txtUCAS.setText("6");
					break;
				}
				break;
				
			case 5:
				switch(grade)
				{
				case 0:
					txtUCAS.setText("0");
					break;
				case 1:
					txtUCAS.setText("112");
					break;
				case 2:
					txtUCAS.setText("96");
					break;
				case 3:
					txtUCAS.setText("64");
					break;
				case 4:
					txtUCAS.setText("32");
					break;
				}
				break;
				
			case 6:
				switch(grade)
				{
				case 0:
					txtUCAS.setText("0");
					break;
				case 1:
					txtUCAS.setText("168");
					break;
				case 2:
					txtUCAS.setText("144");
					break;
				case 3:
					txtUCAS.setText("96");
					break;
				case 4:
					txtUCAS.setText("48");
					break;
				}
				break;
			}
			
			}

			

		// Edit -----------------------------
		if (e.getSource() == btnEditApp) {
			editEnable();
			
			lblDetails.setText("Edit Applicant");
			taEditDisplay2.setText("    Name \t  DOA \t     Tel #\t Email\t             Points     Priority\t Place? \n" + applicants.display());

		}

		if (e.getSource() == btnEditFind) {
			DegreeApp edit = new DegreeApp();
			edit = applicants.search(txtEditFind.getText());

			if (edit != null) {
				int option;
				// double check options
				option = JOptionPane.showConfirmDialog(null, "You searched for " + edit.getName() + " Is this correct?",
						"NOTICE", JOptionPane.YES_NO_OPTION);
				if (option == JOptionPane.YES_OPTION) {
					taEditDisplay.setText(
							"Here is your chosen Applicant \n" + edit.getName() + "\n" + edit.getDateOfApplication()
									+ "\n" + edit.getTelNo() + "\n" + edit.getEmail() + "\n" + edit.getUcasPoints());
					
					txtName.setText(edit.getName());
					txtDOA.setText(edit.getDateOfApplication().toString());
					txtTelNo.setText(edit.getTelNo());
					txtEmail.setText(edit.getEmail());
					txtUCAS.setText(Integer.toString(edit.getUcasPoints()));
					btnEditFind.setVisible(false);
					btnAddNew.setVisible(false);
					btnEdit.setVisible(true);

				} else if (option == JOptionPane.NO_OPTION) {
					JOptionPane.showConfirmDialog(null, "Please Re-Enter An Applications Email", "INFO",
							JOptionPane.OK_OPTION);
					txtEditFind.setText("");

				}
			} else if (edit == null) {
				JOptionPane.showMessageDialog(null, "NONE FOUND, \nEmail not found. Please try again.", "ERROR",
						JOptionPane.ERROR_MESSAGE);
				txtEditFind.setText("");
			}

		}

		if (e.getSource() == btnEdit) {
			edit.setVisible(false);
			add.setVisible(true);
			btnSubmit.setVisible(false);
			btnReset.setVisible(false);
			btnAddQual.setVisible(false);
			btnEditQual.setVisible(true);
			btnUpdate.setVisible(true);
			cmbExamBoard.setEnabled(false);
			cmbGrade.setEnabled(false);
		
			
		}

		if (e.getSource() == btnEditCancel) {
			editEnable();
			lblDetails.setText("Edit Applicant");
		}
		
		if (e.getSource() == btnEditQual)
		{
			
			int option;
			option = JOptionPane.showConfirmDialog(null, "Editing your Qualifications are going to remove all your previously entered Qualifications! \n Are you sure?", "WARNING!", JOptionPane.WARNING_MESSAGE);
			if (option == JOptionPane.YES_OPTION) {
				
				lblDetails.setText("All Qualifications have been Removed!");
				totalPoints = 0;
				cmbExamBoard.setEnabled(true);
				cmbGrade.setEnabled(true);
				btnAddQual.setVisible(true);
				btnAddQual.setEnabled(true);
				btnEditQual.setVisible(false);
			
			

			} else if (option == JOptionPane.CANCEL_OPTION) {
				JOptionPane.showMessageDialog(null, "None of your Qualifications have been changed.", "INFO",
						JOptionPane.OK_OPTION);
			}
		}

		if (e.getSource() == btnUpdate) {
			DegreeApp EditedApp = new DegreeApp();
			valid = true;
			applicants.removeApplicant(txtEditFind.getText());

			tempPoints = Integer.parseInt(txtUCAS.getText());
			totalPoints = tempPoints + totalPoints;


			String name = txtName.getText();
			LocalDate dateOfApplication = LocalDate.now();
			String telNo = txtTelNo.getText();
			String email = txtEmail.getText();
			int ucasPoints = totalPoints;

			//double check this validation
			try {
				EditedApp.setName(name);
				EditedApp.setTelNo(telNo);
				EditedApp.setEmail(email);
				EditedApp.setUcasPoints(ucasPoints);
			} catch (ApplicantException e1) {
			 JOptionPane.showMessageDialog(null, "" + e1 + "***", "ERROR!", JOptionPane.ERROR_MESSAGE);
			 valid = false;
			}
			
			EditedApp.setPriority(totalPoints);
			EditedApp.setDateOfApplication(dateOfApplication);

			if(valid == true)
			{
			lblDetails.setText("Application Updated!");
			applicants.add(EditedApp);
			taAddDisplay.setText("    Name \t  DOA \t     Tel #\t Email\t             Points     Priority\t Place? \n" + applicants.display());

			gradesEntered += 1;
			txtGrades.setText("" + gradesEntered);
			gradesEntered++;
			
			if(gradesEntered < 3)
			{
				JOptionPane.showMessageDialog(null, "You still have less than 3 Qualifications, this may decrease your chances of getting a place!", "WARNING",
						JOptionPane.WARNING_MESSAGE);
			}
			}
			

		}
		
		
			
		

		// Delete -----------------------------
		if (e.getSource() == btnDelApp) {
			delEnable();
			images.setVisible(false);
			display.setVisible(false);

			lblDetails.setText("Delete Applicant");
			add.setVisible(false);
			edit.setVisible(false);
			delete.setVisible(true);
			allocate.setVisible(false);
			taDeleteDisplay2.setText("    Name \t  DOA \t     Tel #\t Email\t             Points     Priority\t Place? \n" + applicants.display());

		}
		if (e.getSource() == btnDeleteFind) {
			DegreeApp remove = new DegreeApp();
			remove = applicants.search(txtDeleteFind.getText());

			if (remove != null) {
				int option;
				option = JOptionPane.showConfirmDialog(null,
						"You searched for " + remove.getName() + " Is this correct?", "NOTICE",
						JOptionPane.YES_NO_OPTION);
				if (option == JOptionPane.YES_OPTION) {
					taDeleteDisplay.setText("Here is your chosen Applicant \n" + remove.getName() + "\n"
							+ remove.getDateOfApplication() + "\n" + remove.getTelNo() + "\n" + remove.getEmail() + "\n"
							+ remove.getUcasPoints());

					btnDeleteFind.setVisible(false);
					btnDel.setVisible(true);
				} else if (option == JOptionPane.NO_OPTION) {
					JOptionPane.showConfirmDialog(null, "Please Re-Enter An Applicants Email", "INFO",
							JOptionPane.OK_OPTION);
					txtDeleteFind.setText("");

				}
			} else if (remove == null) {
				JOptionPane.showMessageDialog(null, "NONE FOUND, \nEmail not found. Please try again.", "ERROR",
						JOptionPane.ERROR_MESSAGE);
				txtDeleteFind.setText("");
			}

		}

		if (e.getSource() == btnDel) {
			applicants.removeApplicant(txtDeleteFind.getText());
			taDeleteDisplay.setText(applicants.display());
			lblDetails.setText("The Application for " + txtDeleteFind.getText() + " has been Deleted.");
			appAmount = appAmount + 1;
			txtAmount.setText("" + appAmount);
			btnDeleteFind.setVisible(true);
			btnDel.setVisible(false);
			txtDeleteFind.setText("");

		}

		if (e.getSource() == btnDeleteCancel) {
			delEnable();
			lblDetails.setText("Delete Applicant");
		}

		// Display-----------------------------
		if (e.getSource() == btnDisApp) {
			display.setVisible(true);
			images.setVisible(false);
			add.setVisible(false);
			delete.setVisible(false);
			edit.setVisible(false);
			allocate.setVisible(false);
			lblDetails.setText("Displaying Applicants");
			taDisDisplay.setEnabled(true);
			taDisDisplay.setText("    Name \t  DOA \t     Tel #\t Email\t             Points     Priority\t Place? \n" + applicants.display());		
			}

		
		
		// Allocate ------------------------------
		if (e.getSource() == btnAllocateApp) {
			lblDetails.setText("Allocate Students");
			allEnable();
			taAllocateDisplay2.setText("    Name \t  DOA \t     Tel #\t Email\t             Points     Priority\t Place? \n" + applicants.display());

		
		}
		
		
		
		if (e.getSource() == btnEnter) {
			lblDetails.setText("Places Available Set!");
			
			txtPlaces.setText(txtAllocatePlaces.getText());
			placesLeft = Integer.parseInt(txtAllocatePlaces.getText());
			
			btnAllocate.setEnabled(true);

		
		}

		if (e.getSource() == btnAllocate) {
			lblDetails.setText("Allocated Students!");

				taAllocateDisplay.setText(applicants.disPriority(placesLeft));
				
			placesLeft -= placesLeft;
			
				
			
			
			if(placesLeft == 0)
			{
				JOptionPane.showMessageDialog(null, "No Places Left!", "ERROR!", JOptionPane.WARNING_MESSAGE);
			}
		
		}
		
	}
}
	

