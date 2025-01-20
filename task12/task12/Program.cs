using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число m (5 <= m <= 20): ");
            int m;
            if (!TryInputNumber(out m) || !(m <= 20 && m >= 5))
            {
                Console.Write("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите число n (5 <= n <= 20): ");
            int n;
            if (!TryInputNumber(out n) || !(n <= 20 && n >= 5))
            {
                Console.Write("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            int[,] array = FillArray(m, n);

            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.Write("Введите число для поиска в массиве: ");
            int searchValue;
            if (!TryInputNumber(out searchValue))
            {
                Console.Write("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            FindElement(array, searchValue);

            FindRowMaxElements(array);
            Console.ReadKey();
        }

        static int[,] FillArray(int m, int n)
        {
            Random rand = new Random();
            int[,] array = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }

            return array;
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        static void FindElement(int[,] array, int value)
        {
            bool found = false;
            bool RepeatedFound = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == value)
                    {
                        Console.WriteLine($"Элемент {value} найден на индексе ({i + 1}, {j + 1}).");
                        found = true;
                        RepeatedFound = true;
                    }
                }              
            }

            if (!found && !RepeatedFound)
            {
                Console.WriteLine($"Элемент {value} не найден в массиве.");
            }
        }

        static void FindRowMaxElements(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int max = array[i, 0];
                int maxIndex = 0;

                for (int j = 1; j < cols; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex = j;
                    }
                }

                Console.WriteLine($"Строка {i + 1}: Максимальный элемент = {max} (индекс столбца {maxIndex + 1})");
            }
        }
        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                return false;
            }

            number = n;
            return true;
        }
    }
}
