using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter Your Binary Number: ");
            string c=Console.ReadLine();
            int[] num = new int[100];
            int p = 1;
            int result=0;
           
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '0')
                    num[i] = 0;
                else if (c[i] == '1')
                    num[i] = 1;
            }
           
            for (int i=c.Length-1; i >=0;i--)
            {
                result = result + num[i] * p;
                p *= 2;
            }
            Console.WriteLine("Your value in decimal is {0}", result);
            Console.ReadLine();
    }
}

