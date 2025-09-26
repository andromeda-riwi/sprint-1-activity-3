using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
    }

    public class Cinema
    {
        private List<Movie> movies = new List<Movie>();

        public void RegisterMovie(string title, string genre, int duration)
        {
            movies.Add(new Movie { Title = title, Genre = genre, DurationMinutes = duration });
            Console.WriteLine("Película registrada con éxito.");
        }

        public void ConsultMovie(string title)
        {
            var movie = movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                Console.WriteLine($"\n--- Información de la Película ---");
                Console.WriteLine($"Título:   {movie.Title}");
                Console.WriteLine($"Género:   {movie.Genre}");
                Console.WriteLine($"Duración: {movie.DurationMinutes} minutos");
                Console.WriteLine($"¿Es una película larga?: {(movie.DurationMinutes > 120 ? "Sí" : "No")}");
            }
            else
            {
                Console.WriteLine("Película no encontrada.");
            }
        }
    }

    public class Exercise7_Cinema
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 7: Gestión de Cine ---");
            Cinema cinema = new Cinema();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nueva película");
                Console.WriteLine("2. Consultar información de una película");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Título: ");
                        string title = Console.ReadLine() ?? "";
                        Console.Write("Género: ");
                        string genre = Console.ReadLine() ?? "";
                        Console.Write("Duración en minutos: ");
                        int duration;
                        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
                        {
                            Console.WriteLine("Duración inválida. Ingrese un número positivo.");
                            Console.Write("Duración en minutos: ");
                        }
                        cinema.RegisterMovie(title, genre, duration);
                        break;
                    case "2":
                        Console.Write("Título de la película a consultar: ");
                        string consultTitle = Console.ReadLine() ?? "";
                        cinema.ConsultMovie(consultTitle);
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