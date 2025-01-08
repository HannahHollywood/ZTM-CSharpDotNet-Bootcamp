Account account1 = new Account("Hannah");
Account account2 = new Account("Ally", 20);

Console.WriteLine($"{account1.Owner}'s account has a balance of {account1.Balance}.");
Console.WriteLine($"{account2.Owner}'s account has a balance of {account2.Balance}.");

public class Account
{
    public decimal Balance { get; set; }
    public string Owner { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }
}
