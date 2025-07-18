using Microsoft.EntityFrameworkCore;
using TestContainersExample.Domain;

namespace TestContainersExample.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        { }
    }
}
