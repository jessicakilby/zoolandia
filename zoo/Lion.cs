using System;

namespace Zoolandia.Animals
{
    public class Lion : MeatEater
    {
        string commonName = "Lion";
        string scientificName = "Lion lion";
        public override void Sound()
        {
            Console.WriteLine("Lion noises");
        }
        public override void SpecificToMeatEaters()
        {
            Console.WriteLine("I am a Lion! I eat meat cuz it's tasty!");
        }
    }
}