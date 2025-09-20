namespace Sprint_1_activity_3.Classes;

using System;
using System.Collections.Generic;
using System.Globalization;

public class Clinic
{
    string PatientName;
    string Specialty;
    DateTime AppointmentDate;

    List<Clinic> Appointments = new List<Clinic>();

    public void RegisterAppointment()
    {
        Console.WriteLine("Register appointment");

        Console.Write("Patient name: ");
        string patient = Console.ReadLine() ?? "";

        Console.Write("Specialty: ");
        string specialty = Console.ReadLine() ?? "";

        Console.Write("Appointment date (yyyy-MM-dd): ");
        string raw = Console.ReadLine() ?? "";
        DateTime date = DateTime.ParseExact(raw, "yyyy-MM-dd", CultureInfo.InvariantCulture);

        Clinic appt = new Clinic
        {
            PatientName = patient,
            Specialty = specialty,
            AppointmentDate = date
        };

        Appointments.Add(appt);
        Console.WriteLine("Appointment registered.");
    }

    public void DisplayAppointment()
    {
        Console.Write("Enter patient name to display appointment: ");
        string patient = Console.ReadLine() ?? "";

        bool found = false;
        for (int i = 0; i < Appointments.Count; i++)
        {
            if (Appointments[i].PatientName == patient)
            {
                Console.WriteLine($"Patient: {Appointments[i].PatientName}, Specialty: {Appointments[i].Specialty}, Date: {Appointments[i].AppointmentDate:yyyy-MM-dd}");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Appointment not found");
    }

    public void DaysUntilAppointment()
    {
        Console.Write("Enter patient name to check days until appointment: ");
        string patient = Console.ReadLine() ?? "";

        bool found = false;
        for (int i = 0; i < Appointments.Count; i++)
        {
            if (Appointments[i].PatientName == patient)
            {
                DateTime today = DateTime.Today;
                TimeSpan diff = Appointments[i].AppointmentDate.Date - today;
                Console.WriteLine($"Days until appointment: {diff.Days}");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Appointment not found");
    }
}