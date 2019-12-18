using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && true && true || false); //true
            Console.WriteLine(false && true && true || false); //false

            //AND - both true
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            //OR - one is true
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            //EQUAL TO 
            Console.WriteLine(true == false);
            Console.WriteLine(true == true);
            Console.WriteLine(false == false);

            //NOT EQUAL TO
            Console.WriteLine(true != false);
            Console.WriteLine(true != true);
            Console.WriteLine(false != false);

            //IF ONE IS TRUE, NOT BOTH (x/or)
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
