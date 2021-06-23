/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Marked Assignment. SUB Class to Assignment.
 * 
 * @author Sean Carlin.
 *
 */
public class _MarkedAssignment extends _Assignment implements java.io.Serializable {

	/**
	 * Marked Assignment Declared Variables.
	 */
	private String assignmentStudent, assignmentGrade, assignmentFeedback;
	private int resultID, assignmentMark;

	/**
	 * Marked Assignment default constructor.
	 */
	public _MarkedAssignment() {

	}

	/**
	 * Marked Assignment default constructor with attributes / fields as parameters.
	 * 
	 * @param assignmentStudent  the assignment student.
	 * @param assignmentGrade    the assignment grade.
	 * @param assignmentFeedback the assignment feedback.
	 * @param resultID           the marked assignment result ID.
	 * @param assignmentMark     the assignment mark.
	 * @param assignmentID       the assignment ID.
	 * @param assignmentCourse   the assignment course.
	 * @param assignmentModule   the assignment module.
	 * @param assignmentName     the assignment name.
	 * @param assignmentDesc     the assignment description.
	 * @param dateAssigned       the date when assignment was given.
	 */
	public _MarkedAssignment(String assignmentStudent, String assignmentGrade, String assignmentFeedback, int resultID,
			int assignmentMark, int assignmentID, String assignmentCourse, String assignmentModule,
			String assignmentName, String assignmentDesc, String dateAssigned) {
		super(assignmentID, assignmentCourse, assignmentModule, assignmentName, assignmentDesc, dateAssigned);
		this.assignmentStudent = assignmentStudent;
		this.assignmentFeedback = assignmentFeedback;
		this.assignmentGrade = assignmentGrade;
		this.assignmentFeedback = assignmentFeedback;
		this.resultID = resultID;
		this.assignmentMark = assignmentMark;

	}

	/**
	 * gets the assignment student.
	 * 
	 * @return the assignment student.
	 */
	public String getAssignmentStudent() {
		return assignmentStudent;
	}

	/**
	 * assignment student setter method.
	 * 
	 * @param assignmentStudent the assignment student.
	 */
	public void setAssignmentStudent(String assignmentStudent) {
		this.assignmentStudent = assignmentStudent;
	}

	/**
	 * gets the assignment grade.
	 * 
	 * @return the assignment grade.
	 */
	public String getAssignmentGrade() {
		return assignmentGrade;
	}

	/**
	 * assignment grade setter method.
	 * 
	 * @param assignmentGrade the assignment grade
	 */
	public void setAssignmentGrade(String assignmentGrade) {
		this.assignmentGrade = assignmentGrade;
	}

	/**
	 * gets the assignment feedback.
	 * 
	 * @return the assignment feedback.
	 */
	public String getAssignmentFeedback() {
		return assignmentFeedback;
	}

	/**
	 * assignment feedback setter method.
	 * 
	 * @param assignmentFeedback the assignment feedback.
	 */
	public void setAssignmentFeedback(String assignmentFeedback) {
		this.assignmentFeedback = assignmentFeedback;
	}

	/**
	 * gets the result ID.
	 * 
	 * @return the result ID.
	 */
	public int getResultID() {
		return resultID;
	}

	/**
	 * result ID setter method.
	 * 
	 * @param resultID the result ID.
	 */
	public void setResultID(int resultID) {
		this.resultID = resultID;
	}

	/**
	 * gets the assignment mark.
	 * 
	 * @return the assignment mark.
	 */
	public int getAssignmentMark() {

		return assignmentMark;
	}

	/**
	 * assignment mark setter method.
	 * 
	 * @param assignmentMark the assignment mark.
	 * @throws _ApplicantException validation for assignment mark.
	 */
	public void setAssignmentMark(int assignmentMark) throws _ApplicantException {
		if (assignmentMark < 0)
			throw new _ApplicantException("Please enter a Valid Mark!");
		else if (assignmentMark > 80)
			throw new _ApplicantException("Marks are between 0 and 80!");
		else
			this.assignmentMark = assignmentMark;
	}

	/**
	 * gets the resultID and assignment Name to display.
	 * 
	 * @return the resultID and assignment Name as a String.
	 */
	public String toString() {
		return this.getResultID() + "" + this.getAssignmentName() + "\n";

	}

}
