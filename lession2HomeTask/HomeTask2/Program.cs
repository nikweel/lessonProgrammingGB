string? inputLkne = Console.ReadLine();

if(inputLkne != null && inputLkne.Length > 2){
    int inputLkneInt = int.Parse(inputLkne.Substring(2, 1));
    Console.WriteLine(inputLkneInt);
}else{
    Console.WriteLine("Третьей цифры нет");
}
