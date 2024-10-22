using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            double y = F(2, 3, 5) + F(3, 4, 7) + F(5, 6, 11);



            Console.WriteLine("x = " + Math.Round(y, 3));

            Console.ReadKey();
        }

        static double F(double a, double b, double c)
        {
            return ((Math.Sin(a) - Math.Cos(b)) / Math.Sqrt(c));
        }
    }
}