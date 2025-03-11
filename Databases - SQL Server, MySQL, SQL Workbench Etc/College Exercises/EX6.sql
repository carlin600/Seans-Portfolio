--1.	Create the following database and name it StockControl:
--DROP DATABASE StockControl

 CREATE DATABASE StockControl

 USE StockControl

  CREATE TABLE Supplier
 (
	SupplierNo			INT				NOT NULL,
	SuppName			VARCHAR(30)		NOT NULL,
	Street				VARCHAR(30)		NOT NULL,
	Town				VARCHAR(30)		NOT NULL,
	County				VARCHAR(30)		NOT NULL,
	PostCode			VARCHAR(30)		NOT NULL,
	TelNo				VARCHAR(15)		NOT NULL,

	CONSTRAINT pkSupplierNo PRIMARY KEY (SupplierNo)
 )

 CREATE TABLE Category
 (
	CategoryNo		INT			NOT NULL,
	CategoryName	VARCHAR(30)	NOT NULL,

	CONSTRAINT pkCategoryNo PRIMARY KEY (CategoryNo)
 )

 CREATE TABLE Stock
 (
	StockNo				INT				NOT NULL,
	StockDesc			VARCHAR (30)	NOT NULL,
	CategoryNo			INT				NOT NULL,
	QTY					INT				NOT NULL,
	CostPrice			MONEY			NOT NULL,
	SellingPrice		MONEY			NOT NULL,
	ReorderLevel		INT				NOT NULL, 
	ReorderQty			INT				NOT NULL,
	SupplierNo			INT				NOT NULL

	CONSTRAINT pkStockNo PRIMARY KEY (StockNo),
	CONSTRAINT fkCategoryNo FOREIGN KEY (CategoryNo) REFERENCES Category (CategoryNo),
	CONSTRAINT fkSupplierNo FOREIGN KEY (SupplierNo) REFERENCES Supplier (SupplierNo)
 )


--2.	Populate it as follows:

INSERT INTO Supplier VALUES
(1, 'Paper Mill', '12 Strand Road', 'Derry', 'Co Derry', 'BT48 7YU', '02871362519'),
(2, 'Ink & Co', '1 Low Road', 'Strabane', 'Co Tyrone', 'BT56 9YU', '02871259768'),
(3, 'Computer Systems', '121 Great James Street', 'Derry', 'Co Derry', 'BT48 7YE', '02871315987'),
(4, 'General Supplies', '11 High Road', 'Stabane', 'Co Tyrone', 'BT56 7YU', '02871359786')


INSERT INTO Category VALUES
(10, 'Paper'),
(11, 'Pens'),
(12, 'Computer Material'),
(13, 'Misc')


INSERT INTO Stock VALUES
(1001, 'A4 pads (100)', 10, 30, 20.00, 30.55, 20, 10, 1),
(1002, 'A3 pads (100)', 10, 20, 25.00, 34.45, 20, 10, 1), 
(1003, 'A5 pads (100)', 10, 15, 30.00, 42.77, 20, 10, 1),
(1004, 'A2 pads (100)', 10, 34, 11.20, 16.74, 20, 10, 1),
(1005, 'Plain Env Box(500)', 10, 22, 11.15, 18.57, 20, 10, 1),
(1006, 'Window Env Box(500)', 10, 50, 12.50, 21.38, 20, 10, 1),
(1007, 'Red Biro (100)', 11, 54, 11.50, 15.52, 30, 10, 2),
(1008, 'Green Biro (100)', 11, 45, 12.15, 16.13, 20, 10, 2),
(1009, 'NOBO Pens Black (100)', 11, 35, 10.50, 15.27, 30, 10, 2),
(1010, 'NOBO Pens Red (100)', 11, 20, 10.50, 15.27, 30, 10, 2),
(1011, 'NOBO Pens Blue (100)', 11, 25, 10.50, 15.27, 30, 10, 2),
(1012, 'Marker Black Perm (100)', 11, 15, 11.50, 15.27, 10, 10, 2),
(1013, 'Marker Red Perm (100)', 11, 22, 12.50, 16.49, 15, 10, 2),
(1014, 'Marker Green Perm (100)', 11, 2, 12.50, 16.49, 10, 10, 2),
(1015, 'Blk Ink Cartridge (50)', 12, 50, 40.50, 64.16, 10, 10, 3),
(1016, 'Red Ink Cartridge (50)', 12, 35, 52.50, 66.60, 30, 10, 3),
(1017, 'Green Ink Cartridge (50)', 12, 44, 55.50, 70.27, 40, 10, 3),
(1018, 'Mouse', 12, 144, 8.50, 11.61, 40, 10, 3),
(1019, 'Mouse Pads (50)', 12, 53, 37.50, 46.05, 40, 10, 3),
(1020, 'Keyboards', 12, 55, 11.50, 15.27, 40, 10, 3),
(1021, 'Keyboards Wireless', 12, 115, 13.50, 18.94, 100, 10, 3),
(1022, 'Video Camera', 12, 25, 20.50, 27.49, 40, 10, 3),
(1023, 'Speaker Set', 12, 45, 23.50, 31.16, 40, 10, 3),
(1024, 'Micro-phone', 12, 25, 9.50, 12.83, 20, 10, 3),
(1025, 'Staples (25mm) BX 50', 13, 145, 7.50, 11.61, 140, 10, 4),
(1026, 'Staples (50mm) BX 50', 13, 125, 3.50, 5.49, 120, 10, 4),
(1027, 'Staples (100mm) BX 50', 13, 118, 3.50, 17.72, 120, 10, 4),
(1028, 'Hole Punch A4',	13, 22, 9.50, 12.83, 20, 10, 4),
(1029, 'Hole Punch A3', 13, 20, 9.50, 12.83, 20, 10, 4),
(1030, 'Hole Punch A5', 13, 25, 9.50, 12.83, 20, 10, 4),
(1031, 'Purchase Ledger', 13, 34, 19.50, 25.05, 30, 10, 4),
(1032, 'Sales Ledger', 13, 24, 19.50, 25.05, 30, 10, 4),
(1033, 'Nominal Ledger', 13, 24, 19.50, 25.05, 30, 10, 4)


