## UnitTestDemo

This project is a simple **Calculator** application developed in **C# (.NET 7)** along with its **unit tests**.  
It uses **MSTest** as the testing framework and **Moq** for creating mock dependencies.

---

## Project Structure

```bash
UnitTestDemo/
├── .gitignore
├── UnitTestDemo.sln
│
├── Calculator/
│   ├── Calculator.cs
│   ├── ILogService.cs
│   └── Calculator.csproj
│
└── Calculator.Tests/
    ├── Calculator.Tests.csproj
    ├── UnitTest1.cs
    └── Usings.cs
```
## Technologies Used
| Technology        | Description                       |
| ------------------| ----------------------------------|
| **C# / .NET 7.0** | Main development platform         |
| **MSTest**        | Official Microsoft test framework |
| **Moq**           | Library for mocking dependencies  |
| **Coverlet**      | Tool for measuring code coverage  |

## How to Run
1. Clone the Repository
git clone https://github.com/dlwluena/UnitTestDemo.git
cd UnitTestDemo
2. Restore Dependencies
dotnet restore
3. Run Tests
dotnet test
4. (Optional) Generate Code Coverage Report
dotnet test --collect:"XPlat Code Coverage"

## Learning Objectives
- Understand the fundamentals of unit testing
- Learn how to isolate dependencies using mock objects
- Explore MSTest and Moq integration
- Ensure code correctness through automated tests

## Extra Notes (Useful Commands)
| Command                                                              | Description                                       |
| -------------------------------------------------------------------- | ------------------------------------------------- |
| `dotnet new sln`                                                     | Create a new solution                             |
| `dotnet new classlib -n Calculator`                                  | Create a new class library project                |
| `dotnet new mstest -n Calculator.Tests`                              | Create a new MSTest project                       |
| `dotnet sln add Calculator/Calculator.csproj`                        | Add the project to the solution                   |
| `dotnet add Calculator.Tests reference Calculator/Calculator.csproj` | Add a reference from test project to main project |
| `dotnet add package Moq`                                             | Add Moq package                                   |
| `dotnet test`                                                        | Run all tests                                     |

## Notes
- This project is for educational and demonstration purposes.
- In real-world scenarios, business logic classes are typically tested instead of a simple calculator.
- Mocking is a technique used to simulate external dependencies (e.g., databases, APIs, or file systems).

## About MOQ
| Feature             | Description                                                                                                                       |
| --------------------| -------------------------------------------------------------------------------------------------------------------------------   |
| **Purpose**         | Moq is a mocking framework for .NET that allows you to create fake (mock) implementations of interfaces or classes for testing.   |
| **Usage**           | Helps isolate dependencies so tests focus only on the logic of the class being tested.                                            |
| **Syntax**          | Simple and fluent API (e.g., `var mock = new Mock<ILogService>();`)                                                               |
| **Verify Behavior** | You can confirm whether specific methods were called using `mock.Verify()`.                                                       |
| **Installation**    | Add via NuGet: `dotnet add package Moq`                                                                                           |
| **Official Site**   | [https://github.com/moq/moq4](https://github.com/moq/moq4)                                                                        |

