using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Wagon
    {
        private List<Animal> animals = new List<Animal>(); // List to store animals in the wagon
        private int sizePoints = 0; // Total size points of all animals in the wagon

        // Method to add an animal to the wagon
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal); // Add the animal to the list
            sizePoints += animal.GetSizePoints(); // Increase the total size points of the wagon 
        }

        //Method to check if an animal can be added to the wagon
        public bool CanAddAnimal(Animal animal)
        {
            if (sizePoints + animal.GetSizePoints() > 10)
                return false;

            // Check if the animal can be with other animal in the same wagon
            foreach (Animal a in animals)
            {
                if (a.Diet == "meat" && animal.Diet == "meat") // If both animals are meat eaters, they cannot be in the same wagon
                    return false;
                if (a.Diet == "plants" && animal.Diet == "meat") // If the wagon already has an animal that cannot be with meat eaters, return false
                    return false;
            }

            return true; // If the animal can be added and the wagon has capacity, return true
        }


        // Method to generate a string representation of the wagon
        public override string ToString()
        {
            string result = "";
            foreach (Animal animal in animals)
            {
                result += animal.Size + " " + animal.Diet + ", "; // Add the animal's size and diet to the result string
            }
            return result.Substring(0, result.Length - 2); // Remove the extra comma and space at the end of the string before returning it
        }
    }
}
