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

            int num1 = 8;
            int num2 = 8;
            if (num1 > num2)
            {
                Console.WriteLine("{num1} > {num2}");
            }
            else if (num2 == num1)
            {
                Console.WriteLine($"{num2} = {num1}");

            }
            
            else
            {
                Console.WriteLine($"{num2} > {num1}");
            }

            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            // break, goto case return, throw
            switch(selection)
            {
                case "Y":
                    Console.WriteLine("Нажата клавиша Y");
                    break;
                case "N":
                    Console.WriteLine("Нажата клавиша N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную клавишу");
                    break;
            }
            // тернарный оператор op1?op2:op3;
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
                string selection2 = Console.ReadLine();
            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);


            Console.ReadKey();


        }
    }
}
