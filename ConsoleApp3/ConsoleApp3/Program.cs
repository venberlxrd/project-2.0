using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 40;
            int d = (c - (--b)) * a;
            // (c--) = 40 | c=39
            // b * a = 15
            // 40 - 15 = 25
            Console.WriteLine($"a={a} b={b} c={c} d={d}");
            Console.ReadKey();
        }
    }
}
