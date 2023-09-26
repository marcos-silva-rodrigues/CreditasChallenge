namespace CreditasChallenge.Domain
{
    public class Customer
    {

        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public int Age { get; private set; }
        public string Location { get; private set; }
        public double Income { get; private set; }

        public Customer(string name, string cpf, int age, string location, double income)
        {
            Name = name;
            Cpf = cpf;
            Age = age;
            Location = location;
            Income = income;
        }
    }
}
