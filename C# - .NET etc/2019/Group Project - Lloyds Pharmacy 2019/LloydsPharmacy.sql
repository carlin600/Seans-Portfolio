

DROP DATABASE LloydsPharmacy

CREATE DATABASE LloydsPharmacy
USE LloydsPharmacy


SELECT * FROM Sales
Delete FROM SupplierOrderDetails WHERE SupplierOrderID = 'SO103'  AND StockID = 'ST118'


INSERT INTO SupplierOrderDetails(StockID, QTYOrdered) VALUES ('ST149', 5) 

SELECT * FROM Stock WHERE SupplierID = 'SUP101'

SELECT sal.SaleID, sal.StockID, sal.QTYSold, s.StockDesc
                                  FROM SaleDetails sal
                                  JOIN Stock s ON sal.StockID = s.StockID
                                  WHERE SaleID = 'S101'
-------- S E A N ----------------------------------------------------------------------------------------------

CREATE TABLE PaymentType
(
	PaymentTypeID	VARCHAR(8)		NOT NULL,
	PaymentTypeDesc	VARCHAR(25)		NOT NULL

	CONSTRAINT pkPaymentTypeID PRIMARY KEY (PaymentTypeID)

)

CREATE TABLE Supplier
(
	SupplierID		VARCHAR(8)		NOT NULL,
	SupplierName		VARCHAR(50)		NOT NULL,
	SupplierStreet		VARCHAR(50)		NOT NULL,
	SupplierTown		VARCHAR(50)		NOT NULL,
	SupplierCounty		VARCHAR(25)		NOT NULL,
	SupplierPostcode	VARCHAR(8)		NOT NULL,
	SupplierTelNo		VARCHAR(11)		NOT NULL

	CONSTRAINT pkSupplierID PRIMARY KEY (SupplierID),

	CONSTRAINT chkSupplierPostcode CHECK (SupplierPostcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),
	CONSTRAINT chkSupplierTelNo CHECK (SupplierTelNo LIKE REPLICATE('[0-9]', 11))
)

CREATE TABLE SupplierOrder
(
	SupplierOrderID		VARCHAR(8)		NOT NULL,
	SupplierID			VARCHAR(8)		NOT NULL,
	OrderDate			DATE	NOT NULL,
	DispatchDate		DATE	NOT NULL,
	DeliveryDate		DATE	 NULL,
	Paid				BIT		NOT NULL

	CONSTRAINT pkSupplierOrderID PRIMARY KEY(SupplierOrderID),
	CONSTRAINT fkSupplierID FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID),
	CONSTRAINT chkDispatchDate CHECK (DispatchDate >= OrderDate ),
)

CREATE TABLE SupplierPayments
(
	SupplierPaymentID	VARCHAR(8)		NOT NULL,
	SupplierID			VARCHAR(8)		NOT NULL,
	PaymentDate			DATE	 NULL

	CONSTRAINT pkSupplierPaymentID	PRIMARY KEY (SupplierPaymentID)
	CONSTRAINT fkSupplierID2 FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
	--CONSTRAINT chkDatePaid CHECK (PaymentDate >= GetDate())
)

CREATE TABLE SupplierPaymentDetails
(
	SupplierPaymentID	VARCHAR(8)		NOT NULL,
	SupplierOrderID		VARCHAR(8)		NOT NULL,
	PaymentTypeID		VARCHAR(8)		NOT NULL,

	CONSTRAINT pkSupplierPaymentOrderID PRIMARY KEY (SupplierPaymentID,SupplierOrderID),
	CONSTRAINT fkSupplierPaymentID	FOREIGN KEY (SupplierPaymentID) REFERENCES SupplierPayments(SupplierPaymentID),
	CONSTRAINT fkSupplierOrderID4	FOREIGN KEY (SupplierOrderID) REFERENCES SupplierOrder(SupplierOrderID),
	CONSTRAINT fkPaymentTypeID	FOREIGN KEY (PaymentTypeID) REFERENCES PaymentType(PaymentTypeID)

)

CREATE TABLE Sales
(
	SaleID			VARCHAR(8)		NOT NULL,
	SaleDate		DATE			NOT NULL,
	PaymentTypeID	VARCHAR(8)		NOT NULL,

	CONSTRAINT pkSaleID PRIMARY KEY (SaleID),
	CONSTRAINT fkPaymentTypeID1 FOREIGN KEY (PaymentTypeID) REFERENCES PaymentType(PaymentTypeID)


)

----------- J A C K ---------------------------------------------------------------------------------------------------
CREATE TABLE Staff
(
	StaffID			VARCHAR(8)     NOT NULL,
	Title			VARCHAR(4)	   NOT NULL,
	Forename		VARCHAR(20)	   NOT NULL,
	Surname			VARCHAR(30)    NOT NULL,
	Town			VARCHAR(15)    NOT NULL,
	Street			VARCHAR(20)    NOT NULL,
	Postcode		VARCHAR(8)     NOT NULL,
	TelephoneNo		VARCHAR(11)    NOT NULL,
	MobileNo		VARCHAR(11)    NOT NULL,
	Email			VARCHAR(30)	   NOT NULL,

	CONSTRAINT pkStaffID PRIMARY KEY (StaffID),
	CONSTRAINT chkPostcode1 CHECK (Postcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),
	CONSTRAINT chkTelNo CHECK (TelephoneNo LIKE REPLICATE('[0-9]', 11)),
	CONSTRAINT chkMobileNo CHECK (MobileNo LIKE REPLICATE('[0-9]', 11)),
	CONSTRAINT chkTitle CHECK (Title IN ('Mr','Mrs','Miss','Ms')),
)

CREATE TABLE CourseType
(
	CourseTypeID	    VARCHAR(8)     NOT NULL,
	CourseTypeDesc		VARCHAR(9)	   NOT NULL,

CONSTRAINT pkCourseTypeID		PRIMARY KEY (CourseTypeID),

)

