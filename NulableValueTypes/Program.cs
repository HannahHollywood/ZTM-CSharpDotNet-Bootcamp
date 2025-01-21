//int? age = 7;
int? age = null;

if (age.HasValue)
{
    Console.WriteLine(age.Value);
}
else
{
    Console.WriteLine("Age is not defined");
}