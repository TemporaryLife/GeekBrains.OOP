using Anatoly.FileManager.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.FileManager.Core.Executors
{
    internal static class FileExecutor
    {
        public static FileManagerService FileManager { get; private set; }
        public static DirectoryManagerService DirectoryManager { get; private set; }

        static FileExecutor()
        {
            FileManager = new FileManagerService();
            DirectoryManager = new DirectoryManagerService();
        }

        

    }
}
