using System;

namespace Zoolandia.Animals
{
    public class PartOfTheWorld : IEatFood
    {
        public static void theWorld ()
        {
            Console.WriteLine("If I go, so does everything inside me. Apocalypse!!");
        }
        public bool Eating()
        {
            return true;
        }
        public void NotEating()
        {
            Console.WriteLine("I'm not eating right now.");
        }
        public void EatingFood()
        {
            Console.WriteLine("I am eating food right now");
        }
    }
}