namespace Lecture8.MiniBank.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient Funds")
        {
        }
    }
}
