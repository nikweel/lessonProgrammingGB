Console.Clear();
string m;

//Метод ввода чисел
int[] readData()
{
    Console.WriteLine("Введите числа");
    string[] numbersLine;
    m = Console.ReadLine();
    numbersLine = m.Split(',');
    int[] outArray = new int[numbersLine.Length];
    int i = 0;
    while(i<numbersLine.Length){
        outArray[i] = int.Parse(numbersLine[i]);
        i++;
    }
    return outArray;
}

//Решение задачи
int ColculateTask(int[] inputArray)
{
    int sum = 0;
    int i = 0;
    while(i<inputArray.Length){
        if(inputArray[i] > 0){
            sum++;
        }
        i++;
    }

    return sum;
}

void PrintResult(int countTask){
    Console.Write(countTask);
}

int[] bufferArray = readData();
int countTask = ColculateTask(bufferArray);
PrintResult(countTask);


