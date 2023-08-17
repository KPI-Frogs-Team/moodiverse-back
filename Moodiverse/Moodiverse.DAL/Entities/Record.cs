using Moodiverse.DAL.Entities.Abstract;

namespace Moodiverse.DAL.Entities;

public class Record : BaseDomain
{
    public int UserId { get; set; }
    public int MoodId { get; set; }
    public string? Text { get; set; }
    
    public virtual User User { get; set; } = null!;
    public virtual Mood Mood { get; set; } = null!;
}