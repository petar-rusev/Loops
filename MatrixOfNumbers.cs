using System;

class MatrixOfNumbers
{
    static void Main()
    {
        string num = Console.ReadLine();
        int number;
        while(int.TryParse(num,out number)==false&&(number>20||number<1))
        {
            Console.WriteLine("Invalid Input!Please enter a number between 1 and 20.");
            num=Console.ReadLine();

        }

        for (int i = 1; i <= number; i++)
        {
            for (int j = i; j < number + i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
   
    }
}

