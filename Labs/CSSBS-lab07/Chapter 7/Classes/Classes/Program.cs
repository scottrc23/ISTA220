using System;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("running class program...");
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            Point proof = new Point();
        }

        static void Main(string[] args)
        {
            //try
            //{
                doWork();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
