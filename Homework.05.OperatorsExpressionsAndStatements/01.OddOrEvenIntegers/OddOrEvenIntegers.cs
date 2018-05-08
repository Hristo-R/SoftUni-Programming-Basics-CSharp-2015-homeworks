using System;

public class OddOrEvenIntegers
{
    public static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 != 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}