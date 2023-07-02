using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo2.Models;

namespace Demo2.Data
{
    public class Demo2Context : DbContext
    {
        public Demo2Context (DbContextOptions<Demo2Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Demo2.Models.Employee> Employee { get; set; } = default!;
    }
}
