# C# Example Coding: Beginner To Advanced
![C# Logo](https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/C_Sharp_logo.svg/150px-C_Sharp_logo.svg.png)


### Variable:
 -  whole number
 -  single character of data
 -  true or false value
 -  line of text 
 -  reference to an Object in memory
 -  reference to specific instance of another class
 -  name CANNOT have spaces
 -  written in lower camel case
 -  different types require different amounts of memory

primitive date type is any data type that is not a reference to an object.
In C#:
primitive data types are: int, object, short, char, float, double, char, bool. 
They are called primitive because they are the main built-in types, and could be used to build other data types.
In C#, primitive data types are actually objects. 


### Variable Types:
    1 int       integral variables
    2 float
    3 char


## C# Primitive Datatypes 
### Integral Variables:
|ALIAS	|TYPE	    |TYPE       |NAME	        |SIZE(BITS)	|RANGE	           |DEFAULT VALUE|
|-------|-----------|-----------|---------------|-----------|------------------|-------------|
|byte	|unsigned   |integer	|System.byte	|8	        |0 to 255	       |0|
|sbyte	|signed     |integer	|System.Sbyte	|8	        |-128 to 127	   |0|
|short	|signed     |integer	|System.Int16	|16	        |-32768 to 32767   |0|
|ushort	|unsigned   |integer	|System.UInt16	|16	        |0 to 65535	       |0|
|Int	|signed     |integer	|System.Int32	|32	        |-231 to 231-1	   |0|
|uint	|unsigned   |integer	|System.UInt32	|32	        |0 to 232	       |0|
|long	|signed     |integer	|System.Int64	|64	        |-263 to 263-1	   |0L|
|ulong	|unsigned   |integer	|System.UInt64	|64	        |0 to 263	       |0|


### Floating point data types:
#### float
    32-bit single (7-digit) precision floating point type declared using the keyword float. 
    For initializing any variable with a float, you have to mention a 'f' or 'F' after the value. 
    For example: float g = 62.4f; 
    In case you do not use the suffix, then compiler treats the value as double.
#### double
    64-bit (14-15 digit) precision floating point type declared using the keyword double. 
    For initializing any variable with double, you have to mention a 'd' or 'D' after the value. 
    For example, double ks =8.403122d;


#### Decimal Types:
    Used for extensive calculations which are of 128-bit used for calculating huge economic data. 
    It uses' or 'M' as the suffix; otherwise, the value will be treated as double.
    In binary arithmetic, the more bits you use to store decimal data, the more precise those decimal values can be.

#### Character Types:
    Used for representing 16-bit Unicode character used for storing a single character.
    Unicode standard limits range of values that can be assigned to a character variable.
    Unicode contains over 100,000 characters, including the alphabets of most languages, digits, and various other symbols. 


#### Boolean Type:
    bool, Boolean data, true/false value, 8-bits. 
    primitive data


#### Reference Type:
    Refers to a memory location assigned to a variable, does not hold a data value. 
    Built-in reference types:
      1 string
          do not take up a predetermined amount of space.
          will reserve memory as needed.
          can be any amount of text.
          can be any type of text.
      2 object
      3 dynamic

#### Pointer Type:
  Used for storing the address of any memory location which is of another type. 
  Pointers are considered a separate data type kind because they do not hold the actual value or data; 
  They store the memory location. 
  The concept of pointers came in C# from C and C++.

### Declaring pointers:
#### Syntax
```c#
type* identifier;
```
#### Example:
```c#
char* str_name;
int* user_id;
```


---
## Hello World
```c#
using System; using System.Threading.Tasks;
namespace HelloWorld {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World");
      Console.ReadLine();
    }
  }
}
```

### Int
```c#
int x, y;
x=7;
y= x + 3;
Console.WriteLine("y= "+ y);
```

---
## Hello: Firstname Lastname
```c#
Console.WriteLine("What is your name?");
Console.Write("Type your first name: ");
string myFirstName = Console.ReadLine();
Console.Write("Type your last name: ");
string myLastName = Console.ReadLine();
Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

```

---
## Game: Big Giveaway, First rev
```c#
Console.WriteLine("Big Giveaway");
Console.Write("Choose a door, 1, 2 or 3: ");
string userValue = Console.ReadLine();
string message = "default";
if (userValue=="1")
	message = "You won a new car!";
else if (userValue=="2")
	message = "You won a new boat!";
else if (userValue=="3")
	message = "You won a new cat!";
else
	message = "We didnt understand!";
Console.WriteLine(message);
```

## Game: Big Givaway, Final
```c#
Console.Write("Big Giveaway\nChoose a door, 1, 2 or 3: ");
string userValue = Console.ReadLine();
string message = (userValue == "1") ? "car" : "strand of lint";
//Console.Write("You won a " + message + ".\n");
Console.WriteLine("You won a {0}.", message);
```

---
# Operators
```c#
// Variable declaration
int x, y, a ,b;
// Assignment Operator
x=3;
y=2;
a=1;
b=0;
// There are many mathematical operators ...
// addition operator
x = 3+4;
// Subtraction operator
x=4-3;
// Multiplication
x = 10*5;
// Division operator
x = 10/5;
// Order of operations using parenthesis
x=(x+y) * (a-b);
// Operators to evaluate
// Equality operator
if (x==y){}
// Grater operator
if (x>y){}
// Less operator
if (x<y){}
// Grater equal operator
if (x>=y){}
// Less equal operator
if (x<=y){}
// Conditional operators
// Conditional AND
if ((x>y) && (a>b)){}
// Conditional OR
if ((x>y) || (a>b)){}
// IN-LINE CONDITIONAL OPERATOR
string message = (x ==1) ? "Car" : "Boat";
// Member access and Method invocation
Console.WriteLine("Hi");```

---
## For Iteration Statement
```c#
// Variable declaration
for (int i=0; i<10; i++)
  Console.WriteLine(i);
```

---
# Arrays
## Arrays are like a fishing tackle box
```c#
int[] numbers = new int[5];
numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;
			
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers.Length);	

int [] nums = new int[] {4, 8, 15, 16, 23, 42};
			
Console.WriteLine(nums[1]);
Console.WriteLine(nums.Length);
			
string[] names = new string[] {"jesse", "bob", "james"};
			
for (int i = 0; i < names.Length; i++)
  Console.WriteLine(names[i]);
			
foreach (string name in names)
	Console.WriteLine(name);						

string zig = "If you believe you can or if" +
	" you believe you cant you are correct.";
			
char[] charArray = zig.ToCharArray();
Console.WriteLine(charArray);
Array.Reverse(charArray);
Console.WriteLine(charArray);
foreach (char item in charArray)
  Console.Write(item);
Console.WriteLine();

```

---
# Defining and Calling Methods
## Hello World via Method
 
```c#
static void Main(string[] args) {
  HelloWorld();    }

private static void HelloWorld() {
  Console.WriteLine("Hello World!");}

```

---
# The Name Game, First Rev.
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();

			char[] firstNameArray = firstName.ToCharArray();
			Array.Reverse(firstNameArray);

			char[] lastNameArray = lastName.ToCharArray();
			Array.Reverse(lastNameArray);

			char[] cityArray = city.ToCharArray();
			Array.Reverse(cityArray);

			string result ="";

			foreach (char item in firstNameArray)
				result += item;
			result += " ";

			foreach (char item in lastNameArray)
				result += item;
			result += " ";

			foreach (char item in cityArray)
				result += item;
			
			Console.WriteLine("results: "+result);

```
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();
			
			Console.WriteLine("results: ");
			ReverseString(firstName);
			ReverseString(lastName);
			ReverseString(city);
			Console.WriteLine();
    }
		
		private static void ReverseString(string message)
		{
			//string message = "Hello world!";
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);

			foreach (char item in messageArray)
				Console.Write(item);
			Console.Write(" ");

		}

```
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();

			Console.WriteLine("results: ");
			string reversedFirstName = ReverseString(firstName);
			string reversedLastName = ReverseString(lastName);
			string reversedCity = ReverseString(city);
			//Console.WriteLine(reversedCity + reversedLastName + reversedFirstName);
			Console.Write(String.Format("{0} {1} {2}", 
				reversedFirstName, 
				reversedLastName, 
				reversedCity));
    }
		
		private static string ReverseString(string message)
		{
			//string message = "Hello world!";
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
		}
