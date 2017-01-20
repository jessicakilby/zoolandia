using System;

namespace Zoolandia.Animals
{
    public class Rabbit : Animals
    {
        public Rabbit()
        {
            var Rabbit = new Animals();
            this.Species = "Oryctolagus cuniculus";
        }
        // public Rabbit(string species)
        // {
        //    base.Species = species;
        // }
        public Rabbit(string name)
        {
            this.Name = name;
        }
        public override void Sound()
        {
            Console.WriteLine("Fffftttfffttt");
        }
        
        public Rabbit(int weight)
        {
            this.Weight = weight;
        }

    }
}