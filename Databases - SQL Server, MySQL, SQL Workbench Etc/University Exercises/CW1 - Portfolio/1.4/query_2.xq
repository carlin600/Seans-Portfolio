(:Query 2.	Retrieve all movies (all fields for each movie) that contain the word ‘American’ in their title. The retrieved movies should be sorted in a descending order of their vote_average value.:)

(:declaring xml_file location:)
let $xml_file := doc("C:\Users\Temporary\OneDrive - Edge Hill University\3rd Year\Advanced Databases - CIS3155\CW1\1.4\tmdb_5000_movies.xml")

(:declaring variable $movie and linking it to movie within xml database:)
let $movies := $xml_file/movies/movie

(:for loop that will go through every movie - whilst grabbing the vote_average and title text:)
for $movie in $movies

(:declaring title and vote_average within movie xml.:)
let $title := $movie/title/text()
let $vote_average := $movie/vote_average/text()

(:Setting parameter to only retrieve records that have 'American' within the title:)
where contains ($title, 'American')

(:Since the vote_average is a decimal value, it must be formatted/cast using xs:decimal:)
(:Ordered by vote_average in descending order:)
order by xs:decimal ($vote_average) descending

(:Returns all declared details for movie:)
return $movie