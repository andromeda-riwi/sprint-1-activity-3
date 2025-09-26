using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public string Specialty { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

    public class Clinic
    {
        private List<Appointment> appointments = new List<Appointment>();

        public void RegisterAppointment(string patientName, string specialty, DateTime appointmentDate)
        {
            appointments.Add(new Appointment { PatientName = patientName, Specialty = specialty, AppointmentDate = appointmentDate });
            Console.WriteLine("Cita registrada con éxito.");
        }

        public void ConsultAppointment(string patientName)
        {
            var appointment = appointments.FirstOrDefault(a => a.PatientName.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (appointment != null)
            {
                Console.WriteLine($"\n--- Datos de la Cita ---");
                Console.WriteLine($"Paciente:     {appointment.PatientName}");
                Console.WriteLine($"Especialidad: {appointment.Specialty}");
                Console.WriteLine($"Fecha:        {appointment.AppointmentDate.ToShortDateString()}");
                TimeSpan remainingTime = appointment.AppointmentDate - DateTime.Today;
                int remainingDays = (int)Math.Ceiling(remainingTime.TotalDays);
                Console.WriteLine($"Días para la cita: {remainingDays}");
            }
            else
            {
                Console.WriteLine("Cita no encontrada.");
            }
        }
    }

    public class Exercise10_Clinic
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Ejercicio 10: Gestión de Clínica ---");
            Clinic clinic = new Clinic();
            string option = "";

            do
            {
                Console.WriteLine("\n1. Registrar nueva cita");
                Console.WriteLine("2. Consultar datos de una cita");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Nombre del paciente: ");
                        string patientName = Console.ReadLine() ?? "";
                        Console.Write("Especialidad: ");
                        string specialty = Console.ReadLine() ?? "";
                        Console.Write("Fecha de la cita (YYYY-MM-DD): ");
                        DateTime appointmentDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out appointmentDate))
                        {
                            Console.WriteLine("Formato de fecha inválido.");
                            Console.Write("Fecha de la cita (YYYY-MM-DD): ");
                        }
                        clinic.RegisterAppointment(patientName, specialty, appointmentDate);
                        break;
                    case "2":
                        Console.Write("Nombre del paciente a consultar: ");
                        string consultPatientName = Console.ReadLine() ?? "";
                        clinic.ConsultAppointment(consultPatientName);
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