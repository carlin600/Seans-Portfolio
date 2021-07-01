using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
class MySupplier
{
private string supplierID;
private string supplierName, supplierStreet, supplierTown, supplierCounty, supplierPostcode, supplierTelNo;
public MySupplier()
{
this.supplierID = "";
this.supplierName = "";
this.supplierStreet = "";
this.supplierTown = "";
this.supplierCounty = "";
this.supplierPostcode = "";
this.supplierTelNo = "";
}
public MySupplier(string supplierID, string supplierName, string supplierStreet, string supplierTown, string supplierCounty, string supplierPostcode, string supplierTelNo)
{
this.supplierID = supplierID;
this.supplierName = supplierName;
this.supplierStreet = supplierStreet;
this.supplierTown = supplierTown;
this.supplierCounty = supplierCounty;
this.supplierPostcode = supplierPostcode;
this.supplierTelNo = supplierTelNo;
}
public string SupplierID
{
get { return supplierID; }
set { supplierID = value; }
}
public string SupplierName
{
get { return supplierName; }
set {
if (MyValidation.validLength(value, 2, 30))
{
supplierName = MyValidation.firstLetterEachWordToUpper(value);
}
else
{
throw new MyException("Supplier Name must be 2-30 characters long.");
}
}
}
public string SupplierStreet
{
get { return supplierStreet; }
set {
if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value)) // sorted validLetterNumberWhitespace
{
supplierStreet = MyValidation.firstLetterEachWordToUpper(value);
}
else
{
throw new MyException("Street must be 5 - 40 characters long.");
}
}
}
public string SupplierTown
{
get { return supplierTown; }
set {

if (MyValidation.validLength(value, 2, 20)
&& MyValidation.validLetterWhitespace(value))
{
supplierTown = MyValidation.firstLetterEachWordToUpper(value);
}
else
{
throw new MyException("Town must be 2 - 2- characters long.");
}
}
}
public string SupplierCounty
{
get { return supplierCounty; }
set
{
if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetter(value))
{
supplierCounty = MyValidation.firstLetterEachWordToUpper(value);
}
else
{
throw new MyException("County must be 2 - 20 characters long.");
}
}
}
public string SupplierPostcode
{
get { return supplierPostcode; }
set {
if (MyValidation.validLength(value, 4, 10) && MyValidation.validLetterNumberWhitespace(value))
{
supplierPostcode = value;
}
else
{
throw new MyException("You Must Enter a valid Postcode!");
}
}
}
//public string SupplierTelNo
//{
//get { return supplierTelNo; }
//set
//{
//if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
//{
//supplierTelNo = value;
//}
//else
//{
//throw new MyException("Telephone number must be 11-15 digits.");
//}
//}
//}
}
}
