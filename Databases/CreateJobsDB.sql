-- Create the database
DROP DATABASE Jobs
CREATE DATABASE Jobs

-- Use the Jobs database for all following commands
USE Jobs

-- Create the Geographical Areas table
CREATE TABLE GeographicalArea
(
	AreaCode			CHAR(3)				NOT NULL,
	AreaName			VARCHAR(25)			NOT NULL
	
	CONSTRAINT pkAreaCode PRIMARY KEY (AreaCode),
	CONSTRAINT unAreaName UNIQUE (AreaName)
);


-- Create the Customers table
CREATE TABLE Customer
(
	CustomerNo			VARCHAR(8)			NOT NULL,
	FirstName			VARCHAR(25)			NOT NULL,
	LastName			VARCHAR(25)			NOT NULL,
	BusinessName		VARCHAR(100)		NULL,
	Street				VARCHAR(50)			NOT NULL,
	Town				VARCHAR(50)			NOT NULL,
	AreaCode			CHAR(3)				NOT NULL,
	Postcode			VARCHAR(8)			NOT NULL,
	CreatedDate			SMALLDATETIME		DEFAULT CONVERT(SMALLDATETIME, GETDATE()),
	Age					AS DATEDIFF (y, CreatedDate, GETDATE())
	
	CONSTRAINT pkCustomers PRIMARY KEY (CustomerNo),
	CONSTRAINT fkAreaCode FOREIGN KEY (AreaCode) REFERENCES GeographicalArea (AreaCode)
)


-- Create the TradesPerson table
CREATE TABLE TradesPerson
(
	TradesPersonNo			VARCHAR(6)			NOT NULL,
	TradesPersonName		VARCHAR(50)			NOT NULL,
	HourlyRate			MONEY				DEFAULT 20,
	OvertimeRate		MONEY				DEFAULT 30,

	CONSTRAINT pkTradesPerson PRIMARY KEY (TradesPersonNo)
)


-- Create the Contracts table
CREATE TABLE Contract
(
	ContractNo			VARCHAR(8)			NOT NULL,
	CustomerNo			VARCHAR(8)			NOT NULL,
	RenewalDate			SMALLDATETIME,
	RenewAutomatically	BIT,
	DaysUntilRenewal	AS datediff(d,getdate(),RenewalDate)

	CONSTRAINT pkContracts PRIMARY KEY (ContractNo),
	CONSTRAINT fkCustomerNo FOREIGN KEY (CustomerNo) REFERENCES Customer (CustomerNo)
)


-- Create the Skills table
CREATE TABLE Skills
(
	SkillCode			CHAR(3)				NOT NULL,
	SkillName			VARCHAR(30)			NOT NULL

	CONSTRAINT pkSkills PRIMARY KEY (SkillCode),
	CONSTRAINT unSkillame UNIQUE (SkillName)
)


-- Create the Standard Jobs table
CREATE TABLE StandardJob
(
	StandardJobNo		INT					NOT NULL,
	JobName				VARCHAR(100)		NOT NULL,
	JobDescription		VARCHAR(250)		NOT NULL,
	StandardPrice		MONEY				NOT NULL

	CONSTRAINT pkStandardJob PRIMARY KEY (StandardJobNo),
	CONSTRAINT unJobName UNIQUE (JobName)
)


-- Create the Part table
CREATE TABLE Part 
(
	PartNo				CHAR(8)				NOT NULL,
	PartName			VARCHAR(50)			NOT NULL,
	UnitCost			MONEY				NOT NULL

	CONSTRAINT pkPart PRIMARY KEY (PartNo),
	CONSTRAINT unPartName UNIQUE (PartName)
)


-- Create the Required Skills table
CREATE TABLE RequiredSkills
(
	StandardJobNo		INT					NOT NULL,
	SkillCode			CHAR(3)				NOT NULL

	CONSTRAINT pkRequiredSkills PRIMARY KEY (StandardJobNo, SkillCode),
	CONSTRAINT fkRequiredSkillsSkillCode FOREIGN KEY (SkillCode) REFERENCES Skills (SkillCode),
	CONSTRAINT fkRequiredSkillsStandardJobNo FOREIGN KEY (StandardJobNo) REFERENCES StandardJob (StandardJobNo)
)

