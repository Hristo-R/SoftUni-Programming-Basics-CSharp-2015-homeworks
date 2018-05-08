using System;

public class RandomizeTheNumbers1N
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];
        int[] shuffledArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrN[i] = i + 1;
        }

        int rndNo;

        Random rnd = new Random();
        for (int i = n; i >= 1; i--)
        {
            rndNo = rnd.Next(1, i + 1) - 1;
            shuffledArray[i - 1] = arrN[rndNo];
            arrN[rndNo] = arrN[i - 1];
        }

        foreach (int value in shuffledArray)
        {
            Console.Write(value);
            Console.Write(' ');
        }

        Console.WriteLine();
    }
}