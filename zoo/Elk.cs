using System;

namespace Zoolandia.Animals
{
    public class Elk : GrassEater
    {
        string commonName = "Elk";
        string scientificName = "Elk elk";
        public override void Sound()
        {
            Console.WriteLine("Elk noises");
        }
        public override void SpecificToGrassEaters()
        {
            Console.WriteLine("I am an Elk! I eat grass and hay because meat eaters are mean!");
        }

    }
}