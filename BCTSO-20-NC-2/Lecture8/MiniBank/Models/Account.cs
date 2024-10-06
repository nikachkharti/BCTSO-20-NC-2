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
            if (balance >= amuont)
            {
                balance -= amuont;
            }
        }

        public void Depoist(decimal amount)
        {
            balance += amount;
        }

        public void Transfer(Account account, decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                account.balance += amount;
            }
        }

        public override string ToString()
        {
            return $"Account {iban} Has Balance {balance} {currency}";
        }

    }
}
