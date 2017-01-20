using System;

namespace Zoolandia.Animals
{
    public class Fish : Animals
    {
        public Fish()
        {
            var Fish = new Animals();
            this.Species = "Carassius auratus";
        }
        public Fish(string species)
        {
           base.Species = species;
        }
        public void MyFish(string name)
        {
            this.Name = name;
        }

        public override void Sound()
        {
            Console.WriteLine("bluuurp");
        }
        public Fish(int weight)
        {
            this.Weight = weight;
        }

    }
}