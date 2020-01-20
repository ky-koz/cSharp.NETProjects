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
            Class1 name = new Class1();
            name.Name = "Tech Academy";
            name.Location = "Remote";
            
            const string studentName = "Kyla";
            var drill = "drill";

            Console.WriteLine("These {0} assignments have been completed by {1}.", studentName, drill);

            
        }        
    }
}

//1. Create a const variable.

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.