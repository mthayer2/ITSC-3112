using PeopleManagement;

namespace CourseManagement;

public class Section
{
    public int SectionNumber {get; set;}
    public TermEnum Term {get; set;}
    public Professor Instructor {get; set;}
    public List<Student> Students {get; set;}

    public Section(int sectionNumber, TermEnum term, Professor instructor)
    {
        SectionNumber = sectionNumber;
        Term = term;
        Instructor = instructor;
        Students = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        Students.Add(student);
    }

    public void EnrollStudents(List<Student> students)
    {
        Students.AddRange(students);
    }

    public void Drop(Student student)
    {
        Students.Remove(student);
    }

    public List<Student> GetStudentRoster()
    {
        return Students;
    }

    public override string ToString()
    {
        string s = $"Section:\n" +
                   $"  Section Number: {SectionNumber}\n" +
                   $"  Term: {Term}\n" +
                   $"  Instructor:\n    {Instructor.ToString().Replace("\n", "\n    ")}\n" +
                   $"  Students ({Students.Count}):\n";

        if (Students.Count == 0)
        {
            s += "    (none)";
        }
        else
        {
            foreach (var student in Students)
            {
                s += "    " + student.ToString().Replace("\n", "\n    ") + "\n";
            }
        }

        return s.TrimEnd();
    }
}