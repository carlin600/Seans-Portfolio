package assignmentTwo;

import java.time.LocalDate;

public class Sale implements java.io.Serializable {

	//declare variables
	private int saleID;
	private String customerName, productCodes;
	private LocalDate dateSold;
	private double totalPrice;
	
	public Sale()
	{
		
	}
	
	//constructors
	public Sale(int saleID, String customerName, String productCodes, LocalDate dateSold, double totalPrice)
	{
		this.saleID = saleID;
		this.customerName = customerName;
		this.productCodes = productCodes;
		this.dateSold = dateSold;
		this.totalPrice = totalPrice;
	}
	
	
	//getters and setters
	public int getSaleID() {
		return saleID;
	}

	public void setSaleID(int saleID) {
		this.saleID = saleID;
	}

	public String getCustomerName() {
		return customerName;
	}

	//|| customerName != "^[A-Za-z0-9@/._-]{1,254}$"
	public void setCustomerName(String customerName) throws ApplicantException {
		if(customerName.length() < 2)
			throw new ApplicantException("Please Enter a Valid Name!");
		else
		this.customerName = customerName;
	}

	public String getProductCodes() {
		return productCodes;
	}

	public void setProductCodes(String productCodes) {
		this.productCodes = productCodes;
	}

	public LocalDate getDateSold() {
		return dateSold;
	}

	public void setDateSold(LocalDate dateSold) {
		this.dateSold = dateSold;
	}

	public double getTotalPrice() {
		return totalPrice;
	}

	public void setTotalPrice(double totalPrice) {
		this.totalPrice = totalPrice;
	}
	
	
	public String toString() {

		return String.format(" %-8d %-20s %-30s  %20s %15f \n", this.saleID, this.customerName, this.productCodes,
				this.dateSold, this.totalPrice);
	}
	

}
