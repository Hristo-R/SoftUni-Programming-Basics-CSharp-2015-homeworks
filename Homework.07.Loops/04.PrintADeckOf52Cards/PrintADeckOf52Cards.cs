using System;

public class PrintADeckOf52Cards
{
    public static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            if (i == 11)
            {
                Console.Write("J♣ J♦ J♥ J♠");
                Console.WriteLine();
            }
            else if (i == 12)
            {
                Console.Write("D♣ D♦ D♥ D♠");
                Console.WriteLine();
            }
            else if (i == 13)
            {
                Console.Write("K♣ K♦ K♥ K♠");
                Console.WriteLine();
            }
            else if (i == 14)
            {
                Console.Write("A♣ A♦ A♥ A♠");
                Console.WriteLine();
            }
            else
            {
                Console.Write("{0}♣ {0}♦ {0}♥ {0}♠", i);
                Console.WriteLine();
            }
        }
    }
}