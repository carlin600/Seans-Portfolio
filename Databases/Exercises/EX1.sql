CREATE DATABASE Training

USE Training

CREATE TABLE Tutor
(
	TutorID		int				NOT NULL,
	Surname		varchar(20)		NOT NULL,
	Forename	varchar(20)		NOT NULL,
	Street		varchar(30)		NOT NULL,
	City		varchar(30)		NOT NULL,
	County		varchar(20)		NOT NULL,
	PostCode	varchar(10)		NOT NULL,
	TelNo		int				NOT NULL,

	CONSTRAINT pkTutorID PRIMARY KEY (TutorID)

)

CREATE TABLE Course
(
	CourseID		int				NOT NULL,
	CourseTitle		varchar(20)		NOT NULL,
	Cost			int				NOT NULL,
	StartDate		date			NOT NULL,
	TutorID			int				NOT NULL,

	CONSTRAINT pkCourseID PRIMARY KEY (CourseID),
	CONSTRAINT fkTutorID FOREIGN KEY (TutorID) REFERENCES Tutor(TutorID)

)

CREATE TABLE Department
(
	DeptID		int				NOT NULL,
	DepName		varchar(20)		NOT NULL,

	CONSTRAINT pkDeptID PRIMARY KEY (DeptID)
)

CREATE TABLE Employee
(
	EmployeeID	int				NOT NULL,
	Surname		varchar(20)		NOT NULL,
	Forename	varchar(20)		NOT NULL,
	Street		varchar(30)		NOT NULL,
	Town		varchar(30)		NOT NULL,
	County		varchar(20)		NOT NULL,
	PostCode	varchar(10)		NOT NULL,
	TelNo		varchar(20)		NOT NULL,
	ExtNo		int				NOT NULL,
	DeptID		int				NOT NULL,

	CONSTRAINT pkEmployeeID PRIMARY KEY (EmployeeID),
	CONSTRAINT fkDeptID FOREIGN KEY (DeptID) REFERENCES Department (DeptID)

)

CREATE TABLE Enrolment
(
	CourseID		int				NOT NULL,
	EmployeeID		int				NOT NULL,

	CONSTRAINT pkEnrolement PRIMARY KEY (CourseID , EmployeeID),
	CONSTRAINT fkEmployeeID FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID),
	CONSTRAINT fkCourseID FOREIGN KEY (CourseID) REFERENCES Course (CourseID)

)