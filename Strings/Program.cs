string message = "Hello World";
Console.WriteLine(message);

// empty string
string emptyMessage = string.Empty;

string stringWithDoubleQuote = "This is a string with a double quote: \" ";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);

// string length
Console.WriteLine(filePath.Length);

//
string firstName = "Hannah";
string lastName = "Becker";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// string interpolation
string fullNameInterpolated = $"{firstName} {lastName}";
Console.WriteLine(fullNameInterpolated);
Console.WriteLine($"The result is {5 * 7}");

// Substrings
string first5Characters = fullName.Substring(0, 4);
Console.WriteLine(first5Characters);