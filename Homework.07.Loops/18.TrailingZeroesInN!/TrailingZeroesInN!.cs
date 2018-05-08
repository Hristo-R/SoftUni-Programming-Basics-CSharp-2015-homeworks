using System;
using System.Numerics;

public class TrailingZeroesInN
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int counter = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        string factorialStr = Convert.ToString(factorial);

        char[] charArray = factorialStr.ToCharArray();

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            if (charArray[i] == '0')
            {
                counter = counter + 1;
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine(counter);
        Console.WriteLine(factorial);
    }
}