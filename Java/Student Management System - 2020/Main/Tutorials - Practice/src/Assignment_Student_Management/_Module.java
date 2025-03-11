/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents a generic Module.
 * 
 * @author Sean Carlin
 *
 */
public class _Module implements java.io.Serializable {

	/**
	 * Module Variable Declarations.
	 */
	private String moduleName, leader, moderator, relatedCourse;
	private int moduleCode;

	/**
	 * Module Default Constructor.
	 */
	public _Module() {

	}

	/**
	 * Module Default Constructor with attributes / fields as parameters.
	 * 
	 * @param moduleCode    the module code.
	 * @param moduleName    the module name.
	 * @param leader        the module leader(Academic).
	 * @param moderator     the module moderator(Tutor).
	 * @param relatedCourse the modules related course.
	 */
	public _Module(Integer moduleCode, String moduleName, String leader, String moderator, String relatedCourse) {
		this.moduleCode = moduleCode;
		this.moduleName = moduleName;
		this.leader = leader;
		this.moderator = moderator;
		this.relatedCourse = relatedCourse;
	}

	/**
	 * gets the module code.
	 * 
	 * @return the module code.
	 */
	public Integer getModuleCode() {
		return moduleCode;
	}

	/**
	 * module code setter method.
	 * 
	 * @param moduleCode the module code.
	 */
	public void setModuleCode(Integer moduleCode) {
		this.moduleCode = moduleCode;
	}

	/**
	 * gets the module name.
	 * 
	 * @return the module name.
	 */
	public String getModuleName() {
		return moduleName;
	}

	/**
	 * module name setter method.
	 * 
	 * @param moduleName the module name.
	 * @throws _ApplicantException validation for module name.
	 */
	public void setModuleName(String moduleName) throws _ApplicantException {
		if (moduleName.length() < 3)
			throw new _ApplicantException("Please Enter a Valid Name!");
		else
			this.moduleName = moduleName;
	}

	/**
	 * gets module leader.
	 * 
	 * @return the module leader.
	 */
	public String getLeader() {
		return leader;
	}

	/**
	 * module leader setter method.
	 * 
	 * @param leader the module leader.
	 */
	public void setLeader(String leader) {
		this.leader = leader;
	}

	/**
	 * gets module moderator.
	 * 
	 * @return the module moderator.
	 */
	public String getModerator() {
		return moderator;
	}

	/**
	 * moderator setter method.
	 * 
	 * @param moderator the moderator.
	 */
	public void setModerator(String moderator) {
		this.moderator = moderator;
	}

	/**
	 * related course setter method.
	 * 
	 * @param relatedCourse the related course.
	 */
	public void setRelatedCourse(String relatedCourse) {
		this.relatedCourse = relatedCourse;
	}

	/**
	 * gets the related course.
	 * 
	 * @return the related course.
	 */
	public String getRelatedCourse() {
		return relatedCourse;
	}

	/**
	 * gets module name to display.
	 * 
	 * @return module name as a String.
	 */
	public String toString() {
		return String.format("" + this.getModuleName());
	}

	/**
	 * gets partial module data to display.
	 * 
	 * @return partial module data as a String.
	 */
	public String toShow() {
		return String.format("" + this.getModuleCode() + " " + this.getModuleName() + "\n");
	}

	/**
	 * gets full module data to display.
	 * 
	 * @return full module data as a String.
	 */
	public String toDisplay() {
		return String.format(this.getModuleCode() + "                 " + this.getModuleName() + "    "
				+ this.getLeader() + "    " + this.getModerator() + "    " + this.getRelatedCourse() + "  \n  ");
	}

	/**
	 * gets full module data to display but in different format.
	 * 
	 * @return full module data to display as a String.
	 */
	public String toDetails() {
		return String.format(this.getModuleCode() + "\n" + this.getModuleName() + "\n" + this.getLeader() + "\n"
				+ this.getModerator() + "\n" + this.getRelatedCourse() + "\n");
	}

}
