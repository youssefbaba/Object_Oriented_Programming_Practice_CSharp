namespace Exercise_9
{
    public class Customer : IComparable<Customer>
    {
        // Constructors
        public Customer(string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }


        // Methods
        public int CompareTo(Customer? other)
        {
            if (FirstName.CompareTo(other.FirstName) != 0)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else if (Balance.CompareTo(other.Balance) != 0)
            {
                return Balance.CompareTo(other.Balance);
            }
            else
            {
                return 0;
            }
        }
        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Balance { get; private set; }
    }
}
