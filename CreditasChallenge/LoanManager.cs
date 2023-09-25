namespace CreditasChallenge
{
    public class LoanManager
    {

        public static Loan[] GetTypesLoansAvailable(Customer customer)
        {
                var list = new List<Loan>() { new Loan("personal", 4)  };

                if (customer.Income <= 3000)
                {
                    if (customer.Age < 30 && customer.Location == "SP")
                    {
                        list.Add(new Loan("collaterized", 3));
                    }
                }

                if (customer.Income > 3000 && customer.Income < 5000)
                {
                    if (customer.Location == "SP")
                    {
                        list.Add(new Loan("collaterized", 3));
                    }
                }

                if (customer.Income >= 5000)
                {

                    if (customer.Age < 30)
                    {
                        list.Add(new Loan("collaterized", 3));
                    }
                    list.Add(new Loan("payroll", 2));
                }

                return list.ToArray();
        }
    }
}
