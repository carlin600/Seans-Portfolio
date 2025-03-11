#Q2 - Update Query.
#The purpose of this query is to update an existing record within the database. 
#This will update a Suspects CrimeType via suspect ID

SELECT * FROM CRIME
WHERE SuspectID = 'SUS1000010'

UPDATE CRIME 
JOIN SUSPECT ON CRIME.SuspectID = SUSPECT.SuspectID
SET CRIME.CrimeType = 'Burglury'
WHERE SUSPECT.SuspectID = 'SUS1000010'

