using System;

namespace buchwasa_Assignment09
{
    interface Powered
    {
        /// <summary>
        /// Sends a message when a item is powered
        /// </summary>
        /// <param name="message">The message</param>
        void OnPower(String message);

        /// <summary>
        /// Called when an item is powered
        /// </summary>
        void OnPower();
    }
}
