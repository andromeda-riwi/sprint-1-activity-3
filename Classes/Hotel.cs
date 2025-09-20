namespace Sprint_1_activity_3.Classes;

using System;
using System.Collections.Generic;

public class Hotel
{
    int RoomNumber;
    string GuestName;
    int Nights;

    List<Hotel> Reservations = new List<Hotel>();

    public void RegisterReservation()
    {
        Console.WriteLine("Register reservation");

        Console.Write("Room number: ");
        int room = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.Write("Guest name: ");
        string guest = Console.ReadLine() ?? "";

        Console.Write("Nights: ");
        int nights = Convert.ToInt32(Console.ReadLine() ?? "0");

        Hotel reservation = new Hotel
        {
            RoomNumber = room,
            GuestName = guest,
            Nights = nights
        };

        Reservations.Add(reservation);
        Console.WriteLine("Reservation registered.");
    }

    public void DisplayReservation()
    {
        Console.Write("Enter room number to display reservation: ");
        int room = Convert.ToInt32(Console.ReadLine() ?? "0");

        bool found = false;
        for (int i = 0; i < Reservations.Count; i++)
        {
            if (Reservations[i].RoomNumber == room)
            {
                Console.WriteLine($"Room: {Reservations[i].RoomNumber}, Guest: {Reservations[i].GuestName}, Nights: {Reservations[i].Nights}");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Reservation not found");
    }

    public void CalculateStayCost()
    {
        Console.Write("Enter room number to calculate total cost: ");
        int room = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.Write("Enter price per night: ");
        double pricePerNight = Convert.ToDouble(Console.ReadLine() ?? "0");

        bool found = false;
        for (int i = 0; i < Reservations.Count; i++)
        {
            if (Reservations[i].RoomNumber == room)
            {
                double total = Reservations[i].Nights * pricePerNight;
                Console.WriteLine($"Total cost for room {room}: ${total}");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Reservation not found");
    }
}