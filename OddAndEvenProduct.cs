using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string nums = Console.ReadLine();
        string[] numbersInput = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int intnums;
        int OddProduct = 1;
        int EvenProduct = 1;
        for (int i = 0; i < numbersInput.Length; i++)
        {

            intnums = int.Parse(numbersInput[i]);
            Console.WriteLine(intnums);
            if (intnums % 2 == 0)
            {
                EvenProduct *= intnums;

            }
            else
            {
                OddProduct *= intnums;
            }
        }
       
       
        if (EvenProduct == OddProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", EvenProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", OddProduct, EvenProduct);
        }
       
    }
}

