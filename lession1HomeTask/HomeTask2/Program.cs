string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();
string? inputLknetThree = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null && inputLknetThree != null){
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);
    int inputNumberThree = int.Parse(inputLknetThree);

    int max = inputNumberOne;

    if(inputNumberTwo > max){
        max = inputNumberTwo;
    }

    if(inputNumberThree > max){
        max = inputNumberThree;
    }

    Console.WriteLine("max " + max);

}
