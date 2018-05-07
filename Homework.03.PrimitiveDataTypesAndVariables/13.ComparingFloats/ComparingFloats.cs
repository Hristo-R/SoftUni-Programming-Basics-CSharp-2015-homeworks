using System;

class ComparingFloats
{
    static void Main()
    {
        decimal a = 5.3m;
        decimal b = 6.01m;
        decimal eps = 0.000001m;
        decimal difference = Math.Abs(a - b);
        Console.WriteLine("Comparing " + a + " and " + b + "?");
        if (difference == eps)
        {
            Console.Write("Equal (with precision eps=0.000001): false. ");
            Console.WriteLine("Border case. The difference 0.000001 == eps. \nWe consider the numbers are different.");
            Console.WriteLine("\n");
        }
        else
        {
            if (difference < eps)
            {
                Console.Write("Equal (with precision eps=0.000001): true. ");
                Console.WriteLine("The difference of " + difference + " > eps.");
            }
            else
            {
                Console.Write("Equal (with precision eps=0.000001): false. ");
                Console.WriteLine("The difference of " + difference + " < eps.");
                Console.WriteLine("\n");
            }
        }

        a = 5.00000001m;
        b = 5.00000003m;
        difference = Math.Abs(a - b);
        Console.WriteLine("Comparing " + a + " and " + b + "?");
        if (difference == eps)
        {
            Console.Write("Equal (with precision eps=0.000001): false. ");
            Console.WriteLine("Border case. The difference 0.000001 == eps. \nWe consider the numbers are different.");
            Console.WriteLine("\n");
        }
        else
        {
            if (difference < eps)
            {
                Console.Write("Equal (with precision eps=0.000001): true. ");
                Console.WriteLine("The difference of " + difference + " > eps.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("Equal (with precision eps=0.000001): false. ");
                Console.WriteLine("The difference of " + difference + " < eps.");
                Console.WriteLine("\n");
            }
        }

        a = 5.00000005m;
        b = 5.00000001m;
        difference = Math.Abs(a - b);
        Console.WriteLine("Comparing " + a + " and " + b + "?");
        if (difference == eps)
        {
            Console.Write("Equal (with precision eps=0.000001): false. ");
            Console.WriteLine("Border case. The difference 0.000001 == eps. \nWe consider the numbers are different.");
            Console.WriteLine("\n");
        }
        else
        {
            if (difference < eps)
            {
                Console.Write("Equal (with precision eps=0.000001): true. ");
                Console.WriteLine("The difference of " + difference + " > eps.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("Equal (with precision eps=0.000001): false. ");
                Console.WriteLine("The difference of " + difference + " < eps.");
                Console.WriteLine("\n");
            }
        }

        a = -0.0000007m;
        b = 0.00000007m;
        difference = Math.Abs(a - b);
        Console.WriteLine("Comparing " + a + " and " + b + "?");
        if (difference == eps)
        {
            Console.Write("Equal (with precision eps=0.000001): false. ");
            Console.WriteLine("Border case. The difference 0.000001 == eps. \nWe consider the numbers are different.");
            Console.WriteLine("\n");
        }
        else
        {
            if (difference < eps)
            {
                Console.Write("Equal (with precision eps=0.000001): true. ");
                Console.WriteLine("The difference of " + difference + " > eps.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("Equal (with precision eps=0.000001): false. ");
                Console.WriteLine("The difference of " + difference + " < eps.");
                Console.WriteLine("\n");
            }
        }

        a = -4.999999m;
        b = -4.999998m;
        difference = Math.Abs(a - b);
        Console.WriteLine("Comparing " + a + " and " + b + "?");
        if (difference == eps)
        {
            Console.Write("Equal (with precision eps=0.000001): false. ");
            Console.WriteLine("Border case. The difference 0.000001 == eps. \nWe consider the numbers are different.");
            Console.WriteLine("\n");
        }
        else
        {
            if (difference < eps)
            {
                Console.Write("Equal (with precision eps=0.000001): true. ");
                Console.WriteLine("The difference of " + difference + " > eps.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("Equal (with precision eps=0.000001): false. ");
                Console.WriteLine("The difference of " + difference + " < eps.");
                Console.WriteLine("\n");
            }
        }

        a = 4.999999m;
        b = 4.999998m;
        difference = Math.Abs(a - b);
        Console.WriteLine("Comparing " + a + " and " + b + "?");
        if (difference == eps)
        {
            Console.Write("Equal (with precision eps=0.000001): false. ");
            Console.WriteLine("Border case. The difference 0.000001 == eps.\nWe consider the numbers are different.");
            Console.WriteLine("\n");
        }
        else
        {
            if (difference < eps)
            {
                Console.Write("Equal (with precision eps=0.000001): true. ");
                Console.WriteLine("The difference of " + difference + " > eps.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.Write("Equal (with precision eps=0.000001): false. ");
                Console.WriteLine("The difference of " + difference + " < eps.");
                Console.WriteLine("\n");
            }
        }
    }
}