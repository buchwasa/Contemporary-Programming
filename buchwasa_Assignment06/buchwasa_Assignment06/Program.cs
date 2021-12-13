using System;

namespace buchwasa_Assignment06
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish bass = new Fish();
            Net smallNet = new Net();
            smallNet.size = "Small";
            bass.type = "Bass";

            FishNet netWithABass = smallNet + bass;
            Console.WriteLine($"The {netWithABass.size} net caught a {netWithABass.type}!");
        }
    }
}
