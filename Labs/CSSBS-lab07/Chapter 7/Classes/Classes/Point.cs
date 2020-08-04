
using System;
using System.Xml.Schema;

namespace Classes
{
    class Point
    {
        //This creates instance fields x and y
        int x;
        int y;
        //class fields will eventuralll go here.
        public Point()
        {
            x = -1;
            y = -1;
            Console.WriteLine("Default constructor called");
            Console.WriteLine($"Default x is {x} and {y}");
        }
            public Point(int xVar, int yVar)
        {
            x = xVar;
            y = yVar;
            Console.WriteLine($"x:{x}, y:{y}");
        
        }
    }
}
