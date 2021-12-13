using System;
using System.Collections.Generic;

namespace buchwasa_Assignment07
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            // Store a list of phone providers
            List<PhoneProvider> phoneProviders = new List<PhoneProvider>();
            phoneProviders.Add(new Boost());
            phoneProviders.Add(new Cricket());
            phoneProviders.Add(new Mint());
            phoneProviders.Add(new Visible());

            foreach(PhoneProvider provider in phoneProviders)
            {
                //If the provider is TMobile, check if they were originally from sprint or not
                if (provider is TMobile) {
                    Console.WriteLine(provider + (((TMobile)provider).wasSprint ? " was" : " was not") + " owned by Sprint.");
                }

                Console.WriteLine($"{provider} (parent company {provider.GetParentName()}) " + (provider.isGSM ? "is" : "is not") + " a GSM carrier");
            }
        }
    }
}
