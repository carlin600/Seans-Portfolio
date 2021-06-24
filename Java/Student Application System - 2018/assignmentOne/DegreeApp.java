package assignmentOne;

import java.awt.HeadlessException;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.time.LocalDate;

import javax.swing.JFrame;

public class DegreeApp {

	private String name, telNo, email;
	private String nameRegex = "[a-zA-Z, ]+ ", emailRegex = "A[A-Z0-9+_.-]+@[A-Z0-9.-]+Z";
	private LocalDate dateOfApplication;
	private int ucasPoints;
	private int priority;
	private boolean placeConfirmed;
	

	public DegreeApp() {
		
		
	}

	
		

	//constructors
	public DegreeApp(String name, String telNo, String email, LocalDate dateOfApplication, int ucasPoints, int priority,
			boolean placeConfirmed) throws HeadlessException {
	
		this.name = name;
		this.telNo = telNo;
		this.email = email;
		this.dateOfApplication = dateOfApplication;
		this.ucasPoints = ucasPoints;
		this.priority = priority;
		this.placeConfirmed = placeConfirmed;
	}

	

	public void setName(String name) throws ApplicantException {
		if(name.length() < 3 || name.matches(nameRegex) == true)
			throw new ApplicantException("Applicant Name must be more than 3 characters in Length.");
		else
		this.name = name;
	}


	//getters setters
		public String getName() {
			return name;
		}
	
	public String getTelNo() {
		
		return telNo;
	}

	public void setTelNo(String telNo)  throws ApplicantException {
		if(telNo.length() < 6 )
			throw new ApplicantException("Telephone Number must be atleast 6 Characters in Length.");
			else
		this.telNo = telNo;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) throws ApplicantException  {
		if(email.length() < 3 || email.matches(emailRegex) == true )
			throw new ApplicantException("Invalid Email. Please have a valid email including a valid Domain.");
	else
		this.email = email;
	}

	public LocalDate getDateOfApplication() {
		return dateOfApplication;
	}

	public void setDateOfApplication(LocalDate dateOfApplication) {
		this.dateOfApplication = dateOfApplication;
	}

	public int getUcasPoints() {
		return ucasPoints;
	}

	public void setUcasPoints(int ucasPoints) throws ApplicantException {
		if(ucasPoints < 30)
		throw new ApplicantException("You haven't enough UCAS Points to apply!");
		else if (ucasPoints > 550)
			throw new ApplicantException("System Error with UCAS Points - Please Reset.");
		
		this.ucasPoints = ucasPoints;
	}

	public int getPriority()
	{
		
		if(ucasPoints >= 96)
		{
			priority = 1;
			
		}
		else if(ucasPoints >= 80)
		{
			priority = 2;
		}
		else if(ucasPoints >=  64)
		{
			priority = 3;
		}
		else
			priority = 4;
		
		
		return priority;
	}
	
	public void setPriority(int priority)
	{
		this.priority = priority;
	}
	public boolean isPlaceConfirmed() {
		return placeConfirmed;
	}

	public void setPlaceConfirmed(boolean placeConfirmed) {

		this.placeConfirmed = placeConfirmed;
	}
	
	
	//i've given up at this point with formatting. It stopped my program as soon as i click submit and wont work whatsoever so i did it manually.
	public String toString()
	{
		String str="";
		
		str = String.format("  %-12s %-12s %-10s %-22s %-12s %-10s %-10s \n", 
				this.name, this.dateOfApplication, this.telNo, this.email, this.ucasPoints, this.priority,  this.placeConfirmed);
		
		return str;

	}


}
	
	

	

