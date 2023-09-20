using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Entities;

namespace MyLibrary
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public AppContext() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PC\SQLEXPRESS;Database=Library;Encrypt=false;Integrated Security=True");
        }

    }
}
