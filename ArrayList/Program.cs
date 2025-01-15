using System.Collections;

var arrayList = new ArrayList();

var day = 22;
arrayList.Add(day);

var person1 = new Person("Hannah");
arrayList.Add(person1);

var firstElement = arrayList[0];
Console.WriteLine($"First Element: {firstElement}, Name: {person1.Name}");

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}