using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectEF.Models;

public class Work
{
    [Key]
    public Guid WorkId { get; set; }

    [ForeignKey("CategoryId")]
    public Guid CategoryId { get; set; }

    [Required]
    [MaxLength(200)]
    public string? Title { get; set; }

    public string? Description { get; set; }

    public Priority WorkPriority { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Category? Category { get; set; }

    [NotMapped]
    public string? Summary { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}