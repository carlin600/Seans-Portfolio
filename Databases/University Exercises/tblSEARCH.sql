CREATE TABLE cis24609650.SEARCH
(
SearchID							CHAR(10)		NOT NULL,
ObjectOfSearch						CHAR(30)		NOT NULL,
ObjectLinkedToOutcomeOfSearch		BOOLEAN			NOT NULL,
RemovelOfMoreThanOuterClothing		BOOLEAN			NOT NULL,
Legislation							CHAR(50)		NOT NULL,
Type								CHAR(30)		NOT NULL,
Date								DATE			NOT NULL,
OfficerID							CHAR(10)		NOT NULL,
SuspectID							CHAR(10)		NOT NULL,
LocationID							CHAR(10)		NOT NULL,
OutcomeID							CHAR(10)		NOT NULL,

PRIMARY KEY(SearchID),
FOREIGN KEY(OfficerID) REFERENCES OFFICER(OfficerID),
FOREIGN KEY(SuspectID) REFERENCES SUSPECT(SuspectID),
FOREIGN KEY(LocationID) REFERENCES LOCATION(LocationID),
FOREIGN KEY(OutcomeID) REFERENCES OUTCOME(OutcomeID)

)
DROP TABLE cis24609650.SEARCH


INSERT INTO cis24609650.SEARCH(SearchID, ObjectOfSearch, ObjectLinkedToOutcomeOfSearch, 
RemovelOfMoreThanOuterClothing, Legislation,Type, Date, OfficerID, SuspectID, LocationID, OutcomeID) VALUES
('SEARCH1001','Controlled drugs',FALSE, FALSE, 'Misuse of Drugs Act 1971 (section 23)','Person search','2020-02-20',									'OFF1000001','SUS1000001','LOC1000001','OUTID10001'),
('SEARCH1002','Stolen goods',FALSE, FALSE, 'Police and Criminal Evidence Act 1984 (section 1)','Person search','2020-03-02',							'OFF1000002','SUS1000002','LOC1000002','OUTID10002'),
('SEARCH1003','Article for use in theft',FALSE, FALSE, 'Police and Criminal Evidence Act 1984 (section 1)','Person and Vehicle search','2020-05-20',	'OFF1000003','SUS1000003','LOC1000003','OUTID10003'),
('SEARCH1004','Firearms',FALSE, FALSE, 'Firearms Act 1968 (section 47)','Person and Vehicle search','2020-01-25',										'OFF1000004','SUS1000004','LOC1000004','OUTID10004'),
('SEARCH1005','Offensive weapons',FALSE, FALSE, 'Firearms Act 1968 (section 47)','Person search','2020-08-10',											'OFF1000005','SUS1000005','LOC1000005','OUTID10005'),
('SEARCH1006','Stolen goods',FALSE, FALSE, 'Police and Criminal Evidence Act 1984 (section 1)','Person and Vehicle search','2020-01-02',				'OFF1000006','SUS1000006','LOC1000006','OUTID10006'),
('SEARCH1007','Controlled drugs',FALSE, FALSE,'Misuse of Drugs Act 1971 (section 23)','Person and Vehicle search','2020-12-06',						'OFF1000007','SUS1000007','LOC1000007','OUTID10007'),
('SEARCH1008','Stolen goods',FALSE, FALSE,'Police and Criminal Evidence Act 1984 (section 1)','Person and Vehicle search','2020-08-06',				'OFF1000008','SUS1000008','LOC1000008','OUTID10008'),
('SEARCH1009','Controlled drugs',FALSE, FALSE, 'Misuse of Drugs Act 1971 (section 23)','Person search','2020-02-09',									'OFF1000009','SUS1000009','LOC1000009','OUTID10009'),
('SEARCH1010','Firearms',FALSE, FALSE, 'Firearms Act 1968 (section 47)','Person and Vehicle search','2020-05-20',										'OFF1000010','SUS1000010','LOC1000010','OUTID10010')


