package assignmentTwo;

public class ApplicantException extends Exception{
	
	//This class is what triggers the errors when an exception is reached.
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
