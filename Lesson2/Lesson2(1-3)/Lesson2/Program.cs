using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите минимальную суточную температуру");

            string a = Console.ReadLine();

            double MinTemper = Convert.ToDouble(a);

            Console.WriteLine("Введите максимальную суточную температуру");

            string b = Console.ReadLine();

            double MaxTemper = Convert.ToDouble(b);

            double MedTemper = (MinTemper + MaxTemper) / 2;

            Console.WriteLine("Введите порядковый номер текущего месяца");

            string c = Console.ReadLine();

            byte MonthNumber = Convert.ToByte(c);

            Console.WriteLine($"Среднесуточная температура равна {MedTemper}");

            switch (MonthNumber)

            {
                case 1:

                    Console.WriteLine("Январь");

                    break;

                case 2:

                    Console.WriteLine("Февраль");

                    break;

                case 3:

                    Console.WriteLine("Март");

                    break;

                case 4:

                    Console.WriteLine("Апрель");

                    break;

                case 5:

                    Console.WriteLine("Май");

                    break;

                case 6:

                    Console.WriteLine("Июнь");

                    break;

                case 7:

                    Console.WriteLine("Июль");

                    break;

                case 8:

                    Console.WriteLine("Август");

                    break;

                case 9:

                    Console.WriteLine("Сентябрь");

                    break;

                case 10:

                    Console.WriteLine("Октябрь");

                    break;

                case 11:

                    Console.WriteLine("Ноябрь");

                    break;

                case 12:

                    Console.WriteLine("Декабрь");

                    break;

            }

            if (MonthNumber % 2 == 0)

            {
                Console.WriteLine("Вы ввели четное число");
            }

            else

            {
                Console.WriteLine("Вы ввели нечетное число");
            }






           
        }
    }
}
