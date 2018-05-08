using System;

public class MinMaxSumAndAverageOfNNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];

        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        int min = num[0];
        int max = num[0];
        double sum = num[0];
        double avg = 0;

        for (int i = 1; i < n; i++)
        {
            if (min >= num[i])
            {
                min = num[i];
            }
            else if (max <= num[i])
            {
                max = num[i];
            }

            sum = sum + num[i];
        }

        avg = sum / n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}