using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Jesse");
            intList.Remove("Jesse");
       

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            // byte[] byteArray =
            //List<int> intList = new List<int>();
            //intList.Add(4);new 
            //intList.Add(10);
            //intList.Add(31);
            //intList.Remove(10);

            //Console.WriteLine(intList[1]);
            //Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }
}
