using TestContainersExample.Domain;

namespace TestContainersExample.Infrastructure
{
    public interface IExamRepository
    {
        Task<IEnumerable<Exam>> GetExamsAsync();
    }
}
