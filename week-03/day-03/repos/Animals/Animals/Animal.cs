
using System;

namespace Animals
{
    class Animal
    {
        private int hunger;
        private int thirst;

        public Animal()
        {
            hunger = 50;
            thirst = 50;
        }

        public int GetHunger()
        {
            return hunger;
        }

        public int GetThirst()
        {
            return thirst;
        }

        public void Eat()
        {
            hunger -= 1;
        }

        public void Drink()
        {
            thirst -= 1;
        }

        public void Play()
        {
            hunger += 1;
            thirst += 1;
        }

        public int RandomDiceRoll()
        {
            Random diceRoll = new Random();
            int d6 = new Random().Next(1, 6);
            return d6;
        }
    }
}
