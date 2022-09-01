//Метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn){
    System.Random numbersSyntezator = new System.Random();
    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow,countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i,j] = numbersSyntezator.Next(0,100);
            j++;
        }

        i++;
    }
    return outArray;
}

//Метод печати двумерного массива
void PrintTeoDimArray(double[,] inputArray){
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i,j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

//Метод для заполнения двумерного массива вещественными числами
double[,] UpdateTwoDimArray(int[,] inputArray){
    int i = 0;
    int j = 0;
    System.Random numbersSyntezator = new System.Random();
    double[,] outArray = new double[inputArray.GetLength(0),inputArray.GetLength(1)];
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            outArray[i,j] = numbersSyntezator.NextDouble() * 100;
            j++;
        }

        i++;
    }

    return outArray;
    
}

int[,] twoDimArray = FillTwoDimArray(5,8);
double[,] twoDimArrayDuble = UpdateTwoDimArray(twoDimArray);
PrintTeoDimArray(twoDimArrayDuble);

