Console.Clear();
double k1;
double k2;
double b1;
double b2;
double x;
double y;


//Метод ввода чисел
void readData()
{
    Console.WriteLine("Введите b1");
    b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k1");
    k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2");
    b2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2");
    k2 = int.Parse(Console.ReadLine());
}

//Решение задачи
string ColculateTask()
{
    x = (b2 - b1) / (k2 - k1);
    y = (k1 * (b2 - b1)) / (k2 - k1) + b1;

    return "("+x+";"+y+")";
}

//Вывод значения
void PrintResult(string coord){
    Console.Write(coord);
}

readData();
PrintResult(ColculateTask());
