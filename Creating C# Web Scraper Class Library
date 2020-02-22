# Creating C# Web Scraper Class Library Using VScode

### Create Project Folder:

```bash
mkdir ~/myCode/cSharp/Project_References_Assemblies
cd    ~/myCode/cSharp/Project_References_Assemblies
dotnet new classlib -o MyCodeLibrary

Restore succeeded.
```

##### Open "MyCodeLibrary" in VScode

Rename
 - class1.cs => Scrape.cs
 - class Class1 => class Scrape

Edit Scrape.cs:

```c#
using System; using System.IO; using System.Net;

namespace MyCodeLibrary{
 public class Scrape{
  public string ScrapeWebpage(string url){
   //WebClient client = new WebClient ();
   //return client.DownloadString (url);
   return getWebpage(url);
  }

  public string ScrapeWebpage(string url, string pathfile){
   //WebClient client = new WebClient ();
   //string reply = client.DownloadString (url);
   //File.WriteAllText(pathfile, reply);
   string reply = getWebpage(url);
   File.WriteAllText(pathfile, reply);
   return reply;
  }

  private string getWebpage(string url){
   WebClient client = new WebClient ();
   return client.DownloadString (url);
}}}
```

##### Build Class Library

```bash

cd ~/myCode/cSharp/Project_References_Assemblies/MyCodeLibrary
dotnet build

Build succeeded.
    0 Warning(s)
    0 Error(s)
```

## Create a new Console Application Folder with Dependancys

```bash

cd ~/myCode/cSharp/Project_References_Assemblies
dotnet new console -o MyClient

Restore succeeded.
```

## Add Reference to Library File.

```bash

cd ~/myCode/cSharp/Project_References_Assemblies/MyClient
dotnet add reference ~/myCode/cSharp/Project_References_Assemblies/MyCodeLibrary/MyCodeLibrary.csproj

Reference `..\MyCodeLibrary\MyCodeLibrary.csproj` added to the project.
```

Above command will add reference to MyCodeLibrary.csproj in MyClient Project. Making the MyCodeLibrary class ready for use in the MyClient Project.

### Open MyClient Folder using VScode

click yes if ask to update dependency

##### Edit Program.cs:

```c#
using System; using MyCodeLibrary;

namespace MyClient{
 class Program{
  static void Main(string[] args){
   Scrape myScrape = new Scrape();
   string targetUrl = "http://github.com";
   string value = myScrape.ScrapeWebpage(targetUrl);
   Console.WriteLine(value);
   Console.WriteLine("Scraping Successful:\n \t\"{0}\" \nHave a blessed day! ", targetUrl);
}}}
```

### Run The Scraper:

```bash
cd ~/myCode/cSharp/Project_References_Assemblies/MyClient
dotnet run
```

---

---

Created by:
Jesse Fore
service.awg@gmail.com

Updated:
22 February 2020

-_-
---
