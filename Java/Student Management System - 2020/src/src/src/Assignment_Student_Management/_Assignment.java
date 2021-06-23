/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Assignment. SUPER Class.
 * 
 * @author Sean Carlin.
 *
 */
public class _Assignment implements java.io.Serializable {

	/**
	 * Assignment Variable Declarations.
	 */
	private String assignmentCourse, assignmentModule, assignmentName, assignmentDesc, dateAssigned;
	private int assignmentID;

	/**
	 * Assigment default constructor.
	 */
	public _Assignment() {

	}

	/**
	 * Assignment default constructor with attributes / fields as parameters.
	 * 
	 * @param assignmentID     the assignment ID.
	 * @param assignmentCourse the assignment course.
	 * @param assignmentModule the assignment module.
	 * @param assignmentName   the assignment name.
	 * @param assignmentDesc   the assignment description.
	 * @param dateAssigned     the data assignment was given/assigned.
	 */
	public _Assignment(int assignmentID, String assignmentCourse, String assignmentModule, String assignmentName,
			String assignmentDesc, String dateAssigned) {

		this.assignmentName = assignmentName;
		this.assignmentID = assignmentID;
		this.assignmentCourse = assignmentCourse;
		this.assignmentModule = assignmentModule;
		this.assignmentDesc = assignmentDesc;
		this.dateAssigned = dateAssigned;

	}

	/**
	 * gets the assignment ID.
	 * 
	 * @return the assignment ID.
	 */
	public int getAssignmentID() {
		return assignmentID;
	}

	/**
	 * assignment ID setter method.
	 * 
	 * @param assignmentID the assignment ID.
	 */
	public void setAssignmentID(int assignmentID) {
		this.assignmentID = assignmentID;
	}

	/**
	 * gets the assignment course.
	 * 
	 * @return the assignment course.
	 */
	public String getAssignmentCourse() {
		return assignmentCourse;
	}

	/**
	 * assignment course setter method.
	 * 
	 * @param assignmentCourse the assignment course.
	 */
	public void setAssignmentCourse(String assignmentCourse) {
		this.assignmentCourse = assignmentCourse;
	}

	/**
	 * gets the assignment module.
	 * 
	 * @return the assignment module.
	 */
	public String getAssignmentModule() {
		return assignmentModule;
	}

	/**
	 * assignment module setter method.
	 * 
	 * @param assignmentModule the assignment module.
	 */
	public void setAssignmentModule(String assignmentModule) {
		this.assignmentModule = assignmentModule;
	}

	/**
	 * gets the assignment name.
	 * 
	 * @return the assignment name.
	 */
	public String getAssignmentName() {
		return assignmentName;
	}

	/**
	 * assignment name setter method.
	 * 
	 * @param assignmentName the assignment name.
	 * @throws _ApplicantException validaton for assignment name.
	 */
	public void setAssignmentName(String assignmentName) throws _ApplicantException {
		if (assignmentName.length() < 3)
			throw new _ApplicantException("Please Enter a Valid Name!");
		else {
			this.assignmentName = assignmentName;
		}
	}

	/**
	 * gets the assignment description.
	 * 
	 * @return the assignment description.
	 */
	public String getAssignmentDesc() {
		return assignmentDesc;
	}

	/**
	 * assignment description setter method.
	 * 
	 * @param assignmentDesc the assignment description.
	 */
	public void setAssignmentDesc(String assignmentDesc) {
		this.assignmentDesc = assignmentDesc;
	}

	/**
	 * gets the assignments date assigned.
	 * 
	 * @return the data assigned.
	 */
	public String getDateAssigned() {
		return dateAssigned;
	}

	/**
	 * assigned data setter method.
	 * 
	 * @param dateAssigned the date assigned.
	 */
	public void setDateAssigned(String dateAssigned) {
		this.dateAssigned = dateAssigned;
	}

	/**
	 * gets partial assignment data to display.
	 * 
	 * @return partial assignment data as a String.
	 */
	public String toString() {
		return this.getAssignmentID() + "    	 " + this.getAssignmentName() + "\n";

	}

	/**
	 * gets full assignment details to display.
	 * 
	 * @return full assignment details as a String.
	 */
	public String toDetails() {
		return "Assignment ID: " + this.getAssignmentID() + "\n Assignment Name: " + this.getAssignmentName()
				+ "\nAssignment Course: " + this.getAssignmentCourse() + "\n Assignment Module: "
				+ this.getAssignmentModule() + "\nDate Assigned: " + this.getDateAssigned() + "\n Description: "
				+ this.getAssignmentDesc() + "\n";

	}

}
