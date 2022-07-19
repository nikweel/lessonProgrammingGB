string? inputLkne = Console.ReadLine();

if(inputLkne != null){
    int inputLkneInt = int.Parse(inputLkne);
    string response = "";
    
    if(inputLkneInt > 0 && inputLkneInt < 8){
            response = "Нет";
        if(inputLkneInt == 6 | inputLkneInt == 7){
            response = "Да";
        }
    }else{
        response = "Ошибка! Укажите номер дня от 1 до 7";
    }
    
    Console.WriteLine(response);
}
