using MiniBank.Models;
using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Customer_Csv_Repository_Should
    {
        private readonly string _testFilePath = @"../../../Data/Customers.csv";

        [Fact]
        public void Get_All_Customers()
        {
            var customerRepository = new CustomerCsvRepository(_testFilePath);
            var expected = 2;

            //Act
            var actual = customerRepository.GetCustomers();

            //Assert
            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void Get_Empty_List_If_Data_File_Do_Not_Exists()
        {
            //Arrange
            var repository = new CustomerCsvRepository(string.Empty);

            //Act
            var customers = repository.GetCustomers();

            //Assert
            Assert.Empty(customers);
        }

        [Fact]
        public void Get_Single_Customer()
        {
            //Arrange
            var customerRepository = new CustomerCsvRepository(_testFilePath);
            var expected = new Customer()
            {
                Id = 1,
                Name = "Iakob Qobalia",
                IdentityNumber = "31024852345",
                PhoneNumber = "555337681",
                Email = "Iakob.Qobalia@gmail.com",
                Type = Models.CustomerType.Phyisical
            };

            //Act
            var actual = customerRepository.GetCustomer(1);

            //Assert
            Assert.Equal(expected, actual, new CustomerEquilityComparer());
        }


        [Fact]
        public void Add_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var expected = 3;
            var newCustomer = new Customer()
            {
                Id = 0,
                Name = "Nikoloz Chkhartishvili",
                IdentityNumber = "01024087459",
                Email = "nika@gmail.com",
                PhoneNumber = "555337681",
                Type = Models.CustomerType.Phyisical
            };

            //Act
            repository.Create(newCustomer);
            var actual = repository.GetCustomers().Count;

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Update_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var updatedCustomer = new Customer()
            {
                Id = 3,
                Name = "Zaal Chkhartishvili",
                IdentityNumber = "01024087459",
                Email = "Zaal.Chkhartishvili@gmail.com",
                PhoneNumber = "555337681",
                Type = Models.CustomerType.Phyisical
            };

            //Act
            repository.Update(updatedCustomer);

            //Assert
            var actual = repository.GetCustomer(3);
            Assert.Equal(updatedCustomer, actual, new CustomerEquilityComparer());
        }

        [Fact]
        public void Delete_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var customerIdToDelete = 3;
            var expected = 2;

            //Act
            repository.Delete(customerIdToDelete);

            //Assert
            var actual = repository.GetCustomers().Count;
            Assert.Equal(expected, actual);
        }
    }
}
