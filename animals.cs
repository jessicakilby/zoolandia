using System;

namespace Zoolandia.Animals
{
    public class Animals
    {
        public string name { get; set;}
        public string species { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string color { get; set; }
        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }
}