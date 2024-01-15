namespace MyApp.Models;
public class Student
{
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
    public string? Major { get; set; }
    public double GPA { get; set; }
    public Course? Course { get; set; }
    public Student SetStudentId(int studentId)
    {
        StudentId = studentId;
        return this;
    }

    public Student SetStudentName(string studentName)
    {
        StudentName = studentName;
        return this;
    }

    public Student SetMajor(string major)
    {
        Major = major;
        return this;
    }

    public Student SetGPA(double gpa)
    {
        GPA = gpa;
        return this;
    }

    public static Student CreateStudent => new Student();



}
