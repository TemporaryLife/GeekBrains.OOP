using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Finanse
{

    internal sealed class BankAccount
    {
        private decimal _accountBalance;
        private AccountTypes _accountType;
        private int _accountNumber;
        private static int accountID;

        public decimal AccountBalance
        {
            get => _accountBalance;
            set => _accountBalance = value;
        }

        public int AccountNumber
        {
            get => _accountNumber;
        }

        public AccountTypes AccountType
        {
            get => _accountType;
            set => _accountType = value;
        }


        public BankAccount() : this(0, AccountTypes.Payment)
        {
        }

        public BankAccount(decimal accountBalance) : this(accountBalance, AccountTypes.Payment)
        {
        }

        public BankAccount(AccountTypes accountTypeNumber) : this(0, accountTypeNumber)
        {
        }

        public BankAccount(decimal accountBalance, AccountTypes accountTypeNumber)
        {
            _accountBalance = accountBalance;
            _accountType = (AccountTypes)accountTypeNumber;
            BankAccount.GenerateID();
            _accountNumber = accountID;

        }

        public void TakeMoney(decimal Amount)
        {
            if (AccountBalance - Amount >= 0)
            {
                AccountBalance -= Amount;
            }
        }

        public void PutMoney(decimal Amount) => AccountBalance += Amount;

        public void SendMoney(BankAccount Receiver, decimal Amount)
        {
            if (AccountBalance >= Amount)
            {
                AccountBalance -= Amount;
                Receiver.AccountBalance += Amount;
                return;
            }
            Console.WriteLine("Недостаточно денег на счету отправителя");
        }


        public static bool operator ==(BankAccount firstAccount, BankAccount secondAccount)
        {
            return firstAccount.AccountBalance == secondAccount.AccountBalance;
        }

        public static bool operator !=(BankAccount firstAccount, BankAccount secondAccount)
        {
            return firstAccount._accountBalance != secondAccount._accountBalance;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            else
            {
                BankAccount account = (BankAccount)obj;
                return (_accountBalance==account._accountBalance) && (_accountType==account._accountType) && (_accountNumber==account._accountNumber);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode()*accountID;
        }

        public override string ToString()
        {
            return
                (
                $"Account ID: {accountID}\nAccount Type: {_accountType}\nAccountNumber: {_accountNumber}\nAccount balance: {_accountBalance}"
                );
        }
        private static void GenerateID() => accountID++;
    }
}
