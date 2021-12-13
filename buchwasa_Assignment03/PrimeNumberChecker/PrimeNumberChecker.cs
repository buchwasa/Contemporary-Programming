using System;

namespace PrimeNumberChecker
{
    public class PrimeNumberChecker
    {

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
    }
}
