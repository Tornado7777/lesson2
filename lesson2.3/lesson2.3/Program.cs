//	Определить, является ли введённое пользователем число чётным.
using System;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целое число:");
            int Number = Convert.ToInt32(Console.ReadLine());
            if ((Number%2) == 0)
            {
                Console.WriteLine($"Число {Number} является чётным.");
            }
            else
            {
                Console.WriteLine($"Число {Number} является нечётным.");
            }
        }
    }
}
