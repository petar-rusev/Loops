using System;

class GreatestCommonDivisor
{
    public static int GCD(int p, int q)
    {
        if (q == 0)
        {
            return p;
        }

        int r = p % q;

        return GCD(q, r);
    }
    static void Main()
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());

        int gcd = GCD(numOne, numTwo);
        Console.WriteLine(gcd);
    }
}

