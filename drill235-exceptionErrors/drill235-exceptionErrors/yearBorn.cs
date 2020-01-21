using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace drill235_exceptionErrors
{
    
    public class yearBorn 
    {
        
        public void Subtract (int age)
        {
            DateTime now = DateTime.Now;
            DateTime born = now.AddHours(-age);
            Console.WriteLine(born);
            Console.ReadLine();
        }
}
}
