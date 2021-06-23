myString = "Hello"

--This counts how many characters are in the given string.
print(#myString)

myOtherString = "World"
-- cancatination, here is how you would merge two strings together with a space inbetween.
print (myString .. " " .. myOtherString)

myNumber = 42
myStringNumber = tostring(myNumber) -- "42"
print(myStringNumber)

myFirstString = 'Hi Mom'
mySecondString = "Hi Dad"
myThirdString = [[Multi-Line
string
that
contains
newline]]

myA, myB, myC = "hi", "hello" -- Only two out of 3 inputted
print(myA)
print(myB)
print(myC) -- This is nil because it hasnt inputted data above ^

--Lua Escape Sequences
--\a - bell
--\b - back space
--\f - form feed

--\n - newline
myNewLine = "This is a string \nwith a newline"
print(myNewLine)
--\r - carriage return
--\t - horizontal tab
--\v - vertical tab
--\\ - backslash
--\" - double quote
--\' - single quote





