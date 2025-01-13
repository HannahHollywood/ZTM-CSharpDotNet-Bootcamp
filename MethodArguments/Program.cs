var rectangle = new Rectangle(200, 300);
Console.WriteLine($"Rectangle Height: {rectangle.Height}mm");
Console.WriteLine("");

// If we don't add 'ref' to the rectangle, the output will be '300mm'
//MethodParameters.ChangeHeight(rectangle);
//Console.WriteLine($"So Rectangle Height is now: {rectangle.Height}mm");

// This is just a reference, so it will now use the Height from the ChangeHeight and print out '500mm'
MethodParameters.ChangeHeight(ref rectangle);
Console.WriteLine($"So Rectangle Height is now: {rectangle.Height}mm");

Console.WriteLine("--");
Console.WriteLine("--");

var person = new Person("Hannah-Beth");
Console.WriteLine($"Name: {person.Name}");

// Should print "Unknown" if not a ref or a person
//MethodParameters.ChangeName(person);
//Console.WriteLine($"Name: {person.Name}");

// This is a reference, so should now print out "Ally Moore"
MethodParameters.ChangeName(ref person);
Console.WriteLine($"New Persons' Name: {person.Name}");

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

    public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }
}

public class MethodParameters
{
    public static void ChangeName(ref Person person)
    {
        person.Name = "Unknown";
        person = new Person("Ally Moore");
    }

    public static void ChangeHeight(ref Rectangle rectangle)
    {
        rectangle.Height = 500;
        Console.WriteLine($"Rectangle height in Method: {rectangle.Height}");
    }
}