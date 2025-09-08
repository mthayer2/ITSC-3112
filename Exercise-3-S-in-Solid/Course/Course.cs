using PeopleManagement;

namespace CourseManagement;

public class Course
{
    public string CourseID {get; private set;}
    public string Title {get; private set;}
    public List<Section> Sections {get; private set;}

    public Course(string courseID, string title, List<Section> sections)
    {
        CourseID = courseID;
        Title = title;
        Sections = sections;
    }

    public void AddSection(Section section)
    {
        Sections.Add(section);
    }

    public void RemoveSection(Section section)
    {
        Sections.Remove(section);
    }

    public bool EnrollStudentInSection(Student student, int sectionNumber)
    {
        bool isSuccess = false;

        foreach (Section section in Sections)
        {
            if (section.SectionNumber == sectionNumber)
            {
                section.EnrollStudent(student);
            }
        }
        
        return isSuccess;
    }
    
    public bool DropStudentFromSection(Student student, int sectionNumber)
    {
        bool isSuccess = false;

        foreach (Section section in Sections)
        {
            if (section.SectionNumber == sectionNumber)
            {
                section.Drop(student);
            }
        }
        
        return isSuccess;
    }

    public bool AssignProfessorToSection(Professor professor, int sectionNumber)
    {
        bool isSuccess = false;

        foreach (Section section in Sections)
        {
            if (section.SectionNumber == sectionNumber)
            {
                section.Instructor = professor;
            }
        }
        
        return isSuccess;
    }

    public override string ToString()
    {
        string s = $"Course:\n" +
                   $"  Id: {CourseID}\n" +
                   $"  Title: {Title}\n" +
                   $"  Sections ({Sections.Count}):\n";

        if (Sections.Count == 0)
        {
            s += "    (none)";
        }
        else
        {
            foreach (var section in Sections)
            {
                s += "    " + section.ToString().Replace("\n", "\n    ") + "\n";
            }
        }

        return s.TrimEnd();
    }
}