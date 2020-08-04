using System;

namespace animalFarm.sql
{
    internal class Horse
    {
        public string name;
        public Horse(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I am a {this.GetType()}");
        }
        public void Eat()
        {
            Console.WriteLine($"This {this.GetType()} eats carrots.");
        }
        public void Produce()
        {
            Console.WriteLine($"This {this.GetType()} produces glue");
        }
        public void Move()
        {
            Console.WriteLine($"This {this.GetType()} in herds.");
        }
    }
}
