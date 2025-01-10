using System.Data;
using System.Security.Principal;

Console.WriteLine("Welcome to the Accounting System 1.0.");
Console.WriteLine("---");
Console.WriteLine("");

AccountHolder checkingAccount = new AccountHolder("Hannah", "Checking Account");
AccountHolder premiumAccount = new AccountHolder("Hannah", "Premium Account");

Console.WriteLine($"The {checkingAccount.GetId()} has a balance of: ");
Console.WriteLine($"The {premiumAccount.GetId()} has a balance of: ");

public interface IBalance
{
    decimal GetBalance();
}

public class AccountHolder
{
    public string Name { get; set; }
    public string AccountType { get; set; }

    public AccountHolder(string name, string accountType)
    {
        Name = name;
        AccountType = accountType;
    }

    public virtual string GetId()
    {
        return AccountType;
    }
}

public class AccountType : AccountHolder, IBalance
{
    public int AccountId { get; set; }

    public AccountType(string name, string accountType, int accountId) : base(name, accountType)
    {
        AccountId = accountId;
    }

    public override string GetId()
    {
        return $"{AccountId}-{base.GetId()}";
    }


    public decimal GetBalance()
    {
        return 2000;
    }
}

//public class CheckingAccount
//{
//    public decimal Balance { get; set; }
//    public int UserId { get; set; }
//    public string Owner { get; set; }

//    public CheckingAccount(string owner)
//    {
//        Owner = owner;
//        UserId = 100;
//        Balance = 0;
//    }

//    public CheckingAccount(string owner, decimal balance)
//    {
//        Owner = owner;
//        Balance = balance;
//    }

//    public virtual int GetId()
//    {
//        return UserId;
//    }
//}

//public class PremiumAccount
//{
//    public decimal Balance { get; set; }
//    public int UserId { get; set; }
//    public string Owner { get; set; }

//    public PremiumAccount(string owner, int userId)
//    {
//        Owner = owner;
//        UserId = 200;
//        Balance = 0;
//    }

//    public PremiumAccount(string owner, decimal balance)
//    {
//        Owner = owner;
//        Balance = balance;
//    }

//    public virtual int GetId()
//    {
//        return UserId;
//    }
//}