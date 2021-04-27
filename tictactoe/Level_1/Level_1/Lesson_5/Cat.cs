using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_5
{
    class Cat
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public static string Type { get; set; }


        //public int age;

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }

        //    set
        //    {
        //        if (value > 0)
        //        {
        //            age = value;
        //        }
        //    }
        //}

        //public Cat()
        //{

        //}

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine($"{Age} {Name} {Type}");
        }
    }
}
