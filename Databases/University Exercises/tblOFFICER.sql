CREATE TABLE cis24609650.OFFICER
(
OfficerID			CHAR(10)		NOT NULL,
BadgeID				INT				NOT NULL,
Firstname			CHAR(30)		NOT NULL,
Lastname			CHAR(30)		NOT NULL,
Gender				CHAR(7)			NOT NULL,
DOB					DATE			NOT NULL,


PRIMARY KEY(OfficerID)
)

DROP TABLE cis24609650.OFFICER

INSERT INTO cis24609650.OFFICER(OfficerID,BadgeID, Firstname, Lastname, Gender, DOB) VALUES
('OFF1000001', 156898, 'Stan', ' Sander',  'Male','1961-01-14'),
('OFF1000002', 156953, 'Jonathan', ' Stamp', 'Male','1968-06-25'),
('OFF1000003', 158947, 'Niki', ' Upton','Female','1971-10-31'),
('OFF1000004', 158975, 'Gisa', ' Spurling','Female','1992-06-21'),
('OFF1000005', 159649, 'Charlton', ' Kranz','Male','1995-01-05'),
('OFF1000006', 156963, 'Daren', ' Blau','Male','1961-11-18'),
('OFF1000007', 153589, 'Benedict', ' Sponaugle','Male','1972-04-29'),
('OFF1000008', 156515, 'Kelli', ' Shepherd','Female','1973-06-10'),
('OFF1000009', 156894, 'Paul', ' Kerper','Male','1984-06-11'),
('OFF1000010', 156397, 'Mart', ' Eldridge','Male','1990-11-09');







