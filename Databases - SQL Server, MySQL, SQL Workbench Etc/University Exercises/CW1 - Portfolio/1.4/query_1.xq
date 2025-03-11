(:Query 1.	Retrieve all movies (all fields for each movie) with a vote_average value equal or greater than 6.5 and a vote_average value equal or less than 8.4:)

(:declaring xml_file location:)
let $xml_file := doc("C:\Users\Temporary\OneDrive - Edge Hill University\3rd Year\Advanced Databases - CIS3155\CW1\1.4\tmdb_5000_movies.xml")

(:declaring variable $movie and linking it to movie within xml database:)
let $movies := $xml_file/movies/movie

(:for loop that will go through every movie - whilst grabbing the vote_average text:)
for $movie in $movies

(:declaring vote_average within movie xml.:)
let $vote_average := $movie/vote_average/text()

(:Setting the boundaries/specifics for the vote_average, retrieving only those between 6.5 and 8.4:)
where $vote_average >= 6.5 and $vote_average <= 8.4

(:Returns all declared details for movie:)
return $movie