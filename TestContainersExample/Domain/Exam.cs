namespace TestContainersExample.Domain;

public class Exam
{
    public Guid ExamId { get; set; }
    public string ExamName { get; set; }
    public int MaxMark { get; set; }
    public DateTime ExamDate { get; set; }
}
