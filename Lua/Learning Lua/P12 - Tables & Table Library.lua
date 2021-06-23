--Data structures, tables, arrays, lists, records, queues & sets

--Lua Tables
--used to represent data structures in Lua like arrays, records, lists, queues, sets

--Arrays
--start with an index of 1 in Lua
--Values can be assigned as a singoe expression

--local binary = {1,2,4,8,16,32,64,128,256}




--Basically prints out its given number 10 times - i also inserted i so it shows you what index is which
local number = { } -- initializes table or array
for i = 1 , 10 do
	number[i] = 0
	print(i, number [i] )
end


--multi-dimensional Arrays or Marices
--storing array within an array
local matrix = { }
for i = 1, 10 do
	matrix[i] = { }
	for j = 1, 10 do
		matrix[i][j] = 0
	end
end

--table library
--# - returns the size of the array(number of elements)
--table.insert - inserts an element in a given position
--table.remove - removes an element from a given position
--table.sort - sorts the table


local list = {5, 7, 1, 10, 12, 6}
table.insert(list, 2, 8) -- table name, location to insert, value)
for i = 1, #list do
	print( list[i] )
end








