using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace QFM
{
    static public class Browser
    {
        static public void DisplayRoot()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var item in drives)
            {
                if (item.IsReady)
                {
                    Console.WriteLine(item.Name);

                    DirectoryInfo root_dir = item.RootDirectory;

                    string[] ff = Directory.GetDirectories(root_dir.FullName);

                    foreach (var path in ff)
                    {
                        DirectoryInfo sub_dir = new DirectoryInfo(path);

                        Console.WriteLine($"Directory    {sub_dir.Name}\n\n      {Path.GetFullPath(sub_dir.Name)}\n");
                    }

                }
            }
            }
            static public void Display()
            {


              string current_directory_path = Directory.GetCurrentDirectory();

                DirectoryInfo current_directory = new DirectoryInfo(current_directory_path);

                DirectoryInfo[] dir_list = current_directory.GetDirectories();

                foreach (DirectoryInfo item in dir_list)
                {
                    if (item.Exists)
                    {
                        string name = item.Name;

                        Console.WriteLine("Directory " + $"{name}\n{Path.GetFullPath(name)}            ");

                        Console.WriteLine();

                        string temp_directory_path = Directory.GetCurrentDirectory();

                        DirectoryInfo temp_directory = new DirectoryInfo(temp_directory_path);

                        FileInfo[] temp_file_list = temp_directory.GetFiles();


                        foreach (var file in temp_file_list)
                        {
                            string file_name = file.Name;

                            Console.WriteLine($"     {file_name}\n{Path.GetFullPath(file_name)}");

                            Console.WriteLine(file.Length);

                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();
                }

            }
            static public void MoveBack()
            {
                Console.Clear();

                string current_directory_path = Directory.GetCurrentDirectory();

                DirectoryInfo parent = Directory.GetParent(current_directory_path);

                Directory.SetCurrentDirectory(parent.FullName);

                Display();
            }
            static public void Open(string target)
            {
                Directory.SetCurrentDirectory(target);

                Display();
            }
            static public long ShowDirectorySize(string s)
            {
                long size = 0;

                DirectoryInfo target = new DirectoryInfo(s);

                DirectoryInfo[] sub_directories = target.GetDirectories();

                FileInfo[] sub_files = target.GetFiles();

                foreach (FileInfo file in sub_files)
                {
                    if (file.Exists)
                    {
                        size += file.Length;
                    }
                }


                foreach (var dir in sub_directories)
                {
                    if (dir.Exists)
                    {
                        ShowDirectorySize(dir.FullName);
                    }

                }
                return size;
            }
        }


    }




