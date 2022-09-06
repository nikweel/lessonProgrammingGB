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
            outArray[i, j] = numberSyntezator.Next(0, 5);
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

//Перемножение двух матриц
int[,] Multiplication(int[,] inputArrayA, int[,] inputArrayB)
{
    int[,] bufArray = new int[inputArrayA.GetLength(0), inputArrayA.GetLength(1)];
    int i = 0; int j = 0;
    while (i < inputArrayA.GetLength(0))
    {
        j = 0;
        while (j < inputArrayA.GetLength(1))
        {
            bufArray[i, j] =  inputArrayA[i, j] * inputArrayB[i, j];
            j++;
        }
        i++;
    }
    return bufArray;
}

Console.Clear();
int[,] twoArrayA = FillTwoDimArray(4, 5);
PrintTwoDimArray(twoArrayA);
Console.WriteLine();
int[,] twoArrayB = FillTwoDimArray(4, 5);
PrintTwoDimArray(twoArrayB);
Console.WriteLine();
PrintTwoDimArray(Multiplication(twoArrayA,twoArrayB));





