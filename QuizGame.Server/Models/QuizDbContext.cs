using Microsoft.EntityFrameworkCore;

namespace QuizGame.Server.Models
{
    public class QuizDbContext: DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext>options):base(options)
        { }

        public DbSet<OperatingSystems> OperatingSystems { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
