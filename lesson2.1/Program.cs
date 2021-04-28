using System;
using System.IO;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки в градусах цельсия:");
            int MinTempDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки в градусах цельсия:");
            int MaxTempDay = Convert.ToInt32(Console.ReadLine());
            if ((MaxTempDay>=100)||(MaxTempDay<=-100)||(MinTempDay>=100)||(MaxTempDay<=-100))
            { 
                Console.WriteLine("Либо земля стала необетованна, либо люди сильно изменились.");
                Console.WriteLine(" Пиши свою программу или введи значение от -100 до +100");
                return;
            }
            int MiddleTempDay = (MaxTempDay + MinTempDay) / 2;
            Console.WriteLine(MiddleTempDay);
            Console.ReadLine();
        }
    }
}
