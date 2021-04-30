/*Для полного закрепления понимания простых типов найдите любой чек, либо фотографию 
 *этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, 
 *по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте
 *переменные, которые были заранее заготовлены до вывода на консоль.
 */
using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumChek = 1;
            DateTime date = DateTime.Now;
            string KassirName = "Хочухина Е.П.";
            string OficiantName = "Разговоривая В.К.";
            string eat1 = "Нечто зелененькое и полезненькое";
            string eat2 = "Штука приятная и апетитная на вид";
            string eat3 = "Пахнет обалденно";
            float Cost1 = 304.4f;
            float Cost2 = 309.4f;
            float Cost3 = 403.4f;
            float NDS = (float) ((Cost1 + Cost2 + Cost3) * 0.18);
            int Okrugl = (int)(NDS * 100);
            NDS = (float)(Okrugl / 100.0);
            float SumEat = (float)(Cost1 + Cost2 + Cost3 + NDS);
            Okrugl = (int)(SumEat * 100);
            SumEat = (float)(Okrugl / 100.0);
            Console.WriteLine("         ООО Едальня");
            Console.WriteLine($"Чек {NumChek} ");
            Console.WriteLine($"Дата {date.ToString("dd/MM/yyyy")} время {date.ToString("HH:mm:ss")} оплаты");
            Console.WriteLine($"Кассир: {KassirName}");
            Console.WriteLine($"Кассир: {OficiantName}");
            Console.WriteLine("Блюдо            Кол-во          Сумма");
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine($"{eat1}       1                   {Cost1}");
            Console.WriteLine($"{eat2}      1                   {Cost2}");
            Console.WriteLine($"{eat3}                       1                   {Cost3}");
            Console.WriteLine($"НДС                                                       {NDS}");
            Console.WriteLine($"Итого к оплате                                           {SumEat}");
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("СПАСИБО ЗА ПОКУПКУ, ЖДЕМ ВАС С ХОРОШИМ НАСТРОЕНИЕМ");
            Console.ReadLine();
        }
    }
}
