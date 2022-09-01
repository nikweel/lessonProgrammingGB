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
void PrintTeoDimArray(int[,] inputArray){
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


//Находим среднее арифмтическое
double[] CalcTeoDimArray(int[,] inputArray){
    int i = 0;
    int j = 0;
    int k = 0;
    double[] outArray = new double[inputArray.GetLength(1)];

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {

            outArray[j] += inputArray[i,j];

            j++;
        }

        i++;
    }

    while (k < outArray.Length)
    {
        outArray[k] = outArray[k] / i;
        k++;
    }



    return outArray;
    
}


//Метод печати двумерного массива
void PrintTeoDimArrayD(double[] inputArray){
    int i = 0;
    while (i < inputArray.Length)
    {
        Console.Write(inputArray[i] + " ");
        i++;
    }
}

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTeoDimArray(twoDimArray);
double[] twoDimArrayD = CalcTeoDimArray(twoDimArray);
PrintTeoDimArrayD(twoDimArrayD);




