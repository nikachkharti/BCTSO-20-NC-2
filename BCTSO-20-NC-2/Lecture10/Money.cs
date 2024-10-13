namespace Lecture10
{
    public class Money
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }

        public Money(decimal amount, string currency)
        {
            Currency = currency;
            Amount = amount;
        }

        public static Money operator +(Money first, Money second)
        {
            //if (first.Currency.Length == 3 && second.Currency.Length == 3 && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
            //{
            //    return new Money(amount: first.Amount + second.Amount, currency: first.Currency);
            //}
            //return null;

            //ტერნარული ოპერატორი   ?  :

            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(amount: first.Amount + second.Amount, currency: first.Currency)
                : null;
        }
        public static Money operator -(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(amount: first.Amount - second.Amount, currency: first.Currency)
                : null;
        }
        public static Money operator *(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(amount: first.Amount * second.Amount, currency: first.Currency)
                : null;
        }
        public static Money operator /(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(amount: first.Amount / second.Amount, currency: first.Currency)
                : null;
        }

        public static bool operator >(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount > second.Amount
                : false;
        }
        public static bool operator <(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount < second.Amount
                : false;
        }
        public static bool operator <=(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount <= second.Amount
                : false;
        }
        public static bool operator >=(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount >= second.Amount
                : false;
        }
        public static bool operator ==(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount == second.Amount
                : false;
        }
        public static bool operator !=(Money first, Money second)
        {
            return (first.Currency.Length == 3
                && second.Currency.Length == 3
                && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount != second.Amount
                : false;
        }

        public static Money operator ++(Money first)
        {
            //return new Money(amount: first.Amount += 1, currency: first.Currency);
            first.Amount += 1;
            return first;
        }
        public static Money operator --(Money first)
        {
            //return new Money(amount: first.Amount -= 1, currency: first.Currency);
            first.Amount -= 1;
            return first;
        }


        public override string ToString() => $"{Amount} {Currency}";
        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
    }
}