CREATE TABLE Courses
(
	CourseID			VARCHAR(20)		NOT NULL,
	CourseDesc			VARCHAR(40)		NOT NULL,
	NoDays				INT				NOT NULL,
	HoursPerDay			FLOAT(2)		NOT NULL,
	CoursePrice			FLOAT(2)		NOT NULL,
	noPatients			INT				NOT NULL,
	CourseTypeID		VARCHAR(8)		NOT NULL,

	CONSTRAINT pkCourseID PRIMARY KEY(CourseID),
	CONSTRAINT fkCourseTypeID	 FOREIGN KEY (CourseTypeID)	 REFERENCES CourseType(CourseTypeID),


)

CREATE TABLE CourseStaff
(
	StaffID					VARCHAR(8)			NOT NULL,
	CourseID				VARCHAR(20)			NOT NULL,
	CourseClassDays			SMALLDATETIME		NOT NULL,

	CONSTRAINT pkStaffCourseID PRIMARY KEY (StaffID, CourseID),
	CONSTRAINT fkStaffID FOREIGN KEY(StaffID) REFERENCES Staff(StaffID),
	CONSTRAINT fkCourseID FOREIGN KEY(CourseID) REFERENCES Courses(CourseID),

)

CREATE TABLE CourseInstance
(
	CourseInstanceID		VARCHAR(8)			NOT NULL,
	CourseID				VARCHAR(20)			NOT NULL,
	CourseStartDate			SMALLDATETIME		NOT NULL,
	CourseStartTime			Float(2)			NOT NULL,
	StaffID					VARCHAR(8)		    NOT NULL,

	CONSTRAINT pkCourseInstanceID PRIMARY KEY (CourseInstanceID),
	CONSTRAINT fkCourseID2        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID), 
	CONSTRAINT fkCourseInstanceStaffID		  FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),


)


-------- C O N O R ------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE Patient
(
	PatientID			VARCHAR(8)		NOT NULL,
	PatientForename		VARCHAR(15)		NOT NULL,
	PatientSurname		VARCHAR(15)		NOT NULL,
	PatientTelNo		VARCHAR(8)		NOT NULL,
	PatientEmail		VARCHAR(23)		NOT NULL,
	PatientStreet		VARCHAR(20)		NOT NULL,
	PatientTown			VARCHAR(20)		NOT NULL,
	PatientCounty		VARCHAR(20)		NOT NULL,
	PatientPostcode		VARCHAR(8)		NOT NULL

	CONSTRAINT pkPatientID PRIMARY KEY (PatientID),
	CONSTRAINT chkPatientID CHECK (PatientID LIKE '[A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9]'),
	CONSTRAINT chkPostcode2 CHECK (PatientPostcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]')
)

CREATE TABLE Prescriptions
(
	PrescriptionID			VARCHAR(8)		NOT NULL,
	PatientID				VARCHAR(8)		NOT NULL,
	PrescriptionDate		SMALLDATETIME	NOT NULL

	CONSTRAINT pkPrescriptionID PRIMARY KEY (PrescriptionID),
	CONSTRAINT fkPatientID1 FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
	CONSTRAINT chkPrescriptionID CHECK (PrescriptionID LIKE '[A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9]')
)

CREATE TABLE MinorAilmentTypes
(
	MinorAilmentsTypeID		VARCHAR(8)		NOT NULL,
	MinorAilmentsTypeDesc	VARCHAR(20)		NOT NULL

	CONSTRAINT pkMinAilmentTypeID PRIMARY KEY (MinorAilmentsTypeID)
)

CREATE TABLE MinorAilments
(
	MinorAilmentID			VARCHAR(8)		NOT NULL,
	MinorAilmentDesc		VARCHAR(25)		NOT NULL,
	MinorAilmentsTypeID		VARCHAR(8)		NOT NULL
	
	CONSTRAINT pkMinorAilmentsID PRIMARY KEY (MinorAilmentID),
	CONSTRAINT fkMinAilTypeID1 FOREIGN KEY (MinorAilmentsTypeID) REFERENCES MinorAilmentTypes(MinorAilmentsTypeID),
)

CREATE TABLE StockType --Sean's Table
(
	StockTypeID				VARCHAR(8)		NOT NULL,
	StockTypeDesc			VARCHAR(30)		NOT NULL,
	MinorAilmentsTypeID		VARCHAR(8)		NULL

	CONSTRAINT pkStockTypeID PRIMARY KEY (StockTypeID),
	CONSTRAINT fkMinAilTypeID2 FOREIGN KEY (MinorAilmentsTypeID) REFERENCES MinorAilmentTypes(MinorAilmentsTypeID)
)

CREATE TABLE Stock -- seans
(
	StockID		VARCHAR(8)	NOT NULL,
	SupplierID	VARCHAR(8)	NOT NULL,
	StockDesc	VARCHAR(50)	NOT NULL,
	StockTypeID	VARCHAR(8)	NOT NULL,
	QTYInStock	INT			NOT NULL,
	StockPrice	MONEY		NOT NULL

	CONSTRAINT pkStockID PRIMARY KEY (StockID),
	CONSTRAINT fkStockTypeID1 FOREIGN KEY (StockTypeID) REFERENCES StockType(StockTypeID),
	CONSTRAINT fkSupplierID3 FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID),
	CONSTRAINT chkQTYInStock CHECK (QTYInStock >= 0),
	CONSTRAINT chkStockPrice CHECK (StockPrice > 0)
	
)

CREATE TABLE SupplierOrderDetails -- seans
(
	SupplierOrderID		VARCHAR(8)		NOT NULL,
	StockID				VARCHAR(8)		NOT NULL,
	QTYOrdered			INT				NOT NULL
	
	CONSTRAINT pkSupplierStockID PRIMARY KEY (SupplierOrderID,StockID),
	CONSTRAINT fkSupplierOrderID1 FOREIGN KEY(SupplierOrderID) REFERENCES SupplierOrder(SupplierOrderID),
	CONSTRAINT fkStockID FOREIGN KEY(StockID) REFERENCES Stock(StockID)

)

