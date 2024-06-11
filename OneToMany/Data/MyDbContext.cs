using Microsoft.EntityFrameworkCore;
using OneToMany.Models;

public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;

        public DbSet<Grade>? Grade { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>().HasData(
            new Grade { Id = 1, Name = "1er Année" },
            new Grade { Id = 2, Name = "2ème Année" },
            new Grade { Id = 3, Name = "3ème Année" },
            new Grade { Id = 4, Name = "4ème Année" },
            new Grade { Id = 5, Name = "5ème Année" },
            new Grade { Id = 6, Name = "6ème Année" }
        );
    }
}
