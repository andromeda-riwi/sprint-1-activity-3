using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class Store
    {
        private List<Product> products = new List<Product>();// Lista para almacenar los productos

        public void RegisterProduct(string name, decimal price, int stock)// Método para registrar un nuevo producto
        {
            if (products.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))// Verifica si el producto ya existe
            {
                Console.WriteLine("El producto ya existe.");
                return;
            }
            products.Add(new Product { Name = name, Price = price, Stock = stock });// Agrega el nuevo producto a la lista
            Console.WriteLine("Producto registrado con éxito.");
        }

        public void ConsultProduct(string name)// Método para consultar los detalles de un producto
        {
            var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));// Busca el producto por nombre
            if (product != null)
            {
                Console.WriteLine($"\n--- Detalles del Producto ---");
                Console.WriteLine($"Nombre: {product.Name}");
                Console.WriteLine($"Precio: {product.Price}");
                Console.WriteLine($"Stock:  {product.Stock}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void SellProduct(string name, int quantity)// Método para vender un producto
        {
            var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));// Busca el producto por nombre
            if (product != null)
            {
                if (product.Stock >= quantity)// Verifica si hay suficiente stock para la venta
                {
                    product.Stock -= quantity;// Reduce el stock del producto
                    Console.WriteLine($"Venta exitosa. {quantity} unidades de {product.Name} vendidas. Stock restante: {product.Stock}");
                }
                else
                {
                    Console.WriteLine("Stock insuficiente para la venta.");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }

    public class Exercise3_Store// Clase principal para ejecutar el ejercicio
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 3: Gestión de Inventario de Tienda ---");
            Store store = new Store();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nuevo producto");
                Console.WriteLine("2. Consultar detalles de un producto");
                Console.WriteLine("3. Vender un producto");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Nombre del producto: ");
                        string name = Console.ReadLine() ?? "";
                        Console.Write("Precio: ");
                        decimal price;
                        while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)// Validación del precio
                        {
                            Console.WriteLine("Precio inválido. Ingrese un número positivo.");
                            Console.Write("Precio: ");
                        }
                        Console.Write("Cantidad en stock: ");
                        int stock;
                        while (!int.TryParse(Console.ReadLine(), out stock) || stock < 0)
                        {
                            Console.WriteLine("Stock inválido. Ingrese un número no negativo.");
                            Console.Write("Cantidad en stock: ");
                        }
                        store.RegisterProduct(name, price, stock);
                        break;
                    case "2":
                        Console.Write("Nombre del producto a consultar: ");
                        string consultName = Console.ReadLine() ?? "";
                        store.ConsultProduct(consultName);
                        break;
                    case "3":
                        Console.Write("Nombre del producto a vender: ");
                        string sellName = Console.ReadLine() ?? "";
                        Console.Write("Cantidad a vender: ");
                        int quantity;
                        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                        {
                            Console.WriteLine("Cantidad inválida. Ingrese un número positivo.");
                            Console.Write("Cantidad a vender: ");
                        }
                        store.SellProduct(sellName, quantity);
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