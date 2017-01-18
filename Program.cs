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
            Pet1.Sound();

            var Pet2 = new Dog();
            Pet2.name = "Finn";
            Pet2.height = 22;
            Pet2.weight = 50;
            Pet2.color = "white and black";
            Pet2.Sound();

            var Pet3 = new Rabbit();
            Pet3.name = "Pico";
            Pet3.height = 8;
            Pet3.weight = 18;
            Pet3.color = "white and black";
            Pet3.Sound();

            var Pet4 = new Rabbit();
            Pet4.name = "Eleanor";
            Pet4.height = 7;
            Pet4.weight = 16;
            Pet4.color = "white and gray";
            Pet4.Sound();


            var Pet5 = new Fish();
            Pet5.height = 2;
            Pet5.weight = 1;
            Pet5.color = "white, black, orange, etc...";
            Pet5.Sound();

            Console.WriteLine($"I have two dogs named {Pet1.name} and {Pet2.name}. I have two rabbits named {Pet3.name} and {Pet4.name}.");

        }
    }
}
