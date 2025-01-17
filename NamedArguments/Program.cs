using ExtensionMethods.Extensions;

var person1 = new Person("Jack", 24, 19);
var person2 = new Person(name: "Hannah", age: 24, luckyNumber: 19);
var person3 = new Person("Ally", age: 24, luckyNumber: 19);

// Optional Args:
var person4 = new Person("Sophie", age: 24);
// Will print 7
Console.WriteLine(person4.LuckyNumber);

var person5 = new Person("Lydia", age: 30, favouriteColour: "red");
Console.WriteLine($"{person5.Name}'s favourite colour is {person5.FavouriteColour}");

// Using Extension Method:
var extensionPerson = new Person("Lulu", age: 25, luckyNumber: 8, favouriteColour: "blue");
Console.WriteLine(extensionPerson.ToAllPersonDetails());    

public class Person
{
    public Person(string name, int age, int luckyNumber = 7, string favouriteColour = "blue")
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
        FavouriteColour = favouriteColour;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
    public string FavouriteColour { get; set; }
}