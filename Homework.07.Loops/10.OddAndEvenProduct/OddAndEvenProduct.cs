using System;

public class OddAndEvenProduct
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string[] strArr = str.Split(' ');
        int[] numArr = new int[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            numArr[i] = int.Parse(strArr[i]);
        }

        int odd_product = 1;
        int even_product = 1;

        if (strArr.Length % 2 == 0)
        {
            for (int i = 1; i <= numArr.Length; i += 2)
            {
                even_product = even_product * numArr[i];
                odd_product = odd_product * numArr[i - 1];
            }
        }
        else
        {
            for (int i = 0; i < strArr.Length; i += 2)
            {
                odd_product = odd_product * numArr[i];
                if (i < strArr.Length - 1)
                {
                    even_product = even_product * numArr[i + 1];
                }
            }
        }

        if (odd_product == even_product)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", odd_product);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", odd_product);
            Console.WriteLine("even_product = {0}", even_product);
        }
    }
}