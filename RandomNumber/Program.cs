
Random rnd = new Random();

int MyRandomNum;
int RandomSum = 0;

for (int i = 0; i < 3; i++)
{ 
    MyRandomNum = rnd.Next(0, 11);
    RandomSum = RandomSum + MyRandomNum;   
    Console.WriteLine("Suvaline number:" + MyRandomNum);
}

Console.WriteLine("Summad kokku:"+ RandomSum);