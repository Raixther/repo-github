using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            long rnktt = 6205_4521_1231_5327;

            long fnn = 2532_4543_1238_5367;

            int smena = 143;

            int chek = 232;

            double a = 84.45;

            double b = 1.29;

            double result = 85.74;

            double cash = 85.74;

            int fd = 48151;

            long fp = 2345124222;






            Console.WriteLine("Кассовый чек/Приход");
            Console.WriteLine($"РН ККТ{rnktt}");
            Console.WriteLine($"ФН:{fnn}");
            Console.WriteLine("Сайт ФНС   nalog.ru");
            Console.WriteLine($"Смена:{smena} Чек{chek}"); 
            Console.WriteLine($"Пополнение проездного\n      {a}");
            Console.WriteLine($"Обработка данных\n            {b}");
            Console.WriteLine($"Итoг         {result}");
            Console.WriteLine($"Наличными  {cash}");
            Console.WriteLine("СНО:       УСН доход");
            Console.WriteLine($"ФД:{fd} ФП:{fp}");

        }
    }
}
