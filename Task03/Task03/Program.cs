using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 150 (включительно)");
            var number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 150)
            {
                Console.WriteLine("Неверный ввод. Введите число от 1 до 150!");
                Console.ReadKey();
            }


            for (int i = 101; i <= 150; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    char digit = i.ToString()[j];
                    if (j == number)

                    {
                        Console.WriteLine("{digit}");
                        
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
