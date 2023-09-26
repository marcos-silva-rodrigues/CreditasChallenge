using CreditasChallenge;
using CreditasChallenge.Domain;
using Xunit.Abstractions;

namespace CreditasChallengeTests
{
    public class CustomerTest
    {

        private readonly ITestOutputHelper _output;

        public CustomerTest(ITestOutputHelper output)
        {
            _output = output;
        }

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


        [Theory]
        [InlineData("João", "123.456.789-10", 29, "SP", 5500)]
        [InlineData("Marcos", "123.456.789-10", 22, "SP", 4500)]
        [InlineData("Paula", "123.456.789-10", 16, "RJ", 3000)]
        public void ShouldReturnPersonalLoan(string name, string cpf, int age, string location, double income)
        {
            var customer = new Customer(name, cpf, age, location, income);
            var loans = LoanManager.GetTypesLoansAvailable(customer);

            Assert.Equal("personal", loans[0].Type);
            Assert.Equal(4, loans[0].Taxes);
        }

        [Theory]
        [InlineData("João", "123.456.789-10", 29, "SP", 2500, 2)]
        [InlineData("João", "123.456.789-10", 29, "SP", 4300, 2)]
        [InlineData("João", "123.456.789-10", 29, "SP", 5500, 3)]
        public void ShouldReturnCollateralizedLoan(string name, string cpf, int age, string location, double income, int expectLoanOption)
        {
            var customer = new Customer(name, cpf, age, location, income);
            var loans = LoanManager.GetTypesLoansAvailable(customer);

            Assert.Equal(expectLoanOption, loans.Length);
            Assert.Equal("collaterized", loans[1].Type);
            Assert.Equal(3, loans[1].Taxes);
        }

        [Theory]
        [InlineData("João", "123.456.789-10", 29, "SP", 5500)]
        [InlineData("João", "123.456.789-10", 29, "SP", 5000)]
        public void ShouldReturnPayroolLoan(string name, string cpf, int age, string location, double income)
        {
            var customer = new Customer(name, cpf, age, location, income);
            var loans = LoanManager.GetTypesLoansAvailable(customer);
            Assert.Equal(3, loans.Length);
            Assert.Equal("payroll", loans[2].Type);
            Assert.Equal(2, loans[2].Taxes);
        }

    }
}