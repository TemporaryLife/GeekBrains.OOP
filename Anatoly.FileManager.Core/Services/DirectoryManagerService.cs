using Anatoly.FileManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Anatoly.FileManager.Core.Services
{
    internal sealed class DirectoryManagerService : CommonManagerService, IManager
    {
        
        public void ChangeName(string oldName, string newName)
        {

            if (Directory.Exists($@"{_currentDirectory}\\{newName}") || !Directory.Exists($@"{_currentDirectory}\\{oldName}"))
            {
                return;
            }
            FileSystem.RenameDirectory($@"{_currentDirectory}\\{oldName}", newName);
        }

        public bool Copy(string fileName, string newPath)
        {

            if (Directory.Exists(newPath) || !Directory.Exists($@"{_currentDirectory}\\{fileName}"))
            {
                return false;
            }

            FileSystem.CopyDirectory($@"{_currentDirectory}\\{fileName}", newPath);
            return true;
        }

        public bool Create(string fileName)
        {

            if (Directory.Exists(fileName))
            {
                return false;
            }
            Directory.CreateDirectory(fileName);
            return true;

        }

        public bool Delete(string fileName)
        {
            if (!Directory.Exists(fileName))
            {
                return false;
            }
            Directory.Delete(fileName, true);
            return true;
        }

        public long GetSize(string fileName, ref long size)
        {
            if (!Directory.Exists(fileName))
            {
                return -1;
            }
            DirectoryInfo DirArr = new DirectoryInfo(fileName);
            DirectoryInfo[] AllDirs = DirArr.GetDirectories();
            FileInfo[] FileArr = DirArr.GetFiles();
            foreach (FileInfo f in FileArr)
            {
                size = size + f.Length;
            }

            foreach (var d in AllDirs)
            {
                GetSize(d.FullName, ref size);
            }
            Console.WriteLine($"{size} байт");

            return size;
        }
    }
}
