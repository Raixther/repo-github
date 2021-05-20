using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;



namespace QFM
{
    class Program
    {
        static void Main(string[] args)
        {
              Browser.DisplayRoot();
            
            while (true)
            {
                Console.WriteLine("Введите комманду");

                string input = Console.ReadLine();

                Command command = new Command(input);

                try
                {
                    command.Exec();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Недопустимый аргумент");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Директория не найдена");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файл не найден");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Ошибка ввода-вывода");
                }
                catch(NotSupportedException)
                {
                    Console.WriteLine("Метод не поддерживается");
                }
                catch(PathTooLongException)
                {
                    Console.WriteLine("Long");
                }

                catch(EndOfStreamException)
                {
                    Console.WriteLine("EndofStream");
                }
                catch (Exception)
                {
                    Console.WriteLine("Мы не знаем,что пошло не так");
                }         
            }
        }
    }
}


