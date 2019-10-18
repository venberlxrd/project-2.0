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
            try
            {
                int a = 22;
                int c = 400;
                byte b = checked((byte)(a + c));
                Console.WriteLine(b);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("недопустимый диапозон");
            }

            Console.ReadKey();
        }
    }
}
