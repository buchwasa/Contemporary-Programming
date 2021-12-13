using System;

namespace buchwasa_Assignment09
{
    class Bike : Foldable, Powered
    {

        private String mType;

        public String type
        {
            get { return mType; }
            set { mType = value; }
        }

        /// <summary>
        /// Constructs a new bike
        /// </summary>
        /// <param name="bikeType">The type of the bike</param>
        public Bike(String bikeType)
        {
            type = bikeType;
        }

        /// <inheritdoc/>
        public virtual void OnPower()
        {
            Console.WriteLine("The bike is now charging your phone.");
        }

        /// <inheritdoc/>
        public virtual void OnPower(String message)
        {
            Console.WriteLine(message);
        }

        /// <inheritdoc/>
        public virtual String GetFoldSize()
        {
            return "Flat";
        }
    }
}
