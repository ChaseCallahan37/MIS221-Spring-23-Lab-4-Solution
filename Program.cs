Menu();

static void Menu(){
    string userInput = "";
    while(userInput != "3"){
        MenuOptions();
        userInput = System.Console.ReadLine();
        
        //Route user to right view
        if(userInput == "1"){
            GetFull();
        }

        else if(userInput == "2"){
            GetPartial();
        }
        else if (userInput == "3"){
            Goodbye();
        }
        else{
            System.Console.WriteLine("Invalid Input!");
        }
        Pause();
    }
}

static void MenuOptions(){
    System.Console.WriteLine("1. Full Triangle");
    System.Console.WriteLine("2. Partial Triangle");
    System.Console.WriteLine("3. Exit");
}

static void GetFull(){

    for (int i = 6; i > 0; i--){
        for (int j = i; j < 6; j++){
            System.Console.Write("O\t");
        }
        System.Console.WriteLine();
    }
}

static void GetPartial(){
 for (int i = 6; i > 0; i--){
        for (int j = i; j < 6; j++){
            if(GetRando() == 1){

            System.Console.Write("O\t");
            }
        }
        System.Console.WriteLine();
    }
}

static int GetRando(){
    Random rnd = new Random();
    return rnd.Next(2);
            
}

static void Goodbye(){

}

static void Pause(){
    System.Console.WriteLine("\n\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}