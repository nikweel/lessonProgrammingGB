//Метод возвращает массив заполненный случайными числами от 100 до 1000
int[] FillingArray()
{
    //Входной массив
    int[] outArray = new int[10];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл хаполнения массива
    while (i < 10)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(100,1000);
        //Увеличиваем инкремент
        i++;
    }
    //Возвращаем значение
    return outArray;
}

//Печать массива
void PrintArray(int[] inputArray)
{   
    //Буфферная переменная
    int i = 0;
    while(i < inputArray.Length - 1){
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим последний элемент массива
    Console.WriteLine(inputArray[i]);
}


//Сортировка пузырьком - задача под *
int[] SortArray(int[] inputArray)
{   
    //Буфферная переменная
    int temp = 0;
    for (int write = 0; write < inputArray.Length; write++) {
        for (int i = 0; i < inputArray.Length - 1; i++) {
            if(inputArray[i] > inputArray[i + 1]){
                temp = inputArray[i + 1];
                inputArray[i + 1] = inputArray[i];
                inputArray[i] = temp;
            }
        }
    }
    //Выводим буфферный массив
    return inputArray;
}


//Решение задачи
int ColculateTask(int[] inputArray)
{
    int sum = 0;
    int i = 0;
    while(i<inputArray.Length){
        if(inputArray[i] % 2 == 0){
            sum++;
        }
        i++;
    }

    return sum;
}

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
int[] sortArray = SortArray(bufferArray);
PrintArray(sortArray);
Console.Write(ColculateTask(bufferArray));