CREATE TABLE SaleDetails -- seans
(
	SaleID		VARCHAR(8)	NOT NULL,
	StockID		VARCHAR(8)	NOT NULL,
	QTYSold		INT			NOT NULL

	CONSTRAINT pkSaleStockID PRIMARY KEY (SaleID,StockID),
	CONSTRAINT fkSaleID FOREIGN KEY(SaleID) REFERENCES Sales(SaleID),
	CONSTRAINT fkStockID1 FOREIGN KEY(StockID) REFERENCES Stock(StockID),
	CONSTRAINT chkQTYSold CHECK (QTYSold > 0)
)

CREATE TABLE PrescriptionDetails
(
	PrescriptionID			VARCHAR(8)		NOT NULL,
	StockID					VARCHAR(8)		NOT NULL,
	Delivery				VARCHAR(3)		NOT NULL,
	RecurringPrescription	VARCHAR(3)		NOT NULL

	CONSTRAINT pkPrescriptionStockID PRIMARY KEY (PrescriptionID, StockID),
	CONSTRAINT fkPrescriptionID FOREIGN KEY (PrescriptionID) REFERENCES Prescriptions(PrescriptionID),
	CONSTRAINT fkStockID2 FOREIGN KEY (StockID) REFERENCES Stock(StockID)
)

CREATE TABLE CustomerMinAilments
(
	CustomerMinAilmentID	VARCHAR(8)		NOT NULL,
	PatientID				VARCHAR(8)		NOT NULL,
	DateAdministrated		SMALLDATETIME	NOT NULL

	CONSTRAINT pkCustMinAilmentID PRIMARY KEY (CustomerMinAilmentID, PatientID),
	CONSTRAINT fkPatientID2 FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
	CONSTRAINT chkMinorAilmentID CHECK (CustomerMinAilmentID LIKE '[A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9]')
)

CREATE TABLE CustomerMinAilDetails
(
	MinorAilmentID			VARCHAR(8)		NOT NULL,
	Qty						INT				NOT NULL

	CONSTRAINT pkCustMinAilDetID PRIMARY KEY (MinorAilmentID),
	CONSTRAINT fkMinorAilmentsID FOREIGN KEY (MinorAilmentID) REFERENCES MinorAilments(MinorAilmentID),
	CONSTRAINT chkQty CHECK (Qty > 0 AND Qty < 50)
)

CREATE TABLE CustomerMinStockDetails
(
	CustMinAilmentID		VARCHAR(8)		NOT NULL,
	MinorAilmentID			VARCHAR(8)		NOT NULL,
	StockID					VARCHAR(8)		NOT NULL,
	Qty						INT				NOT NULL

	CONSTRAINT pkCustMinAilID PRIMARY KEY (CustMinAilmentID, MinorAilmentID, StockID),
	CONSTRAINT fkStockMinAilmentsID FOREIGN KEY (MinorAilmentID) REFERENCES MinorAilments(MinorAilmentID),
	CONSTRAINT fkStockID3 FOREIGN KEY (StockID) REFERENCES Stock(StockID)
)

CREATE TABLE CourseInstanceDetails --jacks table
(
	PatientID			VARCHAR(8)		NOT NULL,
	CourseInstanceID    VARCHAR(8)		NOT NULL,

	CONSTRAINT pkPatientCourseID PRIMARY KEY (PatientID,CourseInstanceID),
	CONSTRAINT fkPatientID FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
	CONSTRAINT fkCourseInstanceID FOREIGN KEY (CourseInstanceID) REFERENCES CourseInstance(CourseInstanceID)

)

----------P O P U L A T I N G - - - -  C O D E---------------------

INSERT INTO PaymentType(PaymentTypeID, PaymentTypeDesc) VALUES
('CA','Cash'),
('AX','American Express'),
('CK','Cheque'),
('DB','Direct Bill'),
('MC','Mastercard'),
('VA','Visa'),
('PP','Paypal'),
('BT','Bank Transfer')

INSERT INTO Supplier(SupplierID,SupplierName,SupplierStreet,SupplierTown,SupplierCounty,SupplierPostcode,SupplierTelNo) VALUES
('SUP101','Head & Shoulders Ltd','2A Olympic Way Bootle', 'Liverpool','Merseyside', 'LP30 1RD', '01515214527'),
('SUP102','Tampax Health Care Ltd','3M Centre Cain Road Bracknell', 'England','Berkshire', 'RG12 8HT', '13448580010'),
('SUP103','Lynx Ltd','9 Bond Court', 'Leeds','West Yorkshire', 'LP51 2JZ', '01708528028'),
('SUP104','ALLURE Diagnostics Ltd','405 Wharfedale Road', 'Wokingham','Berkshire', 'RG41 5RA', '11890444100'),
('SUP105','A1 Pharmaceuticals Plc','Unit 20/21 Easter Park', 'Rainham ','Essex ', 'RM13 9BP', '01708528900'),
('SUP106','E45 Pharmaceuticals Ltd','Sapphire Court Walsgrave Triangle', 'Coventry','West Midlands', 'CV12 2TX', '03445618899'),
('SUP107','Colgate Labs Limited','Abbott House Vanwall Road', 'Maidenhead','Berkshire', 'SL36 4XE', '01628773356'),
('SUP108','Oral-B Ltd','AbbVie House Vanwall Road', 'Maidenhead','Berkshire', 'SL26 4UB', '01628561090'),
('SUP109','Nivea SkinCare Limited','Avonbridge House 2 Bath Road', 'Chippenham','Wiltshire', 'SN15 2BB', '01249466966'),
('SUP110','SURE Pharma UK Limited','3 Furzeground Way Stockley Park', 'Uxbridge','Middlesex', 'UB11 1EZ', '07740406720')

INSERT INTO SupplierOrder(SupplierOrderID,SupplierID,OrderDate,DispatchDate,DeliveryDate, Paid)VALUES
('SO101','SUP101','20200112','20200112','20200115',0),
('SO102','SUP102','20200111','20200111','20200114',1),
('SO103','SUP103','20200110','20200110','20200112',0),
('SO104','SUP104','20200109','20200109','20200111',1),
('SO105','SUP105','20200108','20200108','20200110',0),
('SO106','SUP106','20200107','20200107','20200109',1),
('SO107','SUP107','20200106','20200106','20200108',0),
('SO108','SUP108','20200104','20200104','20200106',1),
('SO109','SUP109','20200103','20200103','20200108',1),
('SO110','SUP110','20200101','20200101','20200109',0)

