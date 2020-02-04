using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        delegate double Operation(double a, double b);
        static void Main(string[] args)
        {
            Operation Add = (a, b) => a + b;
            Operation Sub = (a, b) => a - b;
            Operation Mul = (a, b) => a * b;
            Operation Div = (a, b) => b != 0 ? a / b : 0;

            Console.WriteLine("Input first value");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second value");
            double number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input you choice");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine(Add(number1, number2));
                    break;
                case 2:
                    Console.WriteLine(Sub(number1, number2));
                    break;
                case 3:
                    Console.WriteLine(Mul(number1, number2));
                    break;
                case 4:
                    Console.WriteLine(Div(number1, number2));
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
