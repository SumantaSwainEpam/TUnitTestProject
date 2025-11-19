# TUnit Test Project

## Overview

**TUnit Test Project** is a .NET 8 test automation project that demonstrates unit testing using the **TUnit** testing framework. The project contains a collection of helper classes for common operations and their corresponding test suites.

## Project Details

- **Target Framework:** .NET 8
- **Testing Framework:** TUnit (v1.2.3)
- **Language:** C# 12.0
- **Repository:** [GitHub - SumantaSwainEpam/TUnitTestProject](https://github.com/SumantaSwainEpam/TUnitTestProject)

## Project Structure

```
TUnitTestProject/
├── Data/  # Helper classes and business logic
│   ├── BooleanHelper.cs   # Boolean utility functions
│   ├── MyCalculator.cs       # Calculator with arithmetic operations
│   └── StringHelper.cs          # String utility functions
├── Tests/    # Test suites using TUnit
│   ├── BooleanHelperTests.cs    # Tests for BooleanHelper
│   ├── MyCalculatorTests.cs     # Tests for MyCalculator
│   └── StringHelperTests.cs     # Tests for StringHelper
├── TUnitTestProject.csproj    # Project configuration file
└── README.md  # Project documentation
```

## Components

### Data Layer

#### 1. **StringHelper.cs**
Provides asynchronous string manipulation utilities:
- `ToUpperAsync(string value)` - Converts a string to uppercase
- `ContainsAsync(string input, string substring)` - Checks if a substring exists in a string
- `CountLengthAsync(string input)` - Returns the length of a string

#### 2. **BooleanHelper.cs**
Provides boolean utility functions:
- `IsEvenAsync(int number)` - Checks if a number is even
- `IsAdultAsync(int age)` - Checks if age is >= 18 (adult)

#### 3. **MyCalculator.cs**
A comprehensive calculator supporting multiple numeric types (int, double, decimal):
- **Arithmetic Operations:**
  - `Add(a, b)` - Addition with type overloading
  - `Sub(a, b)` - Subtraction with type overloading
  - `Mul(a, b)` - Multiplication with type overloading
  - `Div(a, b)` - Division with type overloading and divide-by-zero validation
- **Features:**
  - Supports homogeneous operations (int+int, double+double, decimal+decimal)
  - Supports mixed-type operations (int+double, int+decimal, double+decimal)
  - All operations return `Task<T>` for asynchronous execution
  - Division operations throw `DivideByZeroException` when divisor is zero

### Test Layer

#### 1. **StringHelperTests.cs**
TUnit test suite for StringHelper with parallel execution:
- `ToUpperAsync_WithLowercaseString_ReturnsUppercase()` - Tests uppercase conversion
- `ContainsAsync_WhenSubstringExists_ReturnsTrue()` - Tests substring search
- `CountLengthAsync_WithValidString_ReturnsCorrectLength()` - Tests string length counting

#### 2. **BooleanHelperTests.cs**
TUnit test suite for BooleanHelper functionality

#### 3. **MyCalculatorTests.cs**
TUnit test suite for MyCalculator operations covering all arithmetic functions

## Technologies

- **.NET 8** - Latest long-term support framework
- **C# 12.0** - Latest C# language features including implicit usings and nullable reference types
- **TUnit** - Modern unit testing framework for .NET
- **Async/Await** - All helper methods support asynchronous programming

## Key Features

? **Parallel Test Execution** - Tests use TUnit's `[ParallelGroup]` attribute for efficient parallel execution
? **Async-First Design** - All helper methods return `Task<T>` for non-blocking operations
? **Type-Safe** - Supports multiple numeric types with proper overloading
? **Comprehensive Calculator** - Supports mixed-type arithmetic operations
? **Exception Handling** - Division by zero protection in calculator
? **Clean Code** - Follows C# best practices with nullable reference types enabled

## Running Tests

To run the tests, use the following commands:

```bash
# Restore dependencies
dotnet restore

# Run all tests
dotnet test

# Run tests with verbose output
dotnet test --verbosity detailed

# Run a specific test
dotnet test --filter StringHelperTests
```

## Project Configuration

The project uses the following key settings in `TUnitTestProject.csproj`:
- `TargetFramework: net8.0` - Targets .NET 8
- `ImplicitUsings: enable` - Uses implicit global usings (System, etc.)
- `Nullable: enable` - Enables nullable reference types for safer code
- `OutputType: Exe` - Console application output

## Dependencies

- **TUnit v1.2.3** - Modern .NET testing framework with advanced features like parallel test groups and async assertions

## Development Guidelines

1. **Test Naming Convention:** Uses descriptive names following the pattern: `MethodName_Scenario_ExpectedResult`
2. **Async Testing:** All tests use async/await with TUnit's async assertion API
3. **Parallel Execution:** Tests are grouped using `[ParallelGroup]` for improved performance
4. **Setup/Teardown:** Uses `[Before]` hook with `HookType.Test` for test initialization

## Future Enhancements

- Add more comprehensive test coverage
- Implement additional helper utilities
- Add integration tests
- Performance benchmarking with different async operations
- Add XML documentation comments to all public methods

## License

This project is a demonstration/educational project.

## Author

Sumanta Swain (Epam Systems)
