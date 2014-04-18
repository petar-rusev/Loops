using System;
using System.Collections.Generic;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        int num=int.Parse(Console.ReadLine());

        string hex = num.ToString("X");
        Console.WriteLine(hex);
        
    }
}

