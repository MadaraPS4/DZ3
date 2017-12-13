using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=0;
            while (a>b)
            {
                Console.WriteLine("Число а должно быть меньше числа  b");
                Console.WriteLine("Введите число А");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите число B");
                b= Int32.Parse(Console.ReadLine());
            }
            
            for(int i=a; i<=b; i++)
            {
                int count = 0;
                while (count < i)
                {
                    Console.Write(" "+i);
                    count++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();

           
        }
    }
}
