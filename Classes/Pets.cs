namespace Sprint_1_activity_3.Classes;

using System;
using System.Collections.Generic;

public class Pets
{
    string Name;
    string Species;
    int Age;

    List<Pets> AllPets = new List<Pets>();

    public void RegisterPet()
    {
        Console.WriteLine("Register pet");

        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Species: ");
        string species = Console.ReadLine() ?? "";

        Console.Write("Age (years): ");
        int age = Convert.ToInt32(Console.ReadLine() ?? "0");

        Pets pet = new Pets
        {
            Name = name,
            Species = species,
            Age = age
        };

        AllPets.Add(pet);
        Console.WriteLine("Pet registered.");
    }

    public void DisplayPet()
    {
        Console.Write("Enter pet name to display: ");
        string name = Console.ReadLine() ?? "";

        bool found = false;
        for (int i = 0; i < AllPets.Count; i++)
        {
            if (AllPets[i].Name == name)
            {
                Console.WriteLine($"Name: {AllPets[i].Name}, Species: {AllPets[i].Species}, Age: {AllPets[i].Age}");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Pet not found");
    }

    public void IsPuppy()
    {
        Console.Write("Enter pet name to check if it is a puppy (< 2 years): ");
        string name = Console.ReadLine() ?? "";

        bool found = false;
        for (int i = 0; i < AllPets.Count; i++)
        {
            if (AllPets[i].Name == name)
            {
                if (AllPets[i].Age < 2) Console.WriteLine("The pet is a puppy.");
                else Console.WriteLine("The pet is not a puppy.");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Pet not found");
    }
}