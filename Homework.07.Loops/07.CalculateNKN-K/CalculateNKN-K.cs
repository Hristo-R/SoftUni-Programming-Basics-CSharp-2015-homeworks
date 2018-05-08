using System;
using System.Numerics;

public class CalculateNKN
{
    public static void Main()
    {
        //// Calculate N! / (K! * (N-K)!)   1 < k < n < 100

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        int nk = n - k;
        BigInteger factorialNK = 1;

        for (int i = 1; i < n + 1; i++)
        {
            factorialN = factorialN * i;
            if (i <= k)
            {
                factorialK = factorialK * i;
            }
        }

        for (int i = 1; i < nk + 1; i++)
        {
            factorialNK = factorialNK * i;         
        }

        Console.WriteLine(factorialN / (factorialK * factorialNK));
    }
}