```
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();

			Console.WriteLine("results: ");
			string reversedFirstName = ReverseString(firstName);
			string reversedLastName = ReverseString(lastName);
			string reversedCity = ReverseString(city);

			DisplayResult(reversedFirstName, reversedLastName, reversedCity);

    }
		
		private static string ReverseString(string message)
		{
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
		}
```
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();

			Console.WriteLine("results: ");
			//string reversedFirstName = ReverseString(firstName);
			//string reversedLastName = ReverseString(lastName);
			//string reversedCity = ReverseString(city);
			DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

    }
		
		private static string ReverseString(string message)
		{
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
		}

```
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();

			DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

    }
		
		private static string ReverseString(string message)
		{
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
		}

		private static void DisplayResult(
			string reversedFirstName,
			string reversedLastName,
			string reversedCity)
		{
			Console.WriteLine("results: ");
			Console.Write(String.Format("{0} {1} {2}\n", 
				reversedFirstName, 
				reversedLastName, 
				reversedCity));
		}

```
```c#
static void Main(string[] args)
{
  Console.WriteLine("The Name Game");

  Console.Write("What's your first name? ");
  string firstName = Console.ReadLine();

  Console.Write("What's your last name? ");
  string lastName = Console.ReadLine();
  
  Console.Write("What city wer you born? ");
  string city = Console.ReadLine();

  DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
  DisplayResult(
	ReverseString(firstName) + " " + 
	ReverseString(lastName) + " " + 
	ReverseString(city) + "\n" );
}
		
private static string ReverseString(string message)
{
  char[] messageArray = message.ToCharArray();
  Array.Reverse(messageArray);
  return String.Concat(messageArray);
}

private static void DisplayResult(
  string reversedFirstName,
  string reversedLastName,
  string reversedCity)
{
  Console.WriteLine("A Results: ");
	Console.Write(String.Format("{0} {1} {2}\n", 
	reversedFirstName, 
	reversedLastName, 
	reversedCity));
}

private static void DisplayResult(string message)
{
  Console.WriteLine("B Results: ");
  Console.Write(message);
}
```
```c#
    static void Main(string[] args)
    {
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string firstName = Console.ReadLine();

			Console.Write("What's your last name? ");
			string lastName = Console.ReadLine();

			Console.Write("What city wer you born? ");
			string city = Console.ReadLine();

			DisplayResult(
				  ReverseString(firstName) + " " + 
					ReverseString(lastName) + " " + 
					ReverseString(city) + "\n" );
    }
		
		private static string ReverseString(string message)
		{
			char[] messageArray = message.ToCharArray();
			Array.Reverse(messageArray);
			return String.Concat(messageArray);
		}

		private static void DisplayResult(string message)
		{
			Console.WriteLine("B Results: ");
			Console.Write(message);
		}
```
```c#
static void Main(string[] args){
  Console.WriteLine("The Name Game");

  Console.Write("What's your first name? ");
  string firstName = Console.ReadLine();

  Console.Write("What's your last name? ");
  string lastName = Console.ReadLine();
  
  Console.Write("What city wer you born? ");
  string city = Console.ReadLine();

  DisplayResult(ReverseString(firstName) + " " + ReverseString(lastName) + " " + ReverseString(city) + "\n" );
}
		
private static string ReverseString(string message){
  char[] messageArray = message.ToCharArray();
  Array.Reverse(messageArray);
  return String.Concat(messageArray);
}

private static void DisplayResult(string message){
  Console.WriteLine("B Results: ");
  Console.Write(message);
}

```

