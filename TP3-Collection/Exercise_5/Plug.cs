namespace Exercise_5
{
    public class Plug
    {
        // Construstors
        public Plug(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }


        // Methods
        public override string ToString()
        {
            return $"Name = {Name} - Phone = {Phone} - Address = {Address}"; 
        }

        //Properties
        public string Name { get; }
        public string Phone { get; }
        public string Address { get; }
    }
}
