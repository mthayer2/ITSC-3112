namespace PeopleManagement;

public interface IPersonRepository
{
    public void AddOrUpdate(Student student);
    public void AddOrUpdate(List<Student> students);
    public void Remove(Student student);
    public Student GetStudentById(string id);
    public List<Student> GetAllStudents();
    
    public void AddOrUpdate(Professor professor);
    public void AddOrUpdate(List<Professor> professors);
    public void Remove(Professor professor);
    public Professor GetProfessorById(string id);
    public List<Professor> GetAllProfessors();
    
    public Person GetPersonById(string id);
    public List<Person> GetAllPeople();
}