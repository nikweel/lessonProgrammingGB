int numberN;
string numberLineN = "";
string numberLineNNN = "";

//Ввод числа
void readDataN()
{
    Console.WriteLine("Введите число");
    numberN = int.Parse(Console.ReadLine());
}

void calculation()
{

    for (int i = 1; i <= numberN; i++)
    {
        numberLineN = numberLineN + i + ' ';
        numberLineNNN = numberLineNNN + i * i * i + ' ';
    }


    Console.WriteLine(numberLineN);
    Console.WriteLine(numberLineNNN);

}



readDataN();
calculation();
