namespace buchwasa_Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            IPLookup cloudflare = new IPLookup("1.1.1.1");
            IPLookup google = new IPLookup("8.8.8.8");

            cloudflare.RetrieveData();
            google.RetrieveData();
        }
    }
}
