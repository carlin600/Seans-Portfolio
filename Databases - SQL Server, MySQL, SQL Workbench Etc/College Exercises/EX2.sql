USE Training

ALTER TABLE Course
DROP CONSTRAINT fkTutorID

ALTER TABLE Enrolment
DROP CONSTRAINT fkEmployeeID, fkCourseID

ALTER TABLE Employee
DROP CONSTRAINT fkDeptID

DROP TABLE Tutor, Enrolment


--------------Department---------------
ALTER TABLE Department
DROP CONSTRAINT pkDeptID

ALTER TABLE Department
ADD DepartmentNo int NOT NULL

ALTER TABLE Department
DROP COLUMN DeptID, DepName

ALTER TABLE Department
ADD DepartmentName varchar(30) NOT NULL, Manager varchar(20) NOT NULL, Email varchar(40) NOT NULL

ALTER TABLE Department
ADD CONSTRAINT pkDepartmentNo PRIMARY KEY (DepartmentNo)


--------------Employee---------------
ALTER TABLE Employee
DROP CONSTRAINT pkEmployeeID 

ALTER TABLE Employee
DROP COLUMN EmployeeID,Street,Town,County,TelNo,ExtNo,DeptId

ALTER TABLE Employee
ADD EmployeeNo int NOT NULL, Address varchar(20) NOT NULL, TelephoneNo varchar(20) NOT NULL, DOB date NOT NULL, JoinDate date NOT NULL, DepartmentNo int NOT NULL, Salary money NOT NULL

ALTER TABLE Employee
ADD CONSTRAINT pkEmployeeNo PRIMARY KEY (EmployeeNo)

ALTER TABLE Employee
ADD CONSTRAINT fkDepartmentNo FOREIGN KEY (DepartmentNo) REFERENCES Department (DepartmentNo)

--------------Course---------------
ALTER TABLE Course
DROP CONSTRAINT pkCourseID

ALTER TABLE Course
DROP COLUMN CourseID,CourseTitle,StartDate,TutorID

ALTER TABLE Course
ADD CourseCode int NOT NULL, Title varchar(30) NOT NULL, Duration smalldatetime NOT NULL, CourseType varchar(30) NOT NULL

ALTER TABLE Course
ADD CONSTRAINT pkCourseCode PRIMARY KEY (CourseCode)


--------------Location---------------
CREATE TABLE Location
(
	LocationCode	int				NOT NULL,
	Location		varchar(30)		NOT NULL,
	NoOfDelegates	int				NOT NULL,

	CONSTRAINT pkLocationCode PRIMARY KEY (LocationCode)

)


--------------CourseSchedule---------------
CREATE TABLE CourseSchedule
(
	CourseCode			int				NOT NULL,
	CourseDate			smalldatetime	NOT NULL,
	LocationCode		int				NOT NULL,
	TrainingProvider	varchar(30)		NOT NULL,
	AttendDate			smalldatetime	NOT NULL,

	CONSTRAINT pkCourseSchedule PRIMARY KEY (CourseDate , CourseCode),
	CONSTRAINT fkCourseCode FOREIGN KEY (CourseCode) REFERENCES Course (CourseCode),
	CONSTRAINT fkLocationCode FOREIGN KEY (LocationCode) REFERENCES Location (LocationCode)

)

--------------Delegate---------------
CREATE TABLE Delegate
(
	CourseCode			int				NOT NULL,
	CourseDate			smalldatetime	NOT NULL,
	EmployeeNo			int				NOT NULL,
	Attended			int				NOT NULL,


	CONSTRAINT pkDelegate PRIMARY KEY (CourseDate , CourseCode, EmployeeNo),
	CONSTRAINT fkDelegate FOREIGN KEY (CourseDate , CourseCode) REFERENCES CourseSchedule (CourseDate , CourseCode),
	CONSTRAINT fkEmployeeNo FOREIGN KEY (EmployeeNo) REFERENCES Employee (EmployeeNo),


)