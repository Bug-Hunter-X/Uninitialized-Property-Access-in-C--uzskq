# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property that has not been initialized before use.  Uninitialized properties will contain their default values (0 for integers, null for reference types), leading to unexpected results or runtime exceptions depending on how the property is used.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file offers a corrected version.