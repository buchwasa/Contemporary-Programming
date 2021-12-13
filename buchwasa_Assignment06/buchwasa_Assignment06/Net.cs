using System;

namespace buchwasa_Assignment06
{
    class Net
    {
        private String mSize;

        /// <summary>
        /// The size of the net
        /// </summary>
        public String size 
        { 
            get { return mSize; }
            set { mSize = value; }
        }

        public static FishNet operator+(Net net, Fish fish)
        {
            return new FishNet(net.size, fish.type);
        }
    }
}
