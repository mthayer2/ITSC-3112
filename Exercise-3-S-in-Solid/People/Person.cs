namespace PeopleManagement;

public abstract class Person
{
    public string Id { get; init;  }
    public string Name { get; set; }
    public string Email { get; set; }

    protected Person(string id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
    
    public override string ToString()
    {
        return $"Person:\n" +
               $"  Id: {Id}\n" +
               $"  Name: {Name}\n" +
               $"  Email: {Email}";
    }
}
