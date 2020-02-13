using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot myRobot = new Robot(10, "Hover Bot");
            Robot otherRobot = new Robot(5, "Jesse Bot");


            Console.Out.WriteLine("Max Speed: " + myRobot.maxSpeed);
            Console.Out.WriteLine("Robot Type: " + myRobot.robotType);

            // Constructors
            // Initializes and object
            // MUST have the same name as the class
            // No return typpe (not even void)
            // Can only be called(invoked) by using new key word.
            // Optional. A no-arg constructor is provided when none are defined.... only if you do not define.

            
        }
    }
}
