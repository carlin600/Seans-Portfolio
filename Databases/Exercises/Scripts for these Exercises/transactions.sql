
--BASIC INSERT INTO A SINGLE TABLE
BEGIN TRAN
	INSERT INTO Breed VALUES
	(212, 'Staffie', 1)
COMMIT TRAN




--INSERT INTO MULTIPLE TABLES
--CONTAINS NO ERROR CHECKING 
BEGIN TRAN
	INSERT INTO Customer VALUES
	(10020, 'Mrs','White','Claire','123 Main Street','Eglinton','Derry','BT48 6YY','02871123654')

	INSERT INTO Dog VALUES
	(5016, 'Murphy', 210, '20150915','M','Brindle',10019),
	(5017, 'Sadie', 210, '20130207','F','Brown & White',10019)
	
	INSERT INTO Booking VALUES
	(60011, 10019, '20171122', '20171205', 5)

	INSERT INTO BookingDetail VALUES
	(60011, 5016, 102),
	(60011, 5017, 103)

	COMMIT TRAN




--INSERT INTO MULTIPLE TABLES
--CONTAINS BASIC ERROR HANDLING, IE, EITHER 
--COMMITS THE COMPLETE TRANSACTION OR DOES A 
--COMPLETE ROLLBACK
BEGIN TRAN
	BEGIN TRY
		INSERT INTO Customer VALUES
		(10021, 'Mr','Neill','Pat','123 Main Street','Eglinton','Derry','BT48 6YY','02871123654')

		INSERT INTO Dog VALUES
		(5016, 'Murphy', 210, '20150915','M','Brindle',10019),
		(5017, 'Sadie', 210, '20130207','F','Brown & White',10019)

		INSERT INTO Booking VALUES
		(60011, 10019, '20171122', '20171205', 5)

		INSERT INTO BookingDetail VALUES
		(60011, 5016, 102),
		(60011, 5017, 103)

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		IF @@ERROR <> 0
		BEGIN
			PRINT 'Unexpected error occurred!'
			ROLLBACK TRAN
		END

	END CATCH




--INSERT INTO MULTIPLE TABLES
--STILL CONTAINS BASIC ERROR HANDLING, 
--(ALL OR NOTHING) BUT CONTAINS MORE 
--INFORMATIVE ERROR MESSAGES FOR THE USER
BEGIN TRAN
	BEGIN TRY

		DECLARE @TableName varchar(15)
		
		SET @TableName = 'Customer'
		INSERT INTO Customer VALUES
		(10022, 'Mr','Neill','Pat','123 Main Street','Eglinton','Derry','BT48 6YY','02871123654')
		
		SET @TableName = 'Dog'
		INSERT INTO Dog VALUES
		(5020, 'Murphy', 210, '20150915','M','Brindle', 10021),
		(5021, 'Sadie', 210, '20130207','F','Brown & White', 10021)
		
		SET @TableName = 'Booking'
		INSERT INTO Booking VALUES
		(60012, 10021, '20171122', '20171205', 5)
		
		SET @TableName = 'BookingDetail'
		INSERT INTO BookingDetail VALUES
		(60012, 5018, 102),
		(60012, 5019, 103)
		
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		PRINT 'An error occurred at the ' + @TableName
			+ ' table insert.  Row/s not inserted'
		PRINT 'Error number:  ' + CONVERT(varchar, ERROR_NUMBER())
		PRINT 'Error message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH




--INSERT INTO MULTIPLE TABLES USING
--SAVEPOINTS, IE, TRANSACTION ROLLS BACK
--TO A PARTICULAR POINT IN THE TRANSACTION
BEGIN TRAN
	BEGIN TRY

		DECLARE @TableName varchar(15)
		
		SET @TableName = 'Customer'
		INSERT INTO Customer VALUES
		(10025, 'Mrs','Deeney','Teresa','123 Main Street','Eglinton','Derry','BT48 6YY','02871123654')
		SAVE TRAN SP1

		SET @TableName = 'Dog'
		INSERT INTO Dog VALUES
		(5020, 'Murphy', 210, '20150915','M','Brindle', 10021),
		(5021, 'Sadie', 210, '20130207','F','Brown & White', 10021)
		SAVE TRAN SP2

		SET @TableName = 'Booking'
		INSERT INTO Booking VALUES
		(60012, 10021, '20171122', '20171205', 5)
		SAVE TRAN SP3

		SET @TableName = 'BookingDetail'
		INSERT INTO BookingDetail VALUES
		(60012, 5018, 102),
		(60012, 5019, 103)
		
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		PRINT 'An error occurred at the ' + @TableName
			+ ' table insert.  Row/s not inserted'
		PRINT 'Error number:  ' + CONVERT(varchar, ERROR_NUMBER())
		PRINT 'Error message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN SP2
		COMMIT TRAN
	END CATCH

