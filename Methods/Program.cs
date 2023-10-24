// See https://aka.ms/new-console-template for more information

//Add();
//Add();
//Add();
//var result = Add2();
int number1 = 20;
int number2 = 100;
var result2 = Add3(out number1, number2);
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
static int Add3(out int number1, int number2) // Out ile Ref çok benzerdir tek farkı ref kullanırken önceki değişkene kesinlikle değer atanması gerekir Out için atmana gerek yoktur. Methodun içinde set edilmesi gerekir.
{
    number1 = 30;
    return number1 + number2;
}