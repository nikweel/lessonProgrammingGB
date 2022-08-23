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
        Console.Write("{0}\t", i);
    }

    Console.WriteLine('\n');

    for (int i = 1; i <= numberN; i++)
    {
        Console.Write("{0}\t", i * i * i);
    }

    Console.WriteLine('\n');


    //Console.WriteLine('_');
       // Console.Write("{0}", i * i * i);
        //Console.Write("{0}\t", i * i * i);


    //Console.WriteLine(numberLineN);
    //Console.WriteLine(numberLineNNN);

}



readDataN();
calculation();
