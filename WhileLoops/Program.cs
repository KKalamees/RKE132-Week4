
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{ 
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Sisesta number 1-3:");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Võit on kodus!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Proovi uuesti");
    }
}
Console.WriteLine("Kena päeva jätku!");