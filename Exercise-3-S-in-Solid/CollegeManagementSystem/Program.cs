using PeopleManagement;
using CourseManagement;
namespace CollegeManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        ICourseRepository courseRepo = new CourseRepository();
        IPersonRepository personRepo = new PersonRepository();
        PopulateData(courseRepo, personRepo);
        
        // Print everything (Courses, Professors, Students)
        Console.WriteLine("\n============================================");
        Console.WriteLine("All People Added to the Person Repository:");
        Console.WriteLine("============================================");
        PrintPeople(personRepo);
        
        Console.WriteLine("\n============================================");
        Console.WriteLine("All Courses Added to the Course Repository:");
        Console.WriteLine("============================================");
        PrintCourses(courseRepo);

        // === TODO 1: Enroll Emma (s-005) into ITCS 3112 - Section 1 using EnrollStudentInSection ===
        Console.WriteLine("\nTODO 1: ");
        // TYPE YOUR CODE HERE
        PrintCourses(courseRepo);

        // === TODO 2: Drop Alice (s-001) from ITCS 3112 - Section 1 using DropStudentFromSection ===
        Console.WriteLine("\nTODO 2: ");
        // TYPE YOUR CODE HERE
        PrintCourses(courseRepo);

        // === TODO 3: Reassign Section 2 instructor from Dr. Jones (p-002) to Dr. Smith (p-001) using AssignProfessorToSection ===
        Console.WriteLine("\nTODO 3: ");
        // TYPE YOUR CODE HERE
        PrintCourses(courseRepo);

        // === TODO 4: Create a NEW course (ITCS 2214 - Data Structures) with Section 1, in Fall Term, Dr. Smith as instructor ===
        Console.WriteLine("\nTODO 4: ");
        // TYPE YOUR CODE HERE
        PrintCourses(courseRepo);

        // === TODO 5: Update course title of ITCS 2214 'Data Structures' to 'Data Structures and Algorithms' using AddOrUpdate ===
        Console.WriteLine("\nTODO 5: ");
        // TYPE YOUR CODE HERE
        PrintCourses(courseRepo);
        
        // === TODO 6: Find and print all ComputerScience majors ===
        Console.WriteLine("\nTODO 6: ");
        // TYPE YOUR CODE HERE
    }

    private static void PopulateData(ICourseRepository courseRepo, IPersonRepository personRepo)
    {
        // Professors
        Professor smith = new Professor("p-001", "Dr. Smith", "smith@univ.edu", "M/W 2–4pm", "Room 201");
        Professor jones = new Professor("p-002", "Dr. Jones", "jones@univ.edu", "T/Th 10–12", "Room 305");
        personRepo.AddOrUpdate(new List<Professor>() { smith, jones });
        
        // Students
        Student alice = new Student("s-001", "Alice", "alice@univ.edu", MajorEnum.Accounting, 2023);
        Student bob = new Student("s-002", "Bob", "bob@univ.edu", MajorEnum.Mathematics, 2022);
        Student carol = new Student("s-003", "Carol", "carol@univ.edu", MajorEnum.ComputerScience, 2024);
        Student david = new Student("s-004", "David", "david@univ.edu", MajorEnum.ComputerScience, 2023);
        Student emma = new Student("s-005", "Emma", "emma@univ.edu", MajorEnum.ComputerScience, 2025);
        Student frank = new Student("s-006", "Frank", "frank@univ.edu", MajorEnum.Biology, 2021);
        personRepo.AddOrUpdate(new List<Student>() { alice, bob, carol, david, emma, frank });
        
        // Sections
        Section sec1 = new Section(1, TermEnum.Fall, smith);
        sec1.EnrollStudents(new List<Student>() { alice, bob, carol });
        Section sec2 = new Section(2, TermEnum.Fall, jones);
        sec2.EnrollStudents(new List<Student>() { david, frank });

        // Course
        Course cs3112 = new Course("ITCS 3112", "Design & Implementation of OOPS", new List<Section> { sec1, sec2 });
        courseRepo.AddOrUpdate(cs3112);
    }

    private static void PrintCourses(ICourseRepository courseRepo)
    {
        List<Course> courses = courseRepo.GetAllCourses();

        foreach (Course course in courses)
        {
            Console.WriteLine(course);
        }
    }

    private static void PrintPeople(IPersonRepository personRepo)
    {
        List<Person> people = personRepo.GetAllPeople();

        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}