---

# While Iteration Statement
## Menu: Print or Guess Number, First rev.
```c#
static void Main(string[] args)
{
	MainMenu();
}
private static void MainMenu()
{
	Console.WriteLine("Choose an option: ");
	Console.WriteLine("1) Option 1");
	Console.WriteLine("2) Option 2");
	Console.WriteLine("3) Exit");
	string result = Console.ReadLine();
	if (result == "1")
	{
		//xxx
	}	
	else if (result == "2")
	{
		//xx
	}
	else if (result == "3")
	{
 		//xx
	}
	else
	{
		//xx
	}
}
```

```c#
static void Main(string[] args)
{
  bool displayMenu = true;
  while (displayMenu)
    displayMenu = MainMenu();
}
private static bool MainMenu()
{
	Console.WriteLine("Choose an option: ");
	Console.WriteLine("1) Option 1");
	Console.WriteLine("2) Option 2");
	Console.WriteLine("3) Exit");
	string result = Console.ReadLine();
	if (result == "1")
	{
		PrintNumbers();
    return true;
	}	
	else if (result == "2")
	{
		GuessGame();
    return true;
	}
	else if (result == "3")
	{
 		return false;
	}
	else
	{
		return true;
	}
}

private static void PrintNumbers()
{
  Console.WriteLine("Print numbers!");
  Console.ReadLine();
}
private static void GuessGame()
{
  Console.WriteLine("Guessing Game!");
  Console.ReadLine();
}

```

