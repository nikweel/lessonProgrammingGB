// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int sum = 0;

int ReadData(string line){
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

void NaturalNumberSum(int m, int n){
    if(m - 1 == n){
        return;
    }
    sum += m;
    NaturalNumberSum(++m, n);
}

Console.Clear();
int inputNumberM = ReadData("Укажите число M: ");
int inputNumberN = ReadData("Укажите число N: ");
NaturalNumberSum(inputNumberM, inputNumberN);
Console.Write(sum);