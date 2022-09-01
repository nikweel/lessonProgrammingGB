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

//Метод определения нахождения элемента в массиве
string SearchElement(int[,] inputArray, int element){
    int i = 0;
    int j = 0;
    string answer = "Такого числа в массиве нет";
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {

            if(element == inputArray[i,j]){
                answer = "Число ("+element+") находится на позиции: "+i+" "+j;
                break;
            }

            j++;
        }

        i++;
    }

    return answer;
    
}

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTeoDimArray(twoDimArray);
Console.WriteLine(SearchElement(twoDimArray, 10));


