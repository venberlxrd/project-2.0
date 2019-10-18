using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            // for
            //while
            //do..while
            // foreach
            // F = n!
            int n = 8; // 40320
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
                Console.WriteLine(result);

            }
            //int i = 6;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;

            //}
            //while (i > 0);
            Console.ReadKey();


        }
    }
}


