using System;

namespace Anatoly.Finanse
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            BankAccount Sender = new BankAccount(500, AccountTypes.Payment);
            BankAccount Receiver = new BankAccount(0, AccountTypes.Payment);
            Console.WriteLine(Sender.AccountBalance);
            Console.WriteLine(Receiver.AccountBalance);
            Sender.SendMoney(Receiver, 500);
            Console.WriteLine(Sender.AccountBalance);
            Console.WriteLine(Receiver.AccountBalance);*/

            Staff.AllocateMail(@"D:\Documents\Desktop\test.txt", @"D:\Documents\Desktop\new.txt");
        }
    }
}
