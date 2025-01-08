ICar tesla = new TeslaModelS();
ICar nissan = new NissonMicra();

Console.WriteLine($"{tesla.GetModel()}: {tesla.GetTopSpeed()} km/h");
Console.WriteLine($"{nissan.GetModel()}: {nissan.GetTopSpeed()} km/h");

public interface ICar
{
    string GetModel();
    int GetTopSpeed();
}

public class TeslaModelS : ICar
{
    public string GetModel()
    {
        return "Tesla Model S";
    }

    public int GetTopSpeed()
    {
        return 282;
    }
}

public class NissonMicra : ICar
{
public string GetModel()
    {
        return "Nissan Micra";
    }

    public int GetTopSpeed()
    {
        return 186;
    }
}