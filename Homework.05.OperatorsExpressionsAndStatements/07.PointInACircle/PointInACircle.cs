using System;

public class PointInACircle
{
    public static void Main()
    {
        Console.WriteLine("Insert point (x,  y)");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        double r = 0;
        r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (r <= 2)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}