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

//Вывод строки с наименьшей суммой элементов
int FindRow(int[,] inputArray)
{
    int i = 0; int j = 0;
    int minElement = int.MaxValue;
    int sum = 0;
    int row = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        sum = 0;

        while (j < inputArray.GetLength(1))
        {
            sum += inputArray[i, j];
            j++;
        }

        if(sum < minElement){
            minElement = sum;
            row = i;  
        }

        i++;
    }
    return row;
}

Console.Clear();
int[,] twoArray = FillTwoDimArray(4, 5);
PrintTwoDimArray(twoArray);
Console.WriteLine("Строка с наименьшей суммой элементов: " + FindRow(twoArray));




