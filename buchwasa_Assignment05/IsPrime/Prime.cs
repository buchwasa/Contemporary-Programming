using System;
using System.Collections.Generic;

namespace IsPrime
{
    public class Prime
    {

        /// <summary>
        /// Checks if a number is a prime
        /// </summary>
        /// <param name="number">The number to check if is prime</param>
        /// <returns>If the number is prime</returns>
        public static Boolean IsPrime(int number)
        {
            int timesHitZero = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    // Increment the amount of times hit zero to calculate if it is prime at the end of the loop
                    timesHitZero++;
                }
            }

            // If the number is divisible by itself twice, then return true
            return timesHitZero == 2;
        }

        /// <summary>
        /// Calculates all the primes of a given value
        /// </summary>
        /// <param name="maxValue">Highest value to calculate all primes of</param>
        /// <returns>A list of all primes</returns>
        public static List<int> CalculateAllPrimes(int maxValue)
        {
            List<int> primes = new List<int>();
            while (maxValue > 0)
            {
                if (IsPrime(maxValue))
                {
                    primes.Add(maxValue);
                }
                maxValue--;
            }

            return primes;
        }
    }
}
