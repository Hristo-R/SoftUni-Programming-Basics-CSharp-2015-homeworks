using System;

public class MatrixOfNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int k = i + 1;
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", k);
                k = k + 1;
            }

            Console.WriteLine();
        }
    }
}