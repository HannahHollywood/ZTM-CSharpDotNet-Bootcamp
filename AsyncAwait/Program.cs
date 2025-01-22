Console.WriteLine("Program started.");

//await Task.Delay(5000);
await LongRunningTaskAsync();
var number = await Calculate();
Console.WriteLine($"   The meaning of life is: {number}!");

Console.WriteLine("Program finished.");

async Task LongRunningTaskAsync()
{
    Console.WriteLine("   Tasking starting...");
    await Task.Delay(5000);
    Console.WriteLine("   Task finished.");
}

async Task<int> Calculate()
{
    await Task.Delay(2000);
    return 42;
}
