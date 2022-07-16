string? inputLkne = Console.ReadLine();

if(inputLkne != null){
    int inputNumber = int.Parse(inputLkne);
    int i = 1;

    while(i < inputNumber){

        if(i%2 == 0){
            Console.WriteLine(i);
        }
            i++;
    }


}
