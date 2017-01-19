using System;

namespace Zoolandia.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Pet1 = new Dog();
            Pet1.Name = "Gwen";
            Pet1.Height = 24;
            Pet1.Weight = 89;
            Pet1.Color = "black and white";
            Pet1.Sound();

            var Pet2 = new Dog();
            // Pet2.Name = "Finn";
            Pet2.Height = 22;
            Pet2.Weight = 50;
            Pet2.Color = "white and black";
            Pet2.Sound();

            var Pet3 = new Rabbit();
            // Pet3.Name = "Pico";
            Pet3.Height = 8;
            Pet3.Weight = 18;
            Pet3.Color = "white and black";
            Pet3.Sound();

            var Pet4 = new Rabbit();
            Pet4.Name = "Eleanor";
            Pet4.Height = 7;
            Pet4.Weight = 16;
            Pet4.Color = "white and gray";
            Pet4.Sound();


            var Pet5 = new Fish();
            Pet5.Height = 2;
            Pet5.Weight = 1;
            Pet5.Color = "white, black, orange, etc...";
            Pet5.Sound();

            Console.WriteLine($"I have two dogs named {Pet1.Name} and {Pet2.Name}. I have two rabbits named {Pet3.Name} and {Pet4.Name}.");
            
            Dog dogInstance = new Dog();
            Console.WriteLine(dogInstance.Species);
            Rabbit rabbitInstance = new Rabbit();
            Console.WriteLine(rabbitInstance.Species);
            Fish FishInstance = new Fish();
            Console.WriteLine(FishInstance.Species);

        }
    }
}
