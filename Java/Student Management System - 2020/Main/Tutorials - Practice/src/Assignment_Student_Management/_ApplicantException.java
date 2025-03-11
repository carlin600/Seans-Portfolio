/**
 * Assignment Package.
 */
package Assignment_Student_Management;

/**
 * This class represents the Applicant Exceptions that are inherited throughout
 * my assignment classes. This helps with validation techniques.
 * 
 * @author Sean Carlin
 *
 */
public class _ApplicantException extends Exception {

	/**
	 * Applicant Exception Variable Declaration.
	 */
	private String message;

	/**
	 * Exceptions error message.
	 * 
	 * @param the exception String error message.
	 */
	_ApplicantException(String s) {
		message = s;
	}

	/**
	 * Error message for display.
	 */
	_ApplicantException() {
		message = "Invalid Data Entered";
	}

	/**
	 * gets full error message to display when called.
	 * 
	 * @return error message as a String.
	 */
	public String toString() {
		return "**Applicant Exception: " + message;
	}
}
