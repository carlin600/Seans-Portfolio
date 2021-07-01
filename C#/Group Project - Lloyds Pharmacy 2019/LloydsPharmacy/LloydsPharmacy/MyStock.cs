using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LloydsPharmacy
{
class MyStock
{
private int qtyInStock;
private string stockID, supplierID,stockDesc,stocktypeID;
private double stockPrice;
public MyStock()
{
this.stockID = "";
this.supplierID = "";
this.stockDesc = "";
this.stocktypeID = "";
this.qtyInStock = 0;
this.stockPrice = 0.0;
}
public MyStock(string stockID, string supplierID, string stockDesc, string stocktypeID, int qtyInStock, double stockPrice)
{
this.stockID = stockID;
this.supplierID = supplierID;
this.stockDesc = stockDesc;
this.stocktypeID = stocktypeID;
this.qtyInStock = qtyInStock;
this.stockPrice = stockPrice;
}
// GET VALIDATION DONE FOR HERE
public string StockID
{
get { return stockID; }
set { stockID = value; }
}
public string SupplierID
{
get { return supplierID; }
set { supplierID = value; }
}
public string StockDesc
{
get { return stockDesc; }
set {
if (MyValidation.validLength(value, 2, 50) && MyValidation.validLetterWhitespace(value))
{
stockDesc = value;
}
else
{
throw new MyException("Stock Description must be 2-50 characters long.");
}
}
}
public string StockTypeID
{
get { return stocktypeID; }
set { stocktypeID = value; }
}
public int QTYInStock
{
get { return qtyInStock; }
set
{
if (MyValidation.validIntNumber(value, 0, 100))
{
qtyInStock = value;
}
else
{
throw new MyException("Quantity must be > 0 or <= 100");
}
}
}
public double StockPrice
{
get { return stockPrice; }
set
{
if (MyValidation.validDoubleNumber(value, 0.00, 100.00))
{
stockPrice = value;
}
else
{
throw new MyException("Stock Price must be > 0 or <= 100");
}
}
}
}
}
