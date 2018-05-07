using System;


class PrintTheASCIITable
{
    static void Main()
    {
        Console.WriteLine("ASCII Table\n");
        Console.WriteLine("dec\tchar\n");
        for (int i = 0; i < 255; i++)
        {
            char DecimalToChar = (char)i;
            Console.WriteLine("{0}\t{1}", i, DecimalToChar);
        }
    }
}