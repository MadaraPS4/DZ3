using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета трамвая");
            int[] number = new int[6];
            char p;
            for(int i=0; i<6; i++)
            {
                p = Console.ReadKey().KeyChar;

                if (char.IsDigit(p))
                {
                    number[i] = p;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Только цифры, пожалуйста");
                    i--;
                }
            }

            if ((number[0] + number[1] + number[2]) == (number[3] + number[4] + number[5]))
            {
                Console.WriteLine();
                Console.WriteLine("Поздравляю, у вас счастливый билет");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас обычный билет");
            }
            Console.ReadKey();
        }
    }
}
