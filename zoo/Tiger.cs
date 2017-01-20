using System;

namespace Zoolandia.Animals
{
    public class Tiger : MeatEater
    {
        string commonName = "Tiger";
        string scientificName = "Tiger tiger";
        public override void Sound()
        {
            Console.WriteLine("Tiger noises");
        }
        public override void SpecificToMeatEaters()
        {
            Console.WriteLine("I am a Tiger! I eat meat cuz it's tasty!");
        }
    }
}