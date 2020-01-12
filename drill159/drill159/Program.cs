using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill159
{
    class Program
    {
        static void Main(string[] args)
        {
            //This creates an object for the class methods to exist
            Class1 operations = new Class1();



            Console.WriteLine("Please enter a whole number to multiply: ");
            int var1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} multiplied by itself :", var1);
            Console.WriteLine(operations.Math(var1));

            Console.WriteLine("Please enter a decimal to multiply: ");
            decimal var2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("{0} mulptiplied by itself :", var2);
            Console.WriteLine(operations.Math(var2));

            
            bool loop = true;
            while (loop)
            {
                try
                {
                    Console.WriteLine("Please enter a whole number to add to itself: ");
                    string var3 = Console.ReadLine();

                    Console.WriteLine(operations.Math(var3));
                    loop = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Please try again: "); //will write out error message
                }
                
            }
            Console.ReadLine();
        }
    }
}


//1. Create a class. In that class, create a method that will take in an integer, do a math 
//    operation to it and then return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call the one method, 
//    passing in an integer.Display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in a decimal, 
//    do a different math operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call the second method, 
//    passing in a decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a string, convert 
//    it to an integer if possible, do a different math operation to it and then return the 
//    answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call the third method, 
//    passing in a string that equates to an integer.Display the result to the screen.