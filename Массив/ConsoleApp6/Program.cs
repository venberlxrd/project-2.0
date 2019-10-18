using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 }; // 0 -3
            //int n = numbers[0]; // 1
            //numbers[0] = 7;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
             
            foreach(int k in numbers)
            {
                Console.WriteLine(k);
            }
            for (int i = 0; i<numbers.Length ;i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.ReadKey();


        }
    }
}
