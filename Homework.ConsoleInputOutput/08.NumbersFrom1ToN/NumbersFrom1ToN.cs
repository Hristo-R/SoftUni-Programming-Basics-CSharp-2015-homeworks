using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter an integer number: n = ");
        int n = int.Parse(Console.ReadLine());
        int num;
        for (int i = 0; i < n; i++)
        {
            num = i + 1;
            Console.WriteLine(num);
        }
    }
}