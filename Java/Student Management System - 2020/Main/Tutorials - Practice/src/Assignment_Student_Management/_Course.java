/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Course.
 * 
 * @author Sean Carlin.
 *
 */
public class _Course implements java.io.Serializable {

	/**
	 * Course Variable Declarations.
	 */
	private int courseID;
	private String courseName, relatedModules;

	/**
	 * Course Default Constructor.
	 */
	public _Course() {

	}

	/**
	 * Course Default Constructor with attributes / fields as parameters.
	 * 
	 * @param courseID       the course's unique ID
	 * @param courseName     the course's name.
	 * @param relatedModules the course's related modules.
	 */
	public _Course(int courseID, String courseName, String relatedModules) {

		this.courseID = courseID;
		this.courseName = courseName;
		this.relatedModules = relatedModules;
	}

	/**
	 * gets course ID.
	 * 
	 * @return the course ID.
	 */
	public int getCourseID() {
		return courseID;
	}

	/**
	 * course ID setter method.
	 * 
	 * @param courseID the course ID.
	 */
	public void setCourseID(int courseID) {
		this.courseID = courseID;
	}

	/**
	 * get course name.
	 * 
	 * @return the course name.
	 */
	public String getCourseName() {
		return courseName;
	}

	/**
	 * course name setter method.
	 * 
	 * @param courseName the course name.
	 */
	public void setCourseName(String courseName) {
		this.courseName = courseName;
	}

	/**
	 * gets the course's related modules.
	 * 
	 * @return the course related modules.
	 */
	public String getRelatedModules() {
		return relatedModules;
	}

	/**
	 * related modules setter method.
	 * 
	 * @param relatedModules the course related modules.
	 */
	public void setRelatedModules(String relatedModules) {
		this.relatedModules = relatedModules;
	}

	/**
	 * get course name only to display.
	 * 
	 * @return course name only as a String.
	 */
	public String toString() {
		return String.format("" + this.getCourseName());
	}

	/**
	 * gets full course details to display.
	 * 
	 * @return full course details as a String.
	 */
	public String toDisplay() {
		return String.format("" + this.getCourseID() + "	" + this.getCourseName() + "                "
				+ this.getRelatedModules() + "\n");
	}

	/**
	 * gets full course details to display but in different format.
	 * 
	 * @return full course details as a String.
	 */
	public String toDetails() {
		return String.format(
				"" + this.getCourseID() + "\n " + this.getCourseName() + "\n " + this.getRelatedModules() + "\n ");
	}

}
