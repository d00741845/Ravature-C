
# Enable snaps / Install Visual Studio Code / Install .NET Core SDK

Snaps are applications packaged with all their dependencies to run on all popular Linux distributions from a single build. They update automatically and roll back gracefully.

Snaps are discoverable and installable from the Snap Store(https://snapcraft.io/store), an app store with an audience of millions.

## Enable snapd
Snap is available for Linux Mint 18.2 (Sonya), Linux Mint 18.3 (Sylvia), and the latest releases, Linux Mint 19 (Tara), Linux Mint 19.1 (Tessa), Linux Mint 19.2 (Tina) and Linux Mint 19.3 (Tricia). You can find out which version of Linux Mint you’re running by opening System info from the Preferences menu. To install snap from the Software Manager application, search for snapd and click Install.

## Alternatively, snapd Install from Command Line:
```bash
sudo apt update
sudo apt install snapd
sudo reboot
```

## Install Visual Studio Code (SNAP)
Install Visual Studio Code:
```bash
sudo snap install code --classic
```
## Remove Snap packages
Remove a Snap package:
```bash
sudo snap remove <package>
sudo snap remove code
```
---
# Register Microsoft key and Needed before installing .NET:
1. Register the Microsoft key.
2. Register the product repository.
3. Install required dependencies.
* This only needs to be done once per machine.
## Run Command:
```bash
wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```

## Install: .NET Core SDK
* Update & Install the .NET Core SDK: 
```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-3.1
```

## Install the ASP.NET Core runtime
* Update the products available for installation, then install the ASP.NET Core runtime. 
* In your terminal, run the following commands.
```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install aspnetcore-runtime-3.1
```

# Install the .NET Core runtime
* Update the products available for installation, then install the .NET Core runtime. 
* In your terminal, run the following commands.
```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-runtime-3.1
```

# How to install other versions
The packages added to the package manager feeds are named in a hackable format: 
{product}-{type}-{version}.

* product
  * The type of .NET product to install. Valid options are:
    * dotnet
    * aspnetcore
* type
  * Chooses the SDK or the runtime. Valid options are:
    * sdk
    * runtime
* version
  * The version of the SDK or runtime to install. 
  * Valid options are any released version, such as:
    * 3.0
    * 2.2
    * 2.1
* Examples
  * Install the .NET Core 2.2 SDK: dotnet-sdk-2.2
  * Install the ASP.NET Core 3.1 runtime: aspnetcore-runtime-3.1
  * Install the .NET Core 2.1 runtime: dotnet-runtime-2.1


# Create Firtst Console app 
Learn features in .NET Core and the C# language:
  Basics of .NET Core CLI
  Structure of C# Console Applications
  Console I/O
  Basics of File I/O APIs in .NET
  Basics of the Task-based Asynchronous Programming in .NET

Build an application to read text file, and echoe file data to the console. 
Paced output to the console with adjustable speed control. 
Key Press '<' (less than) or '>' (greater than).

## FILE SETUP TO: Create "Hello World" the app
* Open a command prompt, make dir, chg dir, create starter files.
```bash
    mkdir helloworld
    cd helloworld
    dotnet new console 
```

## Build engine(creates your application executable) and Execute application.
```bash
dotnet build
dotnet run
```

## Make first change 
* Edit Program.cs, change namespace: namespace TeleprompterConsole
```bash
gedit Program.cs
```

## Create sampleQuotes.txt for Reading and Echoing the File
* Create and place several lines of data for this project.
```bash
touch sampleQuotes.txt
gedit sampleQuotes.txt
```
## Edit Program.cs adding the following method into Program class (right below the Main method):
```c#
using System;
using System.Collections.Generic;
using System.IO;
namespace TeleprompterConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var lines = ReadFrom("sampleQuotes.txt");
      foreach (var line in lines)
      {
        Console.WriteLine(line);
      }
	    static IEnumerable<string> ReadFrom(string file)
      {
    	  string line;
        using (var reader = File.OpenText(file))
        {
          while ((line = reader.ReadLine()) != null)
          {
            yield return line;
          }
        }
      }
    }
  }
}
```

## Run the program (using dotnet run)
note every line printed out to the console.

## Adding Delays and Formatting output
it is displayed too fast to read aloud. 
Now add the delays in the output. 

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
namespace TeleprompterConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var lines = ReadFrom("sampleQuotes.txt");
      foreach (var line in lines)
      {
        //Console.WriteLine(line);
        Console.Write(line);
        if (!string.IsNullOrWhiteSpace(line))
        {
          var pause = Task.Delay(200);
          // Synchronously waiting on a task is an
          // anti-pattern. This will get fixed in later
          // steps.
          pause.Wait();
        }
      }
	    static IEnumerable<string> ReadFrom(string file)
      {
    	  string line;
        using (var reader = File.OpenText(file))
        {
          while ((line = reader.ReadLine()) != null)
          {
            //yield return line;
            var words = line.Split(' ');
            foreach (var word in words)
            {
              yield return word + " ";
            }
            yield return Environment.NewLine;
          }
        }
      }
    }
  }
}
```

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
namespace TeleprompterConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var lines = ReadFrom("sampleQuotes.txt");
      foreach (var line in lines)
      {
        //Console.WriteLine(line);
        Console.Write(line);
        if (!string.IsNullOrWhiteSpace(line))
        {
          var pause = Task.Delay(200);
          // Synchronously waiting on a task is an
          // anti-pattern. This will get fixed in later
          // steps.
          pause.Wait();
        }
      }
	    static IEnumerable<string> ReadFrom(string file)
      {
    	  string line;
        using (var reader = File.OpenText(file))
        {
          while ((line = reader.ReadLine()) != null)
          {
            //yield return line;
            var words = line.Split(' ');
	    var lineLength = 0;
            foreach (var word in words)
            {
              yield return word + " ";
              lineLength += word.Length + 1;
              if (lineLength > 70)
              {
                yield return Environment.NewLine;
                lineLength = 0;
              }
            }
            yield return Environment.NewLine;
          }
        }
      }
    }
  }
}
```


