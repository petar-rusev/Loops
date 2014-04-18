using System;

class RandomMaxMin
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int Min = int.Parse(Console.ReadLine());
        
        int Max = int.Parse(Console.ReadLine());
        if (Min > Max)
        {
            Console.WriteLine("The minimum number must be smaller than maximum!Please enter the Min number.");
            Min = int.Parse(Console.ReadLine());
        }
        int[] arrRandom = new int[length];

        Random randNum = new Random();
        for (int i = 0; i < arrRandom.Length; i++)
        {
            arrRandom[i] = randNum.Next(Min, Max);
        }
        for (int i = 0; i < arrRandom.Length; i++)
        {
            Console.Write("{0} ",arrRandom[i]);
        }

    }
}

