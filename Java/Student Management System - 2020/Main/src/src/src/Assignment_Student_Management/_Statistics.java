/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents generic Statistics.
 * 
 * @author Sean Carlin.
 *
 */
public class _Statistics implements java.io.Serializable {

	/**
	 * Statistics Declared Variables.
	 */
	private int statisticID, mark;
	private String studentName, Course, assignmentName, feedback, average;

	/**
	 * Statistics default Constructor.
	 */
	public _Statistics() {
	}

	/**
	 * Statistics default constructor with attributes / fields as parameters.
	 * 
	 * @param statisticID    the statistic ID.
	 * @param mark           the student mark.
	 * @param studentName    the student name.
	 * @param Course         the students course.
	 * @param assignmentName the assignment name.
	 * @param feedback       the assignment feedback.
	 * @param average        the calculated student average.
	 */
	public _Statistics(int statisticID, int mark, String studentName, String Course, String assignmentName,
			String feedback, String average) {
		this.statisticID = statisticID;
		this.mark = mark;
		this.studentName = studentName;
		this.Course = Course;
		this.assignmentName = assignmentName;
		this.feedback = feedback;
		this.average = average;
	}

	/**
	 * gets statistic ID.
	 * 
	 * @return statistic ID.
	 */
	public int getStatisticID() {
		return statisticID;
	}

	/**
	 * statistic ID setter method.
	 * 
	 * @param statisticID the statistic ID.
	 */
	public void setStatisticID(int statisticID) {
		this.statisticID = statisticID;
	}

	/**
	 * gets the mark.
	 * 
	 * @return the mark.
	 */
	public int getMark() {
		return mark;
	}

	/**
	 * mark setter method.
	 * 
	 * @param mark the mark.
	 */
	public void setMark(int mark) {
		this.mark = mark;
	}

	/**
	 * gets the student name.
	 * 
	 * @return the students name.
	 */
	public String getStudentName() {
		return studentName;
	}

	/**
	 * student name setter method.
	 * 
	 * @param studentName the students name.
	 */
	public void setStudentName(String studentName) {
		this.studentName = studentName;
	}

	/**
	 * gets the students course.
	 * 
	 * @return the students course.
	 */
	public String getCourse() {
		return Course;
	}

	/**
	 * students course setter method.
	 * 
	 * @param course the course.
	 */
	public void setCourse(String course) {
		Course = course;
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
	 */
	public void setAssignmentName(String assignmentName) {
		this.assignmentName = assignmentName;
	}

	/**
	 * gets the student feedback.
	 * 
	 * @return the student feedback.
	 */
	public String getFeedback() {
		return feedback;
	}

	/**
	 * student feedback setter method.
	 * 
	 * @param feedback the feedback.
	 */
	public void setFeedback(String feedback) {
		this.feedback = feedback;
	}

	/**
	 * gets the calculated student average.
	 * 
	 * @return the calculated student average.
	 */
	public String getAverage() {
		return average;
	}

	/**
	 * average setter method.
	 * 
	 * @param average the average.
	 */
	public void setAverage(String average) {
		this.average = average;
	}

	/**
	 * this gets all statistic data to display.
	 * 
	 * @return the statistic data as a String.
	 */
	public String toString() {
		return this.getStatisticID() + "" + this.getMark() + "" + this.getStudentName() + "" + this.getCourse() + ""
				+ this.getAssignmentName() + "" + this.getFeedback() + "" + this.getAverage();

	}

}
