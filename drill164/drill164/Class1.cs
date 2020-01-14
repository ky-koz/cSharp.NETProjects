using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill164
{
    public class Class1
    {
        public void Divide(int var1)
        {
            int answer = var1 / 2;
            Console.WriteLine(answer);
        }

        
        public void Output(int var2, int var3, out int sum, out int product)
        {
            sum = var2 + var3;
            product = var2 * var3;
        }

        public void Output(int var2, out int sum, out int product, out int one)
        {
            one = 1;
            sum = var2 + 1;
            product = var2 * 1;
        }

    }
}


//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.