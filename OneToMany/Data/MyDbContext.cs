using Microsoft.EntityFrameworkCore;
using OneToMany.Models;

public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = default!;

        public DbSet<Grade>? Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>().HasData(
            new Grade { GradeId = 1, GradeName = "1er Année" },
            new Grade { GradeId = 2, GradeName = "2ème Année" },
            new Grade { GradeId = 3, GradeName = "3ème Année" },
            new Grade { GradeId = 4, GradeName = "4ème Année" },
            new Grade { GradeId = 5, GradeName = "5ème Année" },
            new Grade { GradeId = 6, GradeName = "6ème Année" }
        );
    }
}
