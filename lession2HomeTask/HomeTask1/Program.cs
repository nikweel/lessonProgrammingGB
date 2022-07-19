string? inputLkne = Console.ReadLine();

if(inputLkne != null && inputLkne.Length == 3){
    int inputLkneInt = int.Parse(inputLkne.Substring(1, 1));
    Console.WriteLine(inputLkneInt);
}
