using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public string GuestName { get; set; }
        public int Nights { get; set; }
    }

    public class Hotel
    {
        private List<Reservation> reservations = new List<Reservation>();
        private const decimal NightlyRate = 100.00m; // Ejemplo: $100 por noche

        public void RegisterReservation(int roomNumber, string guestName, int nights)
        {
            reservations.Add(new Reservation { RoomNumber = roomNumber, GuestName = guestName, Nights = nights });
            Console.WriteLine("Reserva registrada con éxito.");
        }

        public void ConsultReservation(int roomNumber)
        {
            var reservation = reservations.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (reservation != null)
            {
                Console.WriteLine($"\n--- Información de la Reserva ---");
                Console.WriteLine($"Número de Habitación: {reservation.RoomNumber}");
                Console.WriteLine($"Huésped:              {reservation.GuestName}");
                Console.WriteLine($"Noches:               {reservation.Nights}");
                Console.WriteLine($"Costo total:          ${reservation.Nights * NightlyRate}");
            }
            else
            {
                Console.WriteLine("Reserva no encontrada.");
            }
        }
    }

    public class Exercise9_Hotel
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 9: Gestión de Hotel ---");
            Hotel hotel = new Hotel();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nueva reserva");
                Console.WriteLine("2. Consultar información de una reserva");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Número de habitación: ");
                        int roomNumber;
                        while (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber <= 0)
                        {
                            Console.WriteLine("Número de habitación inválido. Ingrese un número positivo.");
                            Console.Write("Número de habitación: ");
                        }
                        Console.Write("Nombre del huésped: ");
                        string guestName = Console.ReadLine() ?? "";
                        Console.Write("Cantidad de noches: ");
                        int nights;
                        while (!int.TryParse(Console.ReadLine(), out nights) || nights <= 0)
                        {
                            Console.WriteLine("Cantidad de noches inválida. Ingrese un número positivo.");
                            Console.Write("Cantidad de noches: ");
                        }
                        hotel.RegisterReservation(roomNumber, guestName, nights);
                        break;
                    case "2":
                        Console.Write("Número de habitación para consultar la reserva: ");
                        int consultRoomNumber;
                        while (!int.TryParse(Console.ReadLine(), out consultRoomNumber) || consultRoomNumber <= 0)
                        {
                            Console.WriteLine("Número de habitación inválido. Ingrese un número positivo.");
                            Console.Write("Número de habitación: ");
                        }
                        hotel.ConsultReservation(consultRoomNumber);
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