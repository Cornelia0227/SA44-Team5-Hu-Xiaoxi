using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huxx1
{
    class Class1
    {
        public void Main()
        {
            Console.WriteLine("Input the No of Stus:");
            string No = Console.ReadLine();
            int Num = Convert.ToInt32(No);
            Console.WriteLine("Total cost:${0}",Num*20);
            Console.ReadLine();
        }
    }
}