```c#
static void Main(string[] args)
{
  bool displayMenu = true;
  while (displayMenu)
    displayMenu = MainMenu();
}
private static bool MainMenu()
{
  Console.Clear();
	Console.WriteLine("Choose an option: ");
	Console.WriteLine("1) Option 1");
	Console.WriteLine("2) Option 2");
	Console.WriteLine("3) Exit");
	string result = Console.ReadLine();
	if (result == "1")
	{
		PrintNumbers();
    return true;
	}	
	else if (result == "2")
	{
		GuessGame();
    return true;
	}
	else if (result == "3")
	{
 		return false;
	}
	else
	{
		return true;
	}
}

private static void PrintNumbers()
{
  Console.Clear();
  Console.WriteLine("Print numbers!");
  Console.WriteLine("Type a number: ");
  int result = int.Parse(Console.ReadLine());
  int counter = 1;
  while (counter < result+1)
  {
    Console.Write(counter++ + "-");
  }
  Console.ReadLine();
}
private static void GuessGame()
{
  Console.Clear();
  Console.WriteLine("Guessing Game!");
  Console.WriteLine("Guess number between 1 and 10:");

  Random myRandome = new Random();
  int randomeNumber = myRandome.Next(1, 10);
  
  int guesses = 0;
  bool incorrect = true;

  do{
    Console.WriteLine("Guess number from 1 to 10: ");
    int guessValue = int.Parse(Console.ReadLine());
    guesses++;
    if (guessValue == randomeNumber)
    {
      Console.WriteLine("You won on guess#: !!"+guesses);
      incorrect=false;
    }
    else
      Console.WriteLine("try again!");
  }while(incorrect);
  
  Console.Write("press enter for main menu: ");
  Console.ReadLine();

}

```

```c#
static void Main(string[] args)
{
  bool displayMenu = true;
  while (displayMenu)
    displayMenu = MainMenu();
}
private static bool MainMenu()
{
  Console.Clear();
	Console.WriteLine("==== Welcome To Program Menu ====\n");
	Console.WriteLine("Choose Number Game: ");
	Console.WriteLine("1) Print");
	Console.WriteLine("2) Guess");
	Console.WriteLine("3) Exit");
	string result = Console.ReadLine();
	if (result == "1")
	{
		PrintNumbers();
    return true;
	}	
	else if (result == "2")
	{
		GuessGame();
    return true;
	}
	else if (result == "3")
	{
 		return false;
	}
	else
	{
		return true;
	}
}

private static void PrintNumbers()
{
  Console.Clear();
  Console.WriteLine("-- -- Now Playing Numbers Game! -- -- \n");
  Console.Write("Type a number: ");
  int result = int.Parse(Console.ReadLine());
  int counter = 1;
  while (counter < result+1)
  {
    Console.Write(counter++ + "-");
  }
  Console.WriteLine("\n\nPress Enter for Main Menu");
  Console.ReadLine();
}
private static void GuessGame()
{
  Console.Clear();
  Console.WriteLine("-- -- Now Playing Guessing Game! -- -- \n");
  Console.Write("Guess number from 1 to 10: ");

  Random myRandome = new Random();
  int randomeNumber = myRandome.Next(1, 10);
  
  int guesses = 0;
  bool incorrect = true;

  do{
    //int guessValue = int.Parse(Console.ReadLine());
    string guessValue = Console.ReadLine();
    guesses++;
    if (guessValue == randomeNumber.ToString())
      incorrect=false;
    else
      Console.WriteLine("try again!");
  }while(incorrect);
  Console.Clear();
  Console.WriteLine("-- -- Now Playing Guessing Game! -- -- \n");
  Console.WriteLine("You won! In {0} guesses.",guesses);
  Console.Write("\nPress Enter for Main Menu");
  Console.ReadLine();

}

```

