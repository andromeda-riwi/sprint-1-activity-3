using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
    }

    public class Veterinary
    {
        private List<Pet> pets = new List<Pet>();

        public void RegisterPet(string name, string species, int age)
        {
            pets.Add(new Pet { Name = name, Species = species, Age = age });
            Console.WriteLine("Mascota registrada con éxito.");
        }

        public void ConsultPet(string name)
        {
            var pet = pets.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (pet != null)
            {
                Console.WriteLine($"\n--- Información de la Mascota ---");
                Console.WriteLine($"Nombre:   {pet.Name}");
                Console.WriteLine($"Especie:  {pet.Species}");
                Console.WriteLine($"Edad:     {pet.Age}");
                Console.WriteLine($"¿Es un cachorro?: {(pet.Age < 2 ? "Sí" : "No")}");
            }
            else
            {
                Console.WriteLine("Mascota no encontrada.");
            }
        }
    }

    public class Exercise8_Pets
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 8: Gestión de Mascotas ---");
            Veterinary veterinary = new Veterinary();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nueva mascota");
                Console.WriteLine("2. Consultar datos de una mascota");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Nombre de la mascota: ");
                        string name = Console.ReadLine() ?? "";
                        Console.Write("Especie: ");
                        string species = Console.ReadLine() ?? "";
                        Console.Write("Edad: ");
                        int age;
                        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                        {
                            Console.WriteLine("Edad inválida. Ingrese un número no negativo.");
                            Console.Write("Edad: ");
                        }
                        veterinary.RegisterPet(name, species, age);
                        break;
                    case "2":
                        Console.Write("Nombre de la mascota a consultar: ");
                        string consultName = Console.ReadLine() ?? "";
                        veterinary.ConsultPet(consultName);
                        break;
                    case "3":
                        Console.WriteLine("Volviendo al menú principal.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (option != "3");
        }
    }
}