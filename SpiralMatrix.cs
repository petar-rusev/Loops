using System;

class SpiralMatrix
{
    static void Main()
    {
        //Defining of the Matrix columns and rows quantity.

        Console.WriteLine("Please enter a number for columns and raws of Spiral matrix");
        int n = int.Parse(Console.ReadLine());


        int[,] matrix = new int[n, n];
        FillMatrix(matrix, n);
        PrintMatrix(matrix, n);

    }
    private static void FillMatrix(int[,] matrix, int n)
    {
        int positionX = n % 2 == 0 ? (n / 2) - 1 : (n / 2);
        int positionY = n / 2;
        int direction = 3; //Initial direction is right
        int stepsCount = 1; //Perform one step in current direction
        int stepPosition = 0; //Zero steps already performed
        int stepChange = 0; //Steps count changes after 2 steps

        for (int i = n * n; i > 0 | i == 1; i--)
        {
            matrix[positionY, positionX] = i;

            if (stepPosition < stepsCount)
            {
                stepPosition++;
            }
            else
            {
                stepPosition = 1;
                if (stepChange == 1)
                {
                    stepsCount++;
                }
                stepChange = (stepChange + 1) % 2;
                direction = (direction + 1) % 4;
            }
            if (n % 2 == 0)
            {

                switch (direction)
                {
                    case 0:
                        positionY--;
                        break;
                    case 1:
                        positionX--;
                        break;
                    case 2:
                        positionY++;
                        break;
                    case 3:
                        positionX++;
                        break;
                }
            }
            else if (n % 2 > 0)
            {

                switch (direction)
                {
                    case 0:
                        positionY++;
                        break;
                    case 1:
                        positionX++;
                        break;
                    case 2:
                        positionY--;
                        break;
                    case 3:
                        positionX--;
                        break;
                }
            }
        }
    }
    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
