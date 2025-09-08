using PeopleManagement;

namespace CourseManagement;

class Program
{
    static void Main(string[] args)
    {
        Professor instructor = new Professor("1", "Matthew Thayer", "mthayer2@uncc.edu", "MWF", "Office");
        MajorEnum major = MajorEnum.ComputerScience;
        Student student1 = new Student("0", "John Doe", "johndoe@charlotte.edu", major, 2018);
        Student student2 = new Student("1", "Jane Doe", "janedoe@charlotte.edu", major, 2019);

        List<Section> Sections_3112 = new List<Section>() 
        {
            new Section(001, TermEnum.Fall, instructor),
            new Section(091, TermEnum.Fall, instructor)
        };
        
        Sections_3112[0].EnrollStudent(student1);
        Sections_3112[1].EnrollStudent(student2);
        
        Course course = new Course("ITCS 3112", "Design & Implementation of OOPS", Sections_3112);
        
        ICourseRepository repository = new CourseRepository();
        repository.AddOrUpdate(course);
        List<Course> courses = repository.GetAllCourses();
        printCourses(courses);
        
        Console.WriteLine("\n=========== Removing the second section of 3112 ============\n");
        course.RemoveSection(Sections_3112[1]);
        repository.AddOrUpdate(course);
        courses = repository.GetAllCourses();
        printCourses(courses);
    }

    private static void printCourses(List<Course> courses)
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(course);
        }
    }
}