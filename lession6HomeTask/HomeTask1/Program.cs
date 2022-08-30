Console.Clear();
string inputLine;
string[] numbers;

//Метод ввода чисел
void readData()
{
    Console.WriteLine("Введите числа");
    inputLine = Console.ReadLine();
    numbers = inputLine.Split(',');
    Console.WriteLine(numbers);
}

//Решение задачи
int ColculateTask(string[] inputArray)
{
    int sum = 0;
    int i = 0;
    while(i<inputArray.Length){

        if(int.Parse(inputArray[i]) > 0){
            sum++;
        }
        i++;
    }

    return sum;
}


readData();
Console.Write(ColculateTask(numbers));

