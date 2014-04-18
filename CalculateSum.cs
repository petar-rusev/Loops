using System;


class CalculateSum
{
    static long Factorial(long number)
    {
        if (number <= 1)
            return 1;
        else
            return number * Factorial(number - 1);
    }
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int xnum = int.Parse(Console.ReadLine());
        double sum = 1;
        double temp = 0;
        double numpow = 0;
        for (int i = 1; i <= length; i++)
        {

            temp = Factorial(i);
            numpow = Math.Pow(xnum,i);
            sum += temp / numpow;
        }
        
        Console.WriteLine("{0:0.00000}",sum);
    }
}

