using Anatoly.FileManager.Core.Executors;
using Anatoly.FileManager.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.FileManager.Core
{
    internal static class Runner
    {


        public static void Run()
        {
            string commandFromConsole, mainCommand;
            List<string> separatedCommand;
            long size;
            while (true)
            {
                size = 0;


                Console.Write($">> {FileManagerService.CurrentDirectory} >>");
                commandFromConsole = Console.ReadLine();
                separatedCommand = commandFromConsole.Split(" ").ToList();      //TODO: Адекватное чтение аргументов. Баг, если в названии файла пробел.
                mainCommand = separatedCommand[0];

                if (mainCommand == "ls") GlobalCommandsService.ShowDirectory();
                else if (mainCommand == "cd") GlobalCommandsService.ChangeDirectory(separatedCommand[1]);
                else if (mainCommand == "clr") GlobalCommandsService.ClearConsole();

                //Directory Commands
                else if (mainCommand == "mkdir") FileExecutor.DirectoryManager.Create(separatedCommand[1]);
                else if (mainCommand == "deldir") FileExecutor.DirectoryManager.Delete(separatedCommand[1]);
                else if (mainCommand == "dirsize") FileExecutor.DirectoryManager.GetSize(separatedCommand[1], ref size);
                else if (mainCommand == "dircn") FileExecutor.DirectoryManager.ChangeName(separatedCommand[1], separatedCommand[2]);
                else if (mainCommand == "copydir") FileExecutor.DirectoryManager.Copy(separatedCommand[1], separatedCommand[2]);

                //File Commands

                else if (mainCommand == "mkfile") FileExecutor.FileManager.Create(separatedCommand[1]);
                else if (mainCommand == "delfile") FileExecutor.FileManager.Delete(separatedCommand[1]);
                else if (mainCommand == "filesize") FileExecutor.FileManager.GetSize(separatedCommand[1], ref size);
                else if (mainCommand == "filecn") FileExecutor.FileManager.ChangeName(separatedCommand[1], separatedCommand[2]);
                else if (mainCommand == "copyfile") FileExecutor.FileManager.Copy(separatedCommand[1], separatedCommand[2]);






            }
        }
    }
}
