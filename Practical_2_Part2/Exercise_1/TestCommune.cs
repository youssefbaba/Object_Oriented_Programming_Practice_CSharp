namespace Exercise_1
{
    internal class TestCommune
    {
        static void Main(string[] args)
        {
            Commune commune= new Commune();
            commune.Add(new IndividualHabitation("Youssef Baba", "Madrid-Spain-XXXXXX", 120.5, 5, true));
            commune.Add(new ProfessionalHabitation("Reda Driouch" , "London-UK-XXXXXX" , 400.5 , 50));
            commune.Add(new IndividualHabitation("Mohamed Zidani", "Berlin-Germany-XXXXXX", 130.8, 6, true));
            commune.Add(new ProfessionalHabitation("Omar Abderahmane", "Rabat-Morocco-XXXXXX", 386.5, 100));
            commune.Add(new IndividualHabitation("Hamza Aziz", "Roma-Italy-XXXXXX", 100.5, 4, false));
            commune.Show();
        }
    }
}