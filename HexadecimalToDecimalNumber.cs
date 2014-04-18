using System;
using System.Numerics;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hex = Console.ReadLine();
        hex = hex.ToLower();
        BigInteger dec = 0;
        for (int i = hex.Length - 1, power = 0; i >= 0; i--, power++)
        {
            char c = hex[i];
            if (c >= 'a' && c <= 'z')
            {
                long temp = 0;
                switch (c)
                {
                    case 'a': temp = 10; break;
                    case 'b': temp = 11; break;
                    case 'c': temp = 12; break;
                    case 'd': temp = 13; break;
                    case 'e': temp = 14; break;
                    case 'f': temp = 15; break;
                }
                dec += temp * (int)Math.Pow(16, power);
            }
            else
            {
                dec += Convert.ToInt32(c.ToString()) * (int)Math.Pow(16, power);
            }
            
        }
        Console.WriteLine("{0}", dec);
    }
}

