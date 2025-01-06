//Person person1 = new Person();
//Person person2 = new Person();

//person1.Name = "Beth";
//Console.WriteLine(person1.Name);

//class Person
//{
//    private string _name;

//    // type `ctor` to auto generate class:
//    public Person()
//    {
//        _name = "Hannah";
//    }

//    public string Name
//    {
//        get {  return _name; }
//        set {  _name = value; }
//    }
//}


Person person1 = new Person("Hannah");
Person person2 = new Person("Beth");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();

string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

Math math = new Math();
int result = math.Sum(14, 16);
Console.WriteLine(result);

class Person
{

    // type `ctor` to auto generate class:
    public Person(string name)
    {
        Name = name;
    }

    // set private to ensure you can't set the name value outside of the Person constructor params
    public string Name { get; private set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}!");
    }

    public string GetGreeting()
    {
        return $"Hello, {Name}!";
    }
}

public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}