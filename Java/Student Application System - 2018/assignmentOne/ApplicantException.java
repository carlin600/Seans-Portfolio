package assignmentOne;

public class ApplicantException extends Exception{
	
	private String message;
	
	ApplicantException(String s)
	{
		message = s;
	}
	ApplicantException()
	{
		message = "Invalid Data Entered";
	}
	public String toString()
	{
		return "**Applicant Exception: " + message;
	}

}
