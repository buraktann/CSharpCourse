// See https://aka.ms/new-console-template for more information
 CustomerManager customerManager= new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager= new ProductManager();
productManager.Add();
productManager.Update();

Console.ReadLine();




class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }
    public void Update()
    {
        Console.WriteLine("Customer Uptaded!");
    }
}

class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Product Added!");
    }
    public void Update()
    {
        Console.WriteLine("Product Uptaded!");
    }

}
