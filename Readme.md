This repository contains my solution to a programming test requested for a position:

```
Write a method that takes a string argument and returns whether or not characters in the string have matching brackets. Meaning for every { there is a corresponding } bracket. Return true if they do, return false if they do not. 



Please unit test with the following use cases (and any others you choose to ensure functionality):



Test string - Expected result

{} - True

}{ - False (closed bracket can't proceed all open brackets.)

{{} - False (one bracket pair was not closed)

"" - True. (no brackets in the string will return True) 

{abc...xyz} - True (non-bracket characters are ignored appropriately)
```

The solution to this problem is very straighforward thus decided to take some artistic liberties and create a small, extensible framework for symmetric character validation.

## Build and Run

In order to build and run the tests, .NET 6 must be installed in the computer with support for C# 10.0. Although, I reckon it should be compatible with C# 9.0.

To run the test suite, simple run from the command line

> dotnet test

The small test suite contains the [sample cases suggested](SymmetricCharactersTests/SymmetricCharacterValidatorTests.cs#L5-L19) along with a few others that exercise the functionality beyond `{}`.