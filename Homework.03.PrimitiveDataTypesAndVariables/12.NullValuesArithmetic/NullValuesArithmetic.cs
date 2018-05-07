using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nIntNum = null;
        double? nDoubleNum = null;

        Console.WriteLine(nIntNum);
        Console.WriteLine(nDoubleNum);

        Console.WriteLine(nIntNum + 1);
        Console.WriteLine(nDoubleNum + 10);
    }
}