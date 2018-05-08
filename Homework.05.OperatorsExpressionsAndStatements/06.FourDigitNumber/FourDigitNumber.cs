using System;

public class FourDigitNumber
{
    public static void Main()
    {
        // bool b = true;
        Console.Write("Enter a four-digit number: ");
        string str = Console.ReadLine();
        int[] arr = new int[4];
        int[] reversedArr = new int[4];
        int[] lastDigitFirst = new int[4];
        int[] secondAndThirdDigitsExchanged = new int[4];
        int sum = 0;

        // sum of digits:
        for (int i = 0; i < 4; i++)
        {
            arr[i] = int.Parse(str[i].ToString());
            sum = sum + arr[i];
        }

        Console.WriteLine("sum of digits: {0}", sum);

        // reversed:
        for (int i = 0; i < 4; i++)
        {
            reversedArr[3 - i] = arr[i];
        }

        Console.Write("reversed: ");
        for (int i = 0; i < 4; i++)
        {
            if (i < 3)
            {
                Console.Write(reversedArr[i]);
            }
            else
            {
                Console.WriteLine(reversedArr[i]);
            }
        }

        // last digit in front:
        lastDigitFirst[0] = arr[3];
        for (int i = 1; i < 4; i++)
        {
            lastDigitFirst[i] = arr[i - 1];
        }

        Console.Write("last digit in front: ");
        for (int i = 0; i < 4; i++)
        {
            if (i < 3)
            {
                Console.Write(lastDigitFirst[i]);
            }
            else
            {
                Console.WriteLine(lastDigitFirst[i]);
            }
        }

        // second and third digits exchanged:
        secondAndThirdDigitsExchanged[0] = arr[0];
        secondAndThirdDigitsExchanged[1] = arr[2];
        secondAndThirdDigitsExchanged[2] = arr[1];
        secondAndThirdDigitsExchanged[3] = arr[3];
        Console.Write("second and third digits exchanged: ");
        for (int i = 0; i < 4; i++)
        {
            if (i < 3)
            {
                Console.Write(secondAndThirdDigitsExchanged[i]);
            }
            else
            {
                Console.WriteLine(secondAndThirdDigitsExchanged[i]);
            }
        } 
    }
}