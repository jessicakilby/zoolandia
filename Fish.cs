using System;

namespace Zoolandia.Animals
{
    public class Fish : Animals
    {
        public Fish()
        {
            var Fish = new Animals();
            Fish.species = "Carassius auratus";
        }

        public override void Sound()
        {
            Console.WriteLine("bluuurp");
        }

    }
}