--Input & Output
--i/o library
--io.input(filename)
--io.output(filename)
--io.open(filename, model)
--io.close(filename)

--io.read(arguments)
--io.read(arguments)

io.write("How old are you? ")
local answer = io.read()

if tonumber(answer) > 37 then
	io.write("You're Old!" )
elseif tonumber(answer) < 37 then
	io.write("You're Young!")
else
	io.write("You're not ld, you're only 37!")
end


--writing out to a file
--this creates the file
io.output("tempfile")
--sends this out to the file
io.write("42")
--closes the file
io.close()

io.input("tempfile")

local info = io.read("*all")

print (info)


--io.read
--Read parameters

--"*all" - reads whole file
--"*line" - reads the next line
--"*number" - reads a number
--number - reads a sting with up to number characters.

--io.open
--modes
--r - read
--w - write
--b - binary

local file = io.open("tempfile", "w")
file:write("Hello World")
file:close()

local file = io.open("tempfile","r")
local temp = file:read("*line")
file:close()
print(temp)






