using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
    public class DataBooks:DbContext
    {
        public DataBooks(DbContextOptions options):base(options) { }

        public DbSet<Book> Book { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Ganres> Ganres { get; set; }

        
    }
}
