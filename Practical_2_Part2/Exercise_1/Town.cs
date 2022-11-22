using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Town
    {
        // Fields
        private List<Habitation> _listHabitations;


        // Constructors
        public Town()
        {
            _listHabitations = new List<Habitation>();
        }


        // Methods
        public void Add(Habitation item)
        {
            _listHabitations.Add(item);
        }
        public void Show()
        {
            foreach (Habitation item in _listHabitations)
            {
                item.Display();
                Console.WriteLine($"Tax = {item.Tax()} DH");
                Console.WriteLine();
            }
        }
    }
}



