using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill231_constVarGuid
{
    public class Class1
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public void Academy(string name) : this(name, "Salt Lake City")
        {
        }
        public void Academy(string name, string location)
        {
            Name = name;
            Location = location;
        }
        
    }
}
