--DROP PROCEDURE spGetCustomerName

-- Get town
CREATE PROCEDURE spGetCustomerTown @Town VARCHAR(30)
AS
BEGIN
SELECT * FROM Customer WHERE Town = @Town
END
EXEC spGetCustomerTown @Town = 'Derry'


--get customer name
CREATE PROCEDURE spGetCustomerName @forename VARCHAR(20)
AS
BEGIN
SELECT * FROM Customer WHERE Forename = @forename
END
EXEC spGetCustomerName @forename = 'Sean'


---work sheet
CREATE PROCEDURE spGetCustomerCount
@Town VARCHAR(30),
@CustomerCount INT OUTPUT
AS
BEGIN
	SELECT @CustomerCount = COUNT(*)
	FROM Customer
	WHERE Town = @Town
END

DECLARE @CustCount INT 
EXEC spGetCustomerCount @Town = 'Anytomn',
@CustomerCount = @CustCount OUTPUT 
SELECT @CustCount



CREATE PROCEDURE spGetDogOwner @Name VARCHAR(30),
@Surname VARCHAR(20) OUTPUT,
@Forename VARCHAR(20) OUTPUT
AS
BEGIN
	SELECT @Surname = Surname, @Forename = Forename
	FROM Customer c
	JOIN Dog d ON c.CustomerNo = d.CustomerNo
	WHERE d.name = @Name
END

DECLARE @Sur VARCHAR(30), @Fore VARCHAR(30)
EXEC spGetDogOwner @Name = 'Fluffy',
@Surname = @Sur OUTPUT,
@Forename = @Fore OUTPUT
SELECT @Sur, @Fore


CREATE PROCEDURE spSelectCustomers
AS
BEGIN
	SELECT * FROM Customer
END

EXEC spSelectCustomers

CREATE PROCEDURE spGetCustomer @Town VARCHAR(30)
AS
BEGIN
	SELECT * FROM Customer
	WHERE Town = @Town
END

EXEC spGetCustomer @Town = 'Limavady'

CREATE PROCEDURE spGetCustomer2 @Town VARCHAR(30),
@Title VARCHAR(4)
AS
BEGIN
	SELECT * FROM Customer
	WHERE Town = @Town AND Title = @Title
END

EXEC spGetCustomer2 @Town = 'Limavady', @Title = 'Mr'




--worksheet 2
USE StationeryOrder

CREATE PROCEDURE OrderSummary @MaxQuantity INT OUTPUT 
AS
BEGIN
--SELECT TO RETURN A RESULT SET SUMMARISING ORDER SALES
SELECT OD.OrderNo, SummSales = SUM(S.SellingPrice * OD.QtyOrdered)
FROM OrderDetail AS OD
JOIN Stock AS S ON (OD.StockNo = S.StockNo)
GROUP BY OD.OrderNo
ORDER BY OD.OrderNo

--SELECT to fill the output parameter with the maximum quantity from Order Details
SELECT @MaxQuantity = MAX(QtyOrdered) FROM OrderDetail

--return the number of all items ordered
RETURN (SELECT SUM(QtyOrdered) FROM OrderDetail)
END

--test the stored procedure

--DECLARE variables to hold the return code and output paramenter
DECLARE @OrderSum INT 
DECLARE @LargestOrder INT

--Execute the procedure, which returns the result set from the first select
EXEC @OrderSum = OrderSummary @MaxQuantity = @LargestOrder
OUTPUT

--Use the return code and output parameter.
PRINT 'The size of the largest single Order was : ' + CONVERT(CHAR(6), @LargestOrder)
PRINT 'The sum of the quantities ordered was : ' + CONVERT(CHAR(6), @OrderSum)



--third sheet
--use InTheDogHouse
CREATE PROCEDURE spAddDog
@Name VARCHAR(15), @BreedNo INT, @DOB DATE, @Gender VARCHAR(1),
@Colour VARCHAR(20), @CustomerNo INT
AS
BEGIN TRY
	IF NOT EXISTS(SELECT * FROM Customer WHERE CustomerNo = @CustomerNo)
	RAISERROR ('Customer does not exist', 11,1)

	DECLARE @DogNo INT 

	SELECT @DogNo = CONVERT (INT, (SELECT TOP 1 DogNo FROM Dog ORDER BY DogNo DESC) + 1)
	
	INSERT INTO Dog Values
	(@DogNo, @Name, @BreedNo, @DOB, @Gender, @Colour, @CustomerNo)
END TRY

BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spAddDog
@Name = 'Sam', @BreedNo = 201, @DOB = '20180111',
@Gender = 'M',
@Colour = 'Black', @CustomerNo = 100000


--sheet 4
CREATE PROCEDURE spAddDog2
@Name VARCHAR(15), @BreedName VARCHAR(30), @DOB DATE, @Gender VARCHAR(1), @Colour VARCHAR(20), @CustomerNo INT 
AS 
BEGIN TRY
	IF NOT EXISTS(SELECT * FROM Customer WHERE CustomerNo = @CustomerNo)
		RAISERROR ('Breed does not exist', 11,1)

	DECLARE @DogNo INT 

	SELECT @DogNo = CONVERT (INT, (SELECT TOP  1 DogNo FROM Dog ORDER BY DogNo DESC) + 1)

	INSERT INTO Dog
	VALUES
	(@DogNo, @Name,(SELECT b.BreedNo FROM Breed b 
WHERE b.BreedName = @BreedName),
	@DOB, @Gender, @Colour, @CustomerNo)
END TRY 

BEGIN CATCH
	DECLARE @ErrorMessage VARCHAR(100)
	SELECT @ErrorMessage = ERROR_MESSAGE()
	PRINT @ErrorMessage
END CATCH

EXEC spAddDog2
@Name = 'Joe', @BreedName = 'Alaskan Malamute', @DOB = '20180111', @Gender = 'M', @Colour = 'Black', @CustomerNo= 10000