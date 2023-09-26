using CreditasChallenge.Domain.Rule;

namespace CreditasChallenge.Domain
{
    public class LoanManager
    {

        public static Loan[] GetTypesLoansAvailable(Customer customer)
        {
            var list = new List<Loan>() { };
            var loanRules = new LoanRule[]
            {
                new PersonalRule(),
                new CollaterizedRule(customer),
                new PayrollRule(customer),
            };

            foreach (var rule in loanRules)
            {
                var loan = rule.isApply();
                if (loan != null)
                {
                    list.Add(loan);
                }
            }

            return list.ToArray();
        }
    }
}
