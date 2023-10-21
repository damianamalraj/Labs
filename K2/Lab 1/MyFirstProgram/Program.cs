// Namn: Damian Amalraj
// Klass: NET23

int number = 11;

// If statment that checks and writs the correct statment on the console
if (number > 10)
{
    Console.WriteLine("Talet är stort!");
}
else
{
    Console.WriteLine("Oj. Lågt tal!");
}

Console.WriteLine("Vad heter du?");

// Code thats simultaneously writs and asks a qution
Console.WriteLine($"Hej {Console.ReadLine()}!");

// For loop thats prints all the numbers until the given number
for (int i = 0; i <= number; i++)
{
    Console.WriteLine(i);
}
