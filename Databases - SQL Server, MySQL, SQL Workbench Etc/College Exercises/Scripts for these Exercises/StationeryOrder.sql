create database StationeryOrder

use StationeryOrder
CREATE TABLE Supplier
(
	SupplierNo		int			NOT NULL,
	SuppName		varchar(40) NOT NULL,
	Street			varchar(30) NOT NULL,
	Town			varchar(30) NOT NULL,
	County			varchar(30) NOT NULL,
	Postcode		varchar(15) NOT NULL,
	TelNo			varchar(15) NOT NULL,

	CONSTRAINT pkSuppNo PRIMARY KEY (SupplierNo)
); 
 

CREATE TABLE Category
(
	CategoryNo		int			NOT NULL,
	CategoryName	varchar(30) NOT NULL,

	CONSTRAINT pkCatNo PRIMARY KEY (CategoryNo)
);

 
CREATE TABLE Stock
(
	StockNo			int			NOT NULL,
	StockDesc		varchar(40) NOT NULL,
	CategoryNo		int			NOT NULL,
	Qty				int			NOT NULL,
	CostPrice		money		NOT NULL,
	SellingPrice	money		NOT NULL,
	ReorderLevel	int			NOT NULL,
	ReorderQty		int			NOT NULL,
	SupplierNo		int			NOT NULL,

	CONSTRAINT pkStockNo PRIMARY KEY (StockNo),
	CONSTRAINT fkCategoryNo	FOREIGN KEY (CategoryNo) REFERENCES Category (CategoryNo),
	CONSTRAINT fkSupplierNo FOREIGN KEY (SupplierNo) REFERENCES Supplier (SupplierNo)
);


create table Customer
(
	CustomerNo		int	identity(1000,1)	not null,
	Title			varchar(4)			not null,
	Surname			varchar(20)			not null,
	Forename		varchar(20)			not null,
	Street			varchar(30)			not null,
	Town			varchar(30)			null,
	County			varchar(30)			null,
	PostCode		varchar(8)			null,
	TelNo			varchar(14)			null,
	
	constraint pkCustNo primary key (CustomerNo),

	constraint chkTitle check (Title in('MR','MRS','MISS','Ms'))
	
);


create table CustOrder 
(
	OrderNo			int				not null,
	CustomerNo		int				not null,
	OrderDate		date			not null,
	
	constraint pkOrderNo primary key (OrderNo),
	constraint fkCustomerNo foreign key (CustomerNo) references Customer (CustomerNo)
);


create table OrderDetail 
(
	OrderNo			int	 			not null,
	StockNo			int				not null,
	QtyOrdered		int				not null,

	constraint pkOrderDet primary key (OrderNo, StockNo),
	constraint fkOrderNo foreign key (OrderNo) references CustOrder (OrderNo),
	constraint fkStockNo foreign key (StockNo) references Stock (StockNo)
);



INSERT INTO Supplier VALUES
(1, 'Paper Mill', '12 Strand Road', 'Derry', 'Co Derry', 'BT48 7YU', '02871362519'),
(2, 'Ink & Co', '1 Low Road', 'Strabane', 'Co Tyrone', 'BT56 9YU', '02871259768'),
(3, 'Computer Systems', '121 Great James Street', 'Derry', 'Co Derry', 'BT48 7YE', '02871315987'),
(4, 'General Supplies', '11 High Road', 'Stabane', 'Co Strabane', 'BT56 7YU', '02871359786'),
(5, 'EPS', '159 Main Street', 'Eglinton', 'Co Derry', 'BT48 7YU', '02871346562'),
(6, 'Derry Paper Products', '56 Greenhaven', 'Drumahoe', 'Co Derry', 'BT48 3SY', '02871249876'),
(7, 'Greysteel Inc', '98 Larch Road', 'Greysteel', 'Co Derry', 'BT47 4TB', '02871375921'),
(8, 'Office Requirements', '115 NewLine Road', 'Newbuildings', 'Co Derry', 'BT47 4TB', '07561020748')



