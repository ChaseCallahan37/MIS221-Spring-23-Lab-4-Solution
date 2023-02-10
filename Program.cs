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
    int rows = GetRandomRows();
    for (int i = rows; i > 0; i--){
        for (int j = i; j < rows; j++){
            System.Console.Write("O\t");
        }
        System.Console.WriteLine();
    }
}

static void GetPartial(){
    int rows = GetRandomRows();
    for (int i = rows; i > 0; i--){
        for (int j = i; j < rows; j++){
            if(FiftyFifty() == 1){

            System.Console.Write("O\t");
            }
        }
        System.Console.WriteLine();
    }
}

static int FiftyFifty(){
    Random rnd = new Random();
    return rnd.Next(2);
            
}

static int GetRandomRows(){
    Random rnd = new Random();
    return rnd.Next(3, 9);
}

static void Goodbye(){

}

static void Pause(){
    System.Console.WriteLine("\n\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}