namespace _01.TheBetterMusicProducer
{
    using System;

    public class TheBetterMusicProducer
    {
        public static void Main()
        {
            double europe = double.Parse(Console.ReadLine());
            double euro = double.Parse(Console.ReadLine());
            double nAmerica = double.Parse(Console.ReadLine());
            double dollar = double.Parse(Console.ReadLine());
            double sAmerica = double.Parse(Console.ReadLine());
            double pesos = double.Parse(Console.ReadLine());
            double concerts = double.Parse(Console.ReadLine());
            double profit = double.Parse(Console.ReadLine());

            double profEurope = europe * euro * 1.94;
            double profNAmerica = nAmerica * dollar * 1.72;
            double profSAmerica = sAmerica * pesos / 332.74;

            double allAlbums = (profEurope + profNAmerica + profSAmerica) - ((profEurope + profNAmerica + profSAmerica) * 0.35);
            double totalAlbums = allAlbums - (allAlbums * 0.20);

            //// Console.WriteLine(totalAlbums);

            double concertsProfit = concerts * profit * 1.94;
            if (concertsProfit > 100000)
            {
                concertsProfit = concertsProfit - (concertsProfit * 0.15);
            }

            ////  Console.WriteLine(concertsProfit);

            if (concertsProfit >= totalAlbums)
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", concertsProfit);
            }
            else
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", totalAlbums);
            }
        }
    }
}
