using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(ConsoleKeyInfo k)
        {
            Console.WriteLine("Введите слово или число");

            string s = Console.ReadLine();

            Console.WriteLine("Ваше слово в верхнем регистре");

            string upperS = s.ToUpper();

            Console.WriteLine(upperS);

            Console.ReadKey();
            
        }
    }
}
