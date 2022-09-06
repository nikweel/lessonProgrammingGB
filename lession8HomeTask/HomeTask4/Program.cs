//Метд заполения трехмерного массива
int[,,] Fill3DDimArray(int x, int y, int z)
{
    System.Random numberSyntezator = new System.Random();
    List<int> number = new List<int>();
    int data = numberSyntezator.Next(10, 100);
    int i = 0; int j = 0; int k = 0;
    int[,,] outArray = new int[x, y, z];
    while (i < x)
    {

        j = 0;
        while (j < y)
        {

            k = 0;
            while (k < z)
            {


                while (number.Contains(data))
                {
                    data = numberSyntezator.Next(10, 100);
                }

                number.Add(data);
                outArray[i, j, k] = data;




                k++;
            }


            j++;
        }
        i++;
    }
    return outArray;
}

//Печать трехмерного массива
void Print3DDimArray(int[,,] inputArray)
{
    int i = 0; int j = 0; int k = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {


            k = 0;
            while (k < inputArray.GetLength(2))
            {
                Console.Write(inputArray[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
                k++;
            }


            j++;
        }

        Console.WriteLine();
        i++;
    }
}



Console.Clear();
int[,,] twoArrayA = Fill3DDimArray(2, 2, 2);
Print3DDimArray(twoArrayA);






