using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int onlineUsers;
            onlineUsers = 2;
            i = 50;

            double d = 1.5;
            double accountBalance = 120.35;
            d = 50.6;

            
            char c = 'a';
            char dollar = '$';

            string s = "Hello World!!!";
            string welcomeMessage = "Welcome to the data types demo.";
            string emptyString = "";
            string oneCharacter = "a";

            bool b = true;
            bool activeBanckAccount = false;
            activeBanckAccount = b;


            Console.Out.WriteLine(welcomeMessage);
            Console.Out.WriteLine();
            Console.Out.Write("Account active: ");
            Console.Out.WriteLine(activeBanckAccount);
            Console.Out.Write("Account balance: ");
            Console.Out.Write(dollar);
            Console.Out.WriteLine(accountBalance);
            Console.Out.WriteLine();
            Console.Out.WriteLine("press enter to continue...");
            Console.In.ReadLine();

            Console.WriteLine(s);
            
        }
    }
}
