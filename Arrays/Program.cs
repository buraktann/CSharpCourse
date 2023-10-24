// See https://aka.ms/new-console-template for more information
string[] students = new string[3] { "Burak", "Tan", "Engin" };

string[] students2 = { "Burak", "Tan", "Engin" }

;
foreach (string student in students)
{
    Console.WriteLine(student);
}

string[,] regions = new string[5, 3]
{
    {"Edirne","Kırklareli","Tekirdağ"},
    {"Ankara","Konya","Kırıkkale"},
    {"Antalya","Adana","Mersin"},
    {"Rize","Trabzon","Samsun"},
    {"İzmir","Muğla","Manisa"},
};


for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("************");
}


Console.ReadLine();
