using Microsoft.EntityFrameworkCore;

namespace SoftwareOne.Interview.Questions;

internal class Q1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    };

    public class Course
    {
        public int Id { get; set; }
        public virtual ICollection<Student> Students { get; set; } = null!;
    }

    public class StudentsDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; } = null!;
    }

    public void Question1()
    {
        using var context = new StudentsDbContext();

        var courses = context.Courses;
        foreach (var course in courses)
        {
            foreach (var student in course.Students)
            {
                Console.WriteLine($"{course.Id}: {student.Name}");
            }
        }
    }
    public void Question2()
    {
        IQueryable<Course> GetAllCourses()
        {
            using var context = new StudentsDbContext();
            return context.Courses;
        }

        var courses = GetAllCourses();
        foreach (var course in courses)
        {
            Console.WriteLine(course.Id);
        }
    }

    public void Test()
    {
        for (int i = 0; i < 10; i++)
        {
            Task.Factory.StartNew(() => Console.WriteLine(i));
        }
    }
}