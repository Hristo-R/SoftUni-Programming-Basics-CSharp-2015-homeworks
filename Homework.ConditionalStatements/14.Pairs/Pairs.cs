using System;

class Pairs
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] strArr = str.Split(' ');

        int[] numArr = new int[strArr.Length];
        int[] pairArr = new int[strArr.Length / 2];

        int j = 0;
        bool equal = true;


        for (int i = 0; i < strArr.Length; i++)
        {
            numArr[i] = int.Parse(strArr[i]);
        }

        for (int i = 0; i < strArr.Length; i += 2)
        {
            pairArr[j] = numArr[i] + numArr[i + 1];
            j = j + 1;
        }

        for (int i = 1; i < pairArr.Length; i++)
        {
            if (pairArr[i - 1] != pairArr[i])
            {
                equal = false;
            }
        }

        if (equal == true)
        {
            Console.WriteLine("Yes, value={0}", pairArr[0]);
        }
        else
        {
            int max = pairArr[0];
            for (int i = 1; i < pairArr.Length; i++)
            {
                if (max < pairArr[i])
                {
                    max = pairArr[i];
                }
            }

            int min = pairArr[0];
            for (int i = 1; i < pairArr.Length; i++)
            {
                if (min > pairArr[i])
                {
                    min = pairArr[i];
                }
            }

            int maxdiff = max - min;
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }
    }
}