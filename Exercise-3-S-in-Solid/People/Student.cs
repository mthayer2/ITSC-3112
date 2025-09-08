namespace PeopleManagement;

public class Student : Person
{
    public MajorEnum Major { get; private set; }
    public int AdmissionYear { get; init; }

    public Student(string id, string name, string email, MajorEnum major, int admissionYear)
        : base(id, name, email)
    {
        Major = major;
        AdmissionYear = admissionYear;
    }
    
    public override string ToString()
    {
        return $"Student:\n" +
               $"  Id: {Id}\n" +
               $"  Name: {Name}\n" +
               $"  Email: {Email}\n" +
               $"  Major: {Major}\n" +
               $"  Admission Year: {AdmissionYear}";
    }
}