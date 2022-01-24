using System;

namespace Anatoly.Finanse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount Sender = new BankAccount(500, AccountTypes.Payment);
            Console.Write(Sender.GetHashCode());

        }
    }
}
