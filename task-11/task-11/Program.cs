using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1) Введите первый член арифметической прогрессии (a): ");
            int a;

            if (!TryInputNumber(out a))
            {
                Console.ReadKey();
                return;
            }

            Console.Write("Введите разность арифметической прогрессии (d): ");
            int d;

            if (!TryInputNumber(out d))
            {
                Console.ReadKey();
                return;
            }

            int[] progressionArray = new int[10];

            for (int i = 0; i < progressionArray.Length; i++)
            {
                progressionArray[i] = a + i * d;
            }

            Console.WriteLine("\nПолученный массив арифметической прогрессии:");
            PrintArray(progressionArray);

            Console.Write("\n2) Введите целое число k, на которое нужно увеличить каждый элемент массива: ");
            int k;

            if (!TryInputNumber(out k))
            {
                Console.ReadKey();
                return;
            }

            IncreaseArrayElements(ref progressionArray, k);

            Console.WriteLine("\nМассив после увеличения каждого элемента на k:");
            PrintArray(progressionArray);

            int oddCount = CountOddElements(progressionArray);
            Console.WriteLine($"\n3) Количество нечетных элементов в массиве: {oddCount}");

            Console.Write("\n4) Введите натуральное число для возведения элементов массива в степень: ");
            int power;

            if (!TryInputNumber(out power))
            {
                Console.ReadKey();
                return;
            }

            int[] poweredArray = GetArrayRaisedToPower(progressionArray, power);

            Console.WriteLine($"\nМассив с элементами, возведенными в степень {power}:");
            PrintArray(poweredArray);

            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static void IncreaseArrayElements(ref int[] array, int k)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += k;
            }
        }

        static int CountOddElements(int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        static int[] GetArrayRaisedToPower(int[] array, int power)
        {
            int[] poweredArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                poweredArray[i] = (int)Math.Pow(array[i], power);
            }
            return poweredArray;
        }
    }
}
