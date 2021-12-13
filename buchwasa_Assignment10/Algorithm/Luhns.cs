using System;

namespace Algorithm
{
    public class Luhns
    {
        
        /// <summary>
        /// Checks if a card is valid
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns>True if the card is valid</returns>
        public static bool ValidateCard(String cardNumber)
        {
            int cardLength = cardNumber.Length;
 
            int sum = 0;
            bool isSecond = false;
            for (int i = cardLength - 1; i >= 0; i--)
            {
                int digit = cardNumber[i] - '0';

                if (isSecond)
                {
                    // Double every 2nd digit
                    digit *= 2;
                }
                
                sum += digit / 10;
                sum += digit % 10;
 
                isSecond = !isSecond; //Set it to the opposite of its current valid, switches back and forth between true and false
            }
            
            // If a multiple of 10, card is valid
            return (sum % 10 == 0);
        }
    }
}