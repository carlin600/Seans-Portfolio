--Passing Parameters & Arguments

--A Parameter is a variable in a functions definition
--local function sampleFunction(myParameter)
--An arugment is the data that is passed to the parameter

--Using myModule.lua from last tutorial

local myMod = require ( "myModule" )

local temp = myMod.hi("b")

print ( temp )

print( myMod.twofer( 1, 2, 3) )

local a, b, c, d = myMod.twofer(1,2,3)

print ( a )

print ( b )

print ( c )

print ( d )

local function tablePass( p1 )
	table.sort(p1)
	return p1
end

local function showTable( p2 )
	for key, value in pairs(p2) do
		print( key, value )
	end
end

local myTable = {1,2,5,3,7,9,1}

showTable( myTable )
local myNewTable = tablePass ( myTable )
print("Table after sort")
showTable( myTable )
print( "My new table" )
showTable( myNewTable )


--if you put 3 ... in the parameter section of the function, it tells
--lua that you dont know how many parameters will be passed in
local function myAddition(...)
	local sum = 0
	for index, value in ipairs{...} do
		sum = sum + value
	end
	return sum
end

print( myAddition(1,2,3,1,4,5))
print( myAddition(1,2))
