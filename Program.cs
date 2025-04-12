while (true)
{
    Console.Write("> ");
    string UserInput = Console.ReadLine().ToLower();

    if (UserInput == "cls")
    {
        Console.Clear();
    }
    else if (UserInput == "beep")
    {
        Console.Beep();
    }
    else if (UserInput == "help")
    {
        Console.WriteLine("help - bring this us\ncls - clear the console\nbeep - make a beep");
    }
    else
    {
        Console.WriteLine("\nThe command: \"" + UserInput + "\" doesn't exist. Please input \"help\" if u need some.");
    }
}