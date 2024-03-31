using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3___Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности: ");
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите число: ");
                num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine("Наименьшее число: " + min);
            Console.ReadKey();
        }
    }
}
