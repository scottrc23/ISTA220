using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace CSSBS_EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            calcCir();
        }
        private static void calcCir()
        {
            double radius;
            double area, Cir;
            Console.WriteLine("Part 1, Circumference and Area of a Circle.");
            Console.Write("Enter the Radius of a Circle ===>   ");
            string strradius = Console.ReadLine();
            try
            {
                radius = int.Parse(strradius);
                if (radius < 0)
                    throw new Exception("Your number is out of range.");
                area = Math.PI * radius * radius;
                Cir = 2 * Math.PI * radius;
                Console.WriteLine("The circumference of a Circle is " + Cir);
                Console.WriteLine("The area of a circle is " + area);
                if (double.IsInfinity(Cir))
                    throw new DivideByZeroException("You must enter a valid number.");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcCir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcCir();
            }
            finally
            {
                Console.WriteLine("Your numbers are ok");
            }
            //Console.WriteLine("\nPart 2, Volume of a Hemisphere.");
            //Console.Write("Enter an integer for the radius ===>   ");
            //radius = double.Parse(Console.ReadLine());
            //double volume = ((4 / 3) * Math.PI) * (radius * radius * radius) / 2;
            //Console.WriteLine($"The volume is {volume}");
            //Console.ReadKey();

            //// Part 3
            //double aside;
            //double bside;
            //double cside;
            //double perm;
            //Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            //Console.Write("Enter an integer for side 1 ===>   ");
            //aside = double.Parse(Console.ReadLine());
            //Console.Write("Enter an integer for side 2 ===>   ");
            //bside = double.Parse(Console.ReadLine());
            //Console.Write("Enter an integer for side 3 ===>   ");
            //cside = double.Parse(Console.ReadLine());
            //perm = (aside + bside + cside) / 2;
            //area = Math.Sqrt(perm * (perm - aside) * (perm - bside) * (perm - cside));
            //Console.WriteLine($"The area is {area}");
            //Console.ReadKey();

            ////// Part 4
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("\nPart 4, solving a quadratic equation.");
            //Console.Write("Enter an integer for coefficient a ===>   ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter an integer for coefficient b ===>   ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Enter an integer for coefficient c ===>   ");
            //c = int.Parse(Console.ReadLine());
            //double positive_num = (b * -1) + Math.Sqrt(b * b - 4 * a * c);
            //double negative_num = (b * -1) - Math.Sqrt(b * b - 4 * a * c);
            //double denominator = 2 * a;
            //Console.WriteLine($"The positive solution is {positive_num / denominator}");
            //Console.WriteLine($"The negative solution is {negative_num / denominator}");
            //Console.ReadKey();
        }
    }
}
