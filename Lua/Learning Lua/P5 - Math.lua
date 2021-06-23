--Number Storage
--Version 5.3, Lua stored numbers internally as either integer or double by default
--before version 5.3, Lua stored numbers as double.
--tonumber('42') - Converts strings to numbers


--Math Operators in Lua
-- ^ - exponential
-- * - multiplication
-- / - division
-- % - modulus or modulo (percentage)
-- + - addition
-- - - subtraction and unary

-- Lua Libraries
-- Math -- focused on this in this save.
-- String
-- Table
-- Input/Output
-- Operating System
-- Debug

-- Order Of Precedence -- similiar to BIDMAS
-- ^
-- not #  - (unary)
-- * / %
-- + - (subtraction)


answer = 2+5*4
print(answer)

answer2 = 5%4
print(answer2)

myPi = math.pi
print(myPi)


--randon number generator
math.randomseed(os.time())
myNumber = math.random(1,10)
print(myNumber)

mySin = math.sin(1)
print(mySin)






