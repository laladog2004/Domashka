using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число k (1 <= k <= 150): ");
            int k = int.Parse(Console.ReadLine());

            string sequence = "";

            for (int i = 101; i <= 150; i++)
            {
                sequence += i.ToString();
            }

            Console.WriteLine($"Цифра на позиции {k} в последовательности: {sequence[k - 1]}");

            Console.ReadKey();
        }
    }
}
