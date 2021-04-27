using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_3
{
    class OneMet
    {
        //static void Main(string[] args)
        //{
        //    (string name, int age)[] users;
        //    Console.WriteLine("Введите количество пользователей:");
        //    int count = Convert.ToInt32(Console.ReadLine());
        //    users = new (string name, int age)[count];

        //    for (int i = 0; i < users.Length; i++)
        //    {
        //        Console.Write("Введите имя пользователя: ");
        //        string userName = Console.ReadLine();
        //        Console.Write("Введите возраст пользователя: ");
        //        int userAge = Convert.ToInt32(Console.ReadLine());
        //        users[i] = (userName, userAge);
        //        Console.WriteLine($"Пользователь {userName} ({userAge}) сохранен");
        //    }

        //    Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
        //    Console.ReadKey();
        //    Console.Clear();
        //    int choice;
        //    do
        //    {
        //        Console.WriteLine("0 - Завершение работы");
        //        Console.WriteLine("1 - Просмотр всей базы данных");
        //        Console.WriteLine("2 - Просмотр пользователя");
        //        choice = Convert.ToInt32(Console.ReadLine());
        //        if (choice == 1)
        //        {
        //            Console.WriteLine("Вывод базы данных:");
        //            for (int i = 0; i < users.Length; i++)
        //            {
        //                Console.WriteLine($"{users[i].name} ({users[i].age})");
        //            }
        //        }
        //        if (choice == 2)
        //        {

        //            int userIndex;
        //            do
        //            {
        //                Console.WriteLine($"Введите идентификатор пользователя - от 0 до {users.Length - 1}");
        //                userIndex = Convert.ToInt32(Console.ReadLine());
        //            } while (userIndex < 0 || userIndex >= users.Length);

        //            Console.WriteLine($"{users[userIndex].name} ({users[userIndex].age})");
        //        }
        //    } while (choice != 0);
        //}









        //static void Main()
        //{
        //    (string name, int age)[] users = CreateUsers();
        //    ShowMenu(users);
        //}

        //static (string name, int age)[] CreateUsers()
        //{
        //    Console.WriteLine("Введите количество пользователей:");
        //    int count = ReadInt();
        //    (string name, int age)[] users = new (string name, int age)[count];
        //    for (int i = 0; i < users.Length; i++)
        //    {
        //        users[i] = CreateUser();
        //        Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
        //    }

        //    Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
        //    Console.ReadKey();
        //    Console.Clear();

        //    return users;
        //}

        //static void ShowMenu((string name, int age)[] users)
        //{
        //    int choice;
        //    do
        //    {
        //        choice = GetUserChoice();
        //        switch (choice)
        //        {
        //            case 0: return;
        //            case 1:
        //                PrintUsers(users);
        //                break;
        //            case 2:
        //                PrintSelectedUser(users);
        //                break;
        //            default:
        //                break;
        //        }
        //    } while (choice != 0);
        //}

        //static (string userName, int userAge) CreateUser()
        //{
        //    Console.Write("Введите имя пользователя: ");
        //    string userName = Console.ReadLine();
        //    Console.Write("Введите возраст пользователя: ");
        //    int userAge = ReadInt();
        //    return (userName, userAge);
        //}
        //static int GetUserChoice()
        //{
        //    Console.WriteLine("0 - Завершение работы");
        //    Console.WriteLine("1 - Просмотр всей базы данных");
        //    Console.WriteLine("2 - Просмотр пользователя");
        //    return ReadInt();
        //}

        //static void PrintSelectedUser((string name, int age)[] users)
        //{
        //    int userIndex;
        //    do
        //    {
        //        Console.WriteLine($"Введите идентификатор пользователя - от 0 до {users.Length - 1}");
        //        userIndex = ReadInt();
        //    } while (userIndex < 0 || userIndex >= users.Length);

        //    PrintUser(users[userIndex]);
        //}

        //static void PrintUsers((string name, int age)[] users)
        //{
        //    Console.WriteLine("Вывод базы данных:");
        //    for (int i = 0; i < users.Length; i++)
        //    {
        //        PrintUser(users[i]);
        //    }
        //}

        //static void PrintUser((string name, int age) user)
        //{
        //    Console.WriteLine(FormatUserData(user));
        //}

        //static string FormatUserData((string name, int age) user)
        //{
        //    return $"{user.name} ({user.age})";
        //}
        //static int ReadInt()
        //{
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        static void IncInt(ref int a)
        {
            a++;
        }

        static ref int GetMin(int[] data)
        {
            ref int minValue = ref data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < minValue)
                {
                    minValue = ref data[i];
                }
            }
            return ref minValue;
        }



        //static void Main(string[] args)
        //{

        //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //ref int min = ref GetMin(num);
        //Console.WriteLine(min);
        //min = -1 * min;

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);
        //}

        //int a = 10;
        //IncInt(ref a);
        //Console.WriteLine(a);

        //int a = 2;
        //byte b = 0b10;
        //double c = 2.0;

        //Console.WriteLine(a == b);
        //Console.WriteLine(a == c);
        //Console.WriteLine(b == c);


        //int[] a = { 1, 2, 3 };
        //int[] b = { 1, 2, 3 };

        //int[] linkToA = a;

        //Console.WriteLine(a == linkToA);
        //Console.WriteLine(a == b);
        //Console.WriteLine(b == linkToA);


        //string first = "123";
        //string second = "123";
        //string third = "1" + "2" + "3";

        //Console.WriteLine(first == second);
        //Console.WriteLine(first == third);
        //Console.WriteLine(second == third);

        //string[] array = { "One", "Two", "Three" };
        //string[] replacedByRef = ReplaceArrayByRef(ref array);
        //string[] replaced = ReplaceArray(array);

        //Console.WriteLine("array: ");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write($"{array[i]} ");
        //}
        //Console.WriteLine();

        //Console.WriteLine("replaced: ");
        //for (int i = 0; i < replaced.Length; i++)
        //{
        //    Console.Write($"{replaced[i]} ");
        //}
        //Console.WriteLine();

        //Console.WriteLine("replacedByRef: ");
        //for (int i = 0; i < replacedByRef.Length; i++)
        //{
        //    Console.Write($"{replacedByRef[i]} ");
        //}
        //Console.WriteLine();
        //}

        //static string[] ReplaceArray(string[] data)
        //{
        //    data = new[] { "replaced", "replaced", "replaced" };
        //    return data;
        //}

        //static string[] ReplaceArrayByRef(ref string[] data)
        //{
        //    data = new[] { "ref", "ref", "ref" };
        //    return data;
        //}



        //static void Main(string[] args)
        //{
        //    //string login = Console.ReadLine();
        //    //if (Authorize(login, out string error))
        //    //{
        //    //    Console.WriteLine("Вы успешно авторизованы");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine(error);
        //    //}


        //    // Calc(1,2,3,4,5,6,7,8);

        //   // Console.WriteLine(GetFactorial(3));
            
        //}


        //static void Calc(int a, int b)
        //{
        //    int res = a + b;
        //    Console.WriteLine($"res: {res}");
        //}

        //static void Calc(int a, int b, int c)
        //{
        //    int res = a + b + c;
        //    Console.WriteLine($"res: {res}");
        //}

        //static void Calc(int a, int b, int c, int z)
        //{
        //    int res = a + b + c;
        //    Console.WriteLine($"res: {res}");
        //}

        //static void Calc(int a, int b, int c, int z, int y)
        //{
        //    int res = a + b + c;
        //    Console.WriteLine($"res: {res}");
        //}

        static void Calc(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            Console.WriteLine(sum);
        }


        static bool Authorize(string login, out string error)
        {
            if (login != "admin")
            {
                error = "Доступ разрешен только администратору";
                return false;
            }

            error = "";
            return true;
        }










        static int GetFactorial(int number)
        {
            if (number == 1)
            {
                return number;
            }
            return number * GetFactorial(number - 1);
        }


        static void testMsg1(out string s)
        {

            s = "Hello";
            Console.WriteLine($"{s}");
        }

        static void testInt(out int a)
        {
            a = 10;
            a++;
        }

        static void testString(string s)
        {
            s += "1";
        }

        static void testArray(int[] a)
        {
            a[1] = 600;
        }

        static (string user, int res) calcNumbers(string user, int a, int b)
        {
            int res = a + b;
            return (user, res);
        }

        static void info(string msg)
        {
            if (msg == "user")
            {
                return;
            }
            Console.WriteLine($"msg: {msg}");
        }

        static void checkName(string user, int age)
        {
            if (user == "user1" && age > 10)
            {
                Console.WriteLine("сигареты покупать рано");
            }
            else if (user == "user2" && age > 20)
            {
                Console.WriteLine("сигареты покупать можно");
            }

        }


    }
}
