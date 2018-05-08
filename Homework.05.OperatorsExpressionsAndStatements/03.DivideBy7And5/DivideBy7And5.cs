using System;

public class DivideBy7And5
{
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool checkZero = n == 0;
        if (checkZero)
        {
            Console.WriteLine("false");
        }
        else
        {
            if ((n % 5 == 0) && (n % 7 == 0))
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