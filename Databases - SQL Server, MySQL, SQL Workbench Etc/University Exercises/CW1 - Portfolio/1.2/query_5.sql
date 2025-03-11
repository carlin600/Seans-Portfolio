#Query 5
#Selecting all records from movie
SELECT *
FROM Genre 

#Joining HasGenre to Genre to retrieve the actual fields that have 'Genre'
JOIN HasGenre
ON Genre.genre_id = HasGenre.genre_id

#Joining Movie to HasGenre to retrieve records from the Movie table
JOIN Movie
ON HasGenre.id = Movie.id 

#Setting specific WHERE clause, all Action movies will be returned.
WHERE Genre.genre = 'Science Fiction' 
AND popularity > vote_average

#Returned records are ordered by popularity descending, limited to 10 records.
ORDER BY popularity DESC
LIMIT 0,10;