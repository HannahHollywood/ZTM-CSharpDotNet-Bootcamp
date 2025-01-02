bool keepOpen = true;

while (keepOpen)
{
    Console.WriteLine("Welcome to the C# Console-Based Calculator!");
    Console.WriteLine(">> Type 'exit' to quit.");
    Console.WriteLine("--");

    Console.WriteLine("Please enter what calculation method you'd like to use (add, subtract, divide or multiply): ");
    string? calculationMethod = Console.ReadLine()?.ToLower();

    if (calculationMethod == "exit")
    {
        keepOpen = false;
        Console.WriteLine("Thank you for using the calculator. Goodbye!");
        break;
    }

    Console.WriteLine("--");

    Console.WriteLine("Enter the first number:");
    double number1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    double number2 = double.Parse(Console.ReadLine());

    switch (calculationMethod)
    {
        case "add":
        case "addition":
        case "plus":
            Console.WriteLine("--");
            Console.WriteLine($"The result of the addition is: {number1 + number2}");
            break;

        case "subtract":
        case "subtraction":
            Console.WriteLine("--");
            Console.WriteLine($"The result of the subtraction is: {number1 - number2}");
            break;

        case "multiply":
        case "multiplication":
            Console.WriteLine("--");
            Console.WriteLine($"The result of the multiplication is: {number1 * number2}");
            break;

        case "divide":
        case "division":
            if (number2 != 0)
            {
                Console.WriteLine("--");
                Console.WriteLine($"The result of the division is: {number1 / number2}");
            }
            else
            {
                Console.WriteLine("--");
                Console.WriteLine("You cannot divide by zero! >:|");
            }
            break;

        default:
            Console.WriteLine("--");
            Console.WriteLine("Invalid calculation method selected. Please choose add, subtract, divide or multiply");
            break;
    }

    Console.WriteLine("--");
}
