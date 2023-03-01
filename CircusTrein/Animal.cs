using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    internal class Animal
    {

        //enum gebruiken evt
        public string Size { get; set; } // (small, medium, or large)
        public string Diet { get; set; } // (herbivore or carnivore)
        public int SizeValue { get; set; } // (1 for small, 3 for medium, 5 for large)

        public Animal(string size, string diet)
        {
            Size = size; // Set the animal's size
            Diet = diet; // Set the animal's diet
        }


            
        // caclulate the size points of the animal based on its size
        public int GetSizePoints()
        {
            if (Size == "small") return 1;
            if (Size == "medium") return 3;
            if (Size == "large") return 5;
            return 0; // Return 0 if the animal's size is not recognized
        }
    }
}
