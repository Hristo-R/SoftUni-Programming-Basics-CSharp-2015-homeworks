using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        int a1 = b;
        int b1 = a;
        a = a1;
        b = b1;
        Console.WriteLine("After:");
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}