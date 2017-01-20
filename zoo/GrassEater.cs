using System;

namespace Zoolandia.Animals
{
    public class GrassEater : Animals
    {
        public virtual void SpecificToGrassEaters ()
        { 
            Console.WriteLine("I eat grass and hay.");
        }
    }
}