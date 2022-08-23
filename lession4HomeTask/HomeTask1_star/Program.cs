Console.Clear();
string inputLine;
int inputLineA;
string inputLineFn;
int inputLineB;
double calc = 0;

void readData()
{
    Console.WriteLine("Введите вырожение в формате A,действие,B, пример 4,*,6");
    inputLine = Console.ReadLine();

    inputLineA = int.Parse(inputLine.Substring(0,inputLine.IndexOf(",")));
    inputLineFn = inputLine.Substring(inputLine.IndexOf(",")+1).Substring(0,inputLine.Substring(inputLine.IndexOf(",")+1).IndexOf(","));
    inputLineB = int.Parse(inputLine.Substring(inputLine.IndexOf(",")+1).Substring(inputLine.Substring(inputLine.IndexOf(",")+1).IndexOf(",") + 1));

}

void calculation()
{
    switch (inputLineFn)
    {
        case "+":
            calc = inputLineA + inputLineB;
            break;
        case "-":
            calc = inputLineA - inputLineB;
            break;
        case "*":
            calc = inputLineA * inputLineB;
            break;
        case "/":
            calc = inputLineA / inputLineB;
            break;
        case "pow":
            calc = Math.Pow(inputLineA,inputLineB);
            break;
    }
}

void printData(){
    Console.WriteLine(calc);
}

readData();
calculation();
printData();



