using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12. Только одно из числе m и n меньше двадцати.");
            var m = GetNumber("m");
            var n = GetNumber("n");

            if (IsStatementTrue(m, n))
                Console.WriteLine("Утверждение истинно");
            else
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();

        }
        static bool IsStatementTrue(int m, int n)
        {
            if (m < 20 && n > 20 || n < 20 && m > 20)
            {
                return true;
            }

            return false;
        }

        static int GetNumber(string numberName)
        {
            
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}
