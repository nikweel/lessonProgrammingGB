Console.Clear();
int numberN;
int sum = 0;

void readData()
{
    Console.WriteLine("Введите число");
    numberN = int.Parse(Console.ReadLine());
}

void calculation()
{
    while (numberN > 0)
    {
        sum += numberN%10;
        numberN /= 10;
    }
    
}

void printData(){
    Console.WriteLine(sum);
}

readData();
calculation();
printData();


