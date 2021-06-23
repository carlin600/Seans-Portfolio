
--Nil == Has no value and holds no data.
myVariable = nil
print(type(myVariable))


--Number == Any numeric value. Lua stores numbers as double - Precision Floating - point (i.e 'real numbers')
myInteger = 10
print(myInteger)
print(type(myInteger))
myFloat = 3.14159265
print(myFloat)
print(type(myFloat))

--String == A sequence of characters. Can use single or double quote or double brackets to delimit ([[string]])
myString = "Hello"
print(myString)
print(type(myString))

myString2 = [[Multi-Line
strings
are
fun]]
print(myString2)


--Boolean == Stores true or false values
myBoo = true
myBoo2 = false
myBoo3 = nil
print(myBoo3)
print(type(myBoo3))


--Table == Store associative arrays (non-typed arrays that can be indexed by numbers or strings)
--Lua arrays start count at 1! - NOT 0!
myArray={"a string", 12, 42, "14"}
print(myArray)

print(myArray[1])
print(myArray[3])
print(myArray[2])



--Function == Repeatable programming segments stored in a variable.


--Userdata == used to represent new data types.


--Thread == Stores a co-routine instance(multitask threading)








