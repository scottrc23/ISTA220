using System;

namespace animalFarm.sql
{
    internal class Chicken
    {
        public string name;
        public Chicken(string Name)
        {
            name = Name;
        }
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {this.name} and I am a {this.GetType()}");
        }
        public void Eat()
        {
            Console.WriteLine($"This {this.GetType()} eats anything it can get its beak on.");
        }
        public void Produce()
        {
            Console.WriteLine($"This {this.GetType()} produces nuggets of joy");
        }
        public void Move()
        {
            Console.WriteLine($"This {this.GetType()} travels in flocks.");
        }
    }
}
