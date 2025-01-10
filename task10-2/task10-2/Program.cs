﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество административных единиц в стране (2 и более)");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }
            else if (n < 2)
            {
                Console.WriteLine("Не менее двух!");
                Console.ReadKey();
                return;
            }


            int maxSettlements = 0;
            int maxPopulation = 0;
            double maxAveragePopulation = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите общее количество жителей административной единицы #{i+1} (больше нуля)");
                    
                int population;
                if (!TryInputNumber(out population))
                {
                    Console.ReadKey();
                    return;
                }
                else if (population < 1)
                {
                    Console.WriteLine("Число должно быть больше нуля!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine($"Введите количество населенных пунктов административной единицы #{i+1} (больше нуля)");

                int settlements;
                if(!TryInputNumber(out settlements))
                {
                    Console.ReadKey();
                    return;
                }
                else if (settlements < 1)
                {
                    Console.WriteLine("Число должно быть больше нуля!");
                    Console.ReadKey();
                    return;
                }

                double averagePopulation = (double)population / settlements;

                
                if (averagePopulation > maxAveragePopulation)
                {
                    maxAveragePopulation = averagePopulation;
                    maxSettlements = settlements;
                    maxPopulation = population;
                }
            }

            Console.WriteLine($"Административная единица с {maxSettlements} населенными пунктами и общим населением в {maxPopulation} тыс. чел.\n" +
                               $"имеет наибольшее среднее население населенного пункта {maxPopulation/maxSettlements} тыс. чел.");

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
    }
}