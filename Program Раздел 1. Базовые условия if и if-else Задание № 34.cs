using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program34
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Текущее время (часы 0–23): ");
            if (int.TryParse(Console.ReadLine(), out int hour) && hour >= 0 && hour <= 23)
            {
                if (hour >= 6 && hour <= 12)
                    Console.WriteLine("Доброе утро");
                else
                    Console.WriteLine("Время вне диапазона «утро».");
            }
            else
            {
                Console.WriteLine("Ошибка: введите час от 0 до 23.");
            }
        }
    }
}