int GetCalc(int number)
{
    int ThirdNum = number % 10; return ThirdNum;
}

int GetRand(int startRang, int  endRang)
{
    int rendom = new Random().Next(startRang, endRang); return rendom;
}


Console.Write("Inter a rang for a random three-digit number and a three digit number: ");
int startRang = Convert.ToInt32(Console.ReadLine());
int endRang = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int rendomNum = GetRand(startRang, endRang);
int result2 = GetCalc(GetRand(startRang, endRang));
int result = GetCalc(num3);
if(startRang > 99 && startRang < 1000 && endRang > 99 && endRang < 1000 && num3 > 99 && num3 < 1000)
{
    Console.WriteLine($"{rendomNum} => {result2}");
    Console.WriteLine($"{num3} => {result}");
}
else
{
    Console.WriteLine("Check The correctness of the entered numbers");
}

