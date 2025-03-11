/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Tutor. One of the Child/Sub classes to the
 * SUPER(Staff) attributes.
 * 
 * @author Sean Carlin.
 *
 */
public class _Tutor extends _Staff {

	/**
	 * Tutor Variable Declarations.
	 */
	private int tutorCode;
	Object[] modulesTaught;
	private String course;

	/**
	 * Tutor default constructor.
	 */
	public _Tutor() {

	}

	/**
	 * Tutor default constructor with attributes / fields as parameters.
	 * 
	 * @param tutorCode        the tutors unique code.
	 * @param modulesTaught    the modules the tutor teaches.
	 * @param course           the tutors teaching area/course.
	 * @param staffID          the tutors unique staff ID.
	 * @param name             the tutors name.
	 * @param officeLocation   the tutors office location.
	 * @param officeHours      the tutors office hours.
	 * @param position         the tutors workplace position.
	 * @param employmentStatus the tutors status, part-time etc.
	 * @param personalWebsite  the tutors personal website if any.
	 * 
	 */
	public _Tutor(int tutorCode, Object[] modulesTaught, String course, int staffID, String name, String officeLocation,
			String officeHours, String position, String employmentStatus, String personalWebsite) {
		super(staffID, name, officeLocation, officeHours, position, employmentStatus, personalWebsite);
		this.tutorCode = tutorCode;
		this.modulesTaught = modulesTaught;
		this.course = course;
	}

	/**
	 * get tutors code.
	 * 
	 * @return the tutor code.
	 */
	public int getTutorCode() {
		return tutorCode;
	}

	/**
	 * tutor code setter method.
	 * 
	 * @param tutorCode the tutors code.
	 */
	public void setTutorCode(int tutorCode) {
		this.tutorCode = tutorCode;
	}

	/**
	 * get modules taught.
	 * 
	 * @return the modules taught.
	 */
	public Object[] getModulesTaught() {
		return modulesTaught;
	}

	/**
	 * moudles taught setter method
	 * 
	 * @param modulesTaught the modules taught
	 */
	public void setModulesTaught(Object[] modulesTaught) {
		this.modulesTaught = modulesTaught;
	}

	/**
	 * get course taught.
	 * 
	 * @return the course taught.
	 */
	public String getCourse() {
		return course;
	}

	/**
	 * course taught setter method.
	 * 
	 * @param course the course taught.
	 */
	public void setCourse(String course) {
		this.course = course;
	}

	/**
	 * toString method that displays Tutor Name only.
	 * 
	 * @return tutor name only, as a String.
	 */
	public String toString() {
		return String.format(this.getName());
	}

	/**
	 * Gets Partial tutor data to Display.
	 * 
	 * @return tutor data as a String.
	 */
	public String toDisplay() {
		return String.format(this.getStaffID() + "       " + this.getTutorCode() + "           " + this.getName()
				+ "     " + this.getModulesTaught() + "	   " + this.getCourse() + "\n");
	}

	/**
	 * Gets full tutor data to Display.
	 * 
	 * @return tutor data fully as a String.
	 */
	public String toDisplayFull() {
		return String.format(this.getStaffID() + "\n" + this.getTutorCode() + "\n" + this.getModulesTaught() + "\n"
				+ this.getCourse() + "\n" + this.getName() + "\n" + this.getOfficeLocation() + "\n"
				+ this.getOfficeHours() + "\n" + this.getPosition() + "\n" + this.getEmploymentStatus() + "\n"
				+ this.getPersonalWebsite() + "");
	}

}
