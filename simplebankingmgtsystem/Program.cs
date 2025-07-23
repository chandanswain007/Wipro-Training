using System;

class Account
{
    // public int Balance = 0;
    public int a;
    // Define properties
    // Complete Step 1:............
    public string AccountNumber { get; set; }
    public decimal Balance{get; set;}
    public string OwnerName{get; set;}

    // Define methods
    // Complete Step 2:............
    public void depositeFunds()
    {
        Console.WriteLine("Enter The Amount to Depoit");
        int a = Convert.ToInt32(Console.ReadLine());
        Balance += a;
        Console.WriteLine("Deposited: $" + a);
    }
    public void withdrawFunds()
    {
        Console.WriteLine("Enter The Amount to Withdraw");
        int a = Convert.ToInt32(Console.ReadLine());
        Balance -= a;
        Console.WriteLine("Withdrew: $" + a);
    }
    public void checkAccount()
    {
        Console.WriteLine("Account Balance: $" + Balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account();
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        // Complete Step 3:............
        acc.AccountNumber = Console.ReadLine();

        Console.WriteLine("Enter owner name:");
        // Complete Step 4:............
        acc.OwnerName = Console.ReadLine();

        // Create an instance of the Account class
        // Complete Step 5:............

        Console.WriteLine("Press 1 to deposit funds, 2 to withdraw funds, or 3 to check account balance:");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                acc.depositeFunds();
                break;
            case 2:
                acc.withdrawFunds();
                break;
            case 3:
                acc.checkAccount();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        // Perform transactions
        // Complete Step 6:............
        // acc.depositeFunds();
        // acc.withdrawFunds();
        // acc.checkAccount();
    }
}