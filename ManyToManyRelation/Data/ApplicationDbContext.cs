using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ManyToManyRelation.Models;

namespace ManyToManyRelation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
//            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

//modelBuilder.Entity<StudentCourse>()
//    .HasOne<Student>(sc => sc.Student)
//    .WithMany(s => s.StudentCourses)
//    .HasForeignKey(sc => sc.StudentId);


//modelBuilder.Entity<StudentCourse>()
//    .HasOne<Course>(sc => sc.Course)
//    .WithMany(s => s.StudentCourses)
//    .HasForeignKey(sc => sc.CourseId);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }

}