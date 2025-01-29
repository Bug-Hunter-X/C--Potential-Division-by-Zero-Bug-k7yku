# C# Potential Division by Zero Bug

This repository demonstrates a common but easily overlooked bug in C#: division by zero. The `bug.cs` file contains code that may cause a `DivideByZeroException` if a certain condition is met. The `bugSolution.cs` file provides a solution to mitigate this error.

## Bug Description
The bug occurs in the `MyMethod` function. If the `MyProperty` is zero, attempting to divide 100 by it will result in a `DivideByZeroException`, crashing the program.

## Solution
The solution involves explicitly checking for the condition where `MyProperty` is 0 before performing the division. If `MyProperty` is 0, an alternative action, such as printing a message, is taken.