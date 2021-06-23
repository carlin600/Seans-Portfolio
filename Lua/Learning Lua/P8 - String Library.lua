--String Libray
--Consists of various commands to make using strins much easier
--byte
--char
--find
--format
--gmatch
--gsub
--len
--lower
--match
--patterns
--rep
--sub
--upper

--Strings
--Basics
--Patterns
--Capture
--Replacement
--Tricks

--String Libray
local firstString = "Hello World"
print(string.len(firstString))
print(#firstString)


-- This replicates the string '5' times - basically prints it out as many times as you want
local secondString = string.rep("Dory ", 5)
print(secondString)

--Lower converts the entire string into lowercase whereas Upper does the complete opposite
local thirdString = "HELLO World!!!"
print( string.lower(thirdString) )
print( string.upper(thirdString) )

--The substring will only
local subString = "Hello World"
print( string.sub( subString, 1, 5) )

--Less commonly used, char returns the character equivalent/specific to the integer inputted (ascii) via character call.
print (string.char(123) )

--Byte outputs the ascii NUMBER of the given string - this will return the first character(x) ascii code.
--Then the second integer will turn the second character(y) ascii code.
print( string.byte("xyz", 1,2) )

--Formatting
--Very hand for dates etc;
local day,month, year = 14,3,2020
print(string.format ("%02d/%02d/%04d", month, day, year) )

--Formats amount of integers shown in Pi
print(string.format( "pi: %.4f", math.pi) )

--Formatting codes
-- % Followed by a directive
-- d - decimal number
-- x - hexadecimal
-- o - octal
-- f - floating point number
-- s - strings
-- p - punctuation
-- l - lowercase
-- u - uppercase
-- + - 1 or more repetitions
-- * - 0 or more repetitions
-- - - 0 or more repetitions
-- ? - 0 or 1 occurrence

--Shows you the location of a string via character count/numbered character positions within the ""/String
local findString = "Hello World"
local sBegin, sEnd = string.find( findString, "World" )
print (sBegin, sEnd)

--this returns the occurence of the word youre searching for.
local findString = "Hello World"
local found = string.match( findString, "World")
print(found)

--This does the same as previous however its searching for a match of the decimal number in the given format.
local date = "Today is 04/03/2020"
local d = string.match(date, "%d+/%d+/%d+")
print(d)

--This substitute strings, it searches for the character '2' from the string 'temp'
--that will be replaced with the number '3' in the parameters.
local temp = "I have 2 Children"
local temp2 = string.gsub(temp, "2", "3")
print(temp2)







