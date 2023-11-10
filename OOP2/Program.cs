// See https://aka.ms/new-console-template for more information
using OOP2;
IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Burak";
customer1.LastName = "Tan";
customer1.TcNo = "77777777777";

//Kodlama.io
CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNumber = "1234567890";

//Gerçek Müşteri - Tüzel Müşteri
//SOLID

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
