using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = 0;
            while (true)
            {
                
                if(!Int32.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Только цифры пожалуйста");
                    continue;
                }
                else
                {
                    break;
                }
            }
            int left = number;
            int r = 0;
            while (left > 0)
            {
                number = left % 10;
                r = r * 10 + number;
                left = left / 10;
            }

            Console.WriteLine(r);

            Console.ReadKey();

        }
    }
}
