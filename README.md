# Favorite Things

A simple C# console application that prompts the user to enter their favorite color, food, and number, then displays the entered details in a formatted message. The program includes exception handling and is well-commented for easy understanding.

## Features

- Prompts the user to enter their favorite color, food, and number.
- Displays the entered details in a formatted message.
- Exception handling for invalid input.
- Clear and concise comments throughout the code.

## Code Example

```csharp
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter their favorite color
                Console.Write("Enter your favorite color: ");
                string favoriteColor = Console.ReadLine();

                // Prompt the user to enter their favorite food
                Console.Write("Enter your favorite food: ");
                string favoriteFood = Console.ReadLine();

                // Prompt the user to enter their favorite number
                Console.Write("Enter your favorite number: ");
                string favoriteNumberInput = Console.ReadLine();
                int favoriteNumber = int.Parse(favoriteNumberInput);

                // Display the entered details in a formatted message
                Console.WriteLine("********************************");
                Console.WriteLine($"Favorite color: {favoriteColor}");
                Console.WriteLine($"Favorite food: {favoriteFood}");
                Console.WriteLine($"Favorite number: {favoriteNumber}");
                Console.WriteLine("********************************");
            }
            catch (FormatException ex)
            {
                // Handle format exception if the input is not a valid number
                Console.WriteLine("Error: The input for the favorite number is not a valid number.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }
    }
}
```

## Exception Handling

The program includes exception handling to ensure that it can gracefully handle invalid input. Specifically, it catches `FormatException` if the input for the favorite number is not a valid number and provides a clear error message. It also catches any other exceptions and provides a generic error message.

---
