﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коронация: ");

            var s = "коронация";


            var word1 = s
                .Remove(8)
                .Remove(0, 6);

            word1 += s.Substring(2, 1);
            word1 += s.Substring(0, 1);

            Console.WriteLine("1) " + word1);

            var word2 = s
                .Remove(0);

            word2 += ReverseString(s
                .Remove(2));

            word2 += ReverseString(s
                .Remove(4));

            Console.WriteLine("2) " + word2);        

            Console.ReadKey();
        }

        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}