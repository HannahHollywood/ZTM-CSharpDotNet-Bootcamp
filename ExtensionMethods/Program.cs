using ExtensionMethods.Extensions;

var person1 = new Person("Ally", "Moore");
Console.WriteLine(person1.ToFullName());
Console.WriteLine(person1.HasId());

public interface IIdentification
{
    int Id { get; }
}

public class Person : IIdentification
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Id
    {
        get 
        { 
            return 7; 
        }
    }
}