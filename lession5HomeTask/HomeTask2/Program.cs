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
        outArray[i] = numberSintezator.Next(1,5);
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

//Решение задачи
int ColculateTask(int[] inputArray)
{
    int sum = 0;
    int i = 1;
    while(i<inputArray.Length){
        sum += inputArray[i];
        i += 2;
    }
    return sum;
}

//Решение задачи под *
void ColculateDubble(int[] inputArray)
{   
    int[] bufferArray = new int[0];
    int bufferElement = 0;
    for (int i = 0; i < inputArray.Length; i++) {
        bufferElement = inputArray[i];
        if(Array.IndexOf(bufferArray, bufferElement) == -1){
            for (int j = 0; j < inputArray.Length; j++) {
                if(bufferElement == inputArray[j]){
                    Console.WriteLine("Элемент " + bufferElement + " на индексе " + j);
                }
            }
            bufferArray = bufferArray.Concat(new int[] { bufferElement }).ToArray();
        }
    }
}

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
ColculateDubble(bufferArray);

