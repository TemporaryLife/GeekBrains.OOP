using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.FileManager.Core.Services
{
    internal abstract class CommonManagerService
    {
        protected static string _currentDirectory;

        public static string CurrentDirectory
        {
            get => _currentDirectory;
            internal set => _currentDirectory = value;
        }

        static CommonManagerService()
        {
            _currentDirectory = Directory.GetCurrentDirectory();
        }


        
    }
}
