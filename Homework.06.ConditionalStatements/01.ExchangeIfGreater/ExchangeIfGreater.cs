using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());

        double first = a;
        double second = b;

        if (a > b)
        {
            first = b;
            second = a;
        }

        Console.WriteLine("Result: {0} {1}", first, second);
    }
}