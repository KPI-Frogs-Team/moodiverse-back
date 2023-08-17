using Microsoft.EntityFrameworkCore;
using Moodiverse.DAL.Entities;

namespace Moodiverse.DAL.Context;

public class MoodiverseDbContext : DbContext
{
    public MoodiverseDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Sex> Sexes { get; set; } = null!;
    public DbSet<Avatar> Avatars { get; set; } = null!;
    public DbSet<Mood> Moods { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Record> Records { get; set; } = null!;
}