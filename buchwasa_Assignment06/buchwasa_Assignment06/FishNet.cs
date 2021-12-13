using System;

namespace buchwasa_Assignment06
{
    class FishNet
    {
        private String mSize;
        private String mType;

        /// <summary>
        /// The size of the net
        /// </summary>
        public String size
        {
            get { return mSize; }
            set { mSize = value; }
        }

        /// <summary>
        /// The type of fish in a net
        /// </summary>
        public String type
        {
            get { return mType; }
            set { mType = value; }
        }

        public FishNet(String size, String type)
        {
            this.size = size;
            this.type = type;
        }
    }
}
