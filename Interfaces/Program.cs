// See https://aka.ms/new-console-template for more information
using Interfaces;
//InterfacesIntro();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());

Console.ReadLine();

static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();

    manager.Add(new Customer { Id = 1, FirstName = "Burak", LastName = "Tan", Address = "Kırklareli" });

    Student student = new Student
    {
        Id = 1,
        FirstName = "Yunus Emre",
        LastName = "Tan",
        Departmant = "Computer Sciences"

    };
    manager.Add(student);
}

interface IPerson
{
   public int Id { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }

}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add (IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }

}