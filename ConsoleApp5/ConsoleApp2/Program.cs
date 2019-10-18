using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            bool c= a == b;
            bool d = a != b;
            bool f = a > b;
            bool e = a < b;
            bool g = a <= b;
            bool h = a <= 10;

            bool x1 = (5 > 6) | (4 < 6); //false,true = true
            bool x2 = (5 > 6) || (4 > 6); //false,false = false

            bool x3 = (5 > 6) & (4 < 6); //false,true = false
            bool x4 = (5 > 6) && (4 > 6); //false,false = false
            bool x5 = (5 < 6) && (4 < 6); //true,true = ture

            bool t = true;
            bool s = !t; // false

            bool l = false;
            bool j = !l; // true

            bool x41 = (5 > 6) ^ (4 < 6); //false, true = true
            bool x51 = (5 > 6) ^ (4 > 6); //false, false = false
            bool x52 = (5 < 6) ^ (4 < 6); //true, true = false


            Console.ReadKey();
        }
    }
}
