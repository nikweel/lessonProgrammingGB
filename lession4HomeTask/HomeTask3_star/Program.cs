Console.Clear();
string inputLine;
int lengthArray;
int arrayStart;
int arrayEnd;

System.Random numberSintezator = new Random();

void readData()
{
    Console.WriteLine("Введите длину массива и диапазон значение пример 12,44,90");
    inputLine = Console.ReadLine();

    string[] subs = inputLine.Split(' ',',');
    lengthArray = int.Parse(subs[0]);
    arrayStart = int.Parse(subs[1]);
    arrayEnd = int.Parse(subs[2]);

}

void variantNaiv(){
    int i = 0;
    Console.Write("[");
    while(i < lengthArray - 1){
        Console.Write(numberSintezator.Next(arrayStart,arrayEnd + 1) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(arrayStart,arrayEnd + 1));
    Console.Write("]");
}

readData();
variantNaiv();





