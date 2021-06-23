--Pairs & iPairs
--Generic For loop
--used to work with tables
--ipairs for ordered tables--pairs for unordered(or multidimensional)

--Terms Key & Value
--Tables have a key(or index). Each key has a value

local myTable = {"Hi", "Hello", "World", 42, "inconceivable!"}

for index, value in ipairs( myTable ) do
	--print(value)
	print (index, value)
end

local myTable2 = {"Name", "Age", "Seat", "Grade", "Date"}
myTable2.Name = "Joe"
myTable2.Age = 12
myTable2.Seat = B12
myTable2.Grade = 7
myTable2.Date = "May 12th, 2000"

--print (#myTable2)

for key, value in pairs( myTable2 ) do
	print( key .. ": ", value )
end
