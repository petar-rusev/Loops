using System;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        string numLength = Console.ReadLine();
        int length;

        while (int.TryParse(numLength, out length) == false | length < 0)
        {
            Console.WriteLine("Invalid Input! Please enter a positive integer number.");
            numLength = Console.ReadLine();
        }
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int Max = numbers.Max();
        int Min = numbers.Min();
        int Sum = 0;
        for (int i = 0; i < length; i++)
        {
            Sum += numbers[i];
        }
        int len = numbers.Length;
        double avg = (double)Sum/(double)len;

        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}",Min,Max,Sum,avg);
        
    }
}

