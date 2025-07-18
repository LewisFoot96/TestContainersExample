using TestContainersExample.Infrastructure;

namespace TestContainersExample.Endpoints;

public static class ExamEndpoints
{
    public static void MapExamEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/exams", async (IExamRepository examRepository) =>
        {
            var exams = await examRepository.GetExamsAsync();
            return Results.Ok(exams);
        })
        .WithName("GetExams");
    }
}
