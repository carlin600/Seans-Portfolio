CREATE DATABASE InTheDogHouse    
--GO
DROP DATABASE InTheDogHouse



use InTheDogHouse
GO



IF OBJECT_ID ('Payment') IS NOT NULL
	DROP table Payment
GO

IF OBJECT_ID ('BookingDetail') IS NOT NULL
	DROP table BookingDetail
GO

IF OBJECT_ID ('Booking') IS NOT NULL
	DROP table Booking
GO

IF OBJECT_ID ('Kennel') IS NOT NULL
	DROP table Kennel
GO

IF OBJECT_ID ('Dog') IS NOT NULL
	DROP table Dog
GO
 
IF OBJECT_ID ('Customer') IS NOT NULL
	DROP table Customer
GO

IF OBJECT_ID ('Breed') IS NOT NULL
	DROP table Breed
GO

IF OBJECT_ID ('Method') IS NOT NULL
	DROP table Method
GO

IF OBJECT_ID ('Size') IS NOT NULL
	DROP table Size
GO


CREATE TABLE Method 
(
	MethodNo		int				NOT NULL,
	MethodDesc		varchar(10)		NOT NULL,
	
	CONSTRAINT pkMethodNo PRIMARY KEY (MethodNo),

	CONSTRAINT unqMethodDesc UNIQUE (MethodDesc)
)

CREATE TABLE Size 
(
	SizeNo			int 		NOT NULL,
	ChargePerDay	money		NOT NULL,	

	CONSTRAINT pkSize PRIMARY KEY (SizeNo),

	CONSTRAINT chkSizeCharge CHECK (ChargePerDay between 2.50 and 10.00)
)

CREATE TABLE Kennel 
(
	KennelNo		int			NOT NULL,
	SizeK			int			NOT NULL,
	
	CONSTRAINT pkKennelNo PRIMARY KEY (KennelNo),
	CONSTRAINT fkKennelSize	FOREIGN KEY (SizeK) REFERENCES Size (SizeNo)
)

CREATE TABLE Breed 
(
	BreedNo				int					NOT NULL,
	BreedName			varchar(50)			NOT NULL,
	SizeB				int 				NOT NULL,

	CONSTRAINT pkBreedNo PRIMARY KEY (BreedNo),
	CONSTRAINT unqBreedName unique (BreedName),
	CONSTRAINT fkBreedSize	FOREIGN KEY (SizeB) REFERENCES Size (SizeNo)
)

CREATE TABLE Customer
(
	CustomerNo		int				NOT NULL,
	Title			varchar(4)			NOT NULL,
	Surname			varchar(20)			NOT NULL,
	Forename		varchar(20)			NOT NULL,
	Street			varchar(30)			NOT NULL,
	Town			varchar(30)			NOT NULL,
	County			varchar(30)			NOT NULL,
	PostCode		varchar(8)			NOT NULL,
	TelNo			varchar(11)			NOT NULL,
	
	CONSTRAINT pkCustNo PRIMARY KEY (CustomerNo),

	CONSTRAINT chkTitle CHECK (Title IN ('Mr','Mrs','Miss','Ms')),
	CONSTRAINT chkPostcode CHECK (Postcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),
	CONSTRAINT chkTelNo CHECK (TelNo LIKE REPLICATE('[0-9]', 11))
)

CREATE TABLE Dog
(
	DogNo		int					NOT NULL,
	Name		varchar(15)			NOT NULL,
	BreedNo		int					NOT NULL,
	DOB			date				NOT NULL,
	Gender		char				NOT NULL,
	Colour		varchar(20)			NOT NULL,
	CustomerNo	int					NOT NULL,
	
	CONSTRAINT pkDogNo PRIMARY KEY (DogNo),
	CONSTRAINT fkBreedNo FOREIGN KEY(BreedNo) REFERENCES Breed(BreedNo),
	CONSTRAINT fkcustomerNo	FOREIGN KEY (CustomerNo) REFERENCES Customer(CustomerNo),

	CONSTRAINT chkDOB CHECK (DOB >= dateAdd(Year, -17, getDate())and DOB < getDate()),
	CONSTRAINT chkGender CHECK(Gender in('M','F'))

)

