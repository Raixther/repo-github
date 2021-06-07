using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_3_
{
    class Program
    {

        public class TestCase
        {
            public int X { get; set; }

            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void TestFoo(TestCase testCase)
        {
            try
            {
                var actual = CycleFibonanchi(testCase.X);

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
                   
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }

        }



        static int RecursiveFibonanchi(int number)
        {
            if (number < 2)
            {
                return number;
            }
            else
            {
                return RecursiveFibonanchi(number - 1) + RecursiveFibonanchi(number - 2);
            }

        }


        static int CycleFibonanchi(int number)
        {
            int a = 1;

            int b = 1;

          

            for (int i = 1; i < number; i++)
            {
                a += b;
                b = a - b;
            }
            return b;
        }

        static void Main(string[] args)
        {
            TestCase test1 = new TestCase()
            {
                X = 1,

                Expected = 1,

                ExpectedException = null
            };

            TestCase test2 = new TestCase()
            {
                X = 3,

                Expected = 2,

                ExpectedException = null
            };

            TestCase test3 = new TestCase()
            {
                X = 8,

                Expected = 21,

                ExpectedException = null
            };

            TestCase test4 = new TestCase()
            {
                X = 9,

                Expected = 34,

                ExpectedException = null
            };

            TestCase test5 = new TestCase()
            {
                X = 6,

                Expected = 8,

                ExpectedException = null
            };

            TestFoo(test1);
            TestFoo(test2);
            TestFoo(test3);
            TestFoo(test4);
            TestFoo(test5);

            Console.ReadKey();

        }
    }
}
