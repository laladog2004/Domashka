using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12. Даны длины двух сторон треугольника и угол между ними. Найти площадь и периметр треугольника.");

            Console.WriteLine("Введите длину первой стороны треугольника");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите угол между данными сторонами в градусах");
            double alpha = Math.PI * double.Parse(Console.ReadLine()) / 180;

            double y = Math.Cos(alpha);
            double x = a * a + b * b - 2 * a * b * y;
            double z = Math.Sqrt(x);
            double p = z + a + b;
            double n = Math.Sin(alpha);
            double s = ( n * a * b )/ 2;
           

            Console.WriteLine("Площадь треугольника: " + Math.Round(s, 3));
            Console.WriteLine("Периметр треугольника: " + Math.Round(p, 3));

            Console.ReadKey();
        }
    }
}