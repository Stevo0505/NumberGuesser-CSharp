// See https://aka.ms/new-console-template for more information


GetAppInfo(); //Run GetAppInfo function


GreetUser(); //Run GreetUser Function

//Play again loop
while (true)
{

    // Correct Random Number
    Random random = new Random();

    int correctNumber = random.Next(1, 11);

    // Init Guess var
    int guess = 0;

    Console.WriteLine("Guess a number between 1 and 10");

    //While guess is not correct
    while (guess != correctNumber)
    {
        //get user input
        string input = Console.ReadLine();

        //make sure its a number
        if (!int.TryParse(input, out guess))
        {
            //Run PrintColorMessage Funtion
            PrintColorMessage(ConsoleColor.Yellow, "Thats not a number!");
     
            // Keep Going
            continue;
        }

        //Cast to in and put to pars
        guess = Int32.Parse(input);

        //Match guess to correct number
        if (guess != correctNumber)
        {
            //Run PrintColorMessage Function
            PrintColorMessage(ConsoleColor.Blue, "Try again!");

        }
    }
    // output success message

    //Run PrintColorMessage Function
    PrintColorMessage(ConsoleColor.Green, "Great Job!");

    //Ask to play again
    Console.WriteLine("Would you like to play again? [Y or N]");

    //Answer String 
    string answer = Console.ReadLine().ToUpper();
    
    if (answer == "Y")
    {
        continue;
    }
    else if (answer == "N")
    {
        return;
    }
    else
    {
        return;
    }

}

//List of Functions

//GetAppInfo Fucntion
static void GetAppInfo()
{
    // Set App Vars
    string appName = "Number Guesser";
    string appVersion = "1.0.0";
    string appAuthor = "Stephen Collet";


    // Color Header
    Console.ForegroundColor = ConsoleColor.Red;

    //App Info
    Console.WriteLine(appName + ": by " + appAuthor + " Version " + appVersion);

    //Color reset
    Console.ResetColor();
}
//GreetUser Function
static void GreetUser()
{
    //Ask user name 
    Console.WriteLine("What is your name?");


    // user input
    string inputName = Console.ReadLine();

    Console.WriteLine("Hello {0} lets play a game...", inputName);

}

//PrintColorMessage Function
static void PrintColorMessage(ConsoleColor color, string message)
{
    // Color Header
    Console.ForegroundColor = color;

    //App Info 
    Console.WriteLine(message);

    //Color reset
    Console.ResetColor();
}