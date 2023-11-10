// See https://aka.ms/new-console-template for more information
using Method;

static void Main(string[] args)
{
    string urunAdi = "Elma";
    double fiyat = 15;
    string aciklama = "Amasya Elması";

    string[] fruits = new string[] { "Elma", "Karpuz" };

    Product product1 = new Product();
    product1.Name = "Elma";
    product1.Price = 15;
    product1.Description = "Amasya Elması";

    Product product2 = new Product();
    product2.Name = "Karpuz";
    product2.Price = 80;
    product2.Description = "Diyarbakır Karpuzu";

    Product[] products = new Product[] { product1, product2 };

    foreach (var product in products)
    {
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Price);
        Console.WriteLine(product.Description);
        Console.WriteLine("---------------");
    }

    Console.WriteLine("------------METHODS------------------");

    BasketManager basketManager = new BasketManager();
    basketManager.Add(product1);
    basketManager.Add(product2);

    basketManager.Add2("Armut", "Yeşil Armut", 12, 10);
    basketManager.Add2("Elma", "Yeşil Elma", 12, 9);
    basketManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 8);


    Console.ReadLine();
}
