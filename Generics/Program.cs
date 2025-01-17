var cities = new RandomItemGenerator<string>();
cities.Add("Brisbane");
cities.Add("Sydney");
cities.Add("Perth");

for (int i = 0; i < 10; i++)
{
    var randomCity = cities.Get();
    Console.WriteLine(randomCity);
}

var numbers = new RandomItemGenerator<int>();
numbers.Add(7);
numbers.Add(10);
numbers.Add(23);
numbers.Add(54);

for (int i = 0; i < 10; i++)
{
    var randomNumber = numbers.Get();
    Console.WriteLine(randomNumber);
}

public class RandomItemGenerator<T>
{
    private readonly List<T> _items = new List<T>();
    private readonly Random _random = new Random();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get()
    {
        var index = _random.Next(0, _items.Count);
        return _items[index];
    }
}