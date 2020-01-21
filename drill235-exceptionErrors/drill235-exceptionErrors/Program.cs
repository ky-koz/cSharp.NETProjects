using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill235_exceptionErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            

            yearBorn born = new yearBorn();

            bool go = true;
            while (go)
            {
                try
                {
                    Console.WriteLine("Please type your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    born.Subtract(age);

                    //Console.WriteLine("You were born in the year {0}.", );
                    
                    go = false;
                }
                catch (InputException)
                {
                    Console.WriteLine("Please type whole numbers only, no decimals.");
                    Console.ReadLine();                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Something is wrong with your input. Please type whole numbers only.");
                    Console.ReadLine();

                }
            }

            
            Console.ReadLine();
        }
    }
}

//1. Ask the user for their age.

//2. Display the year the user was born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if the user enters zero or negative numbers.

//5. Display a general message if an exception was caused by anything else.


//can I put this in the class yearBorn?
//if (age < 1)
//{
//    throw new InputException();
//}