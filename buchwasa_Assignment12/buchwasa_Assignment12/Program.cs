using System;

namespace buchwasa_Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkTotientSum = Math.Math.CalculateTotientSumInPrimes(10000);
            Console.WriteLine($"The totient sum of 10,000 is: {checkTotientSum}");
        }
    }
}
