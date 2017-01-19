using System;

namespace Zoolandia.Animals
{
    public class Dog : Animals
    {
        public Dog()
        {
           var Dog = new Animals();
        //    Dog.Species = "Canis lupus";
            this.Species = "Canis lupus";
        }
        public Dog(string species)
        {
           base.Species = species;
        }
        

    }
}
