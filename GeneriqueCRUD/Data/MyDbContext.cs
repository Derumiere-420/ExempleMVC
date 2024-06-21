using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeneriqueCRUD.Models;

    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<GeneriqueCRUD.Models.Product> Product { get; set; } = default!;
    public DbSet<GeneriqueCRUD.Models.User> User { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Hammer", Price = 12.99M },
            new Product { Id = 2, Name = "Screwdriver", Price = 8.99M },
            new Product { Id = 3, Name = "Wrench", Price = 15.50M },
            new Product { Id = 4, Name = "Pliers", Price = 7.99M },
            new Product { Id = 5, Name = "Saw", Price = 22.00M },
            new Product { Id = 6, Name = "Drill", Price = 45.99M },
            new Product { Id = 7, Name = "Tape Measure", Price = 5.49M },
            new Product { Id = 8, Name = "Level", Price = 9.99M },
            new Product { Id = 9, Name = "Chisel", Price = 6.75M },
            new Product { Id = 10, Name = "Allen Wrench Set", Price = 12.00M }
        );
    }
}

