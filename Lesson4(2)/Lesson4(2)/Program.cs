using System;

namespace Lesson4_2_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число через пробел");
            

            string input = Console.ReadLine();
              
            
            double[] arr = new double [input.Length];




            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]==' ')
                {
                    continue;

                }
                else
                {
                    arr[i] = Char.GetNumericValue(input[i]);
                }    
            }


            double a = SumString(arr);

            Console.WriteLine(a);




           
        }




       static double SumString( double[] numbers)
        {

            

           double sum = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

          
            return sum;
        }








    }
}
