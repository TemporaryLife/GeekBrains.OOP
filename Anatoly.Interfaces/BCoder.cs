using Anatoly.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Interfaces
{
    internal sealed class BCoder : ACoder, ICoder
    {
        public new string Decode(string init_text, int key) => Encode(init_text, key);

        public new string Encode(string init_text, int key = 1)
        {

            bool isHigh;
            StringBuilder res = new StringBuilder(100);
            int index;
            char symb_to_add;
            foreach (char symb in init_text)
            {
                isHigh = (symb == Char.ToUpper(symb)) ? true : false;
                index = _alphabet.IndexOf(Char.ToLower(symb));
                symb_to_add = (index < 0) ? symb : _alphabet[(_alphabet.Length - 1 - index)];
                symb_to_add = (isHigh) ? Char.ToUpper(symb_to_add) : symb_to_add;
                res.Append(symb_to_add);
            }
            return res.ToString();
        }
    }
}
