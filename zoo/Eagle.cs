using System;

namespace Zoolandia.Animals
{
    public class Eagle : MeatEater
    {
         string commonName = "Eagle";
         string scientificName = "Eagle eagle";
         public override void Sound()
        {
            Console.WriteLine("Eagle noises");
        }
         public override void SpecificToMeatEaters()
        {
            Console.WriteLine("I am an Eagle! I eat meat cuz it's tasty!");
        }
    }
}
