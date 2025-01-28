# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#. The `swap` function attempts to swap the values of two mutable variables, but it does not modify the original variables as intended.  This is because F#'s `<-` operator creates a new binding for the variable within the scope of the function, rather than modifying the existing binding outside of the function scope. 

## Bug Report

The provided `bug.fs` file contains code that illustrates this issue.  The `swap` function doesn't work as expected due to the way F# handles mutable variables in function arguments. The `printf` statement shows the variables are unchanged after the `swap` function call.

## Solution

The `bugSolution.fs` file shows a correct approach to swapping mutable variables. It uses references (`ref`) to directly modify the values in memory.  This illustrates how to properly manipulate mutable values when this behavior is truly required.