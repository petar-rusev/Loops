using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Please enter a integer number.");
        string numOne = Console.ReadLine();
        int number;
        
        while (int.TryParse(numOne, out number) == false|number<0)
        {
            Console.WriteLine("Invalid Input! Please enter a positive integer number.");
            numOne = Console.ReadLine();
        }
        

        if (number == 0)
        {
            Console.Write("{0} ",number);
            Console.WriteLine();
        }
        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
    }
}

