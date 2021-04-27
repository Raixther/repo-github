using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Level_1.Lesson_3
{
    class MainClass
    {
        //static void Main(string[] args)
        //{

            //int[] mass = { 1, 2, 3 };

            //int[,] mass2 = new int[3, 5];

            //string[,] massStr = new string[3, 5];

            //int[,,] mass3 = new int[3, 5, 2];

            //int[][] a = new int[2][];
            //a[0] = new int[5];
            //a[1] = new int[7];

            //mass2[2, 3] = 10;




            //for (;;)
            //{
            //    Console.WriteLine(0);
            //}


            //int[] mass = { 1, 2, 3 };
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.WriteLine(mass[i]);
            //}




            //int[][] arr = new int[2][];

            //arr[0] = new int[3];
            //arr[1] = new int[5];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Element({0}): ", i);

            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
            //    }
            //    Console.WriteLine();
            //}



            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 4; j >= 0; j--)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(1);
            //        }
            //        else
            //        {
            //            Console.Write(0);
            //        }
            //    }
            //    Console.WriteLine();
            //}




            //int a = 0;

            //while (a < 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}







            //int a = 0;

            //do
            //{
            //    Console.WriteLine("Hello");
            //} while (a > 0);












            //int x;

            //do
            //{
            //    Console.WriteLine("Введите число от 0 до 100");
            //    x = Convert.ToInt32(Console.ReadLine());
            //} while (x < 0 || x > 100);

            //Console.WriteLine("Допустимое значение " + x);


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}





            //for (char i = 'а'; i <= 'я'; i++)
            //{
            //    Console.Write(i + " ");
            //}



            //int[] mass = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //foreach (int item in mass)
            //{
            //    Console.WriteLine(item);
            //}









            //Console.WriteLine(mass);

            //int[][] omass = new int[2][];
            //omass[0] = new int[3];
            //omass[1] = new int[3];

            //omass[0][0] = 1;
            //omass[0][1] = 2;
            //omass[0][2] = 3;

            //omass[1][0] = 4;
            //omass[1][1] = 5;
            //omass[1][2] = 6;

            //int[,,] tmass = new int[10, 5, 6];


            //int[,] dmass = { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < dmass.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dmass.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{dmass[i, j]}");
            //    }
            //}


            //char[] chars = { 'w', 'o', 'r', 'd' };
            //string str1 = new string(chars);

            //Console.WriteLine(str1);

            //byte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45 };
            //string str2 = Encoding.Default.GetString(bytes);
            //Console.WriteLine(str2);





            //int[] arr = { 10, 10, 8, 2, 6 };


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            //int[] arr = { 10, 10, 8, 2, 6 };

            //for (int i = arr.Length - 1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            int tmp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = tmp;
            //        }
            //    }
            //}



            //for (int j = 0; j < arr.Length - 1; j++)
            //{
            //    if (arr[j] > arr[j + 1])
            //    {
            //        int tmp = arr[j];
            //        arr[j] = arr[j + 1];
            //        arr[j + 1] = tmp;
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}



            //int[][] mass = new int[2][];

            //mass[0] = new int[3];
            //mass[1] = new int[5];





            //int[] array = { 10, 4, 2, 4, 4 };

            //int rigth = 0, left = 0;

            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    left += array[i];
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        rigth += array[j];
            //    }

            //    if (left == rigth)
            //    {
            //        Console.WriteLine("Точка баланса есть");
            //        break;
            //    }
            //    rigth = 0;
            //}





            //int[] mass = { 1, 0, 1, 0, 1, 0, 1 };

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = mass[i] == 1 ? 0 : 1;
            //}


            //Console.WriteLine(mass);

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.WriteLine(mass[i]);
            //}


            //string str = "hello";

            //char[] res = str.ToCharArray();

            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);
            //}







            //int[] array = { 1, 2, 3, 4, 5 };

            //int value = 7;

            //bool flag;
            //if (value < 0)
            //{
            //    flag = true;
            //    value = -value;
            //}
            //else
            //{
            //    flag = false;
            //}

            //int lastIndex = array.Length - 1;
            //for (int i = 0; i < value; i++)
            //{
            //    int temp;
            //    if (flag)
            //    {
            //        temp = array[0];
            //    }
            //    else
            //    {
            //        temp = array[lastIndex];
            //    }

            //    for (int j = 0; j < lastIndex; j++)
            //    {
            //        if (flag)
            //        {
            //            array[j] = array[j + 1];
            //        }
            //        else
            //        {
            //            array[lastIndex - j] = array[lastIndex - j - 1];
            //        }
            //    }
            //    if (flag)
            //    {
            //        array[lastIndex] = temp;
            //    }
            //    else
            //    {
            //        array[0] = temp;
            //    }
            //}

        //}
    }
}
