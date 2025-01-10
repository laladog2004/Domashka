using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        int number;
        int k;
        Console.Write("Введите натуральное число: ");

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Введите натуральное число.");
            }
        }

        Console.Write("Введите ОДНУ цифру для подсчета: ");

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out k))
            {
                if (k < 0 ||  k > 9)
                {
                    Console.WriteLine("Ошибка ввода. Введите ОДНУ цифру для подсчета.");
                }
                else
                {
                    break;
                }
            }

            else
            {
                Console.WriteLine("Ошибка ввода. Введите ОДНУ цифру для подсчета.");
            }
        }



        string numberStr = number.ToString();

        int count = 0;


        foreach (char digit in numberStr)
        {
            if (digit == k.ToString()[0])
            {
                count++;
            }
        }

        Console.WriteLine($"Цифра {k} встречается {count} раз(а) в числе {number}.");
        Console.ReadKey();
        return;
    }
}