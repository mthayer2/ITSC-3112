namespace PeopleManagement;

public class PersonRepository : IPersonRepository
{
    private List<Student> _students = new List<Student>();
    private List<Professor> _professors = new List<Professor>();
    
    public void AddOrUpdate(Student student)
    {
        Student existingStudent = this.GetStudentById(student.Id);

        // If the student already exists, remove it.
        if (existingStudent != null)
        {
            _students.Remove(existingStudent);
        }
        
        // Add the student.
        _students.Add(student);
    }

    public void AddOrUpdate(List<Student> students)
    {
        foreach (Student student in students)
        {
            AddOrUpdate(student);
        }
    }

    public void Remove(Student student)
    {
        _students.Remove(student);
    }

    public Student GetStudentById(string id)
    {
        Student result = null;

        foreach (Student student in _students)
        {
            if (student.Id == id)
            {
                result = student;
                break;
            }
        }
        
        return result;
    }

    public List<Student> GetAllStudents()
    {
        return _students;
    }

    public void AddOrUpdate(Professor professor)
    {
        Professor existingProfessor = this.GetProfessorById(professor.Id);

        // If the professor already exists, remove it.
        if (existingProfessor != null)
        {
            _professors.Remove(existingProfessor);
        }
        
        // Add the professor.
        _professors.Add(professor);
    }

    public void AddOrUpdate(List<Professor> professors)
    {
        foreach (Professor professor in professors)
        {
            AddOrUpdate(professor);
        }
    }

    public void Remove(Professor professor)
    {
        _professors.Remove(professor);
    }

    public Professor GetProfessorById(string id)
    {
        Professor result = null;

        foreach (Professor professor in _professors)
        {
            if (professor.Id == id)
            {
                result = professor;
                break;
            }
        }
        
        return result;
    }

    public List<Professor> GetAllProfessors()
    {
        return _professors;
    }

    public Person GetPersonById(string id)
    {
        Person result = null;
        
        // First try to find the person in the students list.
        result = this.GetStudentById(id);

        // If not found, try to find in the professor list.
        if (result == null)
        {
            result = this.GetProfessorById(id);
        }

        return result;
    }

    public List<Person> GetAllPeople()
    {
        List<Person> result = new List<Person>();
        result.AddRange(_students);
        result.AddRange(_professors);
        return result;
    }
}