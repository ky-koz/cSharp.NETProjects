using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill231_constVarGuid
{
    class Program
    {
        static void Main(string[] args)
        {
            Academy name = new Academy("Tech Academy");
            //name.Name = "Tech Academy";
            //name.Location = "Remote";
            Console.WriteLine("{0} {1} ", name.Name, name.Location);
            
            const string studentName = "Kyla";
            var drill = "drill";

            Console.WriteLine("These {0} assignments have been completed by {1}.", drill, studentName);

            Console.ReadLine();
        }        
    }
}

//1. Create a const variable.

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.