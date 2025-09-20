namespace Sprint_1_activity_3.Classes;

using System.Collections.Generic;
using System.Linq;


public class Students
{
    string Name;
    int Age;
    string Grade;

     List <Students> AllStudents = new List <Students>();
    
    public void AddStudent()
    {
        Console.WriteLine("Enter the name of the student: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the age of the student: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the grade of the student: ");
        string grade = Console.ReadLine();

        Students student = new Students
        {
            Name = name,
            Age = age,
            Grade = grade
        };
        
        AllStudents.Add(student);

        foreach (Students students in AllStudents)
        {
            Console.WriteLine($"Name: {students.Name}, Age: {students.Age}, Grade: {students.Grade}");
        }
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Please enter the name of the student which you want to display: ");
        string inputName = (Console.ReadLine() ?? "").Trim();

        if (AllStudents.Count == 0)
        {
            Console.WriteLine("Nothing to display");
            return;
        }

        int foundIndex = -1;

        for (int i = 0; i < AllStudents.Count; i++)
        {
            string currentName = AllStudents[i].Name ?? "";
            if (string.Equals(currentName, inputName, StringComparison.OrdinalIgnoreCase))
            {
                foundIndex = i;
                break;
            }
        }

        if (foundIndex == -1)
        {
            Console.WriteLine("Student not found");
        }
        else
        {
            Students s = AllStudents[foundIndex];
            Console.WriteLine("Student found:");
            Console.WriteLine("Name : " + s.Name);
            Console.WriteLine("Age  : " + s.Age);
            Console.WriteLine("Grade: " + s.Grade);
        }
    }
}

