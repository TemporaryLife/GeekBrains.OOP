using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.FileManager.Core.Services
{
    internal static class GlobalCommandsService
    {

        internal static void ShowDirectory()                             //ls
        {
            string[] directories = Directory.GetDirectories(CommonManagerService.CurrentDirectory);
            string[] files = Directory.GetFiles(CommonManagerService.CurrentDirectory);

            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }

            foreach (string file in files)
            {                
                Console.WriteLine(file);                
            }


        }

        internal static void ClearConsole() => Console.Clear();          //clr

        internal static void ChangeDirectory(string nextDirectory)       //cd
        {
            ClearConsole();
            string newDirectory;
            if (nextDirectory == "..")
            {
                newDirectory = Directory.GetParent(CommonManagerService.CurrentDirectory).ToString();
            }
            else
            {
                newDirectory = $@"{FileManagerService.CurrentDirectory}\{nextDirectory}";
            }
            
            try
            {
                Directory.SetCurrentDirectory(newDirectory);
                CommonManagerService.CurrentDirectory = newDirectory;
                
            }

            catch { return; };

        }





    }
}
