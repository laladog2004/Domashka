using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("А вы могли бы?");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Я сразу смазал карту будня,");
            Console.WriteLine("плеснувши краску из стакана;");
            Console.WriteLine("я показал на блюде студня");
            Console.WriteLine("косые скулы океана.");
            Console.WriteLine("На чешуе жестяной рыбы");
            Console.WriteLine("прочёл я зовы новых губ.");
            Console.WriteLine("А вы");
            Console.WriteLine("ноктюрн сыграть");
            Console.WriteLine("могли бы");
            Console.WriteLine("на флейте водосточных труб?");

            Console.ForegroundColor = originalColor;
            Console.WriteLine("Цвет текста возвращен в исходное состояние.");
            Console.ReadKey();
        }
    }
}