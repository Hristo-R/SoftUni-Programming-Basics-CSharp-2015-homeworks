using System;

public class RandomNumbersInGivenRange
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int num = rnd.Next(min, max + 1);
            Console.Write("{0} ", num);
        }

        Console.WriteLine();
    }
}