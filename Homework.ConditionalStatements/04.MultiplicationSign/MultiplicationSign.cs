using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("result: +");
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("result: -");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("result: -");
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("result: -");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("result: +");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("result: +");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("result: +");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("result: -");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("result: 0");
        }
    }
}