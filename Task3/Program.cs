using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
  
    class Program
    {
        public delegate int MyDelegate();
        public delegate int Averange(MyDelegate[] arr);

        public static Random random = new Random();

        public static int Randomizer()
        {
            return random.Next(1, 100);
        }

        static void Main(string[] args)
        {
            MyDelegate[] myDelegate = new MyDelegate[5];
            for (int i = 0; i < myDelegate.Length; i++)
            {
                myDelegate[i] = Randomizer;
                Console.Write($" {myDelegate[i]()} ");
            }
            Console.WriteLine();
            Averange averangeValue = delegate (MyDelegate[] arr)
            {
                int avr = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    avr += arr[i]();
                }
                return ((avr) / (arr.Length));
            };

            Console.WriteLine(averangeValue(myDelegate));

            Console.ReadKey();
        }
    }
}
