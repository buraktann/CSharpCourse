// See https://aka.ms/new-console-template for more information

//Add();
//Add();
//Add();
//var result = Add2();
int number1 = 20;
int number2 = 100;
var result2 = Add3(ref number1, number2);
Console.WriteLine(result2);
Console.WriteLine(number1);
Console.ReadLine();

//static void Add()
//{
//    Console.WriteLine("Added!!!");
//}
//static int Add2(int number1 = 20, int number2 = 30)  Birden fazla default değer verebiliriz fakat methodun en sonunda olması gerekir.
//{
//    var result = number1 + number2;
//    return result;
//}
static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}