using Microsoft.EntityFrameworkCore;
using TestContainersExample.Domain;

namespace TestContainersExample.Infrastructure
{
    public class ExamDbContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }

        public ExamDbContext(DbContextOptions<ExamDbContext> options)
    : base(options)
        { }
    }
}
