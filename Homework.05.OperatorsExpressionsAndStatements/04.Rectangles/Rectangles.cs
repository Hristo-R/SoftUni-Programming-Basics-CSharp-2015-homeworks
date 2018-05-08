using System;

public class Rectangles
{
    public static void Main()
    {
        Console.Write("width = ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("height = ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("perimeter = {0}", 2 * (width + height));
        Console.WriteLine("area = {0}", width * height);
    }
}