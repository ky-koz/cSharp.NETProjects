using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            //    string name = "Jesse";
            //    string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //    string fileName = @"C:\Users\Jesse"; // @ means everything in quotations is string value, no escape sequences

            //    bool trueOrFalse = name.Contains("s");
            //    trueOrFalse = name.EndsWith("s");

            //    int length = name.Length;

            //    name = name.ToLower();

            //    Console.WriteLine(name);
            //    Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse"); // works similar to string



            Console.WriteLine(sb);
            Console.ReadLine();
           
        }
    }
}