INSERT INTO SupplierPayments(SupplierPaymentID,SupplierID,PaymentDate) VALUES
('SP101','SUP101','20200112'),		
('SP102','SUP102','20200111'),
('SP103','SUP103','20200110'),
('SP104','SUP104','20200109'),
('SP105','SUP105','20200108'),
('SP106','SUP106','20200107'),
('SP107','SUP107','20200106'),
('SP108','SUP108','20200104'),
('SP109','SUP109','20200103'),
('SP110','SUP110','20200101')

INSERT INTO SupplierPaymentDetails(SupplierPaymentID,SupplierOrderID,PaymentTypeID) VALUES
('SP101','SO101','BT'),
('SP102','SO102','PP'),
('SP103','SO103','DB'),
('SP104','SO104','BT'),
('SP105','SO105','BT'),
('SP106','SO106','BT'),
('SP107','SO107','BT'),
('SP108','SO108','BT'),
('SP109','SO109','BT'),
('SP110','SO110','BT')

INSERT INTO Sales(SaleID,SaleDate,PaymentTypeID) VALUES
('S101','20200202','VA'),
('S102','20200201','MC'),
('S103','20200118','PP'),
('S104','20200112','DB'),
('S105','20200113','AX'),
('S106','20200112','CA'),
('S107','20200111','CA'),
('S108','20200110','PP'),
('S109','20200109','AX'),
('S110','20200108','DB'),
('S111','20200107','VA'),
('S112','20200106','VA'),
('S113','20200104','VA'),
('S114','20200103','VA'),
('S115','20200101','VA')





--jacks here
INSERT INTO Staff(StaffID,Title,Forename,Surname,Town,Street,Postcode,TelephoneNo,MobileNo,Email)
VALUES	
	('S100','Mr', 'Eamonn', 'Mclaughlin', 'Derry', '34 Avenue Way', 'BT48 7HB','02871834587','07712312411','emc283@hotmail.com'),
    ('S101','Mr', 'Evan', 'Duffy','Derry','29 Westlake End', 'BT48 4YP','02871495740','07738934881','evand904@hotmail.co.uk'),
	('S102','Ms', 'Sophie', 'Matthews','Derry','24 Malin Park','BT48 4FP','02871458773','07711993487','sophiem45@live.co.uk'),
	('S103','Mr', 'Ethan', 'Morrow','Derry','19 Patricks Street', 'BT48 2JA','02871385775','07734873091','emorrow295@gmail.com'),
	('S104','Miss', 'Kasey', 'Healey', 'Derry','19 Brooke Way', 'BT48 4OP','02871349257','07788221173','kaseyh98@gmail.com'),
	('S105','Mr', 'Ryan', 'McGilloway','Derry', '24 Heartland Park','BT48 3UD','02871128734','07793872001','rmgc777@hotmail.co.uk'),
	('S106','Mr', 'Matthew','Lynch', 'Derry','64 East Way', 'BT48 3RW','02871473981','07719834875','mlynch55@hotmail.com'),
	('S107','Mrs', 'Hannah','Golden', 'Derry', '19 West Way','BT48 8PB','02871487395','07798214662','hannahg75@gmail.com'),
	('S108','Mr', 'Frank','West', 'Derry', '15 Craigavon','BT48 3NH', '02871348749','07775923491','frankw485@gmail.com'),
	('S109','Mr', 'Oliver', 'Leary', 'Derry', '18 Leenan Gardens','BT48 8OA','02871295992','07733981234','oleary4858@live.co.uk'),
	('S110','Miss', 'Chloe', 'Doherty', 'Derry', '24 Beechwood Avenue','BT48 4RI','02871947721','07791239845','cdoherty19@hotmail.co.uk'),
	('S111','Mr', 'Rory', 'Galloway', 'Derry', '29 Buncrana Rd','BT48 3HI','02871349847', '07799123390','rgalloway888@hotmail.com'),
	('S112','Ms', 'Kate', 'Hawthorn', 'Derry', '4 Dervin Gardens','BT48 3KS','02871449001','07721112983','khawthorn49@gmail.com'),
	('S113','Mrs', 'Anne', 'Williams', 'Derry', '34 Herald Gardens','BT48 1NU','02871331994','07700122345','annwilliams459@live.co.uk'),
	('S114','Mr', 'Oliver', 'Queen', 'Derry', '20 Lakeview Avenue', 'BT48 9LU','02871994443','07794821223','oliverqueen33@live.co.uk'),
	('S115','Miss', 'Felicia', 'White', 'Derry', '34 Parkland Way','BT48 4OL','02871934871','07791334449','feliciaw138@hotmail.com')

INSERT INTO CourseType(CourseTypeID,CourseTypeDesc)
VALUES	('CT1', 'FullTime'),
	('CT2', 'PartTime')

INSERT INTO Courses(CourseID,CourseDesc,NoDays,HoursPerDay,CoursePrice,NoPatients,CourseTypeID)
VALUES  ('C10', 'Stop Smoking',14,3.00,10.00,20,'CT1'),
	('C11', 'Asthma & Respitory Help',10,2.00,12.50,15,'CT2'),
	('C12', 'Sexual Health & Assistance',6,3.00,15.00,25,'CT1'),
	('C13', 'Pain Management',7,5.00,15,14,'CT2'),
	('C14', 'Weight Loss',14,3.5,35.00,12,'CT1'),
	('C15', 'Medication Assistance', 5,3,20,1.00,'CT1'),
	('C16', 'Diabetes Help',3,3,15,2.30,'CT2'),
	('C17', 'Travel & Health Consultations',2,2.00,10.00,15,'CT1')

