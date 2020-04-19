using Microsoft.EntityFrameworkCore;
using EdujarBackend.Models.Schema;

namespace EdujarBackend.Models.Contexts
{
    public class SqliteContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Kinder> Kinders { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EduJar.db");
        }
    }
}
