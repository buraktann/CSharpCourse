// See https://aka.ms/new-console-template for more information
using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Burak";
customer.LastName = "Tan";
customer.City = "Kırklareli";

Customer customer2 = new Customer { Id = 2, FirstName = "Yunus Emre",LastName="Tan",City="Lüleburgaz"};
Console.WriteLine(customer2.FirstName);


Console.ReadLine();
