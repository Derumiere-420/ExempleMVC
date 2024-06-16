using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using I18N.Models;

    public class MyDBContext : DbContext
    {
        public MyDBContext (DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        public DbSet<I18N.Models.Student> Student { get; set; } = default!;
    }
