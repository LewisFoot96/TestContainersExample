using Microsoft.EntityFrameworkCore;
using TestContainersExample.Domain;

namespace TestContainersExample.Infrastructure
{
    public class ExamRepository : IExamRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ExamRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Exam>> GetExamsAsync()
        {
            return await _applicationDbContext.Exams.ToListAsync();
        }

    }
}
