using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        public class TestCase
        {
            public int X { get; set; }

            public bool Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }


        static bool CheckSimplicity(int number)
        {
            int d = 0;

            int i = 2;


            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            if (d == 0)
            {


                return true;
               
              
            }
            else
            {
                return false;
            }
        }
        static void TestCheckSimplicity(TestCase testCase)
        {
            try
            {
                var actual = CheckSimplicity(testCase.X);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }

        }
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 1,
                Expected = true,
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                X = 7,
                Expected = true,
                ExpectedException = null
            };
            var testCase3 = new TestCase()
            {
                X = 17,
                Expected = true,
                ExpectedException = null
            };
            var testCase4 = new TestCase()
            {
                X = 18,
                Expected = false,
                ExpectedException = null
            };
            var testCase5 = new TestCase()
            {
                X = 10,
                Expected = false,
                ExpectedException = null
            };


            TestCheckSimplicity(testCase1);

            TestCheckSimplicity(testCase2);

            TestCheckSimplicity(testCase3);

            TestCheckSimplicity(testCase4);

            TestCheckSimplicity(testCase5);
       
            Console.ReadKey();
        }


    }


}
