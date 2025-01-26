namespace MiniBank.Repository
{
    public class SqlClientOperationRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCTSO20N;Trusted_Connection=true;TrustServerCertificate=true";

        Task Insert(int accountId, decimal amount)
        {
            throw new NotImplementedException();
        }

        Task Withdraw(int accountId, decimal amount)
        {
            throw new NotImplementedException();
        }

        Task Transfer(int sourceAccountId, int destinationAccountId, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
