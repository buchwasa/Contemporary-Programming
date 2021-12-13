using System;
using WebServiceClient.MathServiceNamespace;

namespace WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServiceSoapClient client = new MathServiceSoapClient();
            int sum = client.Add(1, 2);
            Console.WriteLine(sum);
        }
    }
}
