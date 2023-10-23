// See https://aka.ms/new-console-template for more information

//IF Bloklarıyla Çalışmak...
var number = 7;
if (number == 7)
{
    Console.WriteLine("Number is 7");
}
else
{
    Console.WriteLine("Number is not 7");

}

// Single Line If ile çalışmak....
var number2 = 8;
Console.WriteLine(number2 == 10 ? "Number is 10 " : "Number is not 10");

// Else If ile çalışmak...

var number3 = 39;
if (number3 == 7)
{
    Console.WriteLine("Number is 7");
}
else if (number3 == 39)
{
    Console.WriteLine("Number is 39");
}
else
{
    Console.WriteLine("Number is not 7 or 39");

}
// Switch ile çalışmak...
switch (number)
{
    case 7:
        Console.WriteLine("Number is 7");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 7 or 20");
        break;




}


















Console.ReadLine();