using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate double AverageValue(double a, double b, double c);

        static void Main(string[] args)
        {
            AverageValue average = delegate (double a, double b, double c)
            {
                return (a + b + c) / 3;
            };

            var ave = average(3, 3, 4);

            Console.WriteLine(ave);

            Console.ReadKey();
        }
    }
}
