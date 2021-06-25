CREATE TABLE cis24609650.OUTCOME
(
OutcomeID						CHAR(10)			NOT NULL,
OutcomeResult					CHAR(35)			NOT NULL,
LastOutcomeCategory				CHAR(50)			NOT NULL,
OutcomeLinkedToObjectOfSearch	BOOLEAN				NOT NULL,
Context							CHAR(50)			NOT NULL,

PRIMARY KEY(OutcomeID)
)

DROP TABLE cis24609650.OUTCOME

INSERT INTO cis24609650.OUTCOME(OutcomeID,OutcomeResult,LastOutcomeCategory,OutcomeLinkedToObjectOfSearch,Context) VALUES
('OUTID10001','Suspect arrested','Unable to prosecute suspect', FALSE, ''),
('OUTID10002','Nothing found - no further action','Investigation complete; no suspect identified', FALSE, ''),
('OUTID10003','Suspect arrested','Suspect charged', FALSE, ''),
('OUTID10004','Nothing found - no further action','Investigation complete; no suspect identified', FALSE, ''),
('OUTID10005','Nothing found - no further action','Investigation complete; no suspect identified', FALSE, ''),
('OUTID10006','Nothing found - no further action','Investigation complete; no suspect identified', FALSE, ''),
('OUTID10007','Suspect arrested','Under investigation', FALSE, ''),
('OUTID10008','Suspect arrested','Suspect charged', FALSE, ''),
('OUTID10009','Suspect arrested','Under investigation', FALSE, ''),
('OUTID10010','Suspect arrested','Local resolution', FALSE, '')

