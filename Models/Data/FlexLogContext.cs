using Microsoft.EntityFrameworkCore;
using FlexLog.Models;

namespace FlexLog.Data;

public class FlexLogContext : DbContext
{
    public FlexLogContext(DbContextOptions<FlexLogContext> options)
        : base(options)
    {
    }

    public DbSet<Workout> Workout { get; set; } = default!;
}