using System;

class DeclareVariables
{
    static void Main()
    {
        ushort ushortNum = 52130;
        string dataType = "\"ushort\"";
        Console.WriteLine("To represent the value:   {0}, the most appropriate of the variables is: {1}", ushortNum, dataType);

        sbyte sbyteNum = -115;
        string sbyteDataType = "\"sbyte\"";
        Console.WriteLine("To represent the value:    {0}, the most appropriate of the variables is: {1}", sbyteNum, sbyteDataType);

        int intNum = 4825932;
        string intDataType = "\"int\"";
        Console.WriteLine("To represent the value: {0}, the most appropriate of the variables is: {1}", intNum, intDataType);

        byte byteNum = 97;
        string byteDataType = "\"byte\"";
        Console.WriteLine("To represent the value:      {0}, the most appropriate of the variables is: {1}", byteNum, byteDataType);

        short shortNum = -10000;
        string shortDataType = "\"short\"";
        Console.WriteLine("To represent the value:  {0}, the most appropriate of the variables is: {1}", shortNum, shortDataType);
    }
}