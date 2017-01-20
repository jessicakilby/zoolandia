using System;

namespace Zoolandia.Animals
{
    public class Horse : GrassEater
    {
        string commonName = "Horse";
        string scientificName = "Horse horse";
        public override void Sound()
        {
            Console.WriteLine("Horse noises");
        }
        public override void SpecificToGrassEaters()
        {
            Console.WriteLine("I am a horse! I eat grass and hay because meat eaters are mean!");
        }
    }
}