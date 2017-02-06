using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huxx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Huxx first C#");
            Console.Write("Write down your dream: ");
            Console.Write("~~~~");
            Console.WriteLine("what?");
            Console.WriteLine("10/2"+"="+10/2);
            Console.WriteLine("q"+"q"+"o");
            Console.WriteLine("\"\"\"hello\"");
            int a=1;
            Console.WriteLine(++a);
            Console.Write(a);
            Console.WriteLine("aaa\\");   /*hhhhhh*/
            Console.WriteLine("\t*\n\t**\n\t***");
            double x = 107.13686, y = 8.22334455;
            Console.WriteLine("{0}+{1}={2}",x,y,x+y);
            Console.WriteLine( x+"+"+y+"="+(x + y));
            /*output 1.0000*/
            Console.WriteLine("{0:0.000} is not equal to {1:1.000}",x,y);
            /*output 001*/
            Console.WriteLine("{0:000}",x);
            /*output 01*/
            Console.WriteLine("{0:##00}", x);
            x += 5;   //x=x+5
            y -= 5;   //y=y-5
            x /= 5;
            y *= 5;

            Console.ReadLine();
             
        }
    }
}
