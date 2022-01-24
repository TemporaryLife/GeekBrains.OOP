using System;

namespace Anatoly.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACoder a = new ACoder();
            BCoder b = new BCoder();

            Console.WriteLine(b.Encode("ZzYyXxWw")); //Функционал зашифровки/расшифровки одинаковый.

        }
    }
}
