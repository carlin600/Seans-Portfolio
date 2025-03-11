USE Jobs

IF OBJECT_ID ('MyCustomerLog') IS NOT NULL
		DROP TABLE MyCustomerLog

GO

CREATE TABLE MyCustomerLog
(
	myCustomerNo			VARCHAR(20),
	myCustomerFirstName		VARCHAR(20),
	myCustomerLastName		VARCHAR(20),
	myCustomerBusinessName	VARCHAR(20),
	myCustomerStreet		VARCHAR(30),
	myCustomerTown			VARCHAR(30),
	myCustomerAreaCode		VARCHAR(15),
	myCustomerPostCode		VARCHAR(8),
	myCustomerCreatedDate	VARCHAR(8),
	myCustomerAge			INT

	CONSTRAINT pkmyCustomerID PRIMARY KEY (myCustomerNo),

);

IF OBJECT_ID ('trCustomerLog') IS NOT NULL
	DROP TRIGGER trCustomerLog
GO

CREATE TRIGGER trCustomerLog on Customer
FOR INSERT, UPDATE, DELETE
AS

BEGIN
	INSERT INTO MyCustomerLog
	(	myCustomerNo,myCustomerFirstName,myCustomerLastName, myCustomerBusinessName, myCustomerStreet,myCustomerTown,myCustomerAreaCode,myCustomerPostCode,myCustomerCreatedDate,myCustomerAge)
	SELECT  d.CustomerNo, d.FirstName, d.LastName,d.BusinessName, d.Street, d.Town, d.AreaCode, d.Postcode, d.CreatedDate, d.Age
	FROM deleted d --old

	INSERT INTO MyCustomerLog
	(	myCustomerNo,myCustomerFirstName,myCustomerLastName, myCustomerBusinessName, myCustomerStreet,myCustomerTown,myCustomerAreaCode,myCustomerPostCode,myCustomerCreatedDate,myCustomerAge)
	SELECT i.CustomerNo, i.FirstName, i.LastName,i.BusinessName, i.Street, i.Town, i.AreaCode, i.Postcode, i.CreatedDate, i.Age
	FROM INSERTED i --new
END
GO

DROP TRIGGER trAddCustomer

CREATE TRIGGER trAddCustomer
ON Customer
FOR INSERT
AS 
BEGIN
	DECLARE @Newname VARCHAR(100)
	SELECT @Newname = (SELECT LastName + ',' + FirstName FROM INSERTED)
	PRINT 'THE CUSTOMER ' + @Newname + ' IS ADDED.';
	END

	INSERT INTO Customer VALUES
	('CU900021', 'Teresa', 'Deeney', 'NWRC', 'Strand RD', 'Derry', 'DerryCity', 'BT48 6OI', '02052019')


CREATE TRIGGER trUpdateCustomer
ON Customer
AFTER UPDATE
AS
BEGIN
	PRINT 'Trigger Output: ' + CONVERT(VARCHAR(5), @@ROWCOUNT ) + ' rows updated.'
END

UPDATE Customer
SET Town = 'Greysteel'
WHERE LastName = 'Paul'

CREATE TRIGGER trUpdateCustomer2
ON Customer
INSTEAD OF UPDATE
AS
BEGIN
	PRINT 'Trigger Output ' + CONVERT(VARCHAR(5), @@ROWCOUNT) + ' rows updated.'
END

UPDATE Customer
SET LastName = 'Carlin'
WHERE LastName = 'Slack'