using Microsoft.EntityFrameworkCore;
using Moodiverse.WebAPI.Models.Domain;

namespace Moodiverse.WebAPI.Data;

public class MoodiverseDbContext : DbContext
{
    public MoodiverseDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Sex> Sexes { get; set; }
    public DbSet<Avatar> Avatars { get; set; }
    public DbSet<Mood> Moods { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Record> Records { get; set; }
}