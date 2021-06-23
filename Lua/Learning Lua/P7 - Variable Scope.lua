--Variable Scope
--Global - A variable whose value is available anywhere in the program
--used for large programs with a lot of external files

--Local - A variable that is available only in a localize portion of the application
--Only available inside this Lua file due to be 'Local'.

temp = "Hi"
_G.temp2 = "hi"

print (temp)
print (temp2)

local function test1()
--this temp is local so it doesnt overwrite the previously declared temp above.
	local temp = "No longer hi"
	print (temp)
end

test1()
print("line 13", temp)


