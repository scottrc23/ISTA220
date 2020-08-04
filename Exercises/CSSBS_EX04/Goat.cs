using System;

namespace animalFarm.sql
{
    internal class Goat
    {
        public string name;
        public Goat(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I am a {this.GetType()}");
        }
        public void Eat()
        {
            Console.WriteLine($"This {this.GetType()} eats everything.");
        }
        public void Produce()
        {
            Console.WriteLine($"This {this.GetType()} produces garbage collection services");
        }
        public void Move()
        {
            Console.WriteLine($"This {this.GetType()} travels in trips.");
        }
    }
}

