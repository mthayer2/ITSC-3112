namespace PeopleManagement;

class Program
{
    static void Main(string[] args)
    {
        MajorEnum major = MajorEnum.ComputerScience;
        Student student = new Student("0", "Jim Bob", "jimbob@charlotte.edu", major, 2018);
        Professor instructor = new Professor("1", "Matthew Thayer", "mthayer2@uncc.edu", "MWF", "Office");
        
        IPersonRepository repository = new PersonRepository();
        
        // Add 1 Student and 1 Instructor.
        repository.AddOrUpdate(student);
        repository.AddOrUpdate(instructor);

        List<Person> people = repository.GetAllPeople();
        List<Student> students = repository.GetAllStudents();
        List<Professor> professors = repository.GetAllProfessors();

        Console.WriteLine($"There are {people.Count} people in the database. " +
                          $"{students.Count} student(s) and {professors.Count} professor(s). ");
    }
}