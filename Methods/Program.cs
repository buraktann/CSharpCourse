// See https://aka.ms/new-console-template for more information

Add();
Add();
Add();
var result = Add2();
Console.WriteLine(result);
Console.ReadLine();

static void Add()
{
    Console.WriteLine("Added!!!");
}
static int Add2(int number1 = 20, int number2 = 30) // Birden fazla default değer verebiliriz fakat methodun en sonunda olması gerekir.
{
    var result = number1 + number2;
    return result;
}