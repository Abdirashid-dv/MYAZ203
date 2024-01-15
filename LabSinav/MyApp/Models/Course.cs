namespace MyApp.Models;
public class Course
{
    public int CourseId { get; set; }
    public string? CourseName { get; set; }
    public int CreditHours { get; set; }
    public string? Instructor { get; set; }
    public List<Student> RegisteredStudents { get; set; } = new List<Student>();


}