--=================================================
-- Create the TradesPerson Skills table
CREATE TABLE TradesPersonSkills 
(
	TradesPersonNo			VARCHAR(6)			NOT NULL,
	SkillCode			CHAR(3)				NOT NULL

	CONSTRAINT pkTradesPersonSkills PRIMARY KEY CLUSTERED (TradesPersonNo, SkillCode)
	CONSTRAINT fkTradesPersonSkillsTradesPerson FOREIGN KEY (TradesPersonNo) REFERENCES TradesPerson (TradesPersonNo),
	CONSTRAINT fkTradesPersonSkillsSkillCode FOREIGN KEY (SkillCode) REFERENCES Skills (SkillCode)
)


-- Create the Jobs table
CREATE TABLE Job 
(
	JobNo				VARCHAR(8)			NOT NULL,
	StandardJobNo		INT					NOT NULL,
	ContractNo			VARCHAR(8)					NOT NULL,
	TradesPersonNo		VARCHAR(6),
	VisitDate			DATETIME,
	Duration			DECIMAL(4,2),
	FollowUpRequired	BIT,
	FollowUpJobNo		VARCHAR(8),
	Notes				VARCHAR(250)
	
	CONSTRAINT pkJobs PRIMARY KEY (JobNo),
	CONSTRAINT fkJobsContracts FOREIGN KEY (ContractNo) REFERENCES Contract (ContractNo),
	CONSTRAINT fkJobsTradesPersonNo FOREIGN KEY (TradesPersonNo) REFERENCES TradesPerson (TradesPersonNo),
	CONSTRAINT fkJobsJobNo FOREIGN KEY (FollowUpJobNo) REFERENCES Job (JobNo),
	CONSTRAINT fkStandardJobNo FOREIGN KEY (StandardJobNo) REFERENCES StandardJob (StandardJobNo)
)


-- Create the Used Parts table
CREATE TABLE UsedParts
(
	JobNo				VARCHAR(8)	NOT NULL,
	PartNo				CHAR(8)				NOT NULL,
	UnitsUsed			DECIMAL(6,2)		NOT NULL,

	CONSTRAINT pkUsedPart PRIMARY KEY (JobNo, PartNo),
	CONSTRAINT fkUsedPartJobNo FOREIGN KEY (JobNo) REFERENCES Job (JobNo),
	CONSTRAINT fkUsedPartPartNo FOREIGN KEY (PartNo) REFERENCES Part (PartNo)
)


-- Create the TradesPerson Stock table
CREATE TABLE TradesPersonStock 
(
	TradesPersonNo			VARCHAR(6)					NOT NULL,
	PartNo				CHAR(8)				NOT NULL,
	UnitsHeld			DECIMAL(6,2)		NOT NULL

	CONSTRAINT pkTradesPersonStock PRIMARY KEY (TradesPersonNo,	PartNo),
	CONSTRAINT fkStockTradesPersonTradesPersonNo FOREIGN KEY (TradesPersonNo) REFERENCES TradesPerson (TradesPersonNo),
	CONSTRAINT fkTradesPersonStockPartNo FOREIGN KEY (PartNo) REFERENCES Part (PartNo)
)


-- Create the TradesPerson Working Areas table
CREATE TABLE TradesPersonWorkingArea 
(
	TradesPersonNo			VARCHAR(6)					NOT NULL,
	AreaCode			CHAR(3)				NOT NULL

	CONSTRAINT pkTradesPersonWorkingAreas PRIMARY KEY (TradesPersonNo, AreaCode),
	CONSTRAINT fkTradesPersonNo FOREIGN KEY (TradesPersonNo) REFERENCES TradesPerson (TradesPersonNo),
	CONSTRAINT fkAreaCode2 FOREIGN KEY (AreaCode) REFERENCES GeographicalArea (AreaCode)
)


-- Create the CustomerComplaints table
CREATE TABLE CustomerComplaints
(
	ComplaintRef		INT IDENTITY (300000,1)		NOT NULL,
	CustomerNo			VARCHAR(8)				NOT NULL,
	TradesPersonNo			VARCHAR(6)				NULL,
    ComplaintTime		DATETIME				DEFAULT getdate(),
	Comment				VARCHAR(100),
	
	CONSTRAINT pkComplaintRef PRIMARY KEY (ComplaintRef),
	CONSTRAINT fkCustomerNo2 FOREIGN KEY (CustomerNo) REFERENCES Customer (CustomerNo),
	CONSTRAINT fkTradesPersonNo2 FOREIGN KEY (TradesPersonNo) REFERENCES TradesPerson (TradesPersonNo)
)