INSERT INTO CourseStaff(StaffID,CourseID,CourseClassDays)
VALUES ('S110','C11',2),
		('S104', 'C10',2),
		('S109', 'C10',2),
	   ('S110','C12',1),
	   ('S109','C15',2),
	   ('S102','C17',1),
	   ('S111','C14',2),
	   ('S112','C13',3),
	   ('S112','C15',1),
	   ('S115','C16',2),
	   ('S109','C12',2),
	   ('S112','C17',2),
	   ('S115','C14',2),
	   ('S108','C10',2)

INSERT INTO CourseInstance(CourseInstanceID,CourseID,CourseStartDate,CourseStartTime,StaffID)
VALUES ('CI5','C12','20200226','9.00','S109'),
		('CI1','C12','20200225','10.00','S110'),
		('CI3','C13','20200226','12.00','S112'),
		('CI4','C11','20200224','9.30','S112'),
		('CI2','C10','20200113','12.30','S109')

--Conor's

INSERT INTO Patient (PatientID, PatientForename, PatientSurname, PatientTelNo, PatientEmail, PatientStreet, PatientTown, PatientCounty, PatientPostcode) VALUES
('PAT1000', 'Conor', 'McGrory', '01278564', 'cmcg@gmail.co.uk', 'Pennyburn', 'Derry', 'County Derry', 'BT48 8WE'),
('PAT1001', 'Sean', 'Carlin', '63301956', 'sc@hotmail.co.uk', 'Abercorn Road', 'Derry', 'County Derry', 'BT48 2PF'),
('PAT1002', 'Jack', 'OKane', '49104523', 'jok@gmail.com', 'Branch Road', 'Derry', 'County Derry', 'BT47 4TF'),
('PAT1003', 'Megan', 'Rose', '01278564', 'mr@hotmail.co.uk', 'Alexander Park', 'Armagh', 'County Armagh', 'BT48 9OS'),
('PAT1004', 'Sean', 'Robert', '28110459', 'srg@gmail.co.uk', 'Abbey Court', 'Belfast', 'County Antrim', 'BT47 8TL'),
('PAT1005', 'Kevin', 'Hugh', '16753098', 'kh@gmail.co.uk', 'Drumbeg Road', 'Lisburn', 'County Antrim', 'BT47 9OI'),
('PAT1006', 'Susan', 'Barney', '86753090', 'sb@hotmail.com', 'Birch Hill Road', 'Antrim', 'County Antrim', 'BT47 3LQ'),
('PAT1007', 'Homer', 'Simpson', '6082301', 'hs@gmail.co.uk', 'Dreg Crescent', 'Derry', 'County Derry', 'BT48 2KQ'),
('PAT1008', 'Peter', 'Griffin', '41555071', 'pg@gmail.co.uk', 'Abercorn', 'Lisburn', 'County Down', 'BT47 2TL'),
('PAT1009', 'Dennis', 'Leery', '60982361', 'dl@gmail.co.uk', 'Foyle Street', 'Derry', 'County Derry', 'BT48 2PW'),
('PAT1010', 'Mary', 'Jane', '50167743', 'mj@hotmail.com', 'Fountain Street', 'Antrim', 'County Antrim', 'BT48 3HC'),
('PAT1011', 'Steven', 'White', '91034421', 'sw@gmail.co.uk', 'Jura Street', 'Antrim', 'County Antrim', 'BT48 1MD'),
('PAT1012', 'Harry', 'Potter', '38466109', 'hp@hotmail.co.uk', 'Haywood Drive', 'Belfast', 'County Down', 'BT48 7PV'),
('PAT1013', 'James', 'Jones', '25912707', 'jj@gmail.co.uk', 'Dukes Road', 'Armagh', 'County Armagh', 'BT47 6KD'),
('PAT1014', 'Eric', 'Cartman', '72099814', 'ec@gmail.com', 'Greenbank', 'Lisburn', 'County Down', 'BT48 8FG'),
('PAT1015', 'Lucy', 'Dale', '19964820', 'ld@hotmail.co.uk', 'Millhouse Drive', 'Antrim', 'County Antrim', 'BT48 3TK'),
('PAT1016', 'Wendy', 'Yards', '50166923', 'wy@gmail.co.uk', 'Garden City', 'Derry', 'County Derry', 'BT48 9BW'),
('PAT1017', 'Kylie', 'Dane', '86401127', 'kd@gmail.com', 'Curzon Street', 'Belfast', 'County Antrim', 'BT48 6VN'),
('PAT1018', 'Steven', 'Tee', '95714501', 'st@gmail.com', 'Eden Road', 'Belfast', 'County Down', 'BT47 6SQ'),
('PAT1019', 'Giovanni', 'Smith', '53210988', 'gs@gmail.co.uk', 'Grove Terrace', 'Armagh', 'County Armagh', 'BT48 2DM'),
('PAT1020', 'Gary', 'Cant', '44910425', 'gc@hotmail.co.uk', 'Village Lane', 'Derry', 'County Derry', 'BT47 1HA'),
('PAT1021', 'Mario', 'Mario', '13091985', 'mm@hotmail.co.uk', 'Hillside Court', 'Lisburn', 'County Antrim', 'BT48 5MR'),
('PAT1022', 'Ann', 'Lee', '30137458', 'al@hotmail.com', 'Westway', 'Derry', 'County Derry', 'BT47 4NM'),
('PAT1023', 'Nemo', 'Paulie', '66156306', 'np@hotmail.co.uk', 'Belmont Road', 'Belfast', 'County Down', 'BT47 3LK'),
('PAT1024', 'Barney', 'Gumble', '27013658', 'bg@gmail.com', 'Oakview', 'Armagh', 'County Armagh', 'BT47 1KV'),
('PAT1025', 'Timmy', 'Turner', '03758992', 'tt@hotmail.co.uk', 'Parklands', 'Antrim', 'County Antrim', 'BT48 4OD'),
('PAT1026', 'Victoria', 'Secret', '73001542', 'vs@hotmail.co.uk', 'Violet Street', 'Derry', 'County Derry', 'BT48 7ZS'),
('PAT1027', 'Amanda', 'Huggenkiss', '50447138', 'ah@hotmail.com', 'Low Road', 'Lisburn', 'County Down', 'BT48 2LP'),
('PAT1028', 'Sophie', 'Housten', '10558334', 'sh@gmail.com', 'Glendower Street', 'Belfast', 'County Antrim', 'BT47 9EB'),
('PAT1029', 'Jesus', 'Chris', '87654321', 'jc@hotmail.co.uk', 'Sufflok Square', 'Antrim', 'County Antrim', 'BT48 1RT')

