// See https://aka.ms/new-console-template for more information

Person[] persons = new Person[3]
    {
        new Customer{FirstName="Burak"},
        new Student{FirstName="Ali Güner"},
        new Person{FirstName="Yunus Emre"}
    };
foreach (Person person in persons)
{
    Console.WriteLine(person.FirstName);
}


Console.ReadLine();

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}