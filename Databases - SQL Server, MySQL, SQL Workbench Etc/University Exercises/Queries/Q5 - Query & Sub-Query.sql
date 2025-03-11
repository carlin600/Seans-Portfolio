#Q5 - Query with a Sub-Query
#Displaying Officers by their Search History Categorised.
#You can see the officers information and it displays the officers that match both ObjectOfSearch data fields.

SELECT o.Firstname, o.Lastname, o.Gender, (2021 - YEAR(o.DOB)) AS 'Officer Age'
FROM OFFICER o
WHERE OfficerID IN 
(
SELECT OfficerID 
FROM SEARCH 
WHERE ObjectOfSearch = 'Controlled Drugs' OR ObjectOfSearch = 'Stolen Goods'
)
