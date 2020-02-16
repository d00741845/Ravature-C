# C# Coding: Beginner To Advance

## Hello World
```c#
using System;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World");
      Console.ReadLine();
    }
  }
}
```

```c#
int x, y;
x=7;
y= x + 3;
Console.WriteLine("y= "+ y);

```
```c#
Console.WriteLine("What is your name?");
Console.Write("Type your first name: ");
string myFirstName;
myFirstName = Console.ReadLine();
string myLastName;
Console.Write("Type your last name: ");
myLastName = Console.ReadLine();
Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
```
```c#
Console.WriteLine("What is your name?");
Console.Write("Type your first name: ");
string myFirstName = Console.ReadLine();
			
Console.Write("Type your last name: ");
string myLastName = Console.ReadLine();

Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

```
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
```c#
Console.Write("Big Giveaway\nChoose a door, 1, 2 or 3: ");
string userValue = Console.ReadLine();

string message = (userValue == "1") ? "car" : "strand of lint";
//Console.Write("You won a " + message + ".\n");

Console.WriteLine("You won a {0}.", message);

```

```c#
			// Variaable declaration
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
## for iteraations statement
```c#
			// Variaable declaration
			for (int i=0; i<10; i++)
				Console.WriteLine(i);
```
# arrays are like a fishing tacelbox
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
## Defining and calling methods
```c#
    static void Main(string[] args)
    {
			HelloWorld();
    }

		private static void HelloWorld()
		{
			Console.WriteLine("Hello World!");
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


## While Iteration Statement
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
```c#

```
```c#

```
```c#

```
```c#

```