--3.	Display the following:----------------------------------------

--1.	Supplier list, ordered by supplier name
		SELECT *
		FROM Supplier
		ORDER BY SuppName

--2.	Category list, ordered by category name
		SELECT *
		FROM Category
		ORDER BY CategoryName

--3.	Stock list, ordered by stock description
		SELECT *
		FROM Stock
		ORDER BY StockDesc

--4.	List value of all stock items to include description, quantity in stock, cost price and stock value, ordered by description
		SELECT StockDesc, QTY, SUM (CostPrice + QTY) AS StockValue
		FROM Stock
		GROUP BY StockDesc, QTY


--5.	List of expected profit from items in stock to include description, quantity in stock, cost price, profit, ordered by description
		SELECT StockDesc, QTY, CostPrice, ((SellingPrice - CostPrice) * QTY) AS ExpectedProfit
		FROM Stock 
		ORDER BY StockDesc

--6.	List of items which need reordered including stock number, description and reorder quantity, ordered by stock number

		--what? See teresa

		
--7.	List of stock items costing between £10.00 and £20.00
		SELECT * 
		FROM Stock
		WHERE CostPrice BETWEEN 10 AND 20

--8.	List of stock items with description beginning with N
		SELECT *
		FROM Stock
		WHERE StockDesc LIKE 'N%'

--9.	List of stock items valued between £50.00 and £70.00
		SELECT StockDesc, QTY, SUM (CostPrice + QTY) AS StockValue
		FROM Stock
		WHERE CostPrice BETWEEN 50 AND 70
		--SEE TERESA

--10.	Stock description of all items in each category to include category and stock description, ordered by category and stock description
		SELECT s.StockDesc,
		c.CategoryName

		FROM Stock s
		JOIN Category c ON s.CategoryNo = c.CategoryNo

		ORDER BY c.CategoryName,s.StockDesc

--11.	Stock description of all items in the Pens category to include category and stock description, ordered by category and stock description
		SELECT s.StockDesc,
		c.CategoryName

		FROM Stock s
		JOIN Category c ON s.CategoryNo = c.CategoryNo
		WHERE c.CategoryName = 'Pens'
		ORDER BY c.CategoryName,s.StockDesc

--12.	Stock description of all items supplied by each supplier to include supplier name and stock description, ordered by supplier name and stock description
		SELECT st.StockDesc,
		sup.SuppName

		FROM Stock st
		JOIN Supplier sup ON st.SupplierNo = sup.SupplierNo
		ORDER BY sup.SuppName,st.StockDesc

		--see teresa about order shown

--13.	Stock description of all items supplied by Paper Mill to include supplier name and stock description, ordered by supplier name and stock description
		SELECT st.StockDesc,
		sup.SuppName

		FROM Stock st
		JOIN Supplier sup ON st.SupplierNo = sup.SupplierNo
		WHERE sup.SuppName = 'Paper Mill'
		ORDER BY sup.SuppName,st.StockDesc

--14.	A full list of stock details including category name and supplier name
		SELECT s.StockDesc,
		c.CategoryName,
		sup.SuppName

		FROM Stock s
		JOIN Category c ON s.CategoryNo = c.CategoryNo
		JOIN Supplier sup ON s.SupplierNo = sup.SupplierNo

--15.	A count of the number of stock items in each category
		SELECT c.CategoryName,
		COUNT (s.QTY) AS NoOfStock
		FROM Category c
		JOIN Stock s ON c.CategoryNo = s.CategoryNo
		GROUP BY C.CategoryName

--16.	A count of the number of stock items supplied by each supplier
		SELECT c.CategoryName,
		sup.SuppName,

		COUNT (s.QTY) AS NoOfStock
		FROM Category c
		JOIN Stock s ON c.CategoryNo = s.CategoryNo
		JOIN Supplier sup ON s.SupplierNo = sup.SupplierNo

		GROUP BY C.CategoryName, sup.SuppName

--17.	A count of the number of items in the Paper category
		SELECT c.CategoryName,
		sup.SuppName,

		COUNT (s.QTY) AS NoOfStock
		FROM Category c
		JOIN Stock s ON c.CategoryNo = s.CategoryNo
		JOIN Supplier sup ON s.SupplierNo = sup.SupplierNo

		WHERE c.CategoryName LIKE '%Paper%'

		GROUP BY C.CategoryName, sup.SuppName


--18.	A count of the number of stock items supplied by Ink & Co
		SELECT c.CategoryName,
		sup.SuppName,

		COUNT (s.QTY) AS NoOfStock
		FROM Category c
		JOIN Stock s ON c.CategoryNo = s.CategoryNo
		JOIN Supplier sup ON s.SupplierNo = sup.SupplierNo

		WHERE sup.SuppName = 'Ink & Co'

		GROUP BY C.CategoryName, sup.SuppName

--19.	The total stock value by category
		SELECT c.CategoryName,
		SUM (s.CostPrice + s.QTY) AS StockValue
		FROM Category c

		JOIN Stock s ON c.CategoryNo = s.CategoryNo

		GROUP BY C.CategoryName


--20.	The total stock value of all items in the stock table
		SELECT StockNo,
		SUM (CostPrice + QTY) AS StockValue
		FROM Stock
		GROUP BY StockNo
		--see teresa