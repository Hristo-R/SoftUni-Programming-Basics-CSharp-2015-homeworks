using System;

public class BinaryToDecimalNumber
{
    public static void Main()
    {
        string numString = Console.ReadLine();
        long[] numArray = new long[numString.Length];
        long decimalNum = 0L;

        char[] array = numString.ToCharArray();
        int position = array.Length - 1;

        for (int i = 0; i < array.Length; i++)
        {
            char letter = array[i];
            numArray[i] = (int)Char.GetNumericValue(letter);        }

        for (int i = 0; i < array.Length; i++)
        {
            decimalNum = decimalNum + (numArray[position] * Convert.ToInt64(Math.Pow(2, i)));
            position = position - 1;
        }

        Console.WriteLine(decimalNum);
    }
}