insert into customer values 
('Mr', 'Wilson', 'Robert', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB', ''), 
('Mr', 'Lynch', 'Conan', '126 Dungiven Road','Derry','Co Derry','BT47 4TB', '02871361782'),
('Mrs', 'Collins', 'Joanne', '62 Limavady Road','Derry','Co Derry','BT47 4TB', '02871267183'),
('Mr', 'Gallagher', 'Adam', '76 Church Brae','Derry','Co Derry','BT47 4TB', '02871348527'),
('Mrs', 'Costello', 'Niamh', '34 Strand Road','Derry','Co Derry','BT47 4TB', '07865255486'), 
('Mr', 'Doherty', 'Kevin', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB', '07759631458'),
('Miss', 'Heaney', 'Amanda', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB', '07566584748'), 
('Mr', 'Evans', 'Rory', '70 Rosewood Avenue','Derry','Co Derry','BT47 4TB', '02871346582'),
('Mr', 'Coyle', 'Stephen', '32 Culmore Road','Derry','Co Derry','BT47 4TB', '07756914238'), 
('Mr', 'Murray', 'Mark', '4b Enfield Street','Derry','Co Derry','BT47 4TB', '07925688149'), 
('Mr', 'Donaghy', 'Martin', '582 Duncrun Road','Limavady','Co Derry','BT47 4TB', '02877741596'), 
('Miss', 'Jenkins', 'Hannah', '94 Carrickbeg Avenue','Eglinton','Co Derry','BT47 4TB', '02871362894'), 
('Mrs', 'Matthews', 'Louise', '241 Clagan Road','Claudy','Co Derry','BT47 4TB', '07774698315'), 
('Miss', 'Cartin', 'Charlene', '200 Rallagh Road','Dungiven','Co Derry','BT47 4TB', '07892579143'), 
('Mr', 'Holmes', 'Kieran', '34 Spencer Road','Waterside','Co Derry','BT47 4TB', '07985020748') 


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
(1008, 'Green Biro (100)', 11, 0, 12.15, 16.13, 20, 10, 2),
(1009, 'NOBO Pens Black (100)', 11, 35, 10.50, 15.27, 30, 10, 2),
(1010, 'NOBO Pens Red (100)', 11, 20, 10.50, 15.27, 30, 10, 2),
(1011, 'NOBO Pens Blue (100)', 11, 25, 10.50, 15.27, 30, 10, 2),
(1012, 'Marker Black Perm (100)', 11, 15, 11.50, 15.27, 10, 10, 2),
(1013, 'Marker Red Perm (100)', 11, 22, 12.50, 16.49, 15, 10, 2),
(1014, 'Marker Green Perm (100)', 11, 0, 12.50, 16.49, 10, 10, 2),
(1015, 'Blk Ink Cartridge (50)', 12, 50, 40.50, 64.16, 10, 10, 3),
(1016, 'Red Ink Cartridge (50)', 12, 35, 52.50, 66.60, 30, 10, 3),
(1017, 'Green Ink Cartridge (50)', 12, 44, 55.50, 70.27, 40, 10, 3),
(1018, 'Mouse', 12, 144, 8.50, 11.61, 40, 10, 3),
(1019, 'Mouse Pads (50)', 12, 53, 37.50, 46.05, 40, 10, 3),
(1020, 'Keyboards', 12, 55, 11.50, 15.27, 40, 10, 3),
(1021, 'Keyboards Wireless', 12, 115, 13.50, 18.94, 100, 10, 3),
(1022, 'Video Camera', 12, 25, 20.50, 27.49, 40, 10, 3),
(1023, 'Speaker Set', 12, 0, 23.50, 31.16, 40, 10, 3),
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


insert into CustOrder values
(10000, 1013, '20141012'),
(10004, 1001, '20141210'),
(10005, 1007, '20141022'),
(10006, 1009, '20141029'),
(10007, 1013, '20141102'),
(10008, 1009, '20141113'),
(10009, 1004, '20141119'),
(10010, 1005, '20141125'),
(10012, 1009, '20141130'),
(10013, 1007, '20141204'),
(10014, 1013, '20141206'),
(10015, 1002, '20141210'),
(10016, 1009, '20141015'),
(10017, 1006, '20150105'),
(10018, 1007, '20150108')


insert into OrderDetail values
(10000, 1033, 5),
(10000, 1029, 5),
(10000, 1012, 10),
(10004, 1004, 15),
(10004, 1007, 12),
(10005, 1010, 12),
(10005, 1011, 12),
(10005, 1012, 12),
(10006, 1023, 3),
(10006, 1032, 5),
(10007, 1006, 50),
(10008, 1011, 10),
(10008, 1012, 10),
(10009, 1001, 4),
(10009, 1002, 4),
(10009, 1003, 4),
(10010, 1015, 25),
(10012, 1003, 5),
(10013, 1001, 20),
(10013, 1018, 15),
(10013, 1026, 20),
(10014, 1029, 10),
(10014, 1030, 15),
(10015, 1013, 8),
(10015, 1031, 2),
(10016, 1008, 30),
(10016, 1028, 15),
(10017, 1010, 110),
(10018, 1028, 10),
(10018, 1030, 10),
(10018, 1032, 10)

