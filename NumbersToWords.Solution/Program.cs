using NumbersToWords.Models;

namespace NumbersToWords;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        long userInput = long.Parse(Console.ReadLine());
        Console.WriteLine(StringBuilder.GetString(userInput));
        Console.WriteLine("\nPress 'n' to run again or any key to exit");
        string userInput2 = Console.ReadLine().ToLower();
        if (userInput2 == "n")
        {
            Main();
        }
    }
}
