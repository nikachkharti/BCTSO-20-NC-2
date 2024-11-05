using System.Diagnostics.CodeAnalysis;

namespace CustomAlgorithm.Tests
{
    class MoneyEquilityComparer : IEqualityComparer<MoneyReference>
    {
        public bool Equals(MoneyReference x, MoneyReference y)
        {
            return x.Currency.Trim().ToUpper() == y.Currency.Trim().ToUpper() && x.Amount == y.Amount;
        }

        public int GetHashCode([DisallowNull] MoneyReference obj)
        {
            return obj.Id;
        }
    }

    class MoneyReference
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }

    struct MoneyValue
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }

    public class Value_Ref_Tests
    {

        [Fact]
        public void Equal_Test_Function()
        {
            MoneyValue mv1 = new() { Id = 1, Amount = 10, Currency = "GEL" };
            MoneyValue mv2 = new() { Id = 2, Amount = 10, Currency = "GEL" };

            MoneyReference mr1 = new() { Id = 3, Amount = 10, Currency = "GEL" };
            MoneyReference mr2 = new() { Id = 4, Amount = 10, Currency = "GEL" };

            Assert.Equal(mr1, mr2, new MoneyEquilityComparer());
        }
    }
}
