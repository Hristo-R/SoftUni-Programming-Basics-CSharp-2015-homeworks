using System;

public class HexadecimalToDecimalNumber
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
            switch (letter)
            {
                case '0': numArray[i] = 0;
                    break;
                case '1': numArray[i] = 1;
                    break;
                case '2': numArray[i] = 2;
                    break;
                case '3': numArray[i] = 3;
                    break;
                case '4': numArray[i] = 4;
                    break;
                case '5': numArray[i] = 5;
                    break;
                case '6': numArray[i] = 6;
                    break;
                case '7': numArray[i] = 7;
                    break;
                case '8': numArray[i] = 8;
                    break;
                case '9': numArray[i] = 9;
                    break;
                case 'A': numArray[i] = 10;
                    break;
                case 'B': numArray[i] = 11;
                    break;
                case 'C': numArray[i] = 12;
                    break;
                case 'D': numArray[i] = 13;
                    break;
                case 'E': numArray[i] = 14;
                    break;
                case 'F': numArray[i] = 15;
                    break;

                default:
                    Console.WriteLine("Не знам какво е това число!");
                    break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            decimalNum = decimalNum + (numArray[position] * Convert.ToInt64(Math.Pow(16, i)));
            position = position - 1;
        }

        Console.WriteLine(decimalNum);
    }
}