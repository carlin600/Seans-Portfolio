#Q1 - Retrieve Interesting Data.
#This query represents data that involves Crimes committed followed by the Region it was reported in, the date
#the crime occured and the suspects information. 

SELECT c.CrimeType, c.ReportedBy, c.Date,
s.Firstname, s.Lastname, s.Gender, (2021 - YEAR(s.DOB)) AS 'Suspect Age'
FROM CRIME c
LEFT JOIN SUSPECT s ON c.SuspectID = s.SuspectID
ORDER BY c.Date



