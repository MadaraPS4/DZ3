using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char c;
            do
            {
                c = Console.ReadKey().KeyChar;
                if (c == ' ')
                {
                    count++;
                }

            } while (c != '.');

            Console.WriteLine();
            Console.WriteLine("Количество пробелов равно " + count);
            Console.ReadKey();
        }
    }
}
