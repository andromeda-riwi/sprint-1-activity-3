namespace Sprint_1_activity_3.Classes;

using System;
using System.Collections.Generic;

public class Restaurant
{
    int TableNumber;
    string DishName;
    double Price;

    List<Restaurant> Orders = new List<Restaurant>();

    public void RegisterOrder()
    {
        Console.WriteLine("Register order");

        Console.Write("Table number: ");
        int table = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.Write("Dish name: ");
        string dish = Console.ReadLine() ?? "";

        Console.Write("Dish price: ");
        double price = Convert.ToDouble(Console.ReadLine() ?? "0");

        Restaurant order = new Restaurant
        {
            TableNumber = table,
            DishName = dish,
            Price = price
        };

        Orders.Add(order);
        Console.WriteLine("Order registered.");
    }

    public void ShowOrderDishes()
    {
        Console.Write("Enter table number to display dishes: ");
        int table = Convert.ToInt32(Console.ReadLine() ?? "0");

        bool found = false;
        for (int i = 0; i < Orders.Count; i++)
        {
            if (Orders[i].TableNumber == table)
            {
                if (!found) Console.WriteLine($"Dishes for table {table}:");
                Console.WriteLine($"- {Orders[i].DishName} (${Orders[i].Price})");
                found = true;
            }
        }

        if (!found) Console.WriteLine("No orders for this table.");
    }

    public void CalculateOrderTotal()
    {
        Console.Write("Enter table number to calculate total: ");
        int table = Convert.ToInt32(Console.ReadLine() ?? "0");

        bool found = false;
        double total = 0;

        for (int i = 0; i < Orders.Count; i++)
        {
            if (Orders[i].TableNumber == table)
            {
                total += Orders[i].Price;
                found = true;
            }
        }

        if (!found) Console.WriteLine("No orders for this table.");
        else Console.WriteLine($"Total for table {table}: ${total}");
    }
}