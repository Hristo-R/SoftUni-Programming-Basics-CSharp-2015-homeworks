namespace _03.PlaidTowel
{
    using System;

    public class PlaidTowel
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine(
                "{0}{1}{2}{1}{0}",
                new string(background, n),
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1),
                new string(background, n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string(background, n - i - 1),
                    new string(symbol, 1),
                    new string(background, (2 * i) + 1),
                    new string(symbol, 1),
                    new string(background, (n + n - 1) - (2 * i) - 2),
                    new string(symbol, 1),
                    new string(background, (2 * i) + 1),
                    new string(symbol, 1),
                    new string(background, n - i - 1));
            }

            Console.WriteLine(
                "{0}{1}{2}{1}{0}",
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string(background, i + 1),
                    new string(symbol, 1),
                    new string(background, (n * 2) - 3 - (2 * i)),
                    new string(symbol, 1),
                    new string(background, 1 + (2 * i)),
                    new string(symbol, 1),
                    new string(background, (n * 2) - 3 - (2 * i)),
                    new string(symbol, 1),
                    new string(background, i + 1));
            }

            Console.WriteLine(
                "{0}{1}{2}{1}{0}",
                new string(background, n),
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1),
                new string(background, n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string(background, n - i - 1),
                    new string(symbol, 1),
                    new string(background, (2 * i) + 1),
                    new string(symbol, 1),
                    new string(background, (n + n - 1) - (2 * i) - 2),
                    new string(symbol, 1),
                    new string(background, (2 * i) + 1),
                    new string(symbol, 1),
                    new string(background, n - i - 1));
            }

            Console.WriteLine(
                "{0}{1}{2}{1}{0}",
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string(background, i + 1),
                    new string(symbol, 1),
                    new string(background, (n * 2) - 3 - (2 * i)),
                    new string(symbol, 1),
                    new string(background, 1 + (2 * i)),
                    new string(symbol, 1),
                    new string(background, (n * 2) - 3 - (2 * i)),
                    new string(symbol, 1),
                    new string(background, i + 1));
            }

            Console.WriteLine(
                "{0}{1}{2}{1}{0}",
                new string(background, n),
                new string(symbol, 1),
                new string(background, (n + n) - 1),
                new string(symbol, 1),
                new string(background, n));
        }
    }
}
