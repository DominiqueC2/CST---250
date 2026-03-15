/*
 * Dominique Canada
 * CST - 250
 * 03/11/2026
 * Count To One Recursion
 * Activity 3
 */
using FactorialRecursion.Services.BusinessLogicLayer;
using System.Numerics;

//--------------------------------------------------
// Start of the Main Method
//--------------------------------------------------

// Declare & Initialize
FactorialLogic factorialLogic = new FactorialLogic();
int input = 0;
BigInteger iterativeAns = 0, recursiveAns = 0;

// Prompt the user
Console.WriteLine("Enter a positive number: ");
// Get the user input
input = Utility.ReadIntFromConsole();

// Solve the factorial using Iteration
Console.WriteLine("Solving the factorial using iteration...");
iterativeAns = factorialLogic.SolveIterativeFactorial(input);
Console.WriteLine($"Answer: {iterativeAns}");

// Solve the factorial using recursion
Console.WriteLine("Solving the factorial using recursion...");
recursiveAns = factorialLogic.SolveRecursiveFactorial(input);
Console.WriteLine($"Answer: {recursiveAns}");


//--------------------------------------------------
// End of the Main Method
//--------------------------------------------------


//--------------------------------------------------
// Start of Utility Class
//--------------------------------------------------
static class Utility
{
    internal static int ReadIntFromConsole()
    {
        // Declare & Initialize
        string input = "";
        int number = -1;

        // Get the current input
        input = Console.ReadLine();
        // Check if the input is valid
        while (!int.TryParse(input, out number))
        {
            // show the user an error message and prompt them again
            Console.WriteLine("Invalid input. Please try again: ");
            // Get the new input
            input = Console.ReadLine();
        }
        // return the resulting integer from the user
        return number;
    }
}