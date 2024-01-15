using MyApp.Models;

namespace Repositories.Contracts;

public interface ICourseRepository
{
    Course CreateCourseWithStudents(Course course);
}