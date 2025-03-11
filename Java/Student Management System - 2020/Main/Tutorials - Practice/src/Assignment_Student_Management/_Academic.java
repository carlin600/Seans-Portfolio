/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents an Academic member. One of the Child/Sub classes to the
 * SUPER(Staff)
 * 
 * @author Sean Carlin.
 *
 */

public class _Academic extends _Staff {

	/**
	 * Academic Variable Declaration.
	 */
	private int academicCode;
	private String areaExpertise, studentSupervised;

	/**
	 * Academic default constructor.
	 */
	public _Academic() {

	}

	/**
	 * Academic constructor with attributes / fields as parameters.
	 * 
	 * @param academicCode      the academics unique code.
	 * @param areaExpertise     the academics area of expertise.
	 * @param studentSupervised the academics supervised student.
	 * @param staffID           the academics unique staff ID.
	 * @param name              the academics name.
	 * @param officeLocation    the academics office location.
	 * @param officeHours       the academics office hours.
	 * @param position          the academics position.
	 * @param employmentStatus  the academics employment status.
	 * @param personalWebsite   the academics personal website if any.
	 */
	public _Academic(int academicCode, String areaExpertise, String studentSupervised, int staffID, String name,
			String officeLocation, String officeHours, String position, String employmentStatus,
			String personalWebsite) {
		super(staffID, name, officeLocation, officeHours, position, employmentStatus, personalWebsite);
		this.academicCode = academicCode;
		this.areaExpertise = areaExpertise;
		this.studentSupervised = studentSupervised;

	}

	/**
	 * gets academic code.
	 * 
	 * @return the academic code.
	 */
	public int getAcademicCode() {
		return academicCode;
	}

	/**
	 * academic code setter method.
	 * 
	 * @param academicCode the academic code.
	 */
	public void setAcademicCode(int academicCode) {
		this.academicCode = academicCode;
	}

	/**
	 * gets area of expertise.
	 * 
	 * @return the expertise area.
	 */
	public String getAreaExpertise() {
		return areaExpertise;
	}

	/**
	 * area of expertise setter method.
	 * 
	 * @param areaExpertise the expertise area.
	 */
	public void setAreaExpertise(String areaExpertise) {
		this.areaExpertise = areaExpertise;
	}

	/**
	 * gets student supervised.
	 * 
	 * @return the student supervised.
	 */
	public String getStudentSupervised() {
		return studentSupervised;
	}

	/**
	 * student supervised setter method.
	 * 
	 * @param studentSupervised the student supervised.
	 */
	public void setStudentSupervised(String studentSupervised) {
		this.studentSupervised = studentSupervised;
	}

	/**
	 * gets academic name only to display
	 * 
	 * @return academic name as a String.
	 */
	public String toString() {
		return String.format(this.getName());
	}

	/**
	 * gets partial academic data for display
	 * 
	 * @return partial academic data as a String.
	 */
	public String toDisplay() {
		return String.format(this.getStaffID() + "        " + this.getAcademicCode() + " 	 " + this.getName()
				+ " 	" + this.getAreaExpertise() + "	 " + this.getStudentSupervised() + "\n");
	}

	/**
	 * gets full academic data in format to display.
	 * 
	 * @return full academic data as a String.
	 */
	public String toDetails() {
		return String.format("Staff ID: " + this.getStaffID() + "\nName:  " + this.getName() + "\nAcademic Code:  "
				+ this.getAcademicCode() + "\nArea Of Expertise:  " + this.getAreaExpertise() + "\nStudent Supervised: "
				+ this.getStudentSupervised() + "\nOffice Location: " + this.getOfficeLocation() + "\nOffice Hours: "
				+ this.getOfficeHours() + " \nPosition: " + this.getPosition() + "\nStatus: "
				+ this.getEmploymentStatus() + "\n Personal Website: " + this.getPersonalWebsite() + "\n");
	}

}
