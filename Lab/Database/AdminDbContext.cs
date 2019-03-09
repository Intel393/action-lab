using Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab.Database
{
    public class AdminDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; } 
        
        public AdminDbContext() { }

        public AdminDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}