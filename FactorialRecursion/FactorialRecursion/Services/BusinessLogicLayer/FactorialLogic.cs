/*
 * Dominique Canada
 * CST - 250
 * 03/11/2026
 * Factorial Recursion
 * Activity 3
 */
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FactorialRecursion.Services.BusinessLogicLayer
{
    internal class FactorialLogic
    {
        /// <summary>
        /// Solve the factorial problem using Iteration
        /// </summary>
        /// <param name="factotial"></param>
        /// <returns></returns>
        internal BigInteger SolveIterativeFactorial (int factotial)
        {
            // Declare & Initialize
            BigInteger result = 1;

            // For loop to solve the factorial
            for(int i = factotial; i>= 1; i--)
            {
                // Multiply the result by 1
                result *= i;
            }
            //Return the result
            return result;
        }

        /// <summary>
        /// Solve the factorial problem using recursion
        /// </summary>
        /// <param name="factotial"></param>
        /// <returns></returns>
        internal BigInteger SolveRecursiveFactorial(int factotial)
        {
            // Base Case: factotial is 0 or 1
            if (factotial == 0 || factotial == 1)
            {
                return 1;
            }
            //Return the result
            return factotial * SolveRecursiveFactorial(factotial - 1);
        }
    }
}
