using Lecture8.MiniBank.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace Lecture8.MiniBank.Models
{
    public class Account
    {
        private string iban;
        private string currency;
        private decimal balance;

        public string Iban
        {
            get { return iban; }
            set
            {
                if (value.Trim().Length == 22)
                {
                    iban = value;
                }
            }
        }

        public string Currency
        {
            get { return currency; }
            set
            {
                if (value.Trim().ToUpper().Length == 3)
                {
                    currency = value;
                }
            }
        }


        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }


        public void Withdraw(decimal amuont)
        {
            if (amuont < 0)
            {
                throw new ArgumentException("Negative Number");
            }

            if (balance >= amuont)
            {
                balance -= amuont;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

        public void Depoist(decimal amount)
        {
            balance += amount;
        }

        public void Transfer(Account account, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(account.Iban))
            {
                throw new ArgumentException("Invalid account");
            }

            if (balance >= amount)
            {
                balance -= amount;
                account.balance += amount;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

        public override string ToString()
        {
            return $"Account {iban} Has Balance {balance} {currency}";
        }

    }
}
