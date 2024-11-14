using MiniBank.Models;
using System.Text.Json;

namespace MiniBank.Repository
{
    public class AccountJsonRepository
    {
        private readonly string _filePath;
        private List<Account> _accounts;

        public AccountJsonRepository(string filePath)
        {
            _filePath = filePath;
            _accounts = LoadData();
        }

        public List<Account> GetAccounts() => _accounts;
        public List<Account> GetAccountsOfCustomer(int customerId) => _accounts.Where(x => x.CustomerId == customerId).ToList();
        public Account GetAccount(int id) => _accounts.FirstOrDefault(x => x.Id == id);

        public void Create(Account account)
        {
            account.Id = _accounts.Any() ? _accounts.Max(a => a.Id) + 1 : 1;
            _accounts.Add(account);
            SaveData();
        }

        public void Update(Account account)
        {
            var index = _accounts.FindIndex(a => a.Id == account.Id);
            if (index >= 0)
            {
                _accounts[index] = account;
                SaveData();
            }
        }

        public void Delete(int id)
        {
            var account = _accounts.FirstOrDefault(a => a.Id == id);
            if (account != null)
            {
                _accounts.Remove(account);
                SaveData();
            }
        }

        public void SaveData()
        {
            var json = JsonSerializer.Serialize(_accounts, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        private List<Account> LoadData()
        {
            if (!File.Exists(_filePath))
                return new List<Account>();

            return JsonSerializer.Deserialize<List<Account>>(File.ReadAllText(_filePath));
        }
    }
}
