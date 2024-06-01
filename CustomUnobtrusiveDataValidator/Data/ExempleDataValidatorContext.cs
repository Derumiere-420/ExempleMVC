using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomUnobtrusiveDataValidator.Models;

namespace CustomUnobtrusiveDataValidator.Data
{
    public class ExempleDataValidatorContext : DbContext
    {
        public ExempleDataValidatorContext(DbContextOptions<ExempleDataValidatorContext> options)
            : base(options)
        {
        }

        public DbSet<Utilisateur> Utilisateur { get; set; } = default!;
    }
}
