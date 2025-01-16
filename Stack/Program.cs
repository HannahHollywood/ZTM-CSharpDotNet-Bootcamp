var countries = new Stack<string>();

countries.Push("Australia");
countries.Push("UK");
countries.Push("Malta");
countries.Push("Denmark");

var lastCountry = countries.Pop();
Console.WriteLine($"The last country I visited: {lastCountry}");

var previouslyVisitedCountry = countries.Peek();
Console.WriteLine($"The previously visited country I visited: {previouslyVisitedCountry}");

foreach (var country in countries)
{
    Console.WriteLine(country);
}



