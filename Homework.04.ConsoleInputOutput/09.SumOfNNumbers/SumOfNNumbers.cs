using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers:", n);
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine("sum is: {0}", sum);
    }
}