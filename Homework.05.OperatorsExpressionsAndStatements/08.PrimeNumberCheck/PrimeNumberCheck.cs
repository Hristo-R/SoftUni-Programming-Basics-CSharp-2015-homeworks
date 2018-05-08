using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter integer number (n ≤ 100) n = ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            double b = n % n;
            if (b == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}