using System;
using System.Collections.Generic;
using IsPrime;

namespace buchwasa_Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1000, b = 1000;
            Console.WriteLine($"The sum of all primes between A ({a}) and B ({b}) is: " + CalculatePrimeSum(a, b));
        }


        /// <summary>
        /// Calculates the sum of all primes and primes +- 1.
        /// </summary>
        /// <param name="a">Max value of the first value to calulcate primes of</param>
        /// <param name="b">Max value of the second value to calculate primes of</param>
        /// <returns>The sum</returns>
        public static int CalculatePrimeSum(int a, int b)
        {
            int result = 0;
            List<int> calculatedAPrime = Prime.CalculateAllPrimes(a);
            List<int> calculatedBPrime = Prime.CalculateAllPrimes(b);

            foreach (int primeA in calculatedAPrime) //Iterate through the prime list of a
            {
                foreach (int primeB in calculatedBPrime)
                {
                    int addedNumbers = primeA + primeB;
                    int addedSum = addedNumbers + 1;
                    int subtractedSum = addedNumbers - 1;
                    if (Prime.IsPrime(subtractedSum) && Prime.IsPrime(addedSum))
                    {
                        result += (subtractedSum + addedSum); //Add their sums to the result number
                    }
                }
            }

            return result;
        }
    }
}
