using System;

namespace Zoolandia.Animals
{
    public class Bear : MeatEater
    {
       string commonName = "Bear";
       string scientificName = "Bear bear";

       public override void Sound()
        {
            Console.WriteLine("Bear noises");
        }
        public override void SpecificToMeatEaters()
        {
            Console.WriteLine("I am a bear! I eat meat cuz it's tasty!");
        }
        
    }
}