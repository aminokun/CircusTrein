using System;
using System.Collections.Generic;
using CircusTrein; // Import the CircusTrein for Animal and Wagon classes

namespace CircusTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>(); // Create a new list to store the animals

            // Prompt the user to enter animals and add them to the list
            Console.WriteLine("Enter the animals in the format: <size> <diet>");
            Console.WriteLine("Size: small, medium, large");
            Console.WriteLine("Diet: meat, plants");
            Console.WriteLine("Enter 'done' when finished.");

            while (true)
            {
                string input = Console.ReadLine(); // Read the user's input
                if (input == "done") break; // If the user enters "done", exit the loop

                string[] parts = input.Split(' '); // Split the input into size and diet strings
                string size = parts[0]; // Get the size string
                string diet = parts[1]; // Get the diet string

                Animal animal = new Animal(size, diet); // Create a new animal object with the given size and diet
                animals.Add(animal); // Add the animal to the list of animals
            }

            List<Wagon> wagons = new List<Wagon>(); // Create a new list to store the wagons
            int wagonCount = 0; // Counter to keep track of the number of wagons used

            foreach (Animal animal in animals)
            {
                bool added = false; // Boolean to keep track of whether the animal has been added to a wagon

                foreach (Wagon wagon in wagons)
                {
                    if (wagon.CanAddAnimal(animal)) // If the animal can be added to the wagon, add it and set the bool to true
                    {
                        wagon.AddAnimal(animal);
                        added = true;
                        break;
                    }
                }

                if (!added) // If the animal was not added to any wagons, create a new wagon and add the animal to it
                {
                    Wagon wagon = new Wagon();
                    wagon.AddAnimal(animal);
                    wagons.Add(wagon);
                    wagonCount++; // wagon count +1
                }
            }

            // display the number of wagons and the animals in each wagon
            Console.WriteLine("The animals have been distributed in " + wagonCount + " wagons:");
            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine("Wagon: " + wagon.ToString());
            }
        }
    }
}