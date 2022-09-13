using Microsoft.EntityFrameworkCore;
using projectEF.Models;

namespace projectEF;

public class WorkContext : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Work>? Works { get; set; }
    public WorkContext(DbContextOptions<WorkContext> options) : base(options) { }
}