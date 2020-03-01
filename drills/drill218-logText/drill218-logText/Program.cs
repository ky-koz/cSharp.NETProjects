using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace drill218_logText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a whole number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Logging your input to file...");

            string file = @"C: \Users\Kyla Kozole\Desktop\Repositories\c#.NET\Logs\log.txt";
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(input);
            }

            Console.WriteLine("The file now reads: ");

            string readText = File.ReadAllText(file);
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}


//1. Ask the user for a number.

//2. Log that number to a text file.

//3. Print the text file back to the user.

//WriteAllText only works for string input, no int:
//File.WriteAllText(file, input);
//Console.WriteLine("The file now reads: ");
//using (StreamReader sr = new StreamReader(file))
//{
//    String line = sr.ReadToEnd();
//    Console.WriteLine(line);
//}
//Console.ReadLine();

//alternative way to read file text:
//string line;
//using (StreamReader sr = new StreamReader(file))
//{
//    line = sr.ReadToEnd();  
//}
//Console.WriteLine(line);