#Q4 - Multi-Row Functions

#Search Details with custom columns.
#I wanted to mix things up with this query and include some basic functions.
#I included basically all tables here, combining two columns using CONCAT and calculating the Age of suspects and 
#officers by subtracting their birth year from DOB data field, and subtracting it from 2021

SELECT s.SearchID, s.ObjectOfSearch, s.Legislation, s.Type, s.Date,
CONCAT (o.Firstname , o.Lastname) AS 'Officer Name', (2021 - YEAR(o.DOB)) AS 'Officer Age',
CONCAT(sus.Firstname , sus.Lastname) AS 'Suspect Name',(2021 - YEAR(sus.DOB)) AS 'Suspect Age', sus.PreviousConviction AS 'History', 
l.LSOAName AS 'Location',
ou.OutcomeResult AS 'Result'

FROM SEARCH s
LEFT JOIN OFFICER o ON s.OfficerID = o.OfficerID
LEFT JOIN SUSPECT sus ON s.SuspectID = sus.SuspectID
LEFT JOIN LOCATION l  ON s.LocationID = l.LocationID
LEFT JOIN OUTCOME ou  ON s.OutcomeID = ou.OutcomeID

/*Take Your pick from the following, all have been tested*/

#WHERE s.Date BETWEEN '2020-01-01' AND '2020-08-01'
#WHERE s.Legislation = 'Misuse of Drugs Act 1971 (section 23)'
#WHERE s.Type = 'Person search'

#ORDER BY o.Name
#ORDER BY s.SearchID
#GROUP BY s.Legislation


