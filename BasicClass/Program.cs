Person person1 = new Person("Hannah");
Person person2 = new Person("Beth");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();

string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

int result = Math.Sum(14, 16);
Console.WriteLine(result);
Console.WriteLine(Math.PI);

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

public static class Math
{
    public static double PI
    {
        get { return 3.14d;  }
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}


// --- First example in video:

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