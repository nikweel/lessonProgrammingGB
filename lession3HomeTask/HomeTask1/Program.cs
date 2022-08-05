int numberN;

//Ввод числа
void readDataOfPoint()
{
    Console.WriteLine("Введите число");
    numberN = int.Parse(Console.ReadLine());
}

void check()
{
    if(numberN/10000 == numberN%10 && (numberN/1000)%10 == (numberN/10)%10){
        Console.WriteLine("да");
    }else{
        Console.WriteLine("нет");
    }    
}

readDataOfPoint();
check();
