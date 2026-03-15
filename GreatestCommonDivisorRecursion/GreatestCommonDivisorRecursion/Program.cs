/*
 * Dominique Canada
 * CST - 250
 * 03/13/2026
 * Greatest Common Divisor Recursion
 * Activity 3
 */

using System.Diagnostics;

//-----------------------------------------------------
// Start 
//-----------------------------------------------------
// Declare & Initialiize
int number1 = 0, number2 = 0, result = 0;
string input = "";
Stopwatch sw = new Stopwatch();

Console.Write("Enter the first number: ");
input = Console.ReadLine();

while (!int.TryParse(input, out number1))
{
    Console.WriteLine("Invalid number");
    Console.Write("Enter the first number: ");
    input = Console.ReadLine();
}

Console.Write("Enter the second number: ");
input = Console.ReadLine();

while (!int.TryParse(input, out number2))
{
    Console.WriteLine("Invalid number");
    Console.Write("Enter the second number: ");
    input = Console.ReadLine();
}

//Call the GCD method
result = Utility.GreatestCommonDivisor(number1, number2);

// Print the result to the user
Console.WriteLine($"The GCD of {number1} and {number2} is {result}");

int iterativeResult = Utility.IterativeGCD(number1, number2);

Console.WriteLine($"The Iterative GCD of {number1} and {number2} is {iterativeResult}");

// Extend to Multiple Numbers Challenge
int multi = Utility.GCDMultiple(440, 80, 20);

Console.WriteLine($"GCD of three numbers: {multi}");

sw.Start();
result = Utility.GreatestCommonDivisor(number1, number2);
sw.Stop();

Console.WriteLine($"Recursive GCD: {result}");
Console.WriteLine($"Recursive Time: {sw.ElapsedMilliseconds} ms");

sw.Restart();
iterativeResult = Utility.IterativeGCD(number1, number2);
sw.Stop();

Console.WriteLine($"Iterative GCD: {iterativeResult}");
Console.WriteLine($"Iterative Time: {sw.ElapsedMilliseconds} ms");

//-----------------------------------------------------
// End 
//-----------------------------------------------------

//-----------------------------------------------------
// Start of Utility Class
//-----------------------------------------------------
public class Utility
{
    /// <summary>
    /// Calculate the GCD using recursion
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    internal static int GreatestCommonDivisor(int num1, int num2)
    {
        // Declare & Initialiize
        int remainder = 0;

        //Base case: num2 is 0
        if (num1 == 0 || num2 == 0)
        {
            // Return the greatest common divisor
            return num1;
        }
        else
        {
            // Get the reminder of dividing num1 and num2
            remainder = num1 % num2;
            // Print an update to user
            Console.WriteLine($"Not yet. The remainder of {num1} and {num2} is {remainder}");
            // call the recursive function of the second number and the remiander
            return GreatestCommonDivisor(num2, remainder);
        }
    }

    internal static int IterativeGCD(int num1, int num2)
    {
        int remainder = 0;

        while (num2 != 0)
        {
            remainder = num1 % num2;
            num1 = num2;
            num2 = remainder;
        }

        return num1;
    }

    internal static int GCDMultiple(int num1, int num2, int num3)
    {
        int first = GreatestCommonDivisor(num1, num2);
        return GreatestCommonDivisor(first, num3);
    }
}