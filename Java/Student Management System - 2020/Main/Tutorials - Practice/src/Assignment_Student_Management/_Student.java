/**
 * Assignment Package
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Student. Implements Serializable for Writing
 * out to File.
 * 
 * @author Sean Carlin
 *
 */
public class _Student implements java.io.Serializable {
	/**
	 * Student Variable Declaration.
	 */
	private int studentID;
	private String name, year, course, gender;
	Object[] modulesTaken;

	/**
	 * Student default constructor.
	 */
	public _Student() {

	}

	/**
	 * Student default constructor with attributes / fields as parameters.
	 * 
	 * @param studentID    the students unique ID.
	 * @param name         the students name.
	 * @param year         the students current school year.
	 * @param course       the students enrolled course.
	 * @param modulesTaken the modules student takes.
	 * @param gender       the students gender.
	 */
	public _Student(int studentID, String name, String year, String course, Object[] modulesTaken, String gender) {
		this.studentID = studentID;
		this.name = name;
		this.year = year;
		this.course = course;
		this.modulesTaken = modulesTaken;
		this.gender = gender;
	}

	/**
	 * gets student ID.
	 * 
	 * @return the student ID.
	 */
	public int getStudentID() {
		return studentID;
	}

	/**
	 * student ID setter method.
	 * 
	 * @param studentID the student ID.
	 */
	public void setStudentID(int studentID) {
		this.studentID = studentID;
	}

	/**
	 * gets student name.
	 * 
	 * @return the students name.
	 */
	public String getName() {
		return name;
	}

	/**
	 * student name setter method.
	 * 
	 * @param name the students name
	 * @throws _ApplicantException the validation for student name.
	 */
	public void setName(String name) throws _ApplicantException {
		if (name.length() < 3)
			throw new _ApplicantException("Please Enter a Valid Name!");
		else
			this.name = name;
	}

	/**
	 * gets student year.
	 * 
	 * @return student year.
	 */
	public String getYear() {
		return year;
	}

	/**
	 * student year setter method.
	 * 
	 * @param year the students year.
	 */
	public void setYear(String year) {
		this.year = year;
	}

	/**
	 * gets student course.
	 * 
	 * @return student course.
	 */
	public String getCourse() {
		return course;
	}

	/**
	 * student course setter method.
	 * 
	 * @param course the students course.
	 */
	public void setCourse(String course) {
		this.course = course;
	}

	/**
	 * gets students modules.
	 * 
	 * @return student modules taken.
	 */
	public Object[] getModulesTaken() {
		return modulesTaken;
	}

	/**
	 * modules taken setter method.
	 * 
	 * @param modules the modules selected.
	 */
	public void setModulesTaken(Object[] modules) {
		this.modulesTaken = modules;
	}

	/**
	 * gets the students gender.
	 * 
	 * @return the students gender.
	 */
	public String getGender() {
		return gender;
	}

	/**
	 * students gender setter method.
	 * 
	 * @param gender the students gender.
	 */
	public void setGender(String gender) {
		this.gender = gender;
	}

	/**
	 * toString method that returns student name only.
	 * 
	 * @return student name only, as a String.
	 */
	public String toString() {
		return "" + this.getName();

	}

	/**
	 * gets student ID only to display.
	 * 
	 * @return student ID only as a string.
	 */
	public String toDisplay() {
		return this.getStudentID() + "";
	}

	/**
	 * gets full student details to display
	 * 
	 * @return full student details as a String.
	 */
	public String toDisplayFull() {
		return "" + this.getStudentID() + "	" + this.getName() + "	  " + this.getYear() + " 	  " + this.getCourse()
				+ " 	  " + this.getModulesTaken() + "   	" + this.getGender() + "\n";
	}

	/**
	 * gets full student details to display but in different format.
	 * 
	 * @return full student details as a string.
	 */
	public String toDetails() {
		return "" + this.getStudentID() + "\n " + this.getName() + "\n " + this.getYear() + "\n " + this.getCourse()
				+ "\n " + this.getModulesTaken() + "\n " + this.getGender() + "\n";
	}

}
