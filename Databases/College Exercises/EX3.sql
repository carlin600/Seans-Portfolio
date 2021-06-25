
---EXERCISE 3 ---
CREATE DATABASE EX3


---1. CREATE THE FOLLOWING TABLE ---
CREATE TABLE EMPLOYEE
(	
	EmployeeNo		int IDENTITY(50000,1) 	NOT NULL,
	Title			varchar(5)				NOT NULL,
	Surname			varchar(30)				NOT NULL,
	Forename		varchar(30)				NOT NULL,
	Street			varchar(50)				NOT NULL,
	Town			varchar(20)				NOT NULL,
	County			varchar(20)				NOT NULL,
	Postcode		varchar(8)				NOT NULL,
	Salary			int						NOT NULL,

	CONSTRAINT pkEmployeeNo PRIMARY KEY (EmployeeNo)
);


---2. POPULATE IT WITH THE FOLLOWING ---
INSERT INTO EMPLOYEE
(Title,Surname,Forename,Street,Town,County,Postcode,Salary)
VALUES
('Mr', 'Morrison', 'Brendan', '159 Main Street','Eglinton','Co Derry','BT47 4TB',23500),   
('Miss', 'Rankin', 'Kathy', '56 Greenhaven','Drumahoe','Co Derry','BT48 3SY',31750),  
('Mr', 'Carlin', 'Sean', '98 Larch Road','Eglinton','Co Derry','BT47 4TB',15655), 
('Mr', 'Cunning', 'Tom', '115 NewLine Road','Newbuildings','Co Derry','BT47 4TB',16900), 
('Mr', 'Wilson', 'Robert', '45 Hollyfoot Hill','Ballykelly','Co Derry','BT47 4TB',12850), 
('Mr', 'Lynch', 'Conan', '126 Dungiven Road','Derry','Co Derry','BT47 4TB',54050),
('Mrs', 'Collins', 'Joanne', '62 Limavady Road','Ballykelly','Co Derry','BT47 4TB',18995),
('Mr', 'Gallagher', 'Adam', '76 Church Brae','Derry','Co Derry','BT47 4TB',34650),
('Mrs', 'Costello', 'Niamh', '34 Strand Road','Derry','Co Derry','BT47 4TB',16900), 
('Mr', 'Doherty', 'Kevin', '624 Glenshane Road','Claudy','Co Derry','BT47 4TB',65425),
('Miss', 'Heaney', 'Amanda', '22 Dungiven Road','Limavady','Co Derry','BT47 4TB',17385);


---3.Create the following queries:---
---(a)Select all columns for everyone in the Employee table.---
SELECT * 
FROM EMPLOYEE
---(b)Amend the above query to sort the details by Surname ascending.---
SELECT * 
FROM EMPLOYEE
ORDER BY Surname ASC
---(c)Select all columns for everyone with a salary over 30000.---
SELECT *
FROM EMPLOYEE
WHERE Salary > 30000
---(d)	Select first and last names for every male employee, sorted by Employee ID descending.---
SELECT Forename, Surname 
FROM EMPLOYEE
WHERE Title = 'Mr'
ORDER BY EmployeeNo DESC
---(e)	Select first and last names for every female employee, sorted by Town.---
SELECT Forename, Surname
FROM EMPLOYEE
WHERE Title = 'Miss' OR Title = 'Mrs'
ORDER BY Town
---(f)	Select first name, last name, and salary for anyone called Kevin.---
SELECT Forename, Surname, Salary
FROM EMPLOYEE
WHERE Forename = 'Kevin'
---(g)	Select all columns for everyone who lives in Ballykelly.---
SELECT *
FROM EMPLOYEE
WHERE Town = 'Ballykelly'
---(h)	Return the full name and title of the person who earns 16900 and lives in Newbuildings.---
SELECT Title, Forename, Surname
FROM EMPLOYEE
WHERE Salary = 16900 AND Town = 'Newbuildings'
---(i)	Return the name and the salary of the employee who live at 98 Larch Road.---
SELECT * 
FROM EMPLOYEE
WHERE Street = '98 Larch Road'
---(j)	Return the names of the employees who earn between 15000 and 35000 per year.---
SELECT Forename, Surname, Salary
FROM EMPLOYEE
WHERE Salary >= 15000 OR Salary <=35000 
---(k)	Return the names of the employees who earn less than 15000 or more than 35000 per year.---
SELECT Forename, Surname, Salary
FROM EMPLOYEE
WHERE Salary <15000 OR Salary >35000
---(l)	Return all details for employees whose surname begins with ‘C’.---
SELECT *
FROM EMPLOYEE
WHERE Surname LIKE 'C%'
---(m)	Return all details for employees whose surname does not begin with either a ‘C’ or a ‘G’.---
SELECT *
FROM EMPLOYEE
WHERE Surname NOT LIKE '[CG]%'
---(n)	Return all details for employees whose forename contains an ‘a’.---
SELECT *
FROM EMPLOYEE
WHERE Forename LIKE '%a%'
---(o)	Return the surname and forename of all employees who do not earn 16900, 18995, 17385 or 31750 per year.  Sort the results in ascending order by Salary.---