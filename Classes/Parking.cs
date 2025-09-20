namespace Sprint_1_activity_3.Classes;

using System;
using System.Collections.Generic;

public class Parking
{
    string Plate;
    string Brand;
    DateTime EntryTime;
    bool IsInside;

    List<Parking> Vehicles = new List<Parking>();

    public void RegisterEntry()
    {
        Console.WriteLine("Register vehicle entry");

        Console.Write("Plate: ");
        string plate = Console.ReadLine() ?? "";

        Console.Write("Brand: ");
        string brand = Console.ReadLine() ?? "";

        DateTime entry = DateTime.Now;

        Parking car = new Parking
        {
            Plate = plate,
            Brand = brand,
            EntryTime = entry,
            IsInside = true
        };

        Vehicles.Add(car);
        Console.WriteLine($"Entry registered at {entry}.");
    }

    public void RegisterExit()
    {
        Console.WriteLine("Register vehicle exit");

        Console.Write("Plate: ");
        string plate = Console.ReadLine() ?? "";

        int index = -1;
        for (int i = 0; i < Vehicles.Count; i++)
        {
            if (Vehicles[i].Plate == plate && Vehicles[i].IsInside)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Vehicle not found or already exited.");
            return;
        }

        DateTime exitTime = DateTime.Now;

        TimeSpan duration = exitTime - Vehicles[index].EntryTime;
        double totalHours = duration.TotalHours;
        if (totalHours < 0) totalHours = 0;

        Console.Write("Enter price per hour: ");
        double pricePerHour = Convert.ToDouble(Console.ReadLine() ?? "0");

        double amount = Math.Ceiling(totalHours) * pricePerHour;

        Vehicles[index].IsInside = false;

        Console.WriteLine($"Time used: {totalHours:0.00} hours (charged as {Math.Ceiling(totalHours)}).");
        Console.WriteLine($"Amount to pay: ${amount}");
    }

    public void CalculatePayment()
    {
        Console.Write("Plate to estimate payment (still inside): ");
        string plate = Console.ReadLine() ?? "";

        int index = -1;
        for (int i = 0; i < Vehicles.Count; i++)
        {
            if (Vehicles[i].Plate == plate && Vehicles[i].IsInside)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Vehicle not found or not inside.");
            return;
        }

        DateTime now = DateTime.Now;
        TimeSpan duration = now - Vehicles[index].EntryTime;
        double totalHours = duration.TotalHours;
        if (totalHours < 0) totalHours = 0;

        Console.Write("Enter price per hour: ");
        double pricePerHour = Convert.ToDouble(Console.ReadLine() ?? "0");

        double amount = Math.Ceiling(totalHours) * pricePerHour;

        Console.WriteLine($"Estimated time: {totalHours:0.00} hours (charged as {Math.Ceiling(totalHours)}).");
        Console.WriteLine($"Estimated amount: ${amount}");
    }
}
