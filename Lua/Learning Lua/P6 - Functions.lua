--Parts of a function
-- function name(parameters)
	--code block
	--return
-- end

-- Parameters & return are optional
--all functions must finish with 'end' so Lua knows you are done with that function

function addOne(numberOne)
result = numberOne + 1
print(result)
end

--number 5 is passed into the parameter for the function.
addOne(5)


addTwo = function ()
	result2 = 5 + 3
	result3 = 42
	return result2, result3
end

temp1, temp2 = addTwo()
print(temp1)
print(temp2)

