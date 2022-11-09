using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionescu_Alex_Daniel_Lab2.Models;

namespace Ionescu_Alex_Daniel_Lab2.Data
{
    public class Ionescu_Alex_Daniel_Lab2Context : DbContext
    {
        public Ionescu_Alex_Daniel_Lab2Context (DbContextOptions<Ionescu_Alex_Daniel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ionescu_Alex_Daniel_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ionescu_Alex_Daniel_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Ionescu_Alex_Daniel_Lab2.Models.Author> Author { get; set; }

        public DbSet<Ionescu_Alex_Daniel_Lab2.Models.Category> Category { get; set; }

        public DbSet<Ionescu_Alex_Daniel_Lab2.Models.Member> Member { get; set; }

        public DbSet<Ionescu_Alex_Daniel_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
