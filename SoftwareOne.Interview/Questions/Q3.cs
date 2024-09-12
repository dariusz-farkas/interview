using Microsoft.EntityFrameworkCore;

namespace SoftwareOne.Interview.Questions;

internal class Q3
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

    public void Test1()
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
    public void Test2()
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

}