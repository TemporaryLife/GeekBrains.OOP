using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Interfaces.Interfaces
{
    internal interface ICoder
    {
        string Encode(string init_text, int key);
        string Decode(string init_text, int key);
    }
}
