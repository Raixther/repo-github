using System;

namespace Lesson3_2_
{
    class Program
    {
        static void Main(string[] args)
        {



            Object[,] arr = new Object[5, 2] { { "Алексей", 421133 }, { "Иван", 317394 }, { "Майкл", 666664 }, { "Анна", 995435 }, { "Ольга", 425385 } };


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr[i, j]);
                    Console.WriteLine();
                }
            }









        }
    }
}
