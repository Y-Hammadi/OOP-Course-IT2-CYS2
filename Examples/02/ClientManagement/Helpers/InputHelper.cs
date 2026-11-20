
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ClientManagement.Helpers;

public static class InputHelper
{
  // Read an integer
  public static int ReadNumber(string message = "Enter a number: ")
  {
    while (true)
    {
      Console.Write(message);

      string? input = Console.ReadLine();

      if (int.TryParse(input, out int number))
        return number;

      Console.WriteLine("Invalid number! Please try again.");
    }
  }

  // Read an integer between two numbers
  public static int ReadNumber(int min, int max)
  {
    while (true)
    {
      int number = ReadNumber(
          $"Enter a number between {min} and {max}: "
      );

      if (number >= min && number <= max)
        return number;

      Console.WriteLine(
          $"Number must be between {min} and {max}."
      );
    }
  }

  // Read non-empty text
  public static string ReadText(string message = "Enter text: ")
  {
    while (true)
    {
      Console.Write(message);

      string? input = Console.ReadLine();

      if (!string.IsNullOrWhiteSpace(input))
        return input.Trim();

      Console.WriteLine("Input cannot be empty!");
    }
  }

  // Read phone number
  public static string ReadPhoneNumber()
  {
    while (true)
    {
      Console.Write("Enter phone number: ");

      string? input = Console.ReadLine()?.Trim();

      if (!string.IsNullOrWhiteSpace(input))
      {
        string phone = input.Replace(" ", "")
                            .Replace("-", "");

        if (Regex.IsMatch(phone, @"^\+?[0-9]{7,15}$"))
          return phone;
      }

      Console.WriteLine("Invalid phone number! Please try again.");
    }
  }

  // Read email
  public static string ReadEmail()
  {
    while (true)
    {
      Console.Write("Enter email: ");

      string? input = Console.ReadLine()?.Trim();

      if (!string.IsNullOrWhiteSpace(input))
      {
        try
        {
          var email = new MailAddress(input);

          if (email.Address == input)
            return input;
        }
        catch (FormatException)
        {
          // Invalid email format
        }
      }

      Console.WriteLine("Invalid email! Please try again.");
    }
  }

  // Clear console screen
  public static void ClearScreen()
  {
    Console.Clear();
  }

  // Read Yes or No
  public static bool ReadYesNo(string message = "Continue? (Y/N): ")
  {
    while (true)
    {
      Console.Write(message);

      string? input = Console.ReadLine()?.Trim().ToLower();

      if (input == "y" || input == "Y")
        return true;

      if (input == "n" || input == "N")
        return false;

      Console.WriteLine("Invalid input! Please enter Y or N.");
    }
  }
  // Pause execution
  public static void Pause()
  {
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
  }
}
