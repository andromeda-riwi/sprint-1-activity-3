using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Order
    {
        public int TableNumber { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
    }

    public class Restaurant
    {
        private List<Order> orders = new List<Order>();

        public void RegisterOrder(int tableNumber, string dishName, decimal price)
        {
            orders.Add(new Order { TableNumber = tableNumber, DishName = dishName, Price = price });
            Console.WriteLine("Pedido registrado con éxito.");
        }

        public void CalculateTotal(int tableNumber)
        {
            decimal total = orders.Where(o => o.TableNumber == tableNumber).Sum(o => o.Price);
            if (total > 0)
            {
                Console.WriteLine($"\n--- Total del Pedido para la Mesa {tableNumber} ---");
                Console.WriteLine($"Costo total: ${total}");
            }
            else
            {
                Console.WriteLine("No se encontraron pedidos para esta mesa.");
            }
        }

        public void ShowOrderDishes(int tableNumber)// Método para mostrar los platos de un pedido específico
        {
            var tableOrders = orders.Where(o => o.TableNumber == tableNumber).ToList();
            if (tableOrders.Any())
            {
                Console.WriteLine($"\n--- Platos del Pedido para la Mesa {tableNumber} ---");
                foreach (var order in tableOrders)
                {
                    Console.WriteLine($"- {order.DishName} (${order.Price})");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron pedidos para esta mesa.");
            }
        }
    }

    public class Exercise5_Restaurant
    {
        public static void Run()// Método principal para ejecutar el ejercicio
        {
            Console.WriteLine("\n--- Ejercicio 5: Gestión de Pedidos de Restaurante ---");
            Restaurant restaurant = new Restaurant();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nuevo pedido");
                Console.WriteLine("2. Calcular total de un pedido");
                Console.WriteLine("3. Mostrar platos de un pedido");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Número de mesa: ");
                        int tableNumber;
                        while (!int.TryParse(Console.ReadLine(), out tableNumber) || tableNumber <= 0)
                        {
                            Console.WriteLine("Número de mesa inválido. Ingrese un número positivo.");
                            Console.Write("Número de mesa: ");
                        }
                        Console.Write("Nombre del plato: ");
                        string dishName = Console.ReadLine() ?? "";
                        Console.Write("Precio: ");
                        decimal price;
                        while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
                        {
                            Console.WriteLine("Precio inválido. Ingrese un número positivo.");
                            Console.Write("Precio: ");
                        }
                        restaurant.RegisterOrder(tableNumber, dishName, price);
                        break;
                    case "2":
                        Console.Write("Número de mesa para calcular el total: ");
                        int totalTable;
                        while (!int.TryParse(Console.ReadLine(), out totalTable) || totalTable <= 0)
                        {
                            Console.WriteLine("Número de mesa inválido. Ingrese un número positivo.");
                            Console.Write("Número de mesa: ");
                        }
                        restaurant.CalculateTotal(totalTable);
                        break;
                    case "3":
                        Console.Write("Número de mesa para ver los platos: ");
                        int showDishesTable;
                        while (!int.TryParse(Console.ReadLine(), out showDishesTable) || showDishesTable <= 0)
                        {
                            Console.WriteLine("Número de mesa inválido. Ingrese un número positivo.");
                            Console.Write("Número de mesa: ");
                        }
                        restaurant.ShowOrderDishes(showDishesTable);
                        break;
                    case "4":
                        Console.WriteLine("Volviendo al menú principal.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (option != "4");
        }
    }
}