using System;

namespace Zoolandia.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Pet1 = new Dog();
            Pet1.name = "Gwen";
            Pet1.height = 24;
            Pet1.weight = 89;
            Pet1.color = "black and white";

            var Pet2 = new Dog();
            Pet2.name = "Finn";
            Pet2.height = 22;
            Pet2.weight = 50;
            Pet2.color = "white and black";

            var Pet3 = new Rabbit();
            Pet3.name = "Pico";
            Pet3.height = 8;
            Pet3.weight = 18;
            Pet3.color = "white and black";

            var Pet4 = new Rabbit();
            Pet3.name = "Eleanor";
            Pet3.height = 7;
            Pet3.weight = 16;
            Pet3.color = "white and gray";

            var Pet5 = new Fish();
            Pet3.height = 2;
            Pet3.weight = 1;
            Pet3.color = "white, black, orange, etc...";

            Console.WriteLine($"I have two dogs named {Pet1.name} and {Pet2.name}. Their species name is {Animals.Dog.species}");

        }
    }
}
