using System;
// Realizado por abrahan Taborda  coder riwi 2025
namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bienvenido al menú de ejercicios de Programación Orientada a Objetos ---");
            string option = "";

            do
            {
                Console.WriteLine("\nSeleccione un ejercicio para ejecutar (1-10):");
                Console.WriteLine("1.  Gestión de Estudiantes");
                Console.WriteLine("2.  Gestión de Cuentas de Banco");
                Console.WriteLine("3.  Gestión de Inventario de Tienda");
                Console.WriteLine("4.  Gestión de Biblioteca");
                Console.WriteLine("5.  Gestión de Pedidos de Restaurante");
                Console.WriteLine("6.  Gestión de Parqueadero");
                Console.WriteLine("7.  Gestión de Cine");
                Console.WriteLine("8.  Gestión de Mascotas");
                Console.WriteLine("9.  Gestión de Hotel");
                Console.WriteLine("10. Gestión de Citas de Clínica");
                Console.WriteLine("0.  Salir");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Exercise1_Students.Run();
                        break;
                    case "2":
                        Exercise2_Bank.Run();
                        break;
                    case "3":
                        Exercise3_Store.Run();
                        break;
                    case "4":
                        Exercise4_Library.Run();
                        break;
                    case "5":
                        Exercise5_Restaurant.Run();
                        break;
                    case "6":
                        Exercise6_ParkingLot.Run();
                        break;
                    case "7":
                        Exercise7_Cinema.Run();
                        break;
                    case "8":
                        Exercise8_Pets.Run();
                        break;
                    case "9":
                        Exercise9_Hotel.Run();
                        break;
                    case "10":
                        Exercise10_Clinic.Run();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            } while (option != "0");
        }
    }
}