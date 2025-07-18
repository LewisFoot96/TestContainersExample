using Microsoft.EntityFrameworkCore;
using TestContainersExample.Domain;

namespace TestContainersExample.Infrastructure
{
    public class ExamRepository : IExamRepository
    {
        private readonly ExamDbContext _applicationDbContext;

        public ExamRepository(ExamDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Exam>> GetExamsAsync()
        {
            return await _applicationDbContext.Exams.ToListAsync();
        }

    }
}
