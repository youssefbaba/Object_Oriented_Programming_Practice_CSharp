using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class TestTown
    {
        static void Main(string[] args)
        {
            Town town = new Town();
            town.Add(new IndividualHabitation("Youssef Baba", "Madrid-Spain-XXXXXX", 120.5, 5, true));
            town.Add(new ProfessionalHabitation("Reda Driouch", "London-UK-XXXXXX", 400.5, 50));
            town.Add(new IndividualHabitation("Mohamed Zidani", "Berlin-Germany-XXXXXX", 130.8, 6, true));
            town.Add(new ProfessionalHabitation("Omar Abderahmane", "Rabat-Morocco-XXXXXX", 386.5, 100));
            town.Add(new IndividualHabitation("Hamza Aziz", "Roma-Italy-XXXXXX", 100.5, 4, false));
            town.Show();
        }
    }
}
