using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            
               string GetFullName(string firstName, string lastName, string patronymic)
            {
                

                return firstName + " " + lastName + " " + patronymic;
            }




            for (int i = 0; i < 4; i++)
            {

                Console.WriteLine("Введите имя");

                string firstName = Console.ReadLine();


                Console.WriteLine("Введите фамилию");


                string lastName = Console.ReadLine();


                Console.WriteLine("Введите отчество");

                string patronymic = Console.ReadLine();



                Console.WriteLine(GetFullName(firstName, lastName, patronymic));



            }


        }

        
    }
}