## Async Tasks, Contols
Alter the code to write the output asynchronously in one task, while also running another task to read input from the user to speed up, slow down the text display, or stop.
```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TeleprompterConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunTeleprompter().Wait();
        }

        private static async Task RunTeleprompter()
        {
            var config = new TelePrompterConfig();
            var displayTask = ShowTeleprompter(config);

            var speedTask = GetInput(config);
            await Task.WhenAny(displayTask, speedTask);
        }

        private static async Task ShowTeleprompter(TelePrompterConfig config)
        {
            var words = ReadFrom("SampleQuotes.txt");
            foreach (var word in words)
            {
                Console.Write(word);
                if (!string.IsNullOrWhiteSpace(word))
                {
                    await Task.Delay(config.DelayInMilliseconds);
                }
            }
            config.SetDone();
        }

        private static async Task GetInput(TelePrompterConfig config)
        {
            Action work = () =>
            {
                do {
                    var key = Console.ReadKey(true);
                    if (key.KeyChar == '>')
                        config.UpdateDelay(-10);
                    else if (key.KeyChar == '<')
                        config.UpdateDelay(10);
                    else if (key.KeyChar == 'X' || key.KeyChar == 'x')
                        config.SetDone();
                } while (!config.Done);
            };
            await Task.Run(work);
        }
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    var lineLength = 0;
                    foreach (var word in words)
                    {
                        yield return word + " ";
                        lineLength += word.Length + 1;
                        if (lineLength > 70)
                        {
                            yield return Environment.NewLine;
                            lineLength = 0;
                        }
                    }
                    yield return Environment.NewLine;                
                }
            }
        }
    }
}
```

make config.cs
```c#
using static System.Math;

namespace TeleprompterConsole
{
    internal class TelePrompterConfig
    {
        private object lockHandle = new object();
        public int DelayInMilliseconds { get; private set; } = 200;

        public void UpdateDelay(int increment) // negative to speed up
        {
            var newDelay = Min(DelayInMilliseconds + increment, 1000);
            newDelay = Max(newDelay, 20);
            lock (lockHandle)
            {
                DelayInMilliseconds = newDelay;
            }
        }

        public bool Done { get; private set; }

        public void SetDone()
        {
            Done = true;
        }
    }
}
```


