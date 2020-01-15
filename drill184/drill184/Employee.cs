using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill184
{
    public class Employee
    {
        public string Id { get; set; }

        public static bool operator ==(Employee A, Employee B)
        {

            return A.Id == B.Id;
        }
        public static bool operator !=(Employee A, Employee B)
        {
            return A.Id != B.Id;
        }
    }
}
