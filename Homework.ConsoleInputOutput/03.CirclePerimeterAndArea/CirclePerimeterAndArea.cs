using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r = ");
        double radius = double.Parse(Console.ReadLine());
        double perimetar = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("perimeter = {0:F2}", perimetar);
        Console.WriteLine("area = {0:F2}", area);
    }
}