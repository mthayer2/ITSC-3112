namespace CourseManagement;

/// <summary>
/// Repository for storing all course information.
/// </summary>
public class CourseRepository : ICourseRepository
{
    private List<Course> courses;

    public CourseRepository()
    {
        courses = new List<Course>();
    }

    /// <summary>
    /// Adds or Updates a Course in the Repo.
    /// </summary>
    /// <param name="course">The course to add or update.</param>
    public void AddOrUpdate(Course course)
    {
        // Get the course object if it exists already.
        Course existingCourse = this.FindCourseById(course.CourseID);
        
        // If the course already exists, remove it.
        if (existingCourse != null)
        {
            courses.Remove(existingCourse);
        }
        
        // Add the new course.
        courses.Add(course);
    }

    /// <summary>
    /// Removes a course from the repo.
    /// </summary>
    /// <param name="course">The course to remove.</param>
    public void Remove(Course course)
    {
        courses.Remove(course);
    }

    /// <summary>
    /// Finds a course by id.
    /// </summary>
    /// <param name="courseId">The course id.</param>
    /// <returns>The course if found, null otherwise.</returns>
    public Course FindCourseById(string courseId)
    {
        Course result = null;

        foreach (Course course in courses)
        {
            if (course.CourseID == courseId)
            {
                result = course;
                break;
            }
        }
        
        return result;
    }

    /// <summary>
    /// Gets all courses in the repo.
    /// </summary>
    /// <returns>List of all courses.</returns>
    public List<Course> GetAllCourses()
    {
        return courses;
    }
}