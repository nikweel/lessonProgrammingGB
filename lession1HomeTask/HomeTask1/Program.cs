string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null){
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);

    int max = inputNumberOne;
    int min = inputNumberTwo;

    if(inputNumberTwo > inputNumberOne){
        max = inputNumberTwo;
        min = inputNumberOne;
    }

    Console.WriteLine("max: " + max + " min: " + min);


}
