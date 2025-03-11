#Q3 - Delete Query
#This query was made to delete a record from its specified entry. You can see for this 
#query its a Suspect Record from the Search table. If i were to delete a suspect directly
#from the suspect table, it would cause a foreign constraint error.

SELECT * FROM SEARCH

DELETE SEARCH
FROM SEARCH
LEFT JOIN SUSPECT ON SEARCH.SuspectID = SUSPECT.SuspectID
WHERE SUSPECT.SuspectID = 'SUS1000010'


