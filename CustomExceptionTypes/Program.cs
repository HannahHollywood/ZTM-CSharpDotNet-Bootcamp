﻿using CustomExceptionTypes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter username: ");
        var userInput = Console.ReadLine();

        try
        {
            var username = GetNormalisedUsername(userInput);
            Console.WriteLine($"Username: {username}");
        }
        catch (InvalidUsernameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static string GetNormalisedUsername(string? username)
    {
        if (string.IsNullOrEmpty(username) || username.Length < 6)
        {
            throw new InvalidUsernameException(username);
        }

        return username.ToLower();
    }
}