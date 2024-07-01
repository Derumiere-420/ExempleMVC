using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pagination.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pagination.Models.Product> Product { get; set; } = default!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        string myString = "";
        for (int i = 1; i <= 500; i++)
        {
            if (i < 10)
            {
                myString = "Product 00" + i;
            }
            else if (i >= 10 && i < 100)
            {
                myString = "Product 0" + i;
            }
            else
            {
                myString = "Product " + i;
            }
           
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = i, Name = myString, Price = i * 5.0m }
            );
        }
    }
}
