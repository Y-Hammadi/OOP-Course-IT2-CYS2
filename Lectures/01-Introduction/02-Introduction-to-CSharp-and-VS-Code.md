---
marp: true
theme: default
paginate: true
---

# Introduction to C# and the Development Environment

### C# Fundamentals & Development Tools

---

# Part 1
## Introduction to C#

---

## 1. What is C#?

- General-purpose programming language developed by Microsoft.
- Modern, strongly typed language.
- Supports multiple programming paradigms, including OOP.

**Common Application Areas:**

- Desktop Applications
- Web Applications and APIs
- Cloud Applications
- Mobile Applications
- Games

---

## 2. What is .NET?

- A development platform for building and running applications.
- Provides libraries, runtime components, and development tools.
- Supports C# and other programming languages.

### C# and .NET

- **C#:** Programming language.
- **.NET:** Development platform and runtime ecosystem.
- **Application:** Software built using the language and platform.

---

## .NET Framework vs. Modern .NET

### .NET Framework

- Original Windows-focused implementation.
- Common in legacy applications.
- Example: .NET Framework 4.8.

### Modern .NET

- Cross-platform.
- Recommended for new development.
- Examples: .NET 8, .NET 9, .NET 10.

---

## .NET Evolution

- **.NET Framework:** Original Windows-focused platform.
- **.NET Core:** Cross-platform successor.
- **.NET 5+:** Unified modern .NET platform.

**Important:**

- .NET Core was the predecessor to modern .NET.
- Modern .NET development continues with .NET 5 and later versions.

---

## 3. Basic C# Program Structure

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
```

---

## Main Elements

| Element | Purpose |
|:--|:--|
| `using System;` | Imports the System namespace |
| `class Program` | Declares a class |
| `static void Main()` | Traditional application entry point |
| `string[] args` | Command-line arguments |
| `Console.WriteLine()` | Writes a line to the console |
| `{ }` | Defines a code block |
| `;` | Terminates a statement |

---

## 4. Basic C# Concepts

### Variables

- Named storage locations for values.
- Each variable has a data type.

**Common Data Types:**

- `int`
- `double`
- `decimal`
- `char`
- `string`
- `bool`

---

## Variables – Example

```csharp
int age = 20;

string name = "Ahmed";

double grade = 88.5;

