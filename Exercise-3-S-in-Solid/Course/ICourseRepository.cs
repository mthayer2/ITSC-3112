namespace CourseManagement;

/// <summary>
/// Repository Interface for storing all course information.
/// </summary>
public interface ICourseRepository
{
    /// <summary>
    /// Adds or Updates a Course in the Repo.
    /// </summary>
    /// <param name="course">The course to add or update.</param>
    public void AddOrUpdate(Course course);
    
    /// <summary>
    /// Removes a course from the repo.
    /// </summary>
    /// <param name="course">The course to remove.</param>
    public void Remove(Course course);
    
    /// <summary>
    /// Finds a course by id.
    /// </summary>
    /// <param name="courseId">The course id.</param>
    /// <returns>The course if found, null otherwise.</returns>
    public Course FindCourseById(string courseId);
    
    /// <summary>
    /// Gets all courses in the repo.
    /// </summary>
    /// <returns>List of all courses.</returns>
    public List<Course> GetAllCourses();
}