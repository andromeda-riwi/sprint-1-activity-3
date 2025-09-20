namespace Sprint_1_activity_3.Classes;

public class Bank
{
    int NumberAccount;
    string NameOwner;
    double Balance;
    
    List <Bank> Banks = new List <Bank>();
    
    public void NewAccount()
    {
        Console.WriteLine("Enter the number of the account: ");
        int numberaccount = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the name of the account: ");
        string nameowner = Console.ReadLine();
        Console.WriteLine("Enter the balance of the account: ");
        double balance = int.Parse(Console.ReadLine()); 
        
        Bank bank = new Bank()
        {
            NumberAccount = numberaccount,
            NameOwner = nameowner,
            Balance = balance

        };
        
        Banks.Add(bank);

        foreach (Bank banks in Banks)
        {
            Console.WriteLine($"Number account: {bank.NumberAccount}, Name: {bank.NameOwner}, Balance: {bank.Balance}");
        }

    }

    public void DisplayBanks()
    {
        Console.WriteLine("Please enter the number of the account: ");
        int numberaccount = int.Parse(Console.ReadLine());
        
        if (Banks.Count == 0)
        {
            Console.WriteLine("Nothing to display");
            return;
        }
        
        bool flag = false;
        
        for (int i = 0; i < Banks.Count; i++)
        {
            int ActualNumberAccount = Banks[i].NumberAccount;
            
            if (ActualNumberAccount == numberaccount)
            {
                Console.WriteLine($"Number account: {ActualNumberAccount}, Name of owner: {Banks[i].NameOwner} and Balance of account: {Banks[i].Balance}");

                flag = true;
                
                break;
            }
        }

        if (!flag)
        {
            Console.WriteLine("Nothing to display or Account not found");
        }
        
    }

    public void Deposit()
    {
        Console.WriteLine("Please enter the number of the account: ");
        int numberaccount = int.Parse(Console.ReadLine());
        
        if (Banks.Count == 0)
        {
            Console.WriteLine("There's no accounts");
            return;
        }
        
        bool flag = false;
        
        for (int i = 0; i < Banks.Count; i++)
        {
            int ActualNumberAccount = Banks[i].NumberAccount;
            
            if (ActualNumberAccount == numberaccount)
            {
                Console.WriteLine("Enter the amount to deposit: ");
                double amount = double.Parse(Console.ReadLine() ?? "0");
            
                Banks[i].Balance += amount;
                Console.WriteLine($"Deposit successful. New balance: {Banks[i].Balance}");
            
                flag = true;
                break;
            }
        }

        if (!flag)
        {
            Console.WriteLine("Account not found");
        }

    }
    
}