# Guide to Quickly Create Console App
The dotnet command creates a new application of type console for you.
The -o parameter creates a directory named myApp where your app is stored, and populates it with the required files.
```bash
dotnet new console -o myApp
cd myApp
```
Note: By default, Program.cs,  contains the necessary code to write "Hello World!" to the Console.

Program.cs:
```c#
using System;
namespace myApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
```

## Run it:
```bash
dotnet run
```
Sucess, just built and run your first .NET console app.