---
# Menu: Print or Guess Number, Final rev.
```c#
static void Main(string[] args){
  bool displayMenu = true;
  while (displayMenu)
    displayMenu = MainMenu();
}
private static bool MainMenu(){
  Console.Clear();
	Console.WriteLine("==== Welcome To Program Menu ====\n");
	Console.WriteLine("Choose Number Game: ");
	Console.WriteLine("1) Print");
	Console.WriteLine("2) Guess");
	Console.WriteLine("3) Exit");
	string result = Console.ReadLine();
	if (result == "1")	{
		PrintNumbers();
    return true;
	}	
	else if (result == "2")	{
		GuessGame();
    return true;
	}
	else if (result == "3")	
    return false;
	else	
		return true;	
}

private static void PrintNumbers()
{
  Console.Clear();
  Console.WriteLine("-- -- Now Playing Numbers Game! -- -- \n");
  Console.Write("Type a number: ");
  string userValue = Console.ReadLine();
  int counter = 0;
  while ((counter).ToString() != userValue)
    Console.Write(++counter + "-"); 
  Console.WriteLine("\n\nPress Enter for Main Menu");
  Console.ReadLine();
}
private static void GuessGame(){
  Console.Clear();
  Console.WriteLine("-- -- Now Playing Guessing Game! -- -- \n");
  Console.Write("Guess number from 1 to 10: ");

  Random myRandome = new Random();
  int randomeNumber = myRandome.Next(1, 10);
  
  int guesses = 0;
  bool incorrect = true;

  do{
    //int guessValue = int.Parse(Console.ReadLine());
    string guessValue = Console.ReadLine();
    guesses++;
    if (guessValue == randomeNumber.ToString())
      incorrect=false;
    else
      Console.WriteLine("try again!");
  }while(incorrect);
  Console.Clear();
  Console.WriteLine("-- -- Now Playing Guessing Game! -- -- \n");
  Console.WriteLine("You won! In {0} guesses.",guesses);
  Console.Write("\nPress Enter for Main Menu");
  Console.ReadLine();

}
```

---
# Work With Strings

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePlayHouse{
class Program{

static void Main(string[] args){
  //string myString = "My \"so-called\" life";
  //string myString = "My new\nline";
  //string myString = "Go to the c:\\ drive";
  //string myString = @"Go to the c:\ drive";
  //String myString = String.Format("{1}={0}","First","Second");
  //string myString = String.Format("{0:C}", 123.45); // C is for currency
  //string myString = string.Format("{0:N}", 1234567890);
  //string myString = string.Format("{0:P}", .123);
  //string myString = string.Format("Phone: {0:(###)###-####}", 2149345637);
  //myString = myString.Substring(6);

  //string myString = " For the Lord loved the world.   ";
  //myString = myString.Substring(6,7);
  //myString = myString.ToUpper();
  //myString = myString.ToLower();
  //myString = myString.Replace("world","earth");
  //myString = myString.Replace(" ","--");
  //myString = String.Format("Lenght befor: {0} -- Lenght after: {1}", myString.Length, myString.Trim().Length);
  //myString = string.Format("Lenght befor: {0} -- Lenght after: {1}", myString.Length, myString.Trim().Length);
  /*
  string myString = "";
  for (int i = 0; i < 100; i++){
    myString += "--"+ i.ToString();
  }
  */

  StringBuilder myString = new StringBuilder();
  for (int i = 0; i < 100; i++)
    myString.Append("--"+i.ToString());

  Console.WriteLine(myString);
}
}
}
		
