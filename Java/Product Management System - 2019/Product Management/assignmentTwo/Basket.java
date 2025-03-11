package assignmentTwo;

public class Basket {
	
	//declaring variables
	private int ID, quantity;
	private double price;
	
	
	
	//constructors
	public Basket()
	{
		
	}
	public Basket(int ID, int quantity, double price)
	{
		this.ID = ID;
		this.quantity = quantity;
		this.price = price;
	}

	//getters and setters
	public int getID() {
		return ID;
	}

	public void setID(int iD) {
		ID = iD;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
	
	
	
	

}
