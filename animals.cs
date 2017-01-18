using System;

namespace Zoolandia.Animals
{
    public class Animals
    {
        public string name { get; set;}
        public string species { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public string color { get; set; }
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