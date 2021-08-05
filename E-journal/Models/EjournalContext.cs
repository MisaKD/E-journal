using Microsoft.EntityFrameworkCore;

namespace E_journal.Models
{
    public class EjournalContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public EjournalContext(DbContextOptions<EjournalContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