bool isActive = true;
```

---

## Operators

### Arithmetic Operators

- `+` Addition
- `-` Subtraction
- `*` Multiplication
- `/` Division
- `%` Modulus

---

## Comparison Operators

- `==` Equal
- `!=` Not Equal
- `>` Greater Than
- `<` Less Than
- `>=` Greater Than or Equal
- `<=` Less Than or Equal

---

## Logical Operators

- `&&` Logical AND
- `||` Logical OR
- `!` Logical NOT

**Purpose:**

- Combine conditions.
- Evaluate logical expressions.
- Control program decisions.

---

## Input and Output

### Output

- `Console.Write()`
- `Console.WriteLine()`

### Input

- `Console.ReadLine()`

### Type Conversion

- `Convert.ToInt32()`
- Converting user input into numeric values.

---

## Methods

- Reusable blocks of code.
- Perform specific tasks.
- Can receive parameters.
- Can return values.
- Can be called when needed.

### Method Example

```csharp
static int Sum(int a, int b)
{
    return a + b;
}
```

---

# Part 2
## Development Environment

---

## 5. What is a Development Environment?

- Tools used to develop software.
- Supports writing, building, running, testing, and debugging applications.

### Code Editor

- Focuses on writing and editing source code.
- Syntax highlighting.
- Code completion.

### IDE

- Integrated Development Environment.
- Combines an editor with development tools.
- Project management, build tools, and debugging.

---

## 6. Visual Studio vs. Visual Studio Code

### Visual Studio

- Full-featured Integrated Development Environment (IDE).
- Includes many development tools.
- Strong support for C# and .NET.
- Advanced debugging and project management.
- Primarily used on Windows.
- Visual Studio for Mac was retired in 2024.

---

## Visual Studio Code

- Lightweight, extensible source code editor.
- Available on Windows, Linux, and macOS.
- Supports multiple programming languages.
- Extends functionality through extensions.
- Supports C# through Microsoft tooling, including C# Dev Kit.

---

## Visual Studio vs. VS Code

| Aspect | Visual Studio | VS Code |
|:--|:--|:--|
| Category | IDE | Code Editor |
| Installation | Generally larger | Generally smaller |
| Built-in Tools | Extensive | Extended through extensions |
| C# Support | Integrated | Through C# tooling |
| Operating Systems | Windows; Mac version retired | Windows, Linux, macOS |
| Customization | Available | Highly extensible |

---

## Why Use VS Code?

- Cross-platform support.
- Lightweight development environment.
- Suitable for introductory C# console projects.
- Supports multiple programming languages and tools.
- Provides a consistent editor across Windows and Linux.

---

# Part 3
## Setting Up the Environment

---

## 7. Required Tools

### .NET SDK

- Software Development Kit.
- Provides tools to create, build, and run .NET applications.
- Includes the .NET CLI.
- Includes compiler and build tooling.

### Visual Studio Code

- Editor used to write and manage source code.

### C# Dev Kit

- Extension for C# development in VS Code.
- Project support.
- Code navigation.
- Debugging integration.

---

## 8. Installation Resources

### Required Downloads

**.NET SDK**

https://dotnet.microsoft.com/download

**Visual Studio Code**

https://code.visualstudio.com/

**C# Dev Kit**

https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit

---

## 9. Creating a Console Application

### Step 1: Verify the SDK

```bash
dotnet --version
```

### Step 2: Create a Project

```bash
dotnet new console -n FirstApp
```

---

## Creating a Console Application

### Step 3: Navigate to the Project

```bash
cd FirstApp
```

### Step 4: Open in VS Code

```bash
code .
```

### Step 5: Run the Application

```bash
dotnet run
```

---

## 10. Project Structure

### FirstApp

```text
FirstApp/
│
├── Program.cs
│
├── FirstApp.csproj
│
├── bin/
│
└── obj/
```

---

## Project Structure – Main Files

| File / Folder | Purpose |
|:--|:--|
| `Program.cs` | Main source code file |
| `FirstApp.csproj` | Project configuration |
| `bin/` | Build output |
| `obj/` | Intermediate build files |

---

## The .csproj File

- Defines project configuration.
- Specifies the target framework.
- Stores build properties.
- Defines project dependencies.

### Example

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
```

---

## Understanding the .csproj File

- `Project Sdk`: Specifies the project SDK.
- `OutputType`: Defines the application output type.
- `TargetFramework`: Specifies the target .NET version.
- `ImplicitUsings`: Enables implicit namespace imports.
- `Nullable`: Enables nullable reference type analysis.

**Note:** The target framework depends on the installed SDK and course environment.

---

## 11. Traditional Structure vs. Top-Level Statements

### Traditional Structure

- Explicit `Program` class.
- Explicit `Main` method.
- Clearly demonstrates the application entry point.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
```

---

## Top-Level Statements

- Available in modern C#.
- Allows statements without explicitly declaring `Program` and `Main`.
- The compiler generates the entry-point structure.

```csharp
Console.WriteLine("Hello World!");
```

---

## Course Convention

- Use the traditional `Program` and `Main` structure.
- Understand classes and methods.
- Learn program structure before deeper OOP topics.

---

## 12. Discussion Questions

- What is the difference between a programming language and a development platform?
- Are C# and .NET the same thing?
- What is the difference between a code editor and an IDE?
- How are Visual Studio and VS Code different?
- Why was VS Code selected for this course?

---

## Discussion Questions

- What is the role of the .NET SDK?
- Can modern .NET applications run on Windows and Linux?
- What is the purpose of a `.csproj` file?
- What do `dotnet new` and `dotnet run` do?
- What are top-level statements?

---

## 13. Summary

- C# is a programming language developed by Microsoft.
- .NET is a development platform and runtime ecosystem.
- Visual Studio is a full-featured IDE.
- VS Code is an extensible source code editor.
- .NET SDK provides tools to develop .NET applications.

---

## Summary – Development Workflow

- C# Dev Kit adds C# development support to VS Code.
- .NET CLI creates, builds, and runs console applications.
- `.csproj` defines project configuration.
- The course will use the traditional `Program` and `Main` structure.

---

# Thank You

### Questions & Discussion

