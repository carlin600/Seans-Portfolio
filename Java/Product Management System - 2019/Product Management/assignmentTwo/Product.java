package assignmentTwo;

public class Product implements java.io.Serializable {

	//declaring variables
	private int productID, noSold, stockLevel;
	private String name, size, category;
	private double unitPrice;

	public Product() {

	}

	// constructors
	public Product(int productID, int noSold, int stockLevel, String name, String size, String category,
			double unitPrice) {
		this.productID = productID;
		this.noSold = noSold;
		this.stockLevel = stockLevel;
		this.name = name;
		this.size = size;
		this.category = category;
		this.unitPrice = unitPrice;

	}

	// getters and setters
	public int getProductID() {
		return productID;
	}

	public void setProductID(int productID) {
		this.productID = productID;
	}

	public int getNoSold() {
		return noSold;
	}

	public void setNoSold(int noSold) {
		this.noSold = noSold;
	}

	public int getStockLevel() {
		return stockLevel;
	}

	//validation exception included also.
	public void setStockLevel(int stockLevel) throws ApplicantException {
		if(stockLevel < 0)
			throw new ApplicantException("Please Enter A Valid Stock Amount");
		else if (stockLevel > 500)
			throw new ApplicantException("Too much stock! Enter Again!");
		else
		this.stockLevel = stockLevel;
	}

	public String getName() {
		return name;
	}

	//|| name != "^[A-Za-z0-9@/._-]{1,254}$"
	public void setName(String name) throws ApplicantException {
		if(name.length() < 3 )
			throw new ApplicantException("Please Enter a Valid Name!");
		else
		this.name = name;
	}

	public String getSize() {
		return size;
	}

	public void setSize(String size) {
		this.size = size;
	}

	public String getCategory() {
		return category;
	}

	public void setCategory(String category) {
		this.category = category;
	}

	public double getUnitPrice() {
		return unitPrice;
	}

	public void setUnitPrice(double unitPrice) throws ApplicantException{
		if(unitPrice < 00.00)
			throw new ApplicantException("Please enter a Valid Price!");
		else if(unitPrice > 100.00)
			throw new ApplicantException("C'mon, be Realistic!");
		else
		this.unitPrice = unitPrice;
	}

	
	
	//tostrings so the class properties can be put on display.
	public String toString() {

		return String.format(" %-12d               %-20s    %-15s  %-12s      %-15.2f    %-20d        %-15d  \n", this.productID, this.name, this.category,
				this.size, this.unitPrice, this.stockLevel, this.noSold);
	}
	
	public String toDisplay() {

		return String.format(" \nProduct ID: %-8d \nName: %-10s \nCategory: %-15s  \nSize: %-10s \nPrice (£): %4.2f \nStock Level: %-4d \n# Sold: %-4d", this.productID, this.name, this.category,
				this.size, this.unitPrice, this.stockLevel, this.noSold);
}



}
