int GetRang(int startRang, int  endRang)
{
    int rendom = new Random().Next(startRang, endRang); return rendom;
}
int GetCalc(int number)
{
    int SecondNum = number / 10 % 10; return SecondNum;
}
int startRang = 100;
int endRang = 1000;
int rendomRang = GetRang(startRang, endRang);
int result = GetCalc(rendomRang);
Console.WriteLine($"Second digit of a random three-digit number {rendomRang} => {result}");
Console.Write("Inter three-digit number: ");
int MeNumber = Convert.ToInt32(Console.ReadLine());
if(MeNumber >= 100 && MeNumber < 1000)
{
    int resultMe = GetCalc(MeNumber);
    Console.WriteLine($"Second digit of a your number {MeNumber} => {resultMe}");
}
else
{
    Console.WriteLine("inter three-digit number");
}

