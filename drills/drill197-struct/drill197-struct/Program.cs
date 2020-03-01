using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill197_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 1.5E6m;

            Console.WriteLine("The amount is: {0}", number.Amount);
            Console.ReadLine();
        }
    }
}

//1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

//2. In the Main() method, create an object of data type Number and assign an amount to it.

//3. Print this amount to the console.