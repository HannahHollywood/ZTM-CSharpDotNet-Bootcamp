var person1 = new Person("Hannah", "Parker");
var person2 = new Person("Ally", "Moore");

if (person1 == person2)
{
    Console.WriteLine("Persons are equal.");
}
else
{
    Console.WriteLine("These are different people.");
}

public record Person(string FirstName, string LastName);
public record Employee(): Person("First", "Last");