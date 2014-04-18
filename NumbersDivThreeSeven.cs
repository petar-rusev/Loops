using System;

class NumbersDivThreeSeven
{
    static void Main()
    {
        Console.WriteLine("Please enter a integer number.");
        string numOne = Console.ReadLine();
        int number;

        while (int.TryParse(numOne, out number) == false | number < 0)
        {
            Console.WriteLine("Invalid Input! Please enter a positive integer number.");
            numOne = Console.ReadLine();
        }

        for (int i = 0; i <= number; i++)
        {
            if (i % 3 != 0 & i % 7 != 0)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}

