using System;

namespace animalFarm.sql
{
    public class Pig
    {
        public string name;
        public Pig(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {name} and I am a {GetType()}");
        }
        public void Eat()
        {
            Console.WriteLine($"This {GetType()} eats everything.");
        }
        public void Produce()
        {
            Console.WriteLine($"This {GetType()} produces bacon");
        }
        public void Move()
        {
            Console.WriteLine($"This {GetType()} travels in sounders.");
        }
    }
}

