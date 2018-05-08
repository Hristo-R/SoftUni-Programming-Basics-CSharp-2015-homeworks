using System;

public class CalculateGCD
{
    public static void Main()
    {
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        int b = Math.Abs(int.Parse(Console.ReadLine()));

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }                
        }

        if (a == 0)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
    }
}