using System;

public class CalculateNK
{
    public static void Main()
    {
        //// Calculate N! / K! (1 < k < n < 100)

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;

        for (int i = 1; i < n + 1; i++)
        {
            factorialN = factorialN * i;
            if (i > k)
            {
                continue;
            }

            factorialK = factorialK * i;
        }

        Console.WriteLine(factorialN / factorialK);
    }
}