
using System;
using System.IO;


namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.AddText();

            Program.AddTime();

            Program.AddBinary();


            Employee[] emplArr =
  {
            new Employee("Иванов","Иван", "Иванович","enginer","work@mail.ru", "546326", "32000", 1991),

            new Employee("Петров","Петр", "Петрович","junior developer","work@mail.ru", "505366", "33000", 1986),

            new Employee("Кузнецов"," Алексей", "Александрович","project manager","work@mail.ru", "135826", "40000", 1977),

            new Employee("Сидров","Александр", "Михайлович","senior developer","work@mail.ru", "874526", "52000", 1979),

            new Employee("Веслов","Сергей", "Генадиеич","community manager","work@mail.ru", "474636", "39000", 1985) };




            for (int i = 0; i < emplArr.Length; i++)
            {

                if (emplArr[i].GetAge() > 40)
                {
                    Console.WriteLine(emplArr[i].GetInfo());
                }
            }

        }

      static void AddText()
        {
            string filename = "qqq.txt";

            File.WriteAllText(filename, "testtest");
        }

       static void AddTime()
        {
            string time = DateTime.Now.ToString();

            File.AppendAllText("Startup.txt", time);
        }

      static void AddBinary()
        {
            byte[] numbers = new byte[] { 56, 54, 23, 223, 20, 57 };

            File.WriteAllBytes("binary.txt", numbers);
        }

    }

        class Employee
        {
            public static int CurrentYear = 2021;

            public string surname { get; set;}

            public string name { get; set; }


            public string patronymic { get; set; }


            public string function { get; set; }


            public string email { get; set; }


            public string phonenumber { get; set; }


            public string salary { get; set; }


            public int birthyear { get; set; }



        public Employee(string surname, string name, string patronimic, string function, string email, string phonenumber, string salary, int birthyear)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.function = function;
            this.email = email;
            this.phonenumber = phonenumber;
            this.salary = salary;
        }




        public int GetAge()
            {
                return CurrentYear - birthyear;
            }
    
            public string GetInfo()
            {

            return
            this.surname + " " +
            this.name + " " +
            this.patronymic + " " +
            this.function + " " +
            this.email + " " +
            this.phonenumber + " " +
            this.salary + "rub";


        }            

        }
        
    }


 




















    






