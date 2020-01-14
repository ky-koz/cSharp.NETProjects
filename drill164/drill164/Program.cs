using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill164
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();
            Class1 parameters = new Class1();

            int input;
            Console.WriteLine("Please type a whole number: ");
            Int32.TryParse(Console.ReadLine(), out input);

            Console.WriteLine("{0} divided by two equals: ", input);
            math.Divide(input);


            int sum;
            int product;
            Console.WriteLine("Please type a whole number for variable 1: ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type a whole number for variable 2: ");
            int var2 = Convert.ToInt32(Console.ReadLine());
            parameters.Output(var1, var2, out sum, out product);
            Console.WriteLine("{0} multiplied by {1} equals: {2}", var1, var2, product);
            Console.WriteLine("{0} added to {1} equals: {2}", var1, var2, sum);

            int one;
            Console.WriteLine("Please type a whole number for variable 1: ");
            int var3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Variable 2 will be set to default value of 1.. ");
            parameters.Output(var3, out sum, out product, out one);
            Console.WriteLine("{0} multiplied by {1} equals: {2}", var3, one, product);
            Console.WriteLine("{0} added to {1} equals: {2}", var3, one, sum);

            
            Console.WriteLine("Please type a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int answer = Class2.Numbers(num);
            Console.WriteLine("{0} multiplied by 100 equals: {1}", num, answer);
            

            Console.ReadLine();
        }
    }
}

//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. 
//It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.
