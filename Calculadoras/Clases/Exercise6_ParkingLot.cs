using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }// Placa del vehículo
        public string Brand { get; set; }// Marca del vehículo
        public DateTime EntryTime { get; set; }// Hora de entrada
    }

    public class ParkingLot// Parqueadero
    {
        private List<Vehicle> vehicles = new List<Vehicle>();// Lista de vehículos en el parqueadero
        private const decimal PricePerHour = 5.00m;// Precio por hora

        public void RegisterEntry(string licensePlate, string brand)// Registrar la entrada de un vehículo
        {
            if (vehicles.Any(v => v.LicensePlate.Equals(licensePlate, StringComparison.OrdinalIgnoreCase)))// Verifica si el vehículo ya está registrado
            {
                Console.WriteLine("Este vehículo ya está en el parqueadero.");
                return;
            }
            vehicles.Add(new Vehicle { LicensePlate = licensePlate, Brand = brand, EntryTime = DateTime.Now });
            Console.WriteLine("Entrada registrada con éxito.");
        }

        public void RegisterExit(string licensePlate)//
        {
            var vehicle = vehicles.FirstOrDefault(v => v.LicensePlate.Equals(licensePlate, StringComparison.OrdinalIgnoreCase));
            if (vehicle != null)
            {
                TimeSpan duration = DateTime.Now - vehicle.EntryTime;//
                decimal totalCost = (decimal)Math.Ceiling(duration.TotalHours) * PricePerHour;
                vehicles.Remove(vehicle);
                Console.WriteLine($"Salida registrada para el vehículo con placa {vehicle.LicensePlate}.");
                Console.WriteLine($"Tiempo de uso: {Math.Ceiling(duration.TotalHours)} horas.");
                Console.WriteLine($"Costo total a pagar: ${totalCost:N2}");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
    }

    public class Exercise6_ParkingLot
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 6: Gestión de Parqueadero ---");
            ParkingLot parkingLot = new ParkingLot();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar entrada de vehículo");
                Console.WriteLine("2. Registrar salida de vehículo y calcular costo");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Placa del vehículo: ");
                        string entryLicensePlate = Console.ReadLine() ?? "";
                        Console.Write("Marca del vehículo: ");
                        string brand = Console.ReadLine() ?? "";
                        parkingLot.RegisterEntry(entryLicensePlate, brand);
                        break;
                    case "2":
                        Console.Write("Placa del vehículo a registrar salida: ");
                        string exitLicensePlate = Console.ReadLine() ?? "";
                        parkingLot.RegisterExit(exitLicensePlate);
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