INSERT INTO Prescriptions (PrescriptionID, PatientID, PrescriptionDate) VALUES
('PRE1000', 'PAT1012', '2020-08-12'),
('PRE1001', 'PAT1003', '2020-10-08'),
('PRE1002', 'PAT1018', '2020-03-25'),
('PRE1003', 'PAT1011', '2019-05-02'),
('PRE1004', 'PAT1008', '2019-11-14'),
('PRE1005', 'PAT1020', '2020-04-19'),
('PRE1006', 'PAT1016', '2019-07-22'),
('PRE1007', 'PAT1023', '2020-06-09'),
('PRE1008', 'PAT1004', '2019-10-18'),
('PRE1009', 'PAT1002', '2020-03-07'),
('PRE1010', 'PAT1001', '2019-01-27'),
('PRE1011', 'PAT1017', '2020-11-13'),
('PRE1012', 'PAT1029', '2019-08-02'),
('PRE1013', 'PAT1008', '2020-08-14'),
('PRE1014', 'PAT1024', '2019-04-20'),
('PRE1015', 'PAT1015', '2019-11-30'),
('PRE1016', 'PAT1020', '2020-01-15'),
('PRE1017', 'PAT1004', '2020-03-07'),
('PRE1018', 'PAT1015', '2020-10-23'),
('PRE1019', 'PAT1017', '2019-06-18'),
('PRE1020', 'PAT1001', '2019-02-17'),
('PRE1021', 'PAT1013', '2019-09-30'),
('PRE1022', 'PAT1025', '2020-05-05'),
('PRE1023', 'PAT1009', '2020-07-14'),
('PRE1024', 'PAT1011', '2019-12-10'),
('PRE1025', 'PAT1028', '2020-12-21'),
('PRE1026', 'PAT1006', '2019-04-12'),
('PRE1027', 'PAT1010', '2020-02-20'),
('PRE1028', 'PAT1000', '2020-05-02'),
('PRE1029', 'PAT1022', '2019-09-17'),
('PRE1030', 'PAT1011', '2020-10-05'),
('PRE1031', 'PAT1026', '2019-06-13'),
('PRE1032', 'PAT1004', '2020-03-09'),
('PRE1033', 'PAT1022', '2019-01-11'),
('PRE1034', 'PAT1022', '2019-07-28')

INSERT INTO MinorAilmentTypes (MinorAilmentsTypeID, MinorAilmentsTypeDesc) VALUES 
('AITY100', 'Stomach'),
('AITY101', 'Head'),
('AITY102', 'Legs'),
('AITY103', 'Arms'),
('AITY104', 'Shoulders'),
('AITY105', 'Backside'),
('AITY106', 'Face'),
('AITY107', 'Hands'),
('AITY108', 'Feet'),
('AITY109', 'Neck'),
('AITY110', 'Pelvis'),
('AITY111', 'Torso'),
('AITY112', 'Hips'),
('AITY113', 'Fingers'),
('AITY114', 'Toes')

INSERT INTO MinorAilments (MinorAilmentID, MinorAilmentDesc, MinorAilmentsTypeID) VALUES
('MIA1000', 'Acne', 'AITY104'),
('MIA1001', 'Headache', 'AITY112'),
('MIA1002', 'Ear Wax', 'AITY107'),
('MIA1003', 'Measles', 'AITY102'),
('MIA1004', 'Cold Sore','AITY108'),
('MIA1005', 'Haemorrhoid', 'AITY110'),
('MIA1006', 'Sore Throat', 'AITY101'),
('MIA1007', 'Head Lice', 'AITY104'),
('MIA1008', 'Mouth Ulcers', 'AITY100'),
('MIA1009', 'Constipation', 'AITY113'),
('MIA1010', 'Athletes Foot', 'AITY103'),
('MIA1011', 'Diarrhoea', 'AITY100'),
('MIA1012', 'Kindey Infection', 'AITY110'),
('MIA1013', 'Flu', 'AITY101'),
('MIA1014', 'Eczema', 'AITY111'),
('MIA1015', 'Allergies', 'AITY102'),
('MIA1016', 'Stomach Ache', 'AITY102'),
('MIA1017', 'Kidney Stones', 'AITY100'),
('MIA1018', 'Insomnia', 'AITY105'),
('MIA1019', 'Indigestion', 'AITY103')

INSERT INTO StockType(StockTypeID, StockTypeDesc) VALUES
('HYG','Hygiene'),
('SC','Skin Care'),
('OC','Oral Care'),
('HP', 'Hair Products'),
('BF', 'Baby Food'),
('SAN','Sanitary Products'),
('COS','Cosmetic Products')

