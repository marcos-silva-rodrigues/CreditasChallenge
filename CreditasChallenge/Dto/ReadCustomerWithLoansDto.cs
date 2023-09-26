using CreditasChallenge.Domain;

namespace CreditasChallenge.Dto
{
    public class ReadCustomerWithLoansDto
    {
        public string Customer { get; set; }
        public Loan[] Loans { get; set; }

        public ReadCustomerWithLoansDto(string customer, Loan[] loans)
        {
            Customer = customer;
            Loans = loans;
        }
    }
}
