using System;
using Sprint_1_activity_3.Classes;

class Program
{
    static void Main()
    {
        Students studentsModule = new Students();
        Bank bankModule = new Bank();
        Store storeModule = new Store();
        Library libraryModule = new Library();
        Restaurant restaurantModule = new Restaurant();
        Parking parkingModule = new Parking();
        Cinema cinemaModule = new Cinema();
        Pets petsModule = new Pets();                
        Hotel hotelModule = new Hotel();
        Clinic clinicModule = new Clinic();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1) Students");
            Console.WriteLine("2) Bank");
            Console.WriteLine("3) Store");
            Console.WriteLine("4) Library");
            Console.WriteLine("5) Restaurant");
            Console.WriteLine("6) Parking");
            Console.WriteLine("7) Cinema");
            Console.WriteLine("8) Pets");
            Console.WriteLine("9) Hotel");
            Console.WriteLine("10) Clinic");
            Console.WriteLine("11) Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1": MenuStudents(studentsModule); break;
                case "2": MenuBank(bankModule); break;
                case "3": MenuStore(storeModule); break;
                case "4": MenuLibrary(libraryModule); break;
                case "5": MenuRestaurant(restaurantModule); break;
                case "6": MenuParking(parkingModule); break;
                case "7": MenuCinema(cinemaModule); break;
                case "8": MenuPets(petsModule); break;    
                case "9": MenuHotel(hotelModule); break;
                case "10": MenuClinic(clinicModule); break;
                case "11": exit = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }

        Console.WriteLine("Program finished.");
    }

    static void MenuStudents(Students m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Students ---");
            Console.WriteLine("1) Register student");
            Console.WriteLine("2) Display student");
            Console.WriteLine("3) Back");
            switch (Console.ReadLine())
            {
                case "1": m.AddStudent(); break;
                case "2": m.DisplayStudents(); break;
                case "3": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuBank(Bank m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Bank ---");
            Console.WriteLine("1) Open account");
            Console.WriteLine("2) Display account");
            Console.WriteLine("3) Deposit");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.NewAccount(); break;
                case "2": m.DisplayBanks(); break;
                case "3": m.Deposit(); break;
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuStore(Store m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Store ---");
            Console.WriteLine("1) Register product");
            Console.WriteLine("2) Display product");
            Console.WriteLine("3) Sell product");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterProduct(); break;
                case "2": m.DisplayProduct(); break;
                case "3": m.SellProduct(); break;
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuLibrary(Library m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Library ---");
            Console.WriteLine("1) Register book");
            Console.WriteLine("2) Display book");
            Console.WriteLine("3) Check pages (>300)");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterBook(); break;
                case "2": m.DisplayProduct(); break;  
                case "3": m.PagesBook(); break;
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuRestaurant(Restaurant m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Restaurant ---");
            Console.WriteLine("1) Register order");
            Console.WriteLine("2) Calculate total");
            Console.WriteLine("3) Show dishes");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterOrder(); break;
                case "2": m.CalculateOrderTotal(); break; 
                case "3": m.ShowOrderDishes(); break;      
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuParking(Parking m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Parking ---");
            Console.WriteLine("1) Register entry");
            Console.WriteLine("2) Register exit");
            Console.WriteLine("3) Calculate payment");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterEntry(); break;
                case "2": m.RegisterExit(); break;
                case "3": m.CalculatePayment(); break;
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuCinema(Cinema m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Cinema ---");
            Console.WriteLine("1) Register movie");
            Console.WriteLine("2) Display movie");
            Console.WriteLine("3) Check if long");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterMovie(); break;
                case "2": m.DisplayMovie(); break;
                case "3": m.IsLongMovie(); break;
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuPets(Pets m)  
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Pets ---");
            Console.WriteLine("1) Register pet");
            Console.WriteLine("2) Display pet");
            Console.WriteLine("3) Check if puppy");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterPet(); break;
                case "2": m.DisplayPet(); break;
                case "3": m.IsPuppy(); break;
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuHotel(Hotel m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Hotel ---");
            Console.WriteLine("1) Register reservation");
            Console.WriteLine("2) Display reservation");
            Console.WriteLine("3) Calculate stay cost");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterReservation(); break;   
                case "2": m.DisplayReservation(); break;     
                case "3": m.CalculateStayCost(); break;      
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void MenuClinic(Clinic m)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("\n--- Clinic ---");
            Console.WriteLine("1) Register appointment");
            Console.WriteLine("2) Display appointment");
            Console.WriteLine("3) Days until appointment");
            Console.WriteLine("4) Back");
            switch (Console.ReadLine())
            {
                case "1": m.RegisterAppointment(); break;
                case "2": m.DisplayAppointment(); break;
                case "3": m.DaysUntilAppointment(); break;   
                case "4": back = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}
