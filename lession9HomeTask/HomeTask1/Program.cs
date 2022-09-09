// Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
int ReadData(string line){
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

void PrintNaturalNumber(int n)
{
    if(n == 1){
        return;
    }else{
        Console.Write(n);
        Console.Write(" ");
        PrintNaturalNumber(--n);
    }
}

Console.Clear();
int inputNumberN = ReadData("Укажите число N: ");
PrintNaturalNumber(inputNumberN);