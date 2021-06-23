---For Loop
--Will repeat a number of times specifically.
--for counter = number1, number2, number3 DO
--	code
--end

--Where number1 is the starting number
--number2 is the end number
--number3 is the step(can count by negative)

for i = 1,10 do
	print ( "loop: ", i )
end

--This skips every second number.
for i = 1, 10, 2 do
	print( "loop step: ", i )
end

--This skips every second number.
--BUT, it counts backwards by swapping the numbers.
for i = 10, 0, -2 do
	print( "loop step2: ", i )
end


--example - wont run here
--~ for i = 1, #shotTable do
--~ 	if( shotTable[i].myName ~= nil) then
--~ 		shotTable[i]:removeSelf()
--~ 		shotTable[i].myName = nil
--~ 	end
--~ end

--while loop
--Will continue to run until a condition is met.

--while condition do
--	code
--end

--if the condition is false, the loop will not reun/execute
local temp = true
local i = 1

while temp == true do
	print ( "loop while: ", i)
	i = i + 1
	if i == 10 then
	temp = false
	end
end

--Repeat loop
--repeat loop will continue until a condition is met
--repeat
--	code
--until condition

--will always execute atleast once



local temp = true
local i = 1

repeat
	print ( "repeat loop: ", i )
	i = i + 1
	if	i == 10 then
		temp = false
	end
until not temp












