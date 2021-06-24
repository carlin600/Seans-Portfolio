drop database ucas

create database ucas

use ucas



CREATE TABLE Degree
(
	DegreeNo		smallint	NOT NULL,
	DegreeClass		varchar		NOT NULL,
	DegreeName		varchar(40)	NOT NULL,
	Duration		smallint	NOT NULL,

	CONSTRAINT pkDegNo PRIMARY KEY (DegreeNo), 
	CONSTRAINT chkClass CHECK  (degreeClasS ='S' OR degreeClass='A'),
	CONSTRAINT chkDuration CHECK (Duration > 0 AND Duration < 5)
)


CREATE TABLE University
(
	UniNo		smallint		NOT NULL,
	UniName		varchar(40)		NOT NULL,

	CONSTRAINT pkUniNo PRIMARY KEY (UniNo) 
)

CREATE TABLE Student
(
	StudentID	smallint		NOT NULL,
	Title		varchar(4)		NOT NULL,
	Surname		varchar(20)		NOT NULL,
	Forename	varchar(20)		NOT NULL,
	gender		varchar(1)		NOT NULL,
	dob			date			NOT NULL,
	Street		varchar(30)		NOT NULL,
	Town		varchar(30)		NOT NULL,
	County		varchar(30)		NOT NULL,
	PostCode	varchar(8)		NOT NULL,
	TelNo		varchar(15)		NOT NULL,
	MobileNo	varchar(15)		NOT NULL,
	EMail		varchar(50)		NOT NULL,
 
	CONSTRAINT pkStudID PRIMARY KEY (StudentID)
)


CREATE TABLE StudentChoice
(
	StudentID		smallint	NOT NULL,
	ChoiceNo		smallint	NOT NULL,
	UniNo			smallint	NOT NULL,
	DegreeNo		smallint	NOT NULL,

	CONSTRAINT pkStudChoice PRIMARY KEY (StudentID, ChoiceNo),
	CONSTRAINT fkStudID FOREIGN KEY (StudentID) REFERENCES Student (StudentID),
	CONSTRAINT fkStudChoice FOREIGN KEY (DegreeNo) REFERENCES Degree (DegreeNo),
	CONSTRAINT fkUniChoice FOREIGN KEY (UniNo) REFERENCES University (UniNo)
)



