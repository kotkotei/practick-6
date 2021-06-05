using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-50, 100);
                Console.WriteLine(mas[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 0)
                {
                    mas[i] = mas[i] + 100;
                }
                else
                {
                    mas[i] = mas[i] - 50;
                }
                Console.WriteLine(mas[i]);

            }
            Console.ReadKey();

        }
    }
}
