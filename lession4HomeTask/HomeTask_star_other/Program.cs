Console.Clear();
string inputLine;
string[] subs;
System.Random numberSintezator = new Random();

void readData()
{
    Console.WriteLine("Введите через запятую имена");
    inputLine = Console.ReadLine();
    subs  = inputLine.Split(',');
    
}

void randomName()
{
    Console.Write(subs[numberSintezator.Next(0,subs.Length)]);
}


readData();
randomName();




