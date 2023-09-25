using CreditasChallenge;

namespace CreditasChallengeTests
{
    public class CustomerTest
    {
        [Theory]
        [InlineData("João", "123.456.789-10", 29, "SP", 9000)]
        [InlineData("Marcos", "123.456.789-10", 22, "SP", 5000)]
        [InlineData("Paula", "123.456.789-10", 16, "RJ", 3000)]

        public void CreateCustomer(string name, string cpf, int age, string location, double income)
        {
            var customer = new Customer(name, cpf, age, location, income);
            Assert.NotNull(customer);
            Assert.Equal(name, customer.Name);
            Assert.Equal(cpf, customer.Cpf);
            Assert.Equal(age, customer.Age);
            Assert.Equal(location, customer.Location);
            Assert.Equal(income, customer.Income, 2);
        }
    }
}