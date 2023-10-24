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
// Çoklu Şartlarla çalışmak...
if (number >= 0 && number <=100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}






Console.ReadLine();