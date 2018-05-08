using System;

public class DecimalToHexadecimalNumber
{
    public static void Main()
    {
        long decimalNum = long.Parse(Console.ReadLine());

        if (decimalNum == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            int counter = 0;
            long countDecimalNum = decimalNum;

            while (countDecimalNum > 0)
            {
                countDecimalNum = countDecimalNum / 16;
                counter = counter + 1;
            }

            string[] hexN = new string[counter];
            int counterBin = counter;
            for (int i = 0; i < counter; i++)
            {
                long hex = decimalNum % 16;
                decimalNum = decimalNum / 16;
                switch (hex)
                {
                    case 0: hexN[i] = "0";
                        break;
                    case 1: hexN[i] = "1";
                        break;
                    case 2: hexN[i] = "2";
                        break;
                    case 3: hexN[i] = "3";
                        break;
                    case 4: hexN[i] = "4";
                        break;
                    case 5: hexN[i] = "5";
                        break;
                    case 6: hexN[i] = "6";
                        break;
                    case 7: hexN[i] = "7";
                        break;
                    case 8: hexN[i] = "8";
                        break;
                    case 9: hexN[i] = "9";
                        break;
                    case 10: hexN[i] = "A";
                        break;
                    case 11: hexN[i] = "B";
                        break;
                    case 12: hexN[i] = "C";
                        break;
                    case 13: hexN[i] = "D";
                        break;
                    case 14: hexN[i] = "E";
                        break;
                    case 15: hexN[i] = "F";
                        break;

                    default:
                        Console.WriteLine("Не знам какво е това число!");
                        break;
                }

                counterBin = counterBin - 1;
            }

            for (int i = counter - 1; i >= 0; i--)
            {
                Console.Write(hexN[i]);
            }

            Console.WriteLine();
        }
    }
}