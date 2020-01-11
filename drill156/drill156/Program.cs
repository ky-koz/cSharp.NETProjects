using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill156
{
    class Program
    {
        static void Main(string[] args)
        {
            //Does this create an object for the class methods to exist?
            Class1 operations = new Class1();


            Console.WriteLine("Choose a variable to perform math operations.");
            Console.WriteLine("Please enter a whole number: ");
            int var1 = Convert.ToInt32(Console.ReadLine());


            //I need an object to call, a method is not an object
            Console.WriteLine("{0} multiplied by itself :", var1);
            Console.WriteLine(operations.Multiply(var1));

            Console.WriteLine("{0} divided by itself :", var1);
            Console.WriteLine(operations.Divide(var1));

            Console.WriteLine("{0} added to itself :", var1);
            Console.WriteLine(operations.Add(var1));
            Console.ReadLine();
        }
        
    }
}

//2. In the Main() program, ask the user what number they want to do the math operations on.
//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
