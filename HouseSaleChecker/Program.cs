Console.WriteLine("House Sale Checker");
Console.WriteLine("This project showcases a basic use-case for a C# class. \nI define a House class to show what year it was built, then reveals if it can be sold based on age.");

Console.WriteLine("");
Console.WriteLine("Enter the property name:");
string houseName1 = Console.ReadLine();

Console.WriteLine($"Enter the year {houseName1} was constructed:");
int yearBuilt = int.Parse(Console.ReadLine());

Console.WriteLine($"Enter size of {houseName1} in square meters:");
int size = int.Parse(Console.ReadLine());

House myHouse = new House(houseName1, yearBuilt, size);

Console.WriteLine("--");

int houseAgeResult = myHouse.HowOld();

Console.WriteLine("");
Console.WriteLine($"{houseName1} is {houseAgeResult} year's old.");
Console.WriteLine("--");

string canCannot = myHouse.CanBeSold() ? "can" : "cannot";
Console.WriteLine($"{houseName1} {canCannot} be sold.");

class House
{
    public House(string houseName, int yearBuilt, int size)
    {
        HouseName = houseName;
        YearBuilt = yearBuilt;
        Size = size;
    }

    public int HowOld()
    {
        int currentYear = DateTime.Today.Year;
        return currentYear - YearBuilt;
    }

    public bool CanBeSold()
    {
        return (this.HowOld() < 15);
    }

    public string HouseName { get; private set; }
    public int YearBuilt { get; private set; }
    public int Size { get; private set; }
}


