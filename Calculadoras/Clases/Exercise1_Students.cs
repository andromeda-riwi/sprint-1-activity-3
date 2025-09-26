using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }

    public class Exercise1_Students
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 1: Gestión de Estudiantes ---");
            List<Student> students = new List<Student>();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nuevo estudiante");
                Console.WriteLine("2. Mostrar información de un estudiante");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        RegisterStudent(students);
                        break;
                    case "2":
                        DisplayStudent(students);
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

        private static void RegisterStudent(List<Student> studentList)
        {
            Console.Write("Nombre del estudiante: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Edad: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Edad inválida. Por favor, ingrese un número positivo.");
                Console.Write("Edad: ");
            }
            Console.Write("Grado: ");
            string grade = Console.ReadLine() ?? "";

            studentList.Add(new Student { Name = name, Age = age, Grade = grade });
            Console.WriteLine("Estudiante registrado con éxito.");
        }

        private static void DisplayStudent(List<Student> studentList)
        {
            Console.Write("Ingrese el nombre del estudiante a buscar: ");
            string name = Console.ReadLine() ?? "";
            var student = studentList.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (student != null)
            {
                Console.WriteLine($"\n--- Información del estudiante ---");
                Console.WriteLine($"Nombre:  {student.Name}");
                Console.WriteLine($"Edad:    {student.Age}");
                Console.WriteLine($"Grado:   {student.Grade}");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
    }
}