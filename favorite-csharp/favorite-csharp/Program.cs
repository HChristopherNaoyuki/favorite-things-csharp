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
