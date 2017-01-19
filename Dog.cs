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
        // public Dog(string name)
        // {
        //     this.Name = name;
        // }
        public Dog(int weight)
        {
            this.Weight = weight;
        }

        public Dog(string words, int number)
        {
            this.StringOfWords = words;
            this.SomeNumber = number;
        }
        

    }
}