INSERT INTO Stock(StockID,SupplierID, StockDesc, StockTypeID, QTYInStock, StockPrice) VALUES
('ST101','SUP101','Head & Shoulders Original','HP',65,3.75),
('ST102','SUP101','Head & Shoulders Dry Scalp','HP',35,4.50),
('ST103','SUP101','Head & Shoulders Moisture','HP',15, 4.99),
('ST104','SUP101','Head & Shoulders Hair Booster','HP',15,4.75),
('ST105','SUP101','Head & Shoulders Moisture Conditioner','HP',54,3.75),
('ST106','SUP101','Head & Shoulders Itchy Scalp','HP',54,2.75),
('ST107','SUP102','Tampax Pearl','SAN',27,2.99),
('ST108','SUP102','Tampax Pearl Super Absorbent','SAN',27,4.99),
('ST109','SUP102','Tampax Pearl Super Absorbent','SAN',27,4.99),
('ST110','SUP102','Tampax Pearl Pocket Pearl','SAN',27,2.99),
('ST111','SUP103','Lynx Africa Aerosol','COS',23,1.75),
('ST112','SUP103','Lynx Gold Aerosol','COS',23,1.75),
('ST113','SUP103','Lynx Black Aerosol','COS',23,1.75),
('ST114','SUP103','Lynx ICE Aerosol','COS',23,1.75),
('ST115','SUP103','Lynx Africa Body Wash','HYG',98,2.35),
('ST116','SUP103','Lynx Gold Wash','HYG',98,2.35),
('ST117','SUP103','Lynx Black Body Wash','HYG',98,2.35),
('ST118','SUP103','Lynx ICE Body Wash','HYG',98,2.35),
('ST119','SUP104','ALLURE TOILETTE SPRAY','COS',14,53.80),
('ST120','SUP104','ALLURE COLOGNE SPRAY','COS',34,14.50),
('ST121','SUP104','ALLURE SHOWER GEL','COS',34,4.50),
('ST122','SUP104','ALLURE DEODORANT SPRAY','COS',34,4.50),
('ST123','SUP104','ALLURE BODY SPRAY','COS',34,4.50),
('ST124','SUP105','Aptamil Profutura Milk','BF',67,13.75),
('ST125','SUP105','Cow & Gate Infant Milk','BF',38,10.75),
('ST126','SUP105','SMA Infant Formula Powder','BF',24,12.75),
('ST127','SUP105','SMA Junior Formula Powder','BF',24,14.75),
('ST128','SUP105','SMA Breastmilk Formula Powder','BF',24,15.75),
('ST129','SUP106','E45 Cream Pump','SC',10,5.50),
('ST130','SUP106','E45 Relief Cream','SC',35,7.50),
('ST131','SUP106','E45 Moisturising Lotion','SC',25,7.50),
('ST132','SUP106','E45 Intense Recovery Cream ','SC',20,10.00),
('ST133','SUP106','E45 Spray Moisturiser','SC',55,12.50),
('ST134','SUP106','E45 Hand Cream' ,'SC',25,6.50),
('ST135','SUP106','E45 Nappy Cream','SC',40,8.50),
('ST136','SUP106','E45 Daily Hand Cream','SC',35,2.50),
('ST137','SUP106','E45 Itch Relief Cream','SC',30,5.50),
('ST138','SUP106','E45 Cream','SC',40,2.50),
('ST139','SUP107','Colgate Advanced Gum Health ToothPaste','OC',42,12.50),
('ST140','SUP107','Colgate Original Toothpaste','OC',42,12.50),
('ST141','SUP107','Colgate Plaque Protection ToothPaste','OC',42,12.50),
('ST142','SUP107','Colgate Advanced Teeth Whitener Paste','OC',42,12.50),
('ST143','SUP108','ORALB PRO 600','OC',15,45.50),
('ST144','SUP108','ORALB VITALITY 100','OC',10,35.50),
('ST145','SUP108','ORALB GENIUS X ','OC',5,75.50),
('ST146','SUP108','ORALB PRO-EXPERT PULSAR TOOTHBRUSH','OC',45,6.50),
('ST147','SUP109','NIVIA Invisible Sun Screen','SC',15,5.50),
('ST148','SUP109','NIVIA Make-Up Remover','SC',20,5.50),
('ST149','SUP109','NIVEA Soft Moisturising Cream','SC',30,6.50),
('ST150','SUP109','NIVEA Body Lotion for Dry Skin','SC',15,10.50),
('ST151','SUP110','SURE Extreme Dry Anti-perspirant','COS',30,2.50),
('ST152','SUP110','SURE Men Advanced Protection','COS',20,3.50),
('ST153','SUP110','Sure Men Sport Cool Anti-perspirant','COS',15,4.50),
('ST154','SUP110','SURE Extreme Dry Anti-perspirant Stick','COS',20,3.50)

INSERT INTO SupplierOrderDetails(SupplierOrderID,StockID,QTYOrdered) VALUES
('SO101','ST101',15),
('SO101','ST102',15),
('SO101','ST103',15),
('SO101','ST104',15),
('SO102','ST107',10),
('SO102','ST108',10),
('SO102','ST109',10),
('SO102','ST110',10),
('SO103','ST111',05),
('SO103','ST112',06),
('SO103','ST113',05),
('SO103','ST114',08),
('SO103','ST115',05),
('SO103','ST116',04),
('SO103','ST117',03),
('SO103','ST118',02),
('SO104','ST119',06),
('SO104','ST120',05),
('SO104','ST121',03),
('SO104','ST122',02),
('SO105','ST124',07),
('SO105','ST125',09),
('SO105','ST126',10),
('SO105','ST128',02),
('SO106','ST129',03),
('SO106','ST130',01),
('SO106','ST131',04),
('SO106','ST132',07),
('SO106','ST133',08),
('SO106','ST134',06),
('SO106','ST135',08),
('SO106','ST136',10),
('SO107','ST139',04),
('SO107','ST140',02),
('SO107','ST142',04),
('SO108','ST143',03),
('SO108','ST144',02),
('SO108','ST146',01),
('SO109','ST147',06),
('SO109','ST148',03),
('SO109','ST150',02),
('SO110','ST151',10),
('SO110','ST154',8),
('SO110','ST152',4)

INSERT INTO SaleDetails(SaleID,StockID,QTYSold) VALUES
('S101','ST101',5),
('S102','ST106',6),
('S103','ST108',8),
('S104','ST109',20),
('S105','ST104',2),
('S106','ST103',9),
('S107','ST111',3),
('S108','ST111',5),
('S109','ST115',15),
('S110','ST114',26),
('S111','ST114',13),
('S112','ST114',1),
('S112','ST115',9),
('S113','ST102',7),
('S114','ST104',5),
('S115','ST115',5)

