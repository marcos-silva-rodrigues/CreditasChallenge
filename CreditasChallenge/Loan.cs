namespace CreditasChallenge
{
    public class Loan
    {

        public string Type { get; private set; }
        public double Taxes { get; private set; }

        public Loan(string type, double taxes)
        {
            Taxes = taxes;
            Type = type;
        }
    }
}
