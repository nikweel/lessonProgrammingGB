//Метод возвращает массив заполненный случайными числами от 100 до 1000
int[] FillingArray()
{
    //Входной массив
    int[] outArray = new int[4];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл хаполнения массива
    while (i < 4)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(1,10);
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
void ColculateTask(int[] inputArray)
{
    int max = 0;
    int min = 1000000;
    int i = 0;

    while(i<inputArray.Length){
        
        if(inputArray[i] > max){
            max = inputArray[i];
        }
        
        if(inputArray[i] < min){
            min = inputArray[i];
        }


        i++;
    }

    Console.WriteLine("max: " + max);
    Console.WriteLine("min: " + min);
    Console.WriteLine("Difference: " + Math.Abs(max - min));    
}

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
ColculateTask(bufferArray);

