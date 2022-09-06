//Метд заполения двумерного массива спиралью
int[,] FillTwoDimArray(int size)
{
    int[,] outArray = new int[size, size];
    int x = 0, y = 0, currentCount = 1;

        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                outArray[x, i] = currentCount++;
            }

            for (int j = x + 1; j <= x + size - 1; j++)
            {
                outArray[j, y + size - 1] = currentCount++;
            }

            for (int i = y + size - 2; i >= y; i--)
            {
                outArray[x + size - 1, i] = currentCount++;
            }

            for (int i = x + size - 2; i >= x + 1; i--)
            {
                outArray[i, y] = currentCount++;
            }

            x = x + 1;
            y = y + 1;
            size = size - 2;
        }

    return outArray;
}

//Печать двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {

            Console.Write(inputArray[i, j] + "\t");

            j++;
        }
        Console.WriteLine();
        i++;
    }
}

Console.Clear();
int[,] twoArrayA = FillTwoDimArray(4);
PrintTwoDimArray(twoArrayA);