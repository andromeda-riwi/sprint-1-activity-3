namespace Sprint_1_activity_3.Classes;

using System;
using System.Collections.Generic;

public class Cinema
{
    string Title;
    string Genre;
    int DurationMinutes;

    List<Cinema> Movies = new List<Cinema>();

    public void RegisterMovie()
    {
        Console.WriteLine("Register movie");

        Console.Write("Title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Genre: ");
        string genre = Console.ReadLine() ?? "";

        Console.Write("Duration (minutes): ");
        int minutes = Convert.ToInt32(Console.ReadLine() ?? "0");

        Cinema movie = new Cinema
        {
            Title = title,
            Genre = genre,
            DurationMinutes = minutes
        };

        Movies.Add(movie);
        Console.WriteLine("Movie registered.");
    }

    public void DisplayMovie()
    {
        Console.Write("Enter movie title to display: ");
        string title = Console.ReadLine() ?? "";

        bool found = false;
        for (int i = 0; i < Movies.Count; i++)
        {
            if (Movies[i].Title == title)
            {
                Console.WriteLine($"Title: {Movies[i].Title}, Genre: {Movies[i].Genre}, Duration: {Movies[i].DurationMinutes} min");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Movie not found");
    }

    public void IsLongMovie()
    {
        Console.Write("Enter movie title to check if it is long (> 120 min): ");
        string title = Console.ReadLine() ?? "";

        bool found = false;
        for (int i = 0; i < Movies.Count; i++)
        {
            if (Movies[i].Title == title)
            {
                if (Movies[i].DurationMinutes > 120) Console.WriteLine("The movie is long.");
                else Console.WriteLine("The movie is not long.");
                found = true;
                break;
            }
        }

        if (!found) Console.WriteLine("Movie not found");
    }
}