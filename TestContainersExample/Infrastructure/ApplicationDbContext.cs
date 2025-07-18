using Microsoft.EntityFrameworkCore;
using TestContainersExample.Domain;

namespace TestContainersExample.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Exams;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
