string? inputLkne = Console.ReadLine();

if(inputLkne != null){
    int inputNumber = int.Parse(inputLkne);

    if(inputNumber%2 == 0){
        Console.WriteLine("yes");
    }else{
        Console.WriteLine("no");
    }

}
