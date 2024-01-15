using MyApp.Models;
using Repositories.Contracts;

namespace Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly RepositoryContext _context;

    public CourseRepository(RepositoryContext context)
    {
        _context = context;
    }

    // how to create course with students

    public Course CreateCourseWithStudents(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();

        return course;
    }


}