INSERT INTO Student VALUES
(5000, 'Mr', 'Morrison', 'Brenden', 'M', '19951208', '159 Main Street','Eglinton','Co Derry','BT47 4TB', '02871261548', '07836251489', 'bm56@hotmail.co.uk'),   
(5001, 'Miss', 'Rankin', 'Kathy', 'F', '19950218', '56 Greenhaven','Drumahoe','Co Derry','BT48 3SY', '02871346562', '07596315785', 'kathyr@googlemail.com'),  
(5002, 'Mr', 'Carlin', 'Patrick', 'M', '19970604', '98 Larch Road','Greysteel','Co Derry','BT47 4TB', '02871249876', '07789651759', 'partickcarlin@live.co.uk'), 
(5003, 'Mr', 'Cunning', 'Tom', 'M', '19940930', '115 NewLine Road','Newbuildings','Co Derry','BT47 4TB', '02871375921', '07985632145', 'tomc99@hotmail.com'), 
(5004, 'Mr', 'Wilson', 'Robert', 'M', '19921127', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB', '07561020748', '08759632514', 'robbyw@gmail.com'), 
(5005, 'Mr', 'Lynch', 'Conan', 'M', '19940716', '126 Dungiven Road','Derry','Co Derry','BT47 4TB', '02871361782', '07485962315', 'conan123@hotmail.co.uk'),
(5006, 'Mrs', 'Collins', 'Joanne', 'F', '19940128', '62 Limavady Road','Derry','Co Derry','BT47 4TB', '02871267183', '08597631574', 'joanne560@yahoo.com'),
(5007, 'Mr', 'Gallagher', 'Adam', 'M', '19910111', '76 Church Brae','Derry','Co Derry','BT47 4TB', '02871348527', '07859317596', 'adamgall@gmail.co.uk'),
(5008, 'Mrs', 'Costello', 'Niamh', 'F', '19880315', '34 Strand Road','Derry','Co Derry','BT47 4TB', '07865255486', '07593175964', 'niamhc@hotmail.com'), 
(5009, 'Mr', 'Doherty', 'Kevin', 'M', '19920307', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB', '07759631458', '07193658479', 'kevindoherty@hotmail.com'),
(5010, 'Miss', 'Heaney', 'Amanda', 'F', '19920808', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB', '07566584748', '08671456983', 'mandyh@live.co.uk'), 
(5011, 'Mr', 'Evans', 'Rory', 'M', '19961227', '70 Rosewood Avenue','Derry','Co Derry','BT47 4TB', '02871346582', '07458931965', 'roryevans100@gmail.com'),
(5012, 'Mr', 'Coyle', 'Stephen', 'M', '19910209', '32 Culmore Road','Derry','Co Derry','BT47 4TB', '07756914238', '07693152485', 'stephencoyle@live.co.uk'), 
(5013, 'Mr', 'Murray', 'Mark', 'M', '19851203', '4b Enfield Street','Derry','Co Derry','BT47 4TB', '07925688149', '08556955741', 'markm@yahoo.com'), 
(5014, 'Mr', 'Donaghy', 'Martin', 'M', '19900429', '582 Duncrun Road','Limavady','Co Derry','BT47 4TB', '02877741596', '07844425889', 'martind@hotmail.com'), 
(5015, 'Miss', 'Jenkins', 'Hannah', 'F', '19920423', '94 Carrickbeg Avenue','Eglinton','Co Derry','BT47 4TB', '02871362894', '07854848562', 'hannah999@googlemail.com'), 
(5016, 'Mrs', 'Matthews', 'Louise', 'F', '19910608', '241 Clagan Road','Claudy','Co Derry','BT47 4TB', '07774698315', '07458458769', 'louisematthews@live.co.uk'), 
(5017, 'Miss', 'Cartin', 'Charlene', 'F', '19900409', '200 Rallagh Road','Dungiven','Co Derry','BT47 4TB', '07892579143', '08968477852', 'charlenec@hotmail.com'), 
(5018, 'Mr', 'Holmes', 'Kieran', 'M', '19880721', '34 Spencer Road','Waterside','Co Derry','BT47 4TB', '07985020748', '08696514789', 'kieran56@gmail.com') 


INSERT INTO Degree VALUES
(1000, 'S', 'Computer Science', 4),
(1001, 'S', 'Applied IT', 4),
(1002, 'S', 'Applied Maths', 3),
(1003, 'S', 'Chemistry', 4),
(1004, 'S', 'Software Engineering', 4),
(1005, 'S', 'Biology', 4),
(1006, 'S', 'Physics', 4),
(1007, 'S', 'BIO Chemistry', 4),
(1008, 'A', 'English', 3),
(1009, 'A', 'Art', 4),
(1010, 'A', 'History', 3),
(1011, 'A', 'French', 3);


INSERT INTO University VALUES
(1, 'QUB, Belfast'),
(2, 'UU Jordanstown'),
(3, 'UU Magee'),
(4, 'UU Coleraine'),
(5, 'John Moores, Liverpool'),
(6, 'Imperial College, London'),
(7, 'St Andrews, Fife'),
(8, 'Robert Gordan, Aberdeen'),
(9, 'Stevenson College, Edinburgh'),
(10, 'East Anglia');


INSERT INTO StudentChoice VALUES
(5003, 1, 1, 1000),
(5003, 2, 2, 1000),
(5003, 3, 3, 1001),
(5003, 4, 4, 1001),
(5003, 5, 7, 1001),
(5008, 1, 4, 1001),
(5008, 2, 4, 1002),
(5008, 3, 4, 1004),
(5008, 4, 4, 1006),
(5002, 1, 6, 1008),
(5002, 2, 6, 1009),
(5002, 3, 7, 1008),
(5002, 4, 7, 1009),
(5010, 1, 1, 1005),
(5010, 2, 1, 1006),
(5010, 3, 1, 1007),
(5012, 1, 3, 1001),
(5012, 2, 3, 1002),
(5012, 3, 3, 1004),
(5012, 4, 4, 1001),
(5012, 5, 4, 1002),
(5011, 1, 9, 1008),
(5011, 2, 9, 1009),
(5011, 3, 9, 1010),
(5011, 4, 10, 1009),
(5006, 1, 10, 1005),
(5006, 2, 10, 1009),
(5006, 3, 8, 1005),
(5006, 4, 8, 1006),
(5006, 5, 8, 1003),
(5009, 1, 1, 1002),
(5009, 2, 1, 1001),
(5009, 3, 2, 1002),
(5009, 4, 2, 1001),
(5013, 1, 1, 1010),
(5013, 2, 1, 1011),
(5013, 3, 2, 1010),
(5013, 4, 2, 1009),
(5005, 1, 5, 1001),
(5005, 2, 5, 1002),
(5005, 3, 5, 1000),
(5005, 4, 5, 1004),
(5016, 1, 3, 1000),
(5016, 2, 3, 1001),
(5016, 3, 3, 1004);



------------------------------EXERCISE 4-----------------------------------------------------------------------------------

------------------------UCAS DATABASE QUERIES--------------------------------------------------------------------------

---1.	Contents of the Student Table.
	SELECT *
	FROM Student

---2.	Contents of the University Table.
	SELECT *
	FROM University

---3.	Contents of the Degree Table.
	SELECT *
	FROM Degree

---4.	The title, surname, forename, gender and date of birth for all students, sorted by date of birth.
	SELECT Title, Surname, Forename, gender, dob
	FROM Student
	ORDER BY dob
	 
---5.	The title, surname, forename, gender and date of birth for all students, sorted by surname and forename.
	SELECT Title, Surname, Forename, Gender, dob
	FROM Student
	ORDER BY Surname, Forename

---6.	The title, surname, forename, gender and date of birth for all male students, ordered by Surname and Forename.
	SELECT Title, Surname, Forename, Gender, dob
	FROM Student
	WHERE gender = 'M'
	ORDER BY Surname, Forename

---7.	The title, surname, forename, gender and date of birth for all female students, ordered by Surname and Forename.
	SELECT Title, Surname, Forename, Gender, dob
	FROM Student
	WHERE gender = 'F'
	ORDER BY Surname, Forename

---8.	The name and address details of Student ID 5014.
	SELECT Title, Surname, Forename, Town, Street, County, PostCode
	FROM Student
	WHERE StudentID = '5014'

---9.	The name and address details of all students living in Derry.
	SELECT Title, Surname, Forename, Town, Street, County, PostCode
	FROM Student
	WHERE Town = 'Derry'


---10.	Details of all 3 year degree programs, sorted by degree name.
	SELECT *
	FROM Degree
	WHERE Duration = '3'
	ORDER BY DegreeName

---11.	Details of all 4 year degree programs, sorted by degree name.
	SELECT *
	FROM Degree
	WHERE Duration = '4'
	ORDER BY DegreeName

---12.	Details of all degree programs, sorted by degree class and degree name.
	SELECT *
	FROM Degree
	ORDER BY DegreeClass, DegreeName

---13.	Details of all arts degrees, sorted by degree name.
	SELECT *
	FROM Degree
	WHERE DegreeClass = 'A'
	ORDER BY DegreeName
	
---14.	Details of all science degrees, sorted by degree name.
	SELECT *
	FROM Degree
	WHERE DegreeClass = 'S'
	ORDER BY DegreeName
	
---15.	Detail of student university choices which should include student name and their choice details, sorted by student name and choice no.
	SELECT s.StudentID, s.Forename, s.Surname, sc.UniNo, u.UniName,
	sc.DegreeNo, d.DegreeName, d.Duration, sc.ChoiceNo
	FROM Student s 
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	JOIN Degree d ON d.DegreeNo = sc.DegreeNo

---16.	Details of Student ID 5006 including their study choices.  
	SELECT s.StudentID, s.Forename, s.Surname, 
	u.UniName, 
	sc.DegreeNo, 
	d.DegreeName 
	FROM Student s
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	JOIN Degree d ON d.DegreeNo = sc.DegreeNo
	WHERE s.StudentID = '5006'

---17.	Details of all student first choices, sorted by student name.
	SELECT s.Forename, s.Surname,
	sc.ChoiceNo, sc.DegreeNo,
	u.UniName,
	d.DegreeName
	FROM Student s
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	JOIN Degree d ON d.DegreeNo = sc.DegreeNo
	WHERE sc.ChoiceNo = '1'
	ORDER BY s.Forename

---18.	Details of students who what to study mathematics, sorted by student name and university name.
	SELECT s.Forename, s.Surname,
	u.UniName, 
	d.DegreeName
	FROM Student s
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	JOIN Degree d ON d.DegreeNo = sc.DegreeNo
	WHERE d.DegreeName = 'Applied Maths'
	ORDER BY s.Forename, u.UniName

---19.	Details of all Students who want to go to East Anglia.  Should include the student details only, sorted by student name.
	SELECT s.Title, s.Forename, s.Surname, s.gender
	FROM Student s
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	WHERE u.UniName = 'East Anglia'
	ORDER BY s.Forename

---20.	Details of all Students who want to go to East Anglia to study Art.  Should include the student details only, sorted by student name.
	SELECT s.Title, s.Forename, s.Surname, s.gender
	FROM Student s
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	JOIN Degree d ON d.DegreeNo = sc.DegreeNo
	WHERE u.UniName = 'East Anglia' AND d.DegreeName = 'Art'
	ORDER BY s.Forename

---21.	Details of all Students who want to go to Magee to study Applied IT.  Should include student details, student choice and degree name, sorted by student name and student choice.
	SELECT s.Title, s.Forename, s.Surname, s.gender,
	sc.ChoiceNo,
	d.DegreeName
	FROM Student s
	JOIN StudentChoice sc ON s.StudentID = sc.StudentID
	JOIN University u ON u.UniNo = sc.UniNo
	JOIN Degree d ON d.DegreeNo = sc.DegreeNo
	WHERE u.Uniname = 'UU Magee' AND d.DegreeName = 'Applied IT'
	ORDER BY s.Forename, sc.ChoiceNo
	
