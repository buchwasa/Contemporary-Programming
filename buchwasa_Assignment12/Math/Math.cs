namespace Math
{
    public class Math
    {
        /// <summary>
        /// Checks if a number is a prime
        /// </summary>
        /// <param name="number">The number to check if is prime</param>
        /// <returns>If the number is prime</returns>
        public static bool IsPrime(int number)
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
        /// Calculates the greatest common divisor between 2 numbers
        /// </summary>
        /// <param name="first">The first input</param>
        /// <param name="second">The second input</param>
        /// <returns>The greatest common divisor</returns>
        public static int CalculateGCD(int first, int second)
        {
            if (first == 0) // If the first number is 0, the second is the gcd
            {
                return second;
            }

            // Take the remainder of the second and first number and use that as the new first
            return CalculateGCD(second % first, first);
        }

        /// <summary>
        /// Calculates the totient in a given number
        /// </summary>
        /// <param name="number">The number to calculate</param>
        /// <returns>The totient</returns>
        public static int CalculateTotient(int number)
        {
            int result = 1; // We always have at least 1 result
            for (int i = 2; i < number; i++)
            {
                if (CalculateGCD(i, number) == 1) // If the gcd between i and the given number is 1, we have a result
                {
                    result++;
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates the totient sum in a given prime bound
        /// </summary>
        /// <param name="primeBound">Max primes to find</param>
        /// <returns>The totient sum</returns>
        public static int CalculateTotientSumInPrimes(int primeBound)
        {
            int sum = 0;
            int primesFound = 0;
            int index = 0;
            while (primesFound < primeBound) // Run while the total primes found is less than the specified limit
            {
                if (IsPrime(index)) // Prime found, calculate the totient and increment primes found
                {
                    sum += CalculateTotient(index);
                    primesFound++;
                }

                index++;
            }

            return sum;
        }
    }
}
