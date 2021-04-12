using System;

namespace Lesson4_3_
{
    class Program
    {

        enum Seasons: byte
        {
            Winter,
            Sping,
            Summer,
            Autumn,

            Incor

        }








        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер месяца");

            byte MounthNumber = Convert.ToByte(Console.ReadLine());

            Enum S = GetSeason(MounthNumber);

            string SeasonMessage = PrintSeason(S);


            Console.WriteLine(SeasonMessage);



        }

  

        static Enum GetSeason(byte a)
        {

            switch (a)
            {
                case 1:
                case 2:
                case 12:
                    return Seasons.Winter;


                case 3:
                case 4:
                case 5:
                    return Seasons.Sping;


                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;


                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;

                default:
                    return Seasons.Incor;
            }
         }

        static string PrintSeason(Enum s)
        {
            switch (s)
            {
                case Seasons.Winter:

                    return "Зима";

                case Seasons.Sping:

                    return "Весна";

                case Seasons.Summer:

                    return "Лето";

                case Seasons.Autumn:

                    return "Осень";

                case Seasons.Incor:
                default:
                    return "Ошибка: введите число от 1 до 12";
            }

        }

    }
        

    

    }
    
    

