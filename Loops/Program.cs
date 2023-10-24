// See https://aka.ms/new-console-template for more information

ForLoop();
WhileLoop();
DoWhileLoop();



static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}
static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}
static void ForLoop()
{
    for (int i = 100; i >= 0; i = i - 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished");
}


Console.ReadLine();