using System;

using System.Diagnostics;




namespace Lesson6
{

    [Serializable]
    public class MyArraySizeException:Exception
    {
        public MyArraySizeException() { }

        public MyArraySizeException(string message) { }

        public  MyArraySizeException( string message, Exception innerException){ }


    }

    		

    [Serializable]
    public class MyArrayDataException : Exception
    {
        public MyArrayDataException() { }

        public MyArrayDataException(string message) { }

        public MyArrayDataException(string message, Exception innerException) { }


    }


    class Program
    {

        static public int SumArr(string[,] arr)
        {

            int index1 = arr.GetLength(0);

            int index2 = arr.GetLength(1);


            int[] b = new int[16];

            int sum = 0;

            if (index1 == 4 && index2 == 4)
            {
               
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                      
                        b[i] = Convert.ToInt32(arr[i,j]);
                       
                    }
                }

                for (int i = 0; i < b.Length; i++)
                {
                    
                    sum += b[i];
                }
                return sum;
            }
            else
            {
                throw new MyArraySizeException();
            }
          

        }





        static void Main(string[] args)
        {
            /*
            while (true)
            {

                Console.WriteLine("Введите название процесса для завершения");
                string forRemove = Console.ReadLine();
                foreach (var process in Process.GetProcessesByName(forRemove))
                {
                    process.Kill();
                }
                Program.ShowProcessList();
            }
            */


            Random rand = new Random();

           string[,] arr = new string[4, 4];




            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; i < 4; i++)
                {
                    arr[i, j] = rand.Next(1, 30).ToString();
   
                }
                
            }
       


            try
            {
              Console.WriteLine( Program.SumArr(arr));
            }

            
            

            catch (MyArraySizeException)
                {

                Console.WriteLine("Недопустимая размерность массива");
                }
            








        }

        /*static Process[] ProcessList = Process.GetProcesses();

        static void ShowProcessList()
        {
            for (int i = 0; i < ProcessList.Length; i++)
            {
                Console.WriteLine(ProcessList[i].ToString());
            }
        }

        */





      
	        

   
    }
  

}


