using System;

public class Calculate
{
    public static void Main()
    {
        //// Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int f = 1;
        double s = 1;

        for (int i = 1; i <= n; i++)
        {
            f = f * i;
            s = s + (f / Math.Pow(x, i));
        }

        Console.WriteLine("{0:F5}", s);
    }
}