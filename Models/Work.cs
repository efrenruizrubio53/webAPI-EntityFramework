namespace projectEF.Models;

public class Work
{
    public Guid WorkId { get; set; }
    public Guid CategoryId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Priority WorkPriority { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual Category? Category { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}