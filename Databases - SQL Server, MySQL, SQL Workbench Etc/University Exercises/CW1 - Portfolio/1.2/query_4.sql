#Query 4
#Selecting specific columns from Movie.
SELECT Movie.id, Movie.title, Movie.vote_average
FROM Genre

#Joining HasGenre to Genre to retrieve the actual fields that have 'Genre'
JOIN HasGenre
ON Genre.genre_id = HasGenre.genre_id

#Joining HasSpokenLanguage on HasGenre to grab specific records containing 'ja' with Action genre.
JOIN HasSpokenLanguage
ON HasGenre.id = HasSpokenLanguage.id

#Joining Movie to HasGenre to retrieve records from the Movie table
JOIN Movie
ON HasSpokenLanguage.id = Movie.id 

#Setting specific WHERE clause, all Japanese Action movies will be returned.
WHERE Genre.genre = 'Action' 
AND HasSpokenLanguage.spoken_language_iso_code = 'ja'

#Returned records are ordered by vote average descending
ORDER BY vote_average DESC