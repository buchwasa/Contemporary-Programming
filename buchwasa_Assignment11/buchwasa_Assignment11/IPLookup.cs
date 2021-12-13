using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace buchwasa_Assignment11
{
    class IPLookup
    {

        private string mIp;

        public string ip
        {
            get { return mIp; }
            set { mIp = value; }
        }

        public IPLookup(string ipAddress)
        {
            ip = ipAddress;
        }

        /// <summary>
        /// Collects information about the IP
        /// </summary>
        public void RetrieveData()
        {
            string url = $"http://ip-api.com/json/{ip}";
            WebClient client = new WebClient();
            string json = client.DownloadString(url);
            JObject parsedJson = JObject.Parse(json);

            Console.WriteLine($"Looking up data for {ip}");
            Console.WriteLine("-------");
            Console.WriteLine("Location: " + parsedJson["regionName"].ToString() + ", " + parsedJson["country"].ToString());
            Console.WriteLine("Timezone: " + parsedJson["timezone"]);
            Console.WriteLine("ISP: " + parsedJson["isp"]);
            Console.WriteLine("-------");
        }
    }
}
