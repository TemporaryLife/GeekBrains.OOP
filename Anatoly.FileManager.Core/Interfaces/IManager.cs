using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.FileManager.Core.Interfaces
{
    internal interface IManager
    {

        bool Create(string fileName);

        bool Delete(string fileName);

        void ChangeName(string oldName, string newName);

        bool Copy(string fileName, string newPath);

        long GetSize(string fileName, ref long size);
    }
}