```
---
# Working with Dates and Times
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePlayHouse{
class Program{

static void Main(string[] args){
  DateTime myValue = DateTime.Now;
  Console.Clear();
  Console.WriteLine(myValue.ToString());
  Console.WriteLine(myValue.ToShortDateString());
  Console.WriteLine(myValue.ToShortTimeString());
  Console.WriteLine(myValue.ToLongDateString());
  Console.WriteLine(myValue.ToLongTimeString());
  Console.WriteLine(myValue.AddDays(3).ToLongDateString());
  Console.WriteLine(myValue.AddHours(3).ToLongDateString());
  Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
  Console.WriteLine(myValue.AddHours(-3).ToLongDateString());
  Console.WriteLine(myValue.Month);
  Console.WriteLine(myValue.Day);
  Console.WriteLine(myValue.DayOfWeek);
  Console.WriteLine(myValue.DayOfYear);

  //DateTime myBirthday = new DateTime(1979, 1, 21);
  //Console.WriteLine(myBirthday.ToShortDateString());

  DateTime myBirthday = DateTime.Parse("12/7/1979");
  TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
  Console.WriteLine(myAge);
  Console.WriteLine(myAge.TotalDays);
}
}
}
```
---
# Understanding Classes
Car Class
 - Make
 - Model
 - Year
 - Color


```c#
static void Main(string[] args)
{
  // 3. Create New Instance of Car Class:
  // (declare car in memory) = (Create instance of that class in memory )
  //               Car myCar = new Car(); 
  Car myCar = new Car(); 

  // 4. Set Properties
  myCar.Make = "Oldsmobile";
  myCar.Model = "Cutlas Supreme";
  myCar.Year = 1986;
  myCar.Color = "Silver";

  // 3. Get Properties
  Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

  // 5. Call Method to determine market value of car
  decimal value = DetermineMarketValue(myCar);
  Console.WriteLine("Market Value: {0:C}", value);

}

// 4. Create a  helper method allowing input parameter: Car car
private static decimal DetermineMarketValue(Car car)
{
  // Temp hard code car value = 100
  decimal CarValue = 100.0M;
  // Todo: Look up using web for accurate value.
  return CarValue;
}

// 1. Define a Class with 4 properties, (Create Blueprint) 
// Also, can say we created a car data type
class Car
{
  // 2. Define/Setup Properties,  identifying Data Types with Name
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public string Color { get; set; }  
}

```

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePlayHouse{
class Program{


static void Main(string[] args)
{
  // 3. Create New Instance of Car Class:
  // (declare car in memory) = (Create instance of that class in memory )
  //               Car myCar = new Car(); 
  Car myCar = new Car(); 

  // 4. Set Properties
  myCar.Make = "Oldsmobile";
  myCar.Model = "Cutlas Supreme";
  myCar.Year = 1986;
  myCar.Color = "Silver";

  // 3. Get Properties
  Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

  // 5. Call Method to determine market value of car
  //decimal value = DetermineMarketValue(myCar);
  //Console.WriteLine("Market Value: {0:C}", value);
  // 5b Modified 
  Console.WriteLine("Market Value: {0:C}", myCar.DetermineMarketValue());

}

// 4. Create a  helper method allowing input parameter: Car car

private static decimal DetermineMarketValue(Car car)
{
  // Temp hard code car value = 100
  decimal CarValue = 100.0M;
  // Todo: Look up using web for accurate value.
  return CarValue;
}

// 1. Define a Class with 4 properties, (Create Blueprint) 
// Also, can say we created a car data type
class Car
{
  // 2. Define/Setup Properties,  identifying Data Types with Name
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public string Color { get; set; }

  // 5b
  public decimal DetermineMarketValue()
  {
    decimal carValue;
    if (Year > 1990)
      carValue = 10000;
    else
      carValue = 2000;
    return carValue;
  }
}

}
}
```

---

# More About Classes and Methods (4:32)
```c#

```
```c#

```
```c#

```
```c#

```
```c#

```
```c#

```
```c#

```
```c#

```
```c#

```

