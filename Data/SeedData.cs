namespace CourseCatalog.Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CourseCatalogContext(
                   serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null Context");
            }

            if (context.Course.Any())
            {
                return;
            }

            context.Course.AddRange(
                    new Course()
                {
                    Id = 233,
                    CourseName = "Course 1",
                    CourseDescription = "Course Desc 1",
                    RoomNumber = 166,
                    StartTime = TimeOnly.Parse("10:30"),
                    EndTime = TimeOnly.Parse("11:15")
                },
                    new Course()
                {
                    Id = 234,
                    CourseName = "Course 2",
                    CourseDescription = "Course Desc 2",
                    RoomNumber = 166,
                    StartTime = TimeOnly.Parse("11:30"),
                    EndTime = TimeOnly.Parse("12:15")
                },
                    new Course()
                {
                    Id = 235,
                    CourseName = "Course 3",
                    CourseDescription = "Course Desc 3",
                    RoomNumber = 200,
                    // fix times to show properly
                    StartTime = TimeOnly.Parse("13:30"),
                    EndTime = TimeOnly.Parse("14:15")
                },
                    new Course()
                {
                    Id = 236,
                    CourseName = "Course 4",
                    CourseDescription = "Course Desc 4",
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("14:30"),
                    EndTime = TimeOnly.Parse("15:15")
                },
                    new Course()
                {
                    Id = 237,
                    CourseName = "Course 5",
                    CourseDescription = "Course Desc 5",
                    RoomNumber = 220,
                    StartTime = TimeOnly.Parse("15:30"),
                    EndTime = TimeOnly.Parse("16:15")
                }
            );
            context.SaveChanges();
        }
    }
}