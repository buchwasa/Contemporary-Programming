using System;

namespace KadaneAlgorithm
{
    public class Algorithm
    {

        /*
         * Finds the max sum subarray sum in a given array.
         */
        public static int Solve(int[] A)
        {
            // stores the maximum sum subarray found so far
            int maxSoFar = 0;

            // stores the maximum sum of subarray ending at the current position
            int maxEndingHere = 0;

            // traverse the given array
            foreach (int i in A)
            {
                // update the maximum sum of subarray "ending" at index `i` (by adding the
                // current element to maximum sum ending at previous index `i-1`)
                maxEndingHere += i;

                // if the maximum sum is negative, set it to 0 (which represents
                // an empty subarray)
                maxEndingHere = Math.Max(maxEndingHere, 0);

                // update the result if the current subarray sum is found to be greater
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
}
