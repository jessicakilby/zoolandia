using System;

namespace Zoolandia.Animals
{
    public class MeatEater : Animals
    {
        public virtual void SpecificToMeatEaters() 
        { 
            Console.WriteLine("I eat meat.");
        }
        
    }
}