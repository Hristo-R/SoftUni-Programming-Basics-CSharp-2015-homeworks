using System;

class SumOf5Numbers
{
    static void Main()
    {
        double sum = 0;
        double[] array = new double[5];
        string str;
        string[] strArray = new string[5];
        Console.Write("Enter 5 numbers separated by a space: ");
        str = (Console.ReadLine());
        strArray = str.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = double.Parse(strArray[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        Console.WriteLine("Their sum is: {0}", sum);
    }
}