CREATE TABLE Booking 
(
	BookingNo		int					NOT NULL,
	CustomerNo		int					NOT NULL,
	DateBooked		datetime			NOT NULL,
	DateStart		datetime			NOT NULL,
	NoDays			int					NOT NULL,
	
	CONSTRAINT pkBookingNo PRIMARY KEY (BookingNo),
	CONSTRAINT fkCustomerNo2 FOREIGN KEY (CustomerNo) REFERENCES Customer (CustomerNo),

	CONSTRAINT chkDOB2 CHECK (DateStart >= DateBooked ),
	CONSTRAINT chkNoDays CHECK (NoDays > 0)
)

CREATE TABLE BookingDetail 
(
	BookingNo		int	 			NOT NULL,
	DogNo			int				NOT NULL,
	KennelNo		int				NOT NULL,

	CONSTRAINT pkBookingDet PRIMARY KEY (BookingNo, DogNo),
	CONSTRAINT fkBookingNo FOREIGN KEY (BookingNo) REFERENCES Booking (BookingNo),
	CONSTRAINT fkDogNo FOREIGN KEY (DogNo) REFERENCES Dog (DogNo),
	CONSTRAINT fkKennelNo FOREIGN KEY (KennelNo) REFERENCES Kennel (KennelNo),
)

CREATE TABLE Payment 
(
	PaymentNo		int				NOT NULL,
	BookingNo		int				NOT NULL,
	MethodNo		int				NOT NULL,
	Amount			money			NOT NULL,
	DatePaid		date			NOT NULL,
	
	
	CONSTRAINT pkPaymentNo PRIMARY KEY (PaymentNo),
	CONSTRAINT fkBookingNo2 FOREIGN KEY (BookingNo) REFERENCES Booking (BookingNo),
	CONSTRAINT fkMethodNo FOREIGN KEY (MethodNo) REFERENCES Method (MethodNo),

	CONSTRAINT chkAmount CHECK (Amount > 0),
	CONSTRAINT chkDatePaid CHECK (DatePaid >= GetDate())
)



 --populating customer table
