//Метд заполения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {

        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
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

//Сортируем значения по возрастанию в строчках
int[,] filter(int[,] inputArray)
{
    int[] bufArray = new int[inputArray.GetLength(1)];
    int[,] bufThoArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int i = 0; int j = 0; int k = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        k = 0;
        while (j < inputArray.GetLength(1))
        {
            bufArray[j] = inputArray[i, j];
            j++;
        }

        Array.Sort(bufArray);

        while (k < bufArray.Length)
        {

            bufThoArray[i, k] = bufArray[k];

            k++;
        }

        i++;


    }

    return bufThoArray;
}

Console.Clear();
int[,] twoArray = FillTwoDimArray(5, 10);
PrintTwoDimArray(twoArray);
Console.WriteLine();
PrintTwoDimArray(filter(twoArray));


