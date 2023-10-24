// See https://aka.ms/new-console-template for more information

//Add();
//Add();
//Add();
//var result = Add2();

//int number1 = 20;
//int number2 = 100;
//var result2 = Add3(out number1, number2);

//Console.WriteLine(result2);
//Console.WriteLine(number1);
var overloading1 = (OverLoading.Multiply(2, 3));
var overloading2 = (OverLoading.Multiply(2, 4, 8));
Console.WriteLine(overloading1);
Console.WriteLine(overloading2);

Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

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

static int Add4(int number1, params int[] numbers) //PARAMS KEYWORD (SUM ile dizilerin içinde ki değerlerin toplamını bulduk.) number1 ilk değer 1 olduğu için onu toplamadı.
{
    return numbers.Sum();
}




public class OverLoading
{
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
    public static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
}







