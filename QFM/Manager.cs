using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
namespace QFM
{
    static public class Manager
    {
        static public void FileCopy(string source_file_path, string target_path)
        {
            FileInfo file = new FileInfo(source_file_path);

            string target = Path.Combine(target_path, "Копия " + file.Name);

            file.CopyTo(target);
        }
        static public void DirectoryCopy(string source_path, string target_path)
        {

            DirectoryInfo dir = new DirectoryInfo(source_path);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException();
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            DirectoryInfo copy_root = Directory.CreateDirectory(Path.Combine(target_path, "Копия " + dir.Name));

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(copy_root.FullName, file.Name);
                file.CopyTo(tempPath, false);
            }


            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(copy_root.FullName, subdir.Name);
                FileSystem.CopyDirectory(subdir.FullName, tempPath);
            }
        }
           
        static public void DeleteFile(string target_path)
        {
            FileInfo file = new FileInfo(target_path);

            FileSystem.DeleteFile(file.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }
        static public void DeleteDirectory(string target_path)
        {
            DirectoryInfo directory = new DirectoryInfo(target_path);

            FileSystem.DeleteDirectory(directory.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }     
    }
}

