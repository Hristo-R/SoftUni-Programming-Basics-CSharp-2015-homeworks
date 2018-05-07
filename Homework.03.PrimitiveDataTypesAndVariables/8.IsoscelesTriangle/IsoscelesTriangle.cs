using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.Write(new string(' ', 3));
        Console.WriteLine('\u00A9');
        for (int i = 0; i < 2; i++)
        {
            int externalSpaces = 2 - i;
            int internalSpaces = 1 + i + i;
            Console.Write(new string(' ', externalSpaces));
            Console.Write('\u00A9');
            Console.Write(new string(' ', internalSpaces));
            Console.Write('\u00A9');
            Console.WriteLine(new string(' ', externalSpaces));
        }
        for (int n = 0; n < 4; n++)
        {
            Console.Write('\u00A9');
            Console.Write(' ');
        }
        Console.WriteLine(' ');
    }
}