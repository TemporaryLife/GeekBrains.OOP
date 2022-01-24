using Anatoly.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Interfaces
{
    internal class ACoder : ICoder
    {
        protected const string _alphabet = "abcdefghijklmnopqrstuvwxyz";
        public string Encode(string init_text, int key)
        {
            StringBuilder res = new StringBuilder(100);
            int index;
            char symb_to_add;
            foreach (char symb in init_text)
            {
                index = _alphabet.IndexOf(symb);
                symb_to_add = (index < 0) ? symb : _alphabet[(_alphabet.Length + index + key) % _alphabet.Length];
                res.Append(symb_to_add);
            }
            return res.ToString();
        }

        public string Decode(string init_text, int key) => Encode(init_text, -key);
    }
}
