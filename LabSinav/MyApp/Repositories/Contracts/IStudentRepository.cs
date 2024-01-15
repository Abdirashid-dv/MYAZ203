using MyApp.Models;

namespace Repositories.Contracts;

public interface IStudentRepository
{
    void DeleteAllStudentByCourse(Course course);
    void AddStudentToCourse(int courseId, Student student);
}