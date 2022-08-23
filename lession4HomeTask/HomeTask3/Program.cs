Console.Clear();

System.Random numberSintezator = new Random();

void variantNaiv(){
    int i = 0;
    Console.Write("[");
    while(i < 8 - 1){
        Console.Write(numberSintezator.Next(1,10) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(1,10));
    Console.Write("]");
}

variantNaiv();
