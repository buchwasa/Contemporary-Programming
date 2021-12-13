using System;

namespace buchwasa_Assignment07
{
    public class PhoneProvider
    {
        private bool mIsGSM;

        public bool isGSM
        {
            get { return mIsGSM; }
            set { mIsGSM = value; }
        }

        /// <summary>
        /// Initializes a new PhoneProvider object.
        /// </summary>
        /// <param name="isGSM">If set to true, the phone provider is a GSM provider</param>
        public PhoneProvider(bool isGSM)
        {
            this.isGSM = isGSM;
        }

        /// <summary>
        /// Gets the short name of the parent class
        /// </summary>
        /// <returns>The parent class name.</returns>
        public String GetParentName()
        {
            String type = this.GetType().BaseType.ToString();
            return type.Substring(type.IndexOf(".") + 1);
        }

        /// <summary>
        /// Gets the short name of the class
        /// </summary>
        /// <returns>The short name of the class</returns>
        public override String ToString()
        {
            String type = this.GetType().ToString();
            return type.Substring(type.IndexOf(".") + 1);
        }
    }
}
