using System;

namespace Zoolandia.Animals
{
    public interface IEatFood
    {
        bool Eating();
        void NotEating();
        void EatingFood();
    }
}