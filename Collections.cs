using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> contacts = new Dictionary<string, string>();

            contacts.Add("Jesse", "214-934-5637");
            contacts.Add("James", "214-999-5637");
            contacts.Add("Bob", "222-934-5637");

            if (contacts.ContainsKey("James"))
                contacts.Remove("James");
            
            Console.Out.WriteLine("Jesse's Number: "+contacts["Jesse"]);

            String output;
            if (contacts.ContainsKey("Bob")){
                contacts.TryGetValue("Bob", out output);
                if (output != null)
                    Console.Out.WriteLine("Output not null: "+output);
            }

            Console.Out.WriteLine("\nAll numbers: ");

            foreach (String value in contacts.Values)
                Console.Out.WriteLine(value);

        }
    }
}