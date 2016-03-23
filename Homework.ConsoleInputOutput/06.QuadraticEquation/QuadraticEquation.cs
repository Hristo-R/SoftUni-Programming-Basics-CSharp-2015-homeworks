using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double D = Math.Pow(b, 2) - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            if (D == 0)
            {
                double x = -1 * (b / (2 * a));
                Console.WriteLine("x1 = x2 = {0}", x);
            }
            else
            {
                double x1 = ((-1 * b) + Math.Sqrt(D)) / (2 * a);
                double x2 = ((-1 * b) - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}