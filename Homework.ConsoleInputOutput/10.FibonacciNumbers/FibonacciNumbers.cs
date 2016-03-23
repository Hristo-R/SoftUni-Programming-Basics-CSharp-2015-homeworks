using System;

class FibonacciNumbers
{
    static void Main()
    {
        int fibonacci = 0;
        int fibonacciFirst = 0;
        int fibonacciSecond = 1;
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The first {0} members of the Fibonacci sequence are: ", n);
        Console.Write("0 ");
        if (n != 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("{0} ", fibonacciSecond);
                fibonacci = fibonacciFirst + fibonacciSecond;
                fibonacciFirst = fibonacciSecond;
                fibonacciSecond = fibonacci;
            }
        }
        Console.WriteLine("");
    }
}