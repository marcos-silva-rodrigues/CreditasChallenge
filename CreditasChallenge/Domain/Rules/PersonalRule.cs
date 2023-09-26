namespace CreditasChallenge.Domain.Rule
{
    public class PersonalRule : LoanRule
    {

        public Loan? isApply()
        {
            return new Loan("personal", 4);
        }

    }
}
