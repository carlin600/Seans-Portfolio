CREATE TABLE cis24609650.CRIME
(
CrimeID				CHAR(10)	NOT NULL,
CrimeType			CHAR(30)	NOT NULL,
ReportedBy			CHAR(30)	NOT NULL,
Context				CHAR(30)	NOT NULL,
Date				DATE		NOT NULL,
FallsWithin			CHAR(30)	NOT NULL,
PoliceOperation		BOOLEAN		NOT NULL,
SuspectID			CHAR(10)	NOT NULL,
OutcomeID			CHAR(10)	NOT NULL,

PRIMARY KEY(CrimeID),
FOREIGN KEY (SuspectID) REFERENCES SUSPECT(SuspectID),
FOREIGN KEY (OutcomeID) REFERENCES OUTCOME(OutcomeID)
)

DROP TABLE cis24609650.CRIME

INSERT INTO cis24609650.CRIME(CrimeID,CrimeType,ReportedBy,Context,Date,FallsWithin,PoliceOperation,SuspectID,OutcomeID) VALUES
('CRIME10001','Violence and sexual offences', 'Lancashire Constabulary','','2020-03-11','Lancashire Constabulary', TRUE, 'SUS1000001','OUTID10001'),
('CRIME10002','Anti-social behaviour', 'Lancashire Constabulary','','2020-03-20','Lancashire Constabulary', TRUE, 'SUS1000002','OUTID10002'),
('CRIME10003','Violence and sexual offences', 'Lancashire Constabulary','','2020-04-01','Lancashire Constabulary', TRUE, 'SUS1000003','OUTID10003'),
('CRIME10004','Anti-social behaviour', 'Lancashire Constabulary','','2020-04-13','Lancashire Constabulary', TRUE, 'SUS1000004','OUTID10002'),
('CRIME10005','Robbery', 'Lancashire Constabulary','','2020-06-01','Lancashire Constabulary', TRUE, 'SUS1000005','OUTID10005'),
('CRIME10006','Shoplifting', 'Lancashire Constabulary','','2020-01-26','Lancashire Constabulary', TRUE, 'SUS1000006','OUTID10006'),
('CRIME10007','Bicycle theft', 'Lancashire Constabulary','','2020-01-29','Lancashire Constabulary', TRUE, 'SUS1000007','OUTID10007'),
('CRIME10008','Violence and sexual offences', 'Lancashire Constabulary','','2020-01-31','Lancashire Constabulary', TRUE, 'SUS1000008','OUTID10008'),
('CRIME10009','Burglary', 'Lancashire Constabulary','','2020-07-31','Lancashire Constabulary', TRUE, 'SUS1000009','OUTID10009'),
('CRIME10010','Vehicle crime', 'Lancashire Constabulary','','2020-12-06','Lancashire Constabulary', TRUE, 'SUS1000010','OUTID10010')








