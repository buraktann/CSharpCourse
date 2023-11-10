using GenericsIntro;

MyList<string> names =new MyList<string>();
names.Add("Burak");
Console.WriteLine(names.Length);
names.Add("Güner");
Console.WriteLine(names.Length);

foreach (var name in names.Items)
{
    Console.WriteLine(name);
}
