using MyApp.Models;
using Repositories;
using Repositories.Contracts;
class Program
{
    static void Main()
    {


        using (var context = new RepositoryContext())
        {
            context.Database.EnsureCreated(); // Ensure the database is created

            ICourseRepository courseRepository = new CourseRepository(context);

            if (courseRepository == null)
            {
                Console.WriteLine("Repository could not be initialized.");
                return;
            }


            var course = new Course
            {
                CourseId = 1,
                CourseName = "Nesne Tabanlı Programlama",
                CreditHours = 3,
                Instructor = "Zafer Comert",
                RegisteredStudents = {
                new Student()
                {
                    StudentId = 101,
                    StudentName = "Ahmet",
                    Major = "Bilgisayar Mühendisliği",
                    GPA = 3.5
                },
                new Student()
                {
                    StudentId = 102,
                    StudentName = "Ayşe",
                    Major = "Elektrik Mühendisliği",
                    GPA = 3.2

                },
                new Student()
                {
                    StudentId = 103,
                    StudentName = "Mustafa",
                    Major = "Matematik",
                    GPA = 3.8

                },

                new Student()
                {
                    StudentId = 104,
                    StudentName = "Fatma",
                    Major = "Fizik",
                    GPA = 3.4

                },
                new Student()
                {
                    StudentId = 105,
                    StudentName = "Mehmet",
                    Major = "Kimya",
                    GPA = 3.1

                },
            }
            };



            var createdCourse = courseRepository.CreateCourseWithStudents(course);


            if (createdCourse != null)
            {
                Console.WriteLine("Course and students have been added to the database.");
            }
            else
            {
                Console.WriteLine("Course could not be added to the database.");
            }


        }


    }

}
