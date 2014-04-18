using System;
using System.Numerics;

class FactorialsNandKCalc
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number for K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger FactorialN = 1;
        BigInteger FactorialK = 1;
        BigInteger FactorialNK = 1;
        int result = n - k;

        if (n < k || k <= 1)
        {
            Console.WriteLine("Error!\nPlease enter a legal number, the rules are:\n1)N must be greater than K;\n2)K must be greater than 1;");
        }
        else
        {
            do
            {
                FactorialN *= n;
                n--;
            } while (n > 0);

            do
            {
                FactorialK *= k;
                k--;
            } while (k > 0);
            do
            {
                FactorialNK *= result;
                result--;
            } while (result > 0);

            BigInteger answer = FactorialN / (FactorialK * (FactorialNK));
            Console.WriteLine("The answer is: {0}", answer);

        }

    }
}


