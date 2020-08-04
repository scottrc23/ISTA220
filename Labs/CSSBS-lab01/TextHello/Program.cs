using System;

namespace TextHello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string appelation;
            Console.Write("Enter you name: ");
            appelation = Console.ReadLine();
            Console.WriteLine($"Hello, {appelation}");
        }
    }
}