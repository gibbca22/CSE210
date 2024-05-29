using System;

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();

        Console.WriteLine($"You have ${account.balance}");

        account.Withdraw();

        Console.WriteLine($"You have ${account.balance}");
    }
}

