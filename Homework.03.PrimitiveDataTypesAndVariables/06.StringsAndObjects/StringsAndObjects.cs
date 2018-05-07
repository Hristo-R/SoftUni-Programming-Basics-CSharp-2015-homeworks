using System;

class StringsAndObjects
{
    static void Main()
    {
        string string1 = "Hello";
        string string2 = "World";
        object objectVariable = string1 + " " + string2;
        string string3 = (string)objectVariable;
        Console.WriteLine(string3);
    }
}