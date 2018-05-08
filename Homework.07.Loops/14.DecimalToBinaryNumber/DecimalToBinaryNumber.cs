using System;

public class DecimalToBinaryNumber
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
                countDecimalNum = countDecimalNum / 2;
                counter = counter + 1;
            }

            string[] binN = new string[counter];
            int counterBin = counter;
            for (int i = 0; i < counter; i++)
            {
                long bin = decimalNum % 2;
                decimalNum = decimalNum / 2;
                counterBin = counterBin - 1;
                binN[counterBin] = Convert.ToString(bin);
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write(binN[i]);
            }

            Console.WriteLine();
        }
    }
}