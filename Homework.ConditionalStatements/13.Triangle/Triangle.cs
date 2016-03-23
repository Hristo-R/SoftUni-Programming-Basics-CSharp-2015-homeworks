using System;

class Triangle
{
    static void Main()
    {
        double Ax = double.Parse(Console.ReadLine());
        double Ay = double.Parse(Console.ReadLine());
        double Bx = double.Parse(Console.ReadLine());
        double By = double.Parse(Console.ReadLine());
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());

        double a = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
        double b = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
        double c = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));

        if (((a + b) > c) && ((a + c) > b) && ((c + b) > a))
        {
            double p = (a + b + c) / 2;
            double arrea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", arrea);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", a);
        }
    }
}