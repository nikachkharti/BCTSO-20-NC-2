using System.Diagnostics.CodeAnalysis;

namespace MiniBank.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Type Type { get; set; }
    }

    public class CustomerEquilityComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y) => x.Id == y.Id &&
                x.Name.Trim().ToLower() == y.Name.Trim().ToLower() &&
                x.IdentityNumber.Trim() == y.IdentityNumber.Trim() &&
                x.PhoneNumber.Trim() == y.PhoneNumber.Trim() &&
                x.Email.Trim().ToLower() == y.Email.Trim().ToLower() &&
                x.Type == y.Type;

        public int GetHashCode([DisallowNull] Customer obj) => obj.Name.Length;
    }
}
