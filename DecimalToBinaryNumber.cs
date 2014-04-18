using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Number in Decimal format = ");
        int n = int.Parse(Console.ReadLine());
        string counter = "";

        while (n >= 1)
        {
            counter = (n % 2) + counter;
            n = n / 2;
        }
        Console.Write("Number in Binary format = {0}\n",counter);
    }
}

