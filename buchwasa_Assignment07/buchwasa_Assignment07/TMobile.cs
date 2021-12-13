namespace buchwasa_Assignment07
{

    public class TMobile : PhoneProvider
    {
        private bool mWasSprint;

        public bool wasSprint
        {
            get { return mWasSprint; }
            set { mWasSprint = value; }
        }

        /// <summary>
        /// Initializes the TMobile object, contains wasSprint to keep track if the provider was owned by Sprint.
        /// Sets base variable to true, as it is a GSM carrier.
        /// </summary>
        /// <param name="wasSprint">If set to true Sprint originally owned the provider</param>
        public TMobile(bool wasSprint) : base(true)
        {
            this.wasSprint = wasSprint;
        }
    }
}
