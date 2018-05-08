using System;

public class ThirdDigitTs7
{
    public static void Main()
    {
        bool b = true;
        Console.Write("n = ");
        string str = Console.ReadLine();
        string[] arr = new string[str.Length];

        if (str.Length > 2)
        {
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[(str.Length - i - 1)].ToString();
            }

            int p = int.Parse(arr[2]);
            if (p == 7)
            {
                b = true;
            }
            else
            {
                b = false;
            }
        }
        else
        {
            b = false;
        }

        Console.WriteLine(b);
    }
}