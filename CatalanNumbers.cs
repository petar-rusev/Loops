using System;
using System.Numerics;

class CatalanNumbers
{
    public static BigInteger Catalan(int n)
    {
        BigInteger CatalFact = 1;
        do
        {
            CatalFact *= n;
            n--;

        } while (n > 0);
        return CatalFact;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a number for \"N\" to calculate Catalan's number");
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("{0}", n + 1);
        }
        else if (n == 1)
        {
            Console.WriteLine("{0}", n);
        }
        else
        {
            BigInteger cFactoriel = (Catalan(2 * n)) / ((Catalan(n + 1)) * Catalan(n));
            Console.WriteLine("The {0}-th Catalan's number is: {1}", n, cFactoriel);
        }

    }
}

