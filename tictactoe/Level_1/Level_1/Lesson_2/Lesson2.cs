using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_2
{
    class Lesson2
    {
        //static void Main(string[] args)
        //{
            //int someAnotherValue = 42;
            //{
            //    int scopedValue = 5;
            //    Console.WriteLine($"{someAnotherValue} {scopedValue}");
            //}

            //{
            //    int scopedValue = 2;
            //    Console.WriteLine($"{someAnotherValue} {scopedValue}");
            //}

            //Console.WriteLine($"{someAnotherValue}");
            //Console.WriteLine($"{scopedValue}");






            //int decimalLiteral = 42; // просто число в десятичной форме
            //int hexLiteral = 0x2A; // 0x указывает на шестнадцатеричную форму
            //int binaryLiteral = 0b_0010_1010; // 0b указывает на двоиччную форму. 

            //int test1 = 1000000000;
            //int test2 = 1_000_000_000;





            //DateTime date1 = new DateTime(2015, 8, 10, 5, 5, 50);
            //DateTime date2 = new DateTime(2015, 8, 10);









            //int million = 1_000_000;
            //int oneMillion = 1000000;
            //Console.WriteLine(million); // 1000000
            //Console.WriteLine(oneMillion); // 1000000







            //int x = 10;
            //x = x + 5;
            //x += 5;



            //int a = 5;
            //int b = 3;
            //Console.WriteLine(a % b); // 2
            //Console.WriteLine(a + b); // 8
            //Console.WriteLine(a - b); // 2
            //Console.WriteLine(a * b); // 15
            //Console.WriteLine(a / b); // 1





            //bool adminRules = false;
            //int age = 10;

            //if (adminRules && age > 18)
            //{
            //    Console.WriteLine("полный доступ!");
            //}
            //else if (adminRules)
            //{
            //    Console.WriteLine("ограниченный доступ");
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("права пользователя");
            //}
            //else
            //{
            //    Console.WriteLine("нет доступа!");
            //}

            //bool adminRules = false;
            //int age = 19;
            //string res = age > 18 && adminRules == true ? " больше 18" : " меньше 18";
            //Console.WriteLine(res);



            //bool adminRules = true;
            //int age = 10;
            //string res = null;

            ////if (age > 0 & adminRules == true)
            ////{
            ////    Console.WriteLine("yes1");
            ////}

            //if (age > 0 | res.StartsWith("test"))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}





            //bool backStud = true;
            //bool frontStud = false;
            //bool DBStud = true;
            //bool softStud = true;

            //if (backStud == true && DBStud == true)
            //{
            //    Console.WriteLine("Backend");
            //} 
            //else if (backStud == true && DBStud == true && softStud == true)
            //{
            //    Console.WriteLine("best Backend");
            //}
            //else if (backStud == true && DBStud == true && softStud == true && frontStud == true)
            //{
            //    Console.WriteLine("full stack");
            //}
            //else if (frontStud == true)
            //{
            //    Console.WriteLine("frontend");
            //}






            //int knowledges = 0b011111; // знания студента

            //// Маски профессий:
            //int backenderMask = 0b010111;
            //int frontenderMask = 0b011010;
            //int designerMask = 0b110000;

            //// Те навыки из каждой профессии, которые присутствуют у студента:
            //int backenderKnowledges = knowledges & backenderMask;
            //int frontenderKnowledges = knowledges & frontenderMask;
            //int designerKnowledges = knowledges & designerMask;

            //// Если навыки полностью совпали с маской, мы получим True, иначе False
            //Console.WriteLine(backenderKnowledges == backenderMask);
            //Console.WriteLine(frontenderKnowledges == frontenderMask);
            //Console.WriteLine(designerKnowledges == designerMask);






            //int res = 10;

            //if (res != 0)
            //{

            //} 

            //int daysOfWeek = 100;

            //string dayTitle = "";

            //switch (daysOfWeek)
            //{
            //    case 0:
            //        dayTitle = "Понедельник";
            //        break;
            //    case 1:
            //        dayTitle = "ВТорник";
            //        break;
            //    case 2:
            //        dayTitle = "Среда";
            //        break;
            //    case 3:
            //        dayTitle = "Четверг";
            //        break;
            //    default:
            //        Console.WriteLine("Выходные!");
            //        break;

            //}

            // Console.WriteLine(dayTitle);















            //            [Flags]
            //public enum Knowledges
            //{
            //    // Для читаемости разряды можно разделять знаком подчёркивания, они никак не влияют на значение
            //    Database = 0b_000001,
            //    Algorithms = 0b_000010,
            //    CSharp = 0b_000100,
            //    JavaScript = 0b_001000,
            //    Git = 0b_010000,
            //    Design = 0b_100000,
            //}

            //static void Main(string[] args)
            //{
            //    // Маски профессий
            //    Knowledges backendRequirements = Knowledges.Database | Knowledges.Algorithms | Knowledges.CSharp | Knowledges.Git;
            //    Knowledges frontendRequirements = Knowledges.Algorithms | Knowledges.JavaScript | Knowledges.Git;
            //    Knowledges designRequirements = Knowledges.Git | Knowledges.Design;

            //    //Знания студента в числовой записи
            //    Knowledges allKnowledges = (Knowledges)0b011111;

            //    // Те навыки из каждой профессии, которые присутствуют у студента:
            //    Knowledges backenderKnowledges = allKnowledges & backendRequirements;
            //    Knowledges frontenderKnowledges = allKnowledges & frontendRequirements;
            //    Knowledges designerKnowledges = allKnowledges & designRequirements;

            //    bool isBackender = backenderKnowledges == backendRequirements;
            //    bool isFrontender = frontenderKnowledges == frontendRequirements;
            //    bool isDesigner = designerKnowledges == designRequirements;

            //    Console.WriteLine($"Знания студента: {allKnowledges}");

            //    if (isBackender)
            //    {
            //        Console.WriteLine("Студент может стать backend-разработчиком");
            //    }

            //    if (isFrontender)
            //    {
            //        Console.WriteLine("Студент может стать frontend-разработчиком");
            //    }

            //    if (isDesigner)
            //    {
            //        Console.WriteLine("Студент может стать дизайнером");
            //    }
            //}


            // Маски профессий
            //Knowledges backendRequirements = Knowledges.Database | Knowledges.Algorithms | Knowledges.CSharp | Knowledges.Git;
            //Knowledges frontendRequirements = Knowledges.Algorithms | Knowledges.JavaScript | Knowledges.Git;
            //Knowledges designRequirements = Knowledges.Git | Knowledges.Design;

            ////Знания студента в числовой записи
            //Knowledges allKnowledges = (Knowledges)0b011111;

            //// Те навыки из каждой профессии, которые присутствуют у студента:
            //Knowledges backenderKnowledges = allKnowledges & backendRequirements;
            //Knowledges frontenderKnowledges = allKnowledges & frontendRequirements;
            //Knowledges designerKnowledges = allKnowledges & designRequirements;

            //bool isBackender = backenderKnowledges == backendRequirements;
            //bool isFrontender = frontenderKnowledges == frontendRequirements;
            //bool isDesigner = designerKnowledges == designRequirements;

            //Console.WriteLine($"Знания студента: {allKnowledges}");

            //if (isBackender)
            //{
            //    Console.WriteLine("Студент может стать backend-разработчиком");
            //}

            //if (isFrontender)
            //{
            //    Console.WriteLine("Студент может стать frontend-разработчиком");
            //}

            //if (isDesigner)
            //{
            //    Console.WriteLine("Студент может стать дизайнером");
            //}



            //byte b = 10;
            //short s = b;

            //short s = 10000;
            //byte b = (byte)s;

            //Console.WriteLine(b);

            // string s = "12345";
            //int i = (int)s;

            //int i1 = Convert.ToInt32(s);

            // Console.WriteLine(2 + ( 2 + "hello" + 2 ) + 2);

            // string str = null;


            //int age = 17;

            //if (age < 18)
            //{
            //    Console.WriteLine("Вам еще рановато!");
            //    return;
            //}

            //Console.WriteLine("Какие сигареты Вы любите?");
            //Console.WriteLine("Бросай курить!");


       // }
    }


    [Flags]
    public enum Knowledges
    {
        // Для читаемости разряды можно разделять знаком подчёркивания, они никак не влияют на значение
        Database = 0b_000001,
        Algorithms = 0b_000010,
        CSharp = 0b_000100,
        JavaScript = 0b_001000,
        Git = 0b_010000,
        Design = 0b_100000,
    }

    enum Season
    {
        Spring = 10,
        Summer = 20,
        Autumn = 30,
        Winter = 40,
    }
}
