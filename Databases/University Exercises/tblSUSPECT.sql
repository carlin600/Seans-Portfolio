CREATE TABLE cis24609650.SUSPECT
(
SuspectID					CHAR(10)		NOT NULL,
Firstname					CHAR(30)		NOT NULL,
Lastname					CHAR(30)		NOT NULL,
Gender						CHAR(7)			NOT NULL,
DOB							DATE			NOT NULL,
SelfDefinedEthnicity		CHAR(75)		NOT NULL,
OfficerDefinedEthnicity		CHAR(75)		NOT NULL,
PreviousConviction			CHAR(75)		NOT NULL,		

PRIMARY KEY (SuspectID)
)

DROP TABLE cis24609650.SUSPECT

INSERT INTO cis24609650.SUSPECT(SuspectID, Firstname, Lastname, Gender, DOB, SelfDefinedEthnicity, OfficerDefinedEthnicity, PreviousConviction) VALUES
('SUS1000001', 'Olli', ' Drew',	'Male','1958-03-29', 	'White - English/Welsh/Scottish/Northern Irish/British',	'White - Irish','None'),
('SUS1000002','Kobe', ' Gardner',	'Male','1985-12-10', 	'Asian/Asian British - Any other Asian background',			'Asian/Asian British - Bangladeshi','Sexual Harassment'),
('SUS1000003','Keri', ' Patton',	'Female','1987-07-19', 	'Asian/Asian British - Pakistani',							'Asian/Asian British - Bangladeshi','Theft'),
('SUS1000004','Wade', ' Findlay',	'Female','1993-08-31', 	'Other ethnic group - Not stated',							'White - Irish','None'),
('SUS1000005','Nigel', ' Tanner',	'Male','2004-02-01', 	'Black/African/Caribbean/Black British',					'Other ethnic group - Not stated','None'),
('SUS1000006','Kajus', ' Rich',	'Male','1958-04-16', 	'White - English/Welsh/Scottish/Northern Irish/British',	'White - Irish','None'),
('SUS1000007','Edith', ' Singh',	'Female','1977-01-12', 	'White - English/Welsh/Scottish/Northern Irish/British',	'White - Irish','Burglary'),
('SUS1000008','Jovan', ' Russell',	'Male','1979-11-06', 	'White - English/Welsh/Scottish/Northern Irish/British',	'White - Irish','None'),
('SUS1000009','Acacia', ' Bains',	'Female','1992-02-06', 	'White - English/Welsh/Scottish/Northern Irish/British',	'White - Irish','Burglary'),
('SUS1000010','Alexis', ' Woodley',	'Male','2005-08-17', 	'Asian/Asian British - Pakistani',							'Asian/Asian British - Bangladeshi','Anti-social behaviour');








