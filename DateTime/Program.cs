using System.Globalization;

DateTime dateOfBirth = new DateTime(1993, 5, 6);
Console.WriteLine(dateOfBirth.DayOfWeek);

// Computed values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing (turn date string into object)\
DateTime localDate = DateTime.Parse("06.05.1993");
DateTime usDate = DateTime.Parse("06/05/1993", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate}, usDate: {usDate}");

// DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));