using System;

namespace Zoolandia.Animals
{
    public class Rabbit : Animals
    {
        public Rabbit()
        {
            var Rabbit = new Animals();
            Rabbit.species = "Oryctolagus cuniculus";
        }

        public override void Sound()
        {
            Console.WriteLine("Fffftttfffttt");
        }

    }
}