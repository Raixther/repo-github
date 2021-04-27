using System;
using System.Collections.Generic;
using System.Text;


namespace Level_1.Lesson_7
{



    class Cross
    {
      
        static int SIZE_X = 3;
        static int SIZE_Y = 3;

        static char[][] field = new char[3][];





        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                
                    field[i] = new char[3];
                
            }

            for (int i = 0; i < SIZE_Y; i++)
            {
                
                    field[i] = new char[] { '.', '.', '.' };
                
            }
           
        }

        private static void PrintField()
        {
            Console.Clear();
            for (int i = 0; i < SIZE_Y; i++)
            {
                
                    Console.Write(field[i]);
                
                Console.WriteLine();
            }
       
        }

        private static void SetSym(int x, int y, char sym)
        {
            field[x][y] = sym;
        }

        private static bool IsCellValid(int x, int y)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[x][y] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i][j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void playerMove()
        {
            int x, y;
            do
            {
              
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } 
            while (!IsCellValid(x, y));
            SetSym(x, y, PLAYER_DOT);
          
        }


        private static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(x, y));
            SetSym(x, y, AI_DOT);

           
         
        }



        static void Main(string[] args)
        {
            InitField();
            PrintField();
            do
            {
                playerMove();
                Console.WriteLine("Ваш ход на поле");
                PrintField();
                if (CheckWin( field, PLAYER_DOT))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
                AiMove();
                Console.WriteLine("Ход Компа на поле");
                PrintField();
                if (CheckWin(field, AI_DOT))
                {
                    Console.WriteLine("Выиграл Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }














        private static bool CheckHorizontal(char[][] field, char sym)
        {
            int count = 0;

            for (int i = 0;  i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (field[i][j].Equals(sym) && field[i][j] == field[i][j + 1])
                    {

                        count++;
                    }
                }
               

            }
            if (count == 2)
            {

                return true;
            }
            else

            {
                return false;

            }

        }

        private static bool CheckVertical(char[][] field, char sym)
        {
            int count = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (field[i][j].Equals(sym) && field[i + 1][j] == field[i][j])
                    {

                        count++;
                    }
                }
             

            }
            if (count == 2)
            {
                return true;
            }
            else

            {
                return false;

            }

        }


        private static bool CheckDiag(char[][] field, char sym)
        {
            int count = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (field[i][j].Equals(sym) && field[i][j] == field[i + 1][j + 1])
                    {

                        count++;
                    }
                }
                
              

            }
            if (count == 2)
            {
                return true;
            }
            else

            {
                return false;

            }

        }

        private static bool CheckInverseDiag(char[][] field, char sym)
        {
            int count = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 2; j > 0; j--)
                {
                    if (field[i][j].Equals(sym) && field[i][j] == field[i + 1][j - 1])
                    {

                        count++;
                    }
                }
            

            }
            if (count == 2)

                return true;

            else

            {
                return false;

            }

        }



    static  bool CheckWin(char[][] field, char sym)
        {
           if(CheckHorizontal(field, sym))
            {
                return true;
            }
           else if(CheckVertical(field, sym))
            {
                return true;
            }
            else if (CheckDiag(field, sym))
            {
                return true;
            }
            else if (CheckInverseDiag(field, sym))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}

