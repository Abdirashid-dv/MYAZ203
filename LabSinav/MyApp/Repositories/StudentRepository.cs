using MyApp.Models;
using Repositories.Contracts;

namespace Repositories;

public class StudentRepository : IStudentRepository
{
    private RepositoryContext _repositoryContext;

    public StudentRepository(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public void AddStudentToCourse(int courseId, Student student)
    {
        var course = _repositoryContext.Courses.FirstOrDefault(c => c.CourseId == courseId);
        if (course != null)
        {
            course.RegisteredStudents.Add(student);
            _repositoryContext.SaveChanges();
        }
    }

    public void DeleteAllStudentByCourse(Course course)
    {
        var students = _repositoryContext.Students.Where(s => s.Course == course);
        _repositoryContext.Students.RemoveRange(students);
        _repositoryContext.SaveChanges();
    }
}