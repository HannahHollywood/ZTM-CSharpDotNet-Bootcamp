int[] array1 = new int[4];

array1[0] = 7;
array1[1] = 16;
array1[2] = 21;
array1[3] = 27;

Console.WriteLine(array1);
Console.WriteLine(array1[0]);

// Array initialiser
var array2 = new int[] {7, 16, 21, 27};

Console.WriteLine(array1);
Console.WriteLine(array1[0]);

// Alternative syntax
int[] array3 = { 7, 16, 21, 27 };

Console.WriteLine(array1);
Console.WriteLine(array1[0]);

// Uninitialised elements (will print 0)
int[] array4 = new int[5];
Console.WriteLine($"This will print zero: {array4[0]}");

Person[] persons = new Person[2];
persons[0] = new Person("Hannah");
persons[1] = new Person("Ally");

Console.WriteLine(persons);
var person0 = persons[0];
Console.WriteLine(person0.Name);

// This will print out each person in the list
foreach(Person person in persons)
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