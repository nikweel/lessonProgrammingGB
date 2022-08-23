Console.Clear();
string inputLine;
int inputLineA;
int inputLineN;
int powNumber = 1;

void readData()
{
    Console.WriteLine("Введите числа");
    inputLine = Console.ReadLine();
    inputLineA = int.Parse(inputLine.Substring(0,inputLine.IndexOf(",")));
    inputLineN = int.Parse(inputLine.Substring(inputLine.IndexOf(",")+1));
}

void calculation()
{
    // double powNumber = Math.Pow(inputLineA,inputLineN);    
    for (int i = 1; i <= inputLineN; i++)
    {
        powNumber = powNumber * inputLineA;
    }
}

void printData(){
    Console.WriteLine(powNumber);
}

readData();
calculation();
printData();