INSERT INTO PrescriptionDetails (PrescriptionID, StockID, Delivery, RecurringPrescription) VALUES
('PRE1000', 'ST105', 'YES', 'NO'),
('PRE1001', 'ST107', 'NO', 'YES'),
('PRE1002', 'ST119', 'NO', 'YES'),
('PRE1003', 'ST102', 'YES', 'YES'),
('PRE1004', 'ST112', 'NO', 'NO'),
('PRE1005', 'ST127', 'YES', 'YES'),
('PRE1006', 'ST103', 'YES', 'NO'),
('PRE1007', 'ST110', 'YES', 'YES'),
('PRE1008', 'ST108', 'NO', 'NO'),
('PRE1009', 'ST105', 'NO', 'YES'),
('PRE1010', 'ST122', 'YES', 'NO'),
('PRE1011', 'ST125', 'NO', 'NO'),
('PRE1012', 'ST120', 'YES', 'YES'),
('PRE1013', 'ST101', 'NO', 'NO'),
('PRE1014', 'ST116', 'YES', 'NO'),
('PRE1015', 'ST121', 'NO', 'YES'),
('PRE1016', 'ST102', 'NO', 'NO'),
('PRE1017', 'ST111', 'YES', 'YES'),
('PRE1018', 'ST119', 'NO', 'YES'),
('PRE1019', 'ST106', 'YES', 'NO'),
('PRE1020', 'ST102', 'YES', 'NO'),
('PRE1021', 'ST113', 'YES', 'YES'),
('PRE1022', 'ST117', 'YES', 'NO'),
('PRE1023', 'ST122', 'NO', 'YES'),
('PRE1024', 'ST104', 'YES', 'YES'),
('PRE1025', 'ST111', 'NO', 'NO'),
('PRE1026', 'ST108', 'YES', 'YES'),
('PRE1027', 'ST125', 'NO', 'YES'),
('PRE1028', 'ST118', 'NO', 'NO'),
('PRE1029', 'ST111', 'NO', 'YES'),
('PRE1030', 'ST129', 'YES', 'YES'),
('PRE1031', 'ST106', 'NO', 'YES'),
('PRE1032', 'ST130', 'YES', 'NO'),
('PRE1033', 'ST109', 'NO', 'YES'),
('PRE1034', 'ST113', 'YES', 'NO')

INSERT INTO CustomerMinAilments (CustomerMinAilmentID, PatientID, DateAdministrated) VALUES
('MIA1000', 'PAT1009', '2020-12-16'),
('MIA1001', 'PAT1012', '2020-08-27'),
('MIA1002', 'PAT1028', '2020-03-25'),
('MIA1003', 'PAT1021', '2020-03-09'),
('MIA1004', 'PAT1017', '2020-05-11'),
('MIA1005', 'PAT1004', '2020-03-08'),
('MIA1006', 'PAT1016', '2020-07-05'),
('MIA1007', 'PAT1000', '2020-06-14'),
('MIA1008', 'PAT1015', '2020-04-18'),
('MIA1009', 'PAT1013', '2020-03-07'),
('MIA1010', 'PAT1025', '2020-06-27'),
('MIA1011', 'PAT1010', '2020-11-13'),
('MIA1012', 'PAT1029', '2020-08-02'),
('MIA1013', 'PAT1008', '2020-07-14'),
('MIA1014', 'PAT1017', '2020-04-20'),
('MIA1015', 'PAT1002', '2020-11-30'),
('MIA1016', 'PAT1016', '2020-12-15'),
('MIA1017', 'PAT1022', '2020-03-07'),
('MIA1018', 'PAT1019', '2020-09-15'),
('MIA1019', 'PAT1004', '2020-11-23')

INSERT INTO CustomerMinAilDetails (MinorAilmentID, Qty) VALUES
('MIA1000', 8),
('MIA1001', 12),
('MIA1002', 4),
('MIA1003', 6),
('MIA1004', 10),
('MIA1005', 2),
('MIA1006', 15),
('MIA1007', 11),
('MIA1008', 18),
('MIA1009', 7),
('MIA1010', 12),
('MIA1011', 4),
('MIA1012', 9),
('MIA1013', 14),
('MIA1014', 7),
('MIA1015', 18),
('MIA1016', 6),
('MIA1017', 12),
('MIA1018', 3),
('MIA1019', 8)

INSERT INTO CustomerMinStockDetails (CustMinAilmentID, MinorAilmentID, StockID, Qty) VALUES
('CMA1000', 'MIA1019', 'ST103', 34),
('CMA1001', 'MIA1009', 'ST107', 12),
('CMA1002', 'MIA1012', 'ST124', 43),
('CMA1003', 'MIA1002', 'ST111', 10),
('CMA1004', 'MIA1006', 'ST108', 26),
('CMA1005', 'MIA1003', 'ST115', 6),
('CMA1006', 'MIA1017', 'ST110', 16),
('CMA1007', 'MIA1015', 'ST121', 9),
('CMA1008', 'MIA1002', 'ST125', 23),
('CMA1009', 'MIA1011', 'ST112', 15),
('CMA1010', 'MIA1010', 'ST106', 4),
('CMA1011', 'MIA1019', 'ST102', 29),
('CMA1012', 'MIA1014', 'ST130', 10),
('CMA1013', 'MIA1006', 'ST101', 17),
('CMA1014', 'MIA1015', 'ST118', 22),
('CMA1015', 'MIA1008', 'ST122', 30),
('CMA1016', 'MIA1018', 'ST104', 19),
('CMA1017', 'MIA1013', 'ST130', 25),
('CMA1018', 'MIA1002', 'ST109', 29),
('CMA1019', 'MIA1004', 'ST124', 13)

INSERT INTO CourseInstanceDetails(PatientID,CourseInstanceID)
VALUES   ('PAT1001','CI3'),
	   ('PAT1002','CI4'),
	   ('PAT1005','CI5'),
	   ('PAT1004','CI3'),
	   ('PAT1007','CI4'),
	   ('PAT1008','CI5'),
	   ('PAT1009','CI3'),
	   ('PAT1009','CI4'),
	   ('PAT1010','CI1'),
	   ('PAT1015','CI5'),
	   ('PAT1019','CI1'),
	   ('PAT1020','CI4'),
	   ('PAT1029','CI3'),
	   ('PAT1013','CI1'),
	   ('PAT1001','CI4'),
		('PAT1001','CI2'),
	   ('PAT1002','CI5')
