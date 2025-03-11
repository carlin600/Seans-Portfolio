#Query 1
#Selecting all records from movie
SELECT * 
FROM cis24609650.Movie

#Setting WHERE clause paremeter - vote average between 8 and 9, followed by budget, popularity and runtime with specific values.
WHERE vote_average 
BETWEEN 8.0 AND 9.0  
AND budget >= 40000 
AND popularity >= 11 
AND runtime >= 50

#Alternative Method - But not as quick
#vote_average >= 8.0 && vote_average <= 9.0




