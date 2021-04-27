using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Level_1.Lesson_4
{
    class Main4
    {
        //static void Main(string[] args)
        //{
            // int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(1);

            //PrtMsg(Console.ReadLine());

            //Console.WriteLine(2);

            // Console.WriteLine(CalcNumbers(2, 3));
           //(string userName, int age, string surname) = AskUser();
           // Console.WriteLine($"{userName}{age}{surname}");


      //  }

        static void PrtMsg(string msg)
        {
            Console.WriteLine($"Hello {msg}");
        }

        static int CalcNumbers(int a, int b)
        {
            return a + b;
        }

        static (string name, int age, string surname) AskUser()
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            string surname = Console.ReadLine();
            return (name, age, surname);
        }
    }
}
