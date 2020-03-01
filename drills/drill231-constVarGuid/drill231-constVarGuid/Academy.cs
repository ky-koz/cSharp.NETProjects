using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill231_constVarGuid
{
    public class Academy
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Academy(string name) : this(name, "Salt Lake City")
        {
        }
        public Academy(string name, string location)
        {
            Name = name;
            Location = location;
        }

        

    }
}

//1. Create a const variable.

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.