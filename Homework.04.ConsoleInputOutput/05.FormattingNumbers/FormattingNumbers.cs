using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Integer a (0 <= a <= 500) = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("floating-point b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("floating-point c = ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}", a);

        string binary = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.Write("|{0}", binary);
        
        Console.Write("|{0,10:0.##}", b);

        Console.WriteLine("|{0,-10:F3}|", c);

    }
}