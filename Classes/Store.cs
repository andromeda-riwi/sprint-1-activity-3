namespace Sprint_1_activity_3.Classes;

public class Store
{
    string Name;
    double Price;
    int Amount;
    
    List <Store> Products = new List<Store>();

    public void RegisterProduct()
    {
        Console.WriteLine("Register product");
        
        Console.Write("Name of product: ");
        string name = Console.ReadLine() ?? "";
        
        Console.Write("Price of product: ");
        double price = Convert.ToDouble(Console.ReadLine() ?? "0");
        
        Console.Write("Amount of product: ");
        int amount = Convert.ToInt32(Console.ReadLine() ?? "0");

        Store store = new Store
        {
            Name = name,
            Price = price,
            Amount = amount

        };
        
        Products.Add(store);
    }


    public void DisplayProduct()
    {
        Console.Write("Name of product: ");
        string name = Console.ReadLine() ?? "";

        bool flag = false;
        
        for (int i = 0; i < Products.Count; i++)
        {
            Store ActualProduct = Products[i];

            if (ActualProduct.Name == name)
            {
                Console.WriteLine($"Name of product: {ActualProduct.Name}, Price of product: {ActualProduct.Price} and Amount of product: {ActualProduct.Amount}");
                
                flag = true;
                
                return;
            }
        }

        if (!flag)
        {
            Console.WriteLine("Product not found");
        }
    }
    
    public void SellProduct()
    {
        Console.WriteLine("Sell product");
        Console.Write("Name of product: ");
        string name = Console.ReadLine() ?? "";
        
        bool flag = false;

        for (int i = 0; i < Products.Count; i++)
        {
            Store ActualProduct = Products[i];

            if (ActualProduct.Name == name)
            {
                Console.WriteLine("Enter amount of product that you want to sell: ");
                int AmountToSell = Convert.ToInt32(Console.ReadLine() ?? "0");
                
                flag = true;

                if (AmountToSell > ActualProduct.Amount)
                {
                    Console.WriteLine("Amount of product it's not avaible");
                    break;
                }
                else
                {
                    ActualProduct.Amount -= AmountToSell;
                    
                    Console.WriteLine($"New amount of product: {ActualProduct.Amount}");
                    
                    break;
                }
            }
        }

        if (!flag)
        {
            Console.WriteLine("Product not found");
        }
        
    }

    
}