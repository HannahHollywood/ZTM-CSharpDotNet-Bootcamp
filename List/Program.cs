using static System.Runtime.InteropServices.JavaScript.JSType;

var numbers = new List<int>();
var day = 22;
numbers.Add(day);

foreach (var number in numbers)
{
    Console.WriteLine($"Number: {number}");
}

var persons = new List<Person>();
var person1 = new Person("Hannah");
persons.Add(person1);

foreach (var person in persons)
{
    Console.WriteLine($"Name: {person.Name}");
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}