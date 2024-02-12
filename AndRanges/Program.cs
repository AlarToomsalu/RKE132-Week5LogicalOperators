// TEMP <= 0- Freezing cold
// TEMP >0 AND temp <=10- cold
// TEMP >10 AND  <= 15 - CHilly
// TEMP >10 AND  <20 - Warm
// TEMP >= 20 AND temp < 30 - Hot
// TEMP >= 30- Boiling hot

Console.WriteLine("Enter the temperature");
int temp= int.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Boiling hot");
}
else if (temp < 30 && temp >= 20 )
{
    Console.WriteLine("Hot");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm");
}
else if (temp < 15 && temp >=10)
{
    Console.WriteLine("Chilly" );
}
else if (temp < 10 && temp >0)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing cold");
}