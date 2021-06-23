--A module is a library that can be loaded using the require command
--modules are a single table that can be returned to the calling program
--The .lua extension is assumed when loading a module
--a package is a collection of modules

--This calls in the separate class named myModule where you can basically set methods
--and call them to use when needed

local myMod = require ( "myModule" )

print( myMod.hi("A") )

print( myMod.add( 1, 5) )

--example 2
local myMod = require ( "myModule" )

print( myMod.hi("B") )

print( myMod.add( 1, 23) )
