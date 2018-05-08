namespace _02.GrandTheftExamo
{
    using System;

    public class GrandTheftExamo
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numberOfThieves = new int[number];
            int[] numberOfBeers = new int[number];

            int totalThieves = 0;
            int totalEscape = 0;
            int beers = 0;

            for (int i = 0; i < number; i++)
            {
                numberOfThieves[i] = int.Parse(Console.ReadLine());
                numberOfBeers[i] = int.Parse(Console.ReadLine());

                totalThieves = totalThieves + numberOfThieves[i];

                totalEscape = totalEscape + (numberOfThieves[i] / 5) * 5;
                beers = beers + numberOfBeers[i];
            }

            Console.WriteLine("{0} thieves slapped.", totalEscape);
            Console.WriteLine("{0} thieves escaped.", totalThieves - totalEscape);

            int sixBeers = beers / 6;
            beers = beers - (sixBeers * 6);

            Console.Write("{0} packs, ", sixBeers);
            Console.WriteLine("{0} bottles.", beers);
        }
    }
}
