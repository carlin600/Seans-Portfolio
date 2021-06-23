--Operating System Library

--Time - returns OS current time
--Date - returns OS current data
--Clock - returns execution time of program
--getenv - returns the environment program
--exit - terminates the program
--execute - runs system command
--setlocale - set location for program
--difftime - returns number of seconds between 2 given times
--remove - deletes a file or directory
--rename - renames a file or directory


--os.times
--Converts a given date/time into seconds
--when called without arguments, returns current(OS) date and time

print( os.clock() )

local t1 = os.time()
print ( t1 )

local t2 = os.time({
	year = 1999,
	month = 1,
	day = 1,
	hour = 12,
	min = 10,
	sec = 30
	})

	print(t2)

	print( "Seconds Difference: ", os.difftime( t1, t2) )


--os.date
--Converts from seconds back to date/time(opposite of os.time)
--returns a table when given an argument and time number value

print ( os.date() )

local date1 = os.date("*t", t2 )
for key, value in pairs(date1) do
	print( key, value )
end

print( os.date( "%A", t2) )

print ( os.getenv("Home") )

--this would get you rejected from the app store
os.exit()






