using System;
using System.Numerics;

public class CatalanNumbers
{
    public static void Main()
    {
        //// (2n)!/((n+1)!*n!)
        int n = int.Parse(Console.ReadLine());
        BigInteger factoriel2N = 1;
        BigInteger factorielN = 1;
        BigInteger factorielN1 = 1;

        for (int i = 1; i < n + 2; i++)
        {
            factorielN1 = factorielN1 * i;
            if (i <= n)
            {
                factorielN = factorielN * i;
            }
        }

        for (int i = 1; i < (2 * n) + 1; i++)
        {
            factoriel2N = factoriel2N * i;
        }

        Console.WriteLine(factoriel2N / (factorielN1 * factorielN));
    }
}