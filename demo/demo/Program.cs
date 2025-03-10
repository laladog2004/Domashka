using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int j = 3;

            Console.WriteLine("1) Пример использования оператора цикла while:\n");
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\n2) Пример использования оператора цикла do-while:\n");
            do
            {
                Console.WriteLine(j);
                j++;

            } while (j < 3);

            Console.ReadKey();
        }
    }
}
