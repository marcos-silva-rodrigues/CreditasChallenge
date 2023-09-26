using System.Collections.Generic;

namespace CreditasChallenge.Domain.Rule
{
    public class CollaterizedRule : LoanRule
    {

        private readonly Customer _customer;

        public CollaterizedRule(Customer customer)
        {
            _customer = customer;
        }

        public Loan? isApply()
        {

            if (_customer.Income <= 3000 && _customer.Age < 30 && _customer.Location == "SP")
            {
                return new Loan("collaterized", 3);
            }

            if (_customer.Income > 3000 && _customer.Income < 5000 && _customer.Location == "SP")
            {
                return new Loan("collaterized", 3);
            }

            if (_customer.Income >= 5000 && _customer.Age < 30)
            {
                return new Loan("collaterized", 3);
            }

            return null;
        }

    }
}
