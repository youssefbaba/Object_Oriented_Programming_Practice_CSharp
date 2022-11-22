namespace Exercise_9
{
    public class User : IComparer<User>
    {
        // Constructors
        public User()
        {
        }
        public User(string firstName, string lastName, int rank)
        {
            FirstName = firstName;
            LastName = lastName;
            Rank = rank;
        }


        // Methods
        public int Compare(User? user1, User? user2)
        {
            if (user1.FirstName.CompareTo(user2.FirstName) != 0)
            {
                return user1.FirstName.CompareTo(user2.FirstName);
            }
            else if (user1.Rank.CompareTo(user2.Rank) != 0)
            {
                return user1.Rank.CompareTo(user2.Rank);
            }
            else
            {
                return 0;
            }
        }


        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Rank { get; private set; }
    }
}
