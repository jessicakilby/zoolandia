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
        public Rabbit(string species)
        {
           base.Species = species;
        }
        public void MyRabbit()
        {
            this.Name = "Pico";
        }
        public override void Sound()
        {
            Console.WriteLine("Fffftttfffttt");
        }
        

    }
}