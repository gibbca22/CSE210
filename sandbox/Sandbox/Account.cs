using System;

class Account {
    
    
    public float balance = 12;

    public float Withdraw()
    {
        Console.WriteLine("How much would you like to withdraw?");
        float amount = float.Parse(Console.ReadLIne());
        
        if (amount > this.balance)
        {
            return 0;
        }
        this.balance -= amount;
        
        return amount;
    }

    public float GetAccountBalance()
    {
        return this.balance;
    }
}