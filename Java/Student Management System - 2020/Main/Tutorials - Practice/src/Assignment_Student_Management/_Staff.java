/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Staff member. This is the SUPER class out of
 * my Hierarchical Inheritance.
 * 
 * @author Sean Carlin
 *
 */
public class _Staff implements java.io.Serializable {

	/**
	 * Staff Variable Declarations.
	 */
	private int staffID;
	private String name, officeLocation, officeHours, position, employmentStatus, personalWebsite;

	/**
	 * Staff default constructor.
	 */
	public _Staff() {

	}

	/**
	 * Staff default constructor with attributes / fields as parameters.
	 * 
	 * @param staffID          the staffs members unique code.
	 * @param name             the staff members name
	 * @param officeLocation   the staff members office location.
	 * @param officeHours      the staff members office hours.
	 * @param position         the staff members position.
	 * @param employmentStatus the staff members status.
	 * @param personalWebsite  the staff members personal website if any.
	 */
	public _Staff(int staffID, String name, String officeLocation, String officeHours, String position,
			String employmentStatus, String personalWebsite) {
		this.staffID = staffID;
		this.name = name;
		this.officeLocation = officeLocation;
		this.officeHours = officeHours;
		this.position = position;
		this.employmentStatus = employmentStatus;
		this.personalWebsite = personalWebsite;

	}

	/**
	 * gets staff ID.
	 * 
	 * @return the staff ID.
	 */
	public int getStaffID() {
		return staffID;
	}

	/**
	 * staff ID setter method.
	 * 
	 * @param staffID the Staff ID.
	 */
	public void setStaffID(int staffID) {
		this.staffID = staffID;
	}

	/**
	 * gets staff Name.
	 * 
	 * @return the staff Name.
	 */
	public String getName() {
		return name;
	}

	/**
	 * staff name setter method.
	 * 
	 * @param name the staff name.
	 * @throws _ApplicantException validation for staff name.
	 */
	public void setName(String name) throws _ApplicantException {
		if (name.length() < 3)
			throw new _ApplicantException("Please Enter a Valid Name!");
		else
			this.name = name;
	}

	/**
	 * gets office location.
	 * 
	 * @return the offices' location.
	 */
	public String getOfficeLocation() {
		return officeLocation;
	}

	/**
	 * office location setter method.
	 * 
	 * @param officeLocation the office location.
	 */
	public void setOfficeLocation(String officeLocation) {
		this.officeLocation = officeLocation;
	}

	/**
	 * gets office hours.
	 * 
	 * @return the office hours.
	 */
	public String getOfficeHours() {
		return officeHours;
	}

	/**
	 * office hours setter method.
	 * 
	 * @param officeHours the office hours.
	 */
	public void setOfficeHours(String officeHours) {
		this.officeHours = officeHours;
	}

	/**
	 * gets staff position.
	 * 
	 * @return the staffs position
	 */
	public String getPosition() {
		return position;
	}

	/**
	 * position setter method.
	 * 
	 * @param position the staff position.
	 */
	public void setPosition(String position) {
		this.position = position;
	}

	/**
	 * gets employment status.
	 * 
	 * @return employment status.
	 */
	public String getEmploymentStatus() {
		return employmentStatus;
	}

	/**
	 * employment status setter method.
	 * 
	 * @param employmentStatus the staff employment status.
	 */
	public void setEmploymentStatus(String employmentStatus) {
		this.employmentStatus = employmentStatus;
	}

	/**
	 * gets personal website if any.
	 * 
	 * @return personal website.
	 */
	public String getPersonalWebsite() {
		return personalWebsite;
	}

	/**
	 * personal website setter method.
	 * 
	 * @param personalWebsite the personal website.
	 */
	public void setPersonalWebsite(String personalWebsite) {
		this.personalWebsite = personalWebsite;
	}

	/**
	 * gets full staff details to display.
	 * 
	 * @return full staff details as a String.
	 */
	public String toString() {
		return String.format(" " + this.getStaffID() + "     " + this.getName() + "      " + this.getOfficeLocation()
				+ " 	     " + this.getOfficeHours() + "        " + this.getPosition() + "    "
				+ this.getEmploymentStatus() + "   " + this.getPersonalWebsite() + "\n");
	}

	/**
	 * gets full staff details to display in a different format.
	 * 
	 * @return full student details as a String.
	 */
	public String toDetails() {
		return String.format(" " + this.getStaffID() + "\n " + this.getName() + "\n " + this.getOfficeLocation() + "\n "
				+ this.getOfficeHours() + "\n " + this.getPosition() + "\n " + this.getEmploymentStatus() + "\n"
				+ this.getPersonalWebsite() + "\n");
	}

}
