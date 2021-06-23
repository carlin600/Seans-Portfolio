--Used to handle decision or mutliple situations in Lua

--IF comparision THEN
--		code
--	END

--comparision operators

--and		or		not
--	<		>
--	>=	<=		~=		==

local count = 1
local answer = "yes"
local lives = 0

--true situation
if count == 1 and answer == "yes" then
	print("1.if-then using and")
end

--first part is true, second is false.
--As long as one of the two conditions is true, it will run
if count == 1 or answer == "no" then
	print("2.if-then using or")
end

--not evaluates the opposite of the situation.
--it would be false, however not reverses it, making it true.
if not (count == 0) then
	print("3.if-then using not")
end

--As long as the section within the brackets is equal to true, then the 'and'
--will be evaluated as true.
if count == 1 and (answer == "no" or lives == 0) then
	print("4.if-then complex comparison")
end

--IF-THEN ELSE
--IF comparision THEN
--		code
--	else
--		code
--end


local count2 = 0

--if requirements are met it runs the first print. If anything ELSE, it will run the second print.
-- ~= means not equal to
if count2 == 1 then
	print ("Equal if-then structure count = 1")
else
	print("if-then else, count ~= 1")
end

--NESTED IF
--if-then commands can be nested

----NESTED IF
--IF comparison THEN
--	if comparison 2 then
--		code
--	end
--		optional code
--end

local count3 = 0
local answer2 = "yes"

if count3 == 0 then
	if answer2 == "yes" then
		print("Nested if-then answer equals yes")
	end
else
	if answer2 == "no" then
		print("Nested if, count ~= 0, answer equals no")
	end
end


--elseif
--same as else followed by if, but avoids the use of multiple end

--if comparison then
--	code
--elseif condition then
--	code
--end

local newcount = 0

if newcount == 0 then
	print( "if-then newcount equals 0" )
elseif newcount == 1 then
	print( "elseif, count = 1" )
elseif newcount == 1 then
	print( "elseif, count = 2" )
else
	print ("else, count not equal to 0, 1, or 2" )
end






