namespace Sprint_1_activity_3.Classes;

public class Library
{
    string Title;
    string Author;
    int Pages;
    
    List<Library> Libraries = new List<Library>();

    public void RegisterBook()
    {
        Console.WriteLine("Registro del library");
        
        Console.WriteLine("Title of book");
        string title = Console.ReadLine();
        Console.WriteLine("Author of book");
        string author = Console.ReadLine();
        Console.WriteLine("Pages of library");
        int pages = int.Parse(Console.ReadLine());

        Library library = new Library
        {
            Title = title,
            Author = author,
            Pages = pages
        };
        
        Libraries.Add(library);
    }

    public void DisplayProduct()
    {
        Console.WriteLine("title of book");
        string title = Console.ReadLine() ?? "";

        bool flag = false;

        for (int i = 0; i < Libraries.Count; i++)
        {
            Library ActualBook = Libraries[i];

            if (ActualBook.Title == title)
            {
                Console.WriteLine($"Title of book: {ActualBook.Title}, Author of book: {ActualBook.Author}, Pages of the book: {ActualBook.Pages}");
                flag = true;
                
                return;
            }
        }

        if (!flag)
        {
            Console.WriteLine("No book found");
        }
    }

    public void PagesBook()
    {
        Console.WriteLine("title of book");
        string title = Console.ReadLine() ?? "";
        bool flag = false;    
        
        for (int i = 0; i < Libraries.Count; i++)
        {
            Library ActualBook = Libraries[i];

            if (ActualBook.Title == title && ActualBook.Pages > 300)
            {
                Console.WriteLine($"Title of book: {ActualBook.Title},  has more than 300 pages.");
                flag = true;
                
                return;
            }if (ActualBook.Title == title)
            {
                Console.WriteLine($"Title of book: {ActualBook.Title}, is no longer than 300 pages. ");
                flag = true;
                
                return;
            }
            
           if(!flag)
               {
                Console.WriteLine("No book found");
               }
        }
        
        
    }




}