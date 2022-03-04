using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_4
{
    // To add a class in Visual Stuido use Project / Add Class
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(Math.Sqrt(225)); // Math is a static class. Do not have to create an instance of the Math class.
            string name = "Hristian";

            // SayHello is a static method we declared in a static class "UsefullTools" using "Project / Add Class" menu option in Visual Studio.
            UsefullTools.SayHello(name); 
            Console.ReadLine();
        }
    }
}
 