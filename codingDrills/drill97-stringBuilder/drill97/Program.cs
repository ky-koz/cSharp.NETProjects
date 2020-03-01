using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill97
{
    class Program
    {
        static void Main(string[] args)
        {
            //concatenate three strings
            string sOne = "This is ";
            string sTwo = "a multiple ";
            string sThree = "part sentence.";
            string str;

            //convert a string to uppercase
            sTwo = sTwo.ToUpper();

            str = String.Concat(sOne, sTwo, sThree);

            //Create a Stringbuilder for a paragraph
            StringBuilder sb = new StringBuilder("Hello, ", 100);

            sb.Append("viewer. ");
            sb.Append("I am creating a paragraph with the Stringbuilder.");
            sb.Append("One line at a time. ");
            sb.Append("Three sentences is the minimum for a paragraph. ");
            sb.Append("This paragraph has exceeded the minimum sentence requirement.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
