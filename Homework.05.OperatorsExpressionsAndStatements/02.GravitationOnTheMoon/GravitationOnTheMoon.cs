using System;

public class GravitationOnTheMoon
{
    public static void Main()
    {
        Console.Write("weight = ");
        double weightOnTheEarth = double.Parse(Console.ReadLine());
        double weightOnTheMoon = weightOnTheEarth * 17 / 100;

        Console.WriteLine("weight on the Moon = {0}", weightOnTheMoon);
    }
}