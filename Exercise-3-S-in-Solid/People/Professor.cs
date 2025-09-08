namespace PeopleManagement;

public class Professor : Person
{
    public string OfficeHours { get; private set; }
    public string OfficeLocation { get; private set; }

    public Professor(string id, string name, string email, string officeHours, string officeLocation)
        : base(id, name, email)
    {
        OfficeHours = officeHours;
        OfficeLocation = officeLocation;
    }
    
    public override string ToString()
    {
        return $"Professor:\n" +
               $"  Id: {Id}\n" +
               $"  Name: {Name}\n" +
               $"  Email: {Email}\n" +
               $"  Office Hours: {OfficeHours}\n" +
               $"  Office Location: {OfficeLocation}";
    }

}