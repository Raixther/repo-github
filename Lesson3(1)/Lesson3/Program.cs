using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {






            int[,] arr = new int[3,3] { { 1, 3, 2 }, { 4, 6, 2 }, { 2, 9, 0 } };


        


           for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(arr[i,j]);
                    }
                }
            }  
            
            
           








            
        }
    }
}
