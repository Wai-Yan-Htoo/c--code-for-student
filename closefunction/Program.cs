using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostusage
{
    class Program
    {
        static void Main(string[] args)
        {
            //string interpolation
            string a = "student";
            Console.WriteLine($"hello {a}");
            Console.WriteLine("----------------------------------------------");
            //about of trim function start,end
            string a1 = "  student     ";
            Console.WriteLine(a1.Trim());//default start
            Console.WriteLine(a1.TrimStart()+"are you ok?");
            Console.WriteLine(a1.TrimEnd()+" are you ok?");
            Console.WriteLine("----------------------------------------------");
            //replace function
            string a2 = "hello";
            Console.WriteLine(a2.Replace("hello", "hi"));
            Console.WriteLine("----------------------------------------------");
            //contains function
            string a3 = "today is very hot";
            Console.WriteLine(a3.Contains("h"));
            Console.WriteLine(a3.Contains("cold"));
            Console.WriteLine("----------------------------------------------");
            //startswith function
            string a4 = "You say greetings, and I say hello";
            Console.WriteLine(a4.StartsWith("You"));
            Console.WriteLine(a4.StartsWith("you"));
            Console.WriteLine("----------------------------------------------");
            //int can store this size
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"min {min} to max {max}");
            int what = max + 1;
            Console.WriteLine($"overflow {what}");
            Console.WriteLine("----------------------------------------------");
            
        }
    }
}
