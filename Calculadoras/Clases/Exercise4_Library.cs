using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void RegisterBook(string title, string author, int pageCount)
        {
            books.Add(new Book { Title = title, Author = author, PageCount = pageCount });
            Console.WriteLine("Libro registrado con éxito.");
        }

        public void ConsultBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine($"\n--- Información del Libro ---");
                Console.WriteLine($"Título:    {book.Title}");
                Console.WriteLine($"Autor:     {book.Author}");
                Console.WriteLine($"Páginas:   {book.PageCount}");
                Console.WriteLine($"¿Es un libro largo?: {(book.PageCount > 300 ? "Sí" : "No")}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
    }

    public class Exercise4_Library
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 4: Gestión de Biblioteca ---");
            Library library = new Library();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nuevo libro");
                Console.WriteLine("2. Consultar información de un libro");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Título del libro: ");
                        string title = Console.ReadLine() ?? "";
                        Console.Write("Autor: ");
                        string author = Console.ReadLine() ?? "";
                        Console.Write("Número de páginas: ");
                        int pageCount;
                        while (!int.TryParse(Console.ReadLine(), out pageCount) || pageCount <= 0)
                        {
                            Console.WriteLine("Número de páginas inválido. Ingrese un número positivo.");
                            Console.Write("Número de páginas: ");
                        }
                        library.RegisterBook(title, author, pageCount);
                        break;
                    case "2":
                        Console.Write("Título del libro a consultar: ");
                        string consultTitle = Console.ReadLine() ?? "";
                        library.ConsultBook(consultTitle);
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