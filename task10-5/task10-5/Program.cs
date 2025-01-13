using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:\n"
            + "(Не менее двух знаков!)");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long number) && number >= 10)
            {
                char[] digits = input.ToCharArray();

                int left = 0;
                int right = digits.Length - 1;

                while (left < right)
                {
                    char temp = digits[left];
                    digits[left] = digits[right];
                    digits[right] = temp;

                    left++;
                    right--;
                }

                string result = new string(digits);
                Console.WriteLine("Измененное число: " + result);
                Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine("Введено некорректное число.");
                Console.ReadKey();
            }
        }
    }
}