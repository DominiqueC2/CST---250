/*
 * Dominique Canada
 * CST - 250
 * 03/11/2026
 * Count To One Recursion
 * Activity 3
 */

//--------------------------------------------------
// Start of the Main Method
//--------------------------------------------------

// Declare & Initialize
int choice = 0, result = 0;
string input = "";

// Prompt the user for a number
Console.Write("Enter a positive number: ");
// Get the user input
input = Console.ReadLine();
// See if the user entered valid input
while(!int.TryParse(input, out choice))
{
    Console.WriteLine("Invalid number");
    //re-prompt the user for a number
    Console.Write("Enter a positive number: ");
    // Get the users input
    input = Console.ReadLine();
}
// CAll the CountToOne function
result = Utility.CountToOne(choice, 0);
Console.WriteLine($"The end number is {result}");

//--------------------------------------------------
// End of the Main Method
//--------------------------------------------------
static class Utility 
{
    /// <summary>
    /// Count to one using recursion
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    internal static int CountToOne(int num, int steps)
    {
        // Print out the current number
        Console.WriteLine($"The current number is {num}");
        // check if the number is 1
        if (num == 1)
        {
            Console.WriteLine($"The Total Steps: {steps}");
            return 1;
        }
        steps++;

        if (num < 0)
        {
            Console.WriteLine("Negative number turn positive");
            num = Math.Abs(num);
        }

        if (num == 0)
        {
            Console.WriteLine("Zero. add 1");
            return CountToOne(num + 1, steps);
        }


        // check if the number is
        if (num == 5)
        {
            Console.WriteLine("Number is 5. Follow odd rule.");
            return CountToOne(num - 1, steps);
        }

        // divisible by 5 rule
        if (num % 5 == 0)
        {
            Console.WriteLine("Divisible by 5. Multiply by 2.");
            return CountToOne(num * 2, steps);
        }

        else if (num % 4 == 0)
        {
            Console.WriteLine("The number is even. Divide by 4");
            return CountToOne(num / 4, steps);
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("The number is even. Divide by 3");
            return CountToOne(num / 3, steps);
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("The number is even. Divide by 2");
            return CountToOne(num / 2, steps);
        }
        else
        {
            Console.WriteLine("The number is odd. Subtract 1");
            // add 1 and call the function
            return CountToOne(num - 1, steps);
        }



    }
}