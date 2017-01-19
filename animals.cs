using System;

namespace Zoolandia.Animals
{
    public class Animals
    {
        public string Name { get; set;}
        public string Species { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Bark");
        }
        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    
    }
}