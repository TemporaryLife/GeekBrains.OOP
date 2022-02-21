using Anatoly.FileManager.Core.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.FileManager.Core.Services
{
    internal sealed class FileManagerService : CommonManagerService, IManager
    {
        

        public void ChangeName(string oldName, string newName)
        {

            if (!File.Exists($@"{_currentDirectory}\\{oldName}") || File.Exists($@"{_currentDirectory}\\{newName}"))
            {
                return;
            }
            FileSystem.RenameFile(oldName, newName);
        }

        public bool Copy(string fileName, string newPath)
        {

            if (!File.Exists($@"{_currentDirectory}\\{fileName}") || File.Exists(newPath))
            {
                return false;
            }
            
            File.Copy($@"{_currentDirectory}\\{fileName}", newPath);
            return true;
        }

        public bool Create(string fileName)
        {
            if (File.Exists(@$"{_currentDirectory}\\{fileName}"))
            {
                return false;
            }


            StreamWriter sw = new StreamWriter(fileName);
            sw.Close();
            return true;
        }

        public bool Delete(string fileName)
        {

            if (!File.Exists(@$"{_currentDirectory}\\{fileName}"))
            {
                return false;
            }

            File.Delete($@"{fileName}");
            return true;
        }

        public long GetSize(string fileName, ref long size)
        {

            if (!File.Exists(@$"{_currentDirectory}\\{fileName}"))
            {   
                return -1;
            }
            size = new FileInfo(@$"{_currentDirectory}\\{fileName}").Length;
            Console.WriteLine($"{size} байт");
            return size;
        }
    }
}
