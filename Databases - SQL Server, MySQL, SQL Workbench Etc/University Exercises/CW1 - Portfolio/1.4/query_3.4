(:Query 3.	Retrieve all Action movies (the value of genre in the Genre table is ‘Comedy’). Your query should retrieve the id, title and vote_average for each Action movie. The retrieved Action movies should be sorted in a descending order of their vote_average value.:)

(:declaring xml_file location:)
let $xml_file := doc("C:\Users\Temporary\OneDrive - Edge Hill University\3rd Year\Advanced Databases - CIS3155\CW1\1.4\tmdb_5000_movies.xml")

(:declaring variable $movie and linking it to movie within xml database:)
let $movies := $xml_file/movies/movie

(:for loop that will go through every movie - whilst grabbing the id, title, genre and vote_average text:)
for $movie in $movies

(:declaring id,title,genre and vote_average within movie xml.:)
let $id := $movie/@id
let $title := $movie//title/text()
let $genre := $movie/genre/text()
let $vote_average := $movie/vote_average/text()

(:Setting parameter to only retrieve records that have 'Action' and 'Comedy' within the title:)
where $genre = 'Comedy'

(:Since the vote_average is a decimal value, it must be formatted/cast using xs:decimal:)
(:Ordered by vote_average in descending order:)
order by xs:decimal ($vote_average) descending

(:Returns the id, title, vote average for each movie:)
(:Formatted with a string-join to keep all returned title on one line for eligibility:)
return string-join(($id,$title,$vote_average),',')