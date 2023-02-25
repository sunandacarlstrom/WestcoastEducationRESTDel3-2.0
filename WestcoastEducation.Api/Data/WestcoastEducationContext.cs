using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WestcoastEducation.Api.Models;

namespace WestcoastEducation.Api.Data;
public class WestcoastEducationContext : IdentityDbContext<UserModel>
{
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<StudentModel> Students { get; set; }
    public DbSet<TeacherModel> Teachers { get; set; }
    public DbSet<TeacherSkillsModel> TeacherSkills { get; set; }
    public DbSet<StudentModelCourseModel> StudentCourses { get; set; }

    public WestcoastEducationContext(DbContextOptions options) : base(options)
    {
    }

    //P.S. sätter upp manuell många-till-många förhållande här eftersom jag vill ha tillgång till statusen på kursen på en specifik student 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //sätt upp sammansatt primärnyckel som består av CourseId och StudentId...
        modelBuilder.Entity<StudentModelCourseModel>()
            .HasKey(sc => new { sc.CourseId, sc.StudentId });

        //sätta upp förhållandet att en student kan vara anmäld på flera kurser... 
        modelBuilder.Entity<StudentModelCourseModel>()
            // en student kan förekomma flera gånger i den här tabellen 
            .HasOne(sc => sc.Student)
            .WithMany(c => c.StudentCourses)
            .HasForeignKey(sc => sc.StudentId);

        //sätta upp förhållandet att en kurs kan ha flera studenter... 
        modelBuilder.Entity<StudentModelCourseModel>()
            // en kurs kan förekomma flera gånger i den här tabellen
            .HasOne(sc => sc.Course)
            .WithMany(c => c.StudentCourses)
            .HasForeignKey(sc => sc.CourseId);
    }
}