INSERT INTO customer (CustomerNo, Title, Surname, Forename, Street, Town, County, PostCode, TelNo) VALUES 
(10000, 'Mr', 'Morrison', 'Brenden', '159 Main Street','Eglinton','Co Derry','BT47 4TB', '02871261548'),   
(10001, 'Miss', 'Rankin', 'Kathy', '56 Greenhaven','Drumahoe','Co Derry','BT48 3SY', '02871346562'),  
(10002, 'Mr', 'Carlin', 'Patrick', '98 Larch Road','Greysteel','Co Derry','BT47 4TB', '02871249876'), 
(10003, 'Mr', 'Cunning', 'Tom', '115 NewLine Road','Newbuildings','Co Derry','BT47 4TB', '02871375921'), 
(10004, 'Mr', 'Wilson', 'Robert', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB', '07561020748'), 
(10005, 'Mr', 'Lynch', 'Conan', '126 Dungiven Road','Derry','Co Derry','BT47 4TB', '02871361782'),
(10006, 'Mrs', 'Collins', 'Joanne', '62 Limavady Road','Derry','Co Derry','BT47 4TB', '02871267183'),
(10007, 'Mr', 'Gallagher', 'Adam', '76 Church Brae','Derry','Co Derry','BT47 4TB', '02871348527'),
(10008, 'Mrs', 'Costello', 'Niamh', '34 Strand Road','Derry','Co Derry','BT47 4TB', '07865255486'), 
(10009, 'Mr', 'Doherty', 'Kevin', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB', '07759631458'),
(10010, 'Miss', 'Heaney', 'Amanda', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB', '07566584748'), 
(10011, 'Mr', 'Evans', 'Rory', '70 Rosewood Avenue','Derry','Co Derry','BT47 4TB', '02871346582'),
(10012, 'Mr', 'Coyle', 'Stephen', '32 Culmore Road','Derry','Co Derry','BT47 4TB', '07756914238'), 
(10013, 'Mr', 'Murray', 'Mark', '4b Enfield Street','Derry','Co Derry','BT47 4TB', '07925688149'), 
(10014, 'Mr', 'Donaghy', 'Martin', '582 Duncrun Road','Limavady','Co Derry','BT47 4TB', '02877741596'), 
(10015, 'Miss', 'Jenkins', 'Hannah', '94 Carrickbeg Avenue','Eglinton','Co Derry','BT47 4TB', '02871362894'), 
(10016, 'Mrs', 'Matthews', 'Louise', '241 Clagan Road','Claudy','Co Derry','BT47 4TB', '07774698315'), 
(10017, 'Miss', 'Cartin', 'Charlene', '200 Rallagh Road','Dungiven','Co Derry','BT47 4TB', '07892579143'), 
(10018, 'Mr', 'Holmes', 'Kieran', '34 Spencer Road','Waterside','Co Derry','BT47 4TB', '07985020748') 

SELECT * FROM customer

 --populating size table
INSERT INTO size (sizeNo, chargePerDay) VALUES 
(1, 5.00),   
(2, 6.50),  
(3, 8.00), 
(4, 10.00)

SELECT * FROM size

 --populating breed table
INSERT INTO breed (BreedNo, BreedName, SizeB) VALUES 
(200, 'Labrador', 3),   
(201, 'Alaskan Malamute', 3),  
(202, 'St Bernard', 4), 
(203, 'Poodle', 1), 
(204, 'Border Collie', 2), 
(205, 'Shih Tzu', 1),
(206, 'Alsatian', 3),
(207, 'Bulldog', 2),
(208, 'German Shepherd', 3), 
(209, 'Jack Russell', 1),
(210, 'Boxer', 2),
(211, 'Pug', 1)

SELECT * FROM breed

 --populating dog table
INSERT INTO dog (DogNo, Name, BreedNo, DOB, Gender, Colour, CustomerNo) VALUES 
(5000, 'Akira', 201, '20100815', 'F', 'Black & White', 10000),   
(5001, 'Aurora', 201, '20140321', 'F', 'Grey',10000),  
(5002, 'Mischa', 205, '20100214', 'F', 'White',10000), 
(5003, 'Charlie', 210, '20110913', 'M', 'Brown',10002), 
(5004, 'Diesel', 208, '20120630', 'M', 'Brown & Black',10002), 
(5005, 'Fluffy', 203, '20130311', 'F', 'White',10001),
(5006, 'Max', 204, '20140815', 'M', 'Black',10004),
(5007, 'Bob', 204, '20140815', 'M', 'Black',10004),
(5008, 'Storm', 207, '20121107', 'M', 'White',10003), 
(5009, 'Darcy', 200, '20080422', 'F', 'Golden',10005),
(5010, 'Roxy', 210, '20110505', 'F', 'Tan',10006), 
(5011, 'Ayras', 209, '20060327', 'F', 'Brown & White',10007),
(5012, 'King', 206, '20111209', 'M', 'Brown & Black',10008), 
(5013, 'Duke', 202, '20120113', 'M', 'Tan & White',10009), 
(5014, 'Diego', 211, '20131118', 'M', 'White',10009),
(5015, 'Milo', 201, '20100815', 'M', 'Black & White', 10000)

SELECT * FROM dog


 --populating kennel table
INSERT INTO kennel (KennelNo, SizeK) VALUES 
(100, 3),   
(101, 3),  
(102, 3), 
(103, 4), 
(104, 2), 
(105, 2),
(106, 1),
(107, 3),
(108, 4)

SELECT * FROM kennel



 --populating booking
INSERT INTO booking(BookingNo, CustomerNo, DateBooked, DateStart, NoDays) VALUES 
(60000, 10000, '20141017', '20141022', 4),   
(60001, 10009, '20141020', '20141025', 2),  
(60002, 10004, '20141104', '20141111', 7), 
(60003, 10001, '20141116', '20141201', 3), 
(60004, 10000, '20141117', '20141122', 4), 
(60005, 10008, '20141208', '20141214', 2),
(60006, 10003, '20141210', '20141211', 3),
(60007, 10005, '20150108', '20150113', 7),
(60008, 10000, '20150117', '20150122', 4),
(60009, 10001, '20150210', '20150222', 4)

SELECT * FROM booking




 --populating bookingDetail
INSERT INTO bookingDetail(bookingNo, dogNo, kennelNo) VALUES 
(60000, 5000, 101),   
(60000, 5001, 102),  
(60001, 5013, 104), 
(60002, 5006, 105), 
(60002, 5007, 106), 
(60003, 5004, 107),
(60004, 5000, 101),
(60004, 5001, 102),
(60005, 5012, 101),
(60006, 5010, 105),
(60007, 5009, 108),
(60008, 5000, 103),
(60008, 5001, 108),
(60009, 5004, 107)


SELECT * FROM bookingDetail


	
	
