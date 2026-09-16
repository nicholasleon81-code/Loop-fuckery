for (int i = 10; i > 0; i--)
{
    Console.Write($", {i}");
}

bool programOnline = true;
while (programOnline)
{
    Console.WriteLine("Vad vill du göra?");
    Console.WriteLine("Exit, ifall du vill avsluta.");
    string smart = Console.ReadLine();
    if (smart == "Exit")
    {
        programOnline = false;
    }
    else 
    {
        Console.WriteLine("HAHA, Nerd!");
    }
}