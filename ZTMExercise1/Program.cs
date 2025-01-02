using System.Globalization;

// Happy Birthday Message Exercise:

Console.WriteLine("When is your birthday?: ");
string? input = Console.ReadLine();

DateTime birthday = DateTime.ParseExact(input, "dd/MM/yyyy", null);

DateTime today = DateTime.Today;
int age = today.Year - birthday.Year;

bool isBirthday = birthday.Month == today.Month && birthday.Day == today.Day;

switch (isBirthday)
{
    case true:
        Console.WriteLine($"Happy Birthday! You are {age} years old today!");
        break;

    default:
        Console.WriteLine($"Today isn't your birthday :( You turn {age} later this year.");
        break;
}