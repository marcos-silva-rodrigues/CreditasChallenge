namespace CreditasChallenge.Domain.Rule
{
    public class PayrollRule : LoanRule
    {

        private readonly Customer _customer;

        public PayrollRule(Customer customer)
        {
            _customer = customer;
        }

        public Loan? isApply()
        {
            if (_customer.Income >= 5000)
            {
                return new Loan("payroll", 2);
            }

            return null;

        